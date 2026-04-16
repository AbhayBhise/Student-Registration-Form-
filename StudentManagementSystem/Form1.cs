using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        string connStr = "server=localhost;user=root;password=root;database=studentdb;";
        string photoPath = "";
        string resumePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentIds();
        }

        private void LoadStudentIds()
        {
            cmbStudentIdAcc.Items.Clear();
            cmbStudentIdLib.Items.Clear();
            cmbStudentIdExam.Items.Clear();
            cmbStudentIdPlace.Items.Clear();
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("SELECT student_id, full_name FROM students", conn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string item = reader["student_id"] + " - " + reader["full_name"];
                        cmbStudentIdAcc.Items.Add(item);
                        cmbStudentIdLib.Items.Add(item);
                        cmbStudentIdExam.Items.Add(item);
                        cmbStudentIdPlace.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private int GetSelectedStudentId(ComboBox cmb)
        {
            if (cmb.SelectedItem == null) return -1;
            return int.Parse(cmb.SelectedItem.ToString().Split('-')[0].Trim());
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photoPath = ofd.FileName;
                picPhoto.Image = Image.FromFile(photoPath);
                picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "" || txtContact.Text.Trim() == "")
            {
                MessageBox.Show("Full Name and Contact Number are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                byte[] photoBytes = null;
                if (photoPath != "") photoBytes = File.ReadAllBytes(photoPath);

                using (var conn = GetConnection())
                {
                    conn.Open();
                    string q = @"INSERT INTO students (full_name,dob,gender,address,contact,email,course,admission_date,photo)
                                 VALUES(@name,@dob,@gender,@address,@contact,@email,@course,@admdate,@photo)";
                    var cmd = new MySqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@course", cmbCourse.Text);
                    cmd.Parameters.AddWithValue("@admdate", dtpAdmission.Value.Date);
                    cmd.Parameters.AddWithValue("@photo", (object)photoBytes ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                    long sid = cmd.LastInsertedId;
                    var accCmd = new MySqlCommand("INSERT INTO accounts(student_id,total_fees,fees_paid,scholarship,fine) VALUES(@sid,0,0,0,0)", conn);
                    accCmd.Parameters.AddWithValue("@sid", sid);
                    accCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentIds();
                ClearStudentFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClearStudent_Click(object sender, EventArgs e)
        {
            ClearStudentFields();
        }

        private void ClearStudentFields()
        {
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            cmbGender.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Today;
            dtpAdmission.Value = DateTime.Today;
            picPhoto.Image = null;
            photoPath = "";
        }

        private void btnLoadAccount_Click(object sender, EventArgs e)
        {
            int sid = GetSelectedStudentId(cmbStudentIdAcc);
            if (sid == -1) { MessageBox.Show("Please select a student."); return; }
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("SELECT * FROM accounts WHERE student_id=@sid", conn);
                    cmd.Parameters.AddWithValue("@sid", sid);
                    var r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        txtTotalFees.Text = r["total_fees"].ToString();
                        txtFeesPaid.Text = r["fees_paid"].ToString();
                        txtScholarship.Text = r["scholarship"].ToString();
                        txtFine.Text = r["fine"].ToString();
                        decimal pending = Convert.ToDecimal(r["total_fees"]) - Convert.ToDecimal(r["fees_paid"]);
                        txtPendingFees.Text = pending.ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("No account record found for this student.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            int sid = GetSelectedStudentId(cmbStudentIdAcc);
            if (sid == -1) { MessageBox.Show("Please select a student."); return; }
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string q = "UPDATE accounts SET total_fees=@tf,fees_paid=@fp,scholarship=@sc,fine=@fn WHERE student_id=@sid";
                    var cmd = new MySqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@tf", txtTotalFees.Text);
                    cmd.Parameters.AddWithValue("@fp", txtFeesPaid.Text);
                    cmd.Parameters.AddWithValue("@sc", txtScholarship.Text);
                    cmd.Parameters.AddWithValue("@fn", txtFine.Text);
                    cmd.Parameters.AddWithValue("@sid", sid);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLoadAccount_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            int sid = GetSelectedStudentId(cmbStudentIdLib);
            if (sid == -1 || txtBookName.Text.Trim() == "")
            {
                MessageBox.Show("Please select a student and enter book name.");
                return;
            }
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string q = "INSERT INTO lib_books(student_id,book_name,issue_date,return_date) VALUES(@sid,@bname,@idate,@rdate)";
                    var cmd = new MySqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@sid", sid);
                    cmd.Parameters.AddWithValue("@bname", txtBookName.Text.Trim());
                    cmd.Parameters.AddWithValue("@idate", dtpIssueDate.Value.Date);
                    cmd.Parameters.AddWithValue("@rdate", dtpReturnDate.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book record added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookName.Text = "";
                    btnLoadBooks_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLoadBooks_Click(object sender, EventArgs e)
        {
            int sid = GetSelectedStudentId(cmbStudentIdLib);
            if (sid == -1) { MessageBox.Show("Please select a student."); return; }
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string q = "SELECT book_name AS 'Book Name', issue_date AS 'Issue Date', return_date AS 'Return Date' FROM lib_books WHERE student_id=@sid";
                    var cmd = new MySqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@sid", sid);
                    var adapter = new MySqlDataAdapter(cmd);
                    var table = new System.Data.DataTable();
                    adapter.Fill(table);
                    dgvLibrary.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            int sid = GetSelectedStudentId(cmbStudentIdExam);
            if (sid == -1 || txtSubject.Text.Trim() == "")
            {
                MessageBox.Show("Please select a student and fill all fields.");
                return;
            }
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string q = "INSERT INTO exam_results(student_id,semester,subject,marks,grade,sgpa,cgpa) VALUES(@sid,@sem,@sub,@marks,@grade,@sgpa,@cgpa)";
                    var cmd = new MySqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@sid", sid);
                    cmd.Parameters.AddWithValue("@sem", cmbSemester.Text);
                    cmd.Parameters.AddWithValue("@sub", txtSubject.Text.Trim());
                    cmd.Parameters.AddWithValue("@marks", txtMarks.Text == "" ? "0" : txtMarks.Text);
                    cmd.Parameters.AddWithValue("@grade", txtGrade.Text.Trim());
                    cmd.Parameters.AddWithValue("@sgpa", txtSGPA.Text == "" ? "0" : txtSGPA.Text);
                    cmd.Parameters.AddWithValue("@cgpa", txtCGPA.Text == "" ? "0" : txtCGPA.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Result added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSubject.Text = "";
                    txtMarks.Text = "";
                    txtGrade.Text = "";
                    txtSGPA.Text = "";
                    txtCGPA.Text = "";
                    btnLoadResults_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLoadResults_Click(object sender, EventArgs e)
        {
            int sid = GetSelectedStudentId(cmbStudentIdExam);
            if (sid == -1) { MessageBox.Show("Please select a student."); return; }
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string q = "SELECT semester AS 'Semester', subject AS 'Subject', marks AS 'Marks', grade AS 'Grade', sgpa AS 'SGPA', cgpa AS 'CGPA' FROM exam_results WHERE student_id=@sid";
                    var cmd = new MySqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@sid", sid);
                    var adapter = new MySqlDataAdapter(cmd);
                    var table = new System.Data.DataTable();
                    adapter.Fill(table);
                    dgvExam.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUploadResume_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                resumePath = ofd.FileName;
                lblResumeName.Text = "File: " + Path.GetFileName(resumePath);
            }
        }

        private void btnSubmitPlacement_Click(object sender, EventArgs e)
        {
            int sid = GetSelectedStudentId(cmbStudentIdPlace);
            if (sid == -1) { MessageBox.Show("Please select a student."); return; }
            if (resumePath == "") { MessageBox.Show("Please upload a resume first."); return; }
            if (cmbPlacementType.SelectedIndex == -1) { MessageBox.Show("Please select placement type."); return; }
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string q = "INSERT INTO placement(student_id,resume_path,placement_type,interested_domain) VALUES(@sid,@rpath,@ptype,@domain)";
                    var cmd = new MySqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@sid", sid);
                    cmd.Parameters.AddWithValue("@rpath", resumePath);
                    cmd.Parameters.AddWithValue("@ptype", cmbPlacementType.Text);
                    cmd.Parameters.AddWithValue("@domain", txtDomain.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resumePath = "";
                    lblResumeName.Text = "No file selected";
                    txtDomain.Text = "";
                    cmbPlacementType.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        private void ApplyGradient(object sender, PaintEventArgs e)
        {
            TabPage page = (TabPage)sender;
            using (LinearGradientBrush brush = new LinearGradientBrush(page.ClientRectangle, 
                Color.FromArgb(230, 240, 255), // Very light formal blue
                Color.White, 
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, page.ClientRectangle);
            }
        }
    }
}