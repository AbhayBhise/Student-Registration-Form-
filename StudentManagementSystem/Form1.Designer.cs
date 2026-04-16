namespace StudentManagementSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tabLibrary = new System.Windows.Forms.TabPage();
            this.tabExam = new System.Windows.Forms.TabPage();
            this.tabPlacement = new System.Windows.Forms.TabPage();
            this.lblStudentTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblAdmDate = new System.Windows.Forms.Label();
            this.dtpAdmission = new System.Windows.Forms.DateTimePicker();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.btnClearStudent = new System.Windows.Forms.Button();
            this.lblAccountTitle = new System.Windows.Forms.Label();
            this.lblStudentSelAcc = new System.Windows.Forms.Label();
            this.cmbStudentIdAcc = new System.Windows.Forms.ComboBox();
            this.btnLoadAccount = new System.Windows.Forms.Button();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.txtTotalFees = new System.Windows.Forms.TextBox();
            this.lblFeesPaid = new System.Windows.Forms.Label();
            this.txtFeesPaid = new System.Windows.Forms.TextBox();
            this.lblPending = new System.Windows.Forms.Label();
            this.txtPendingFees = new System.Windows.Forms.TextBox();
            this.lblScholarship = new System.Windows.Forms.Label();
            this.txtScholarship = new System.Windows.Forms.TextBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.lblLibraryTitle = new System.Windows.Forms.Label();
            this.lblStudentSelLib = new System.Windows.Forms.Label();
            this.cmbStudentIdLib = new System.Windows.Forms.ComboBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnLoadBooks = new System.Windows.Forms.Button();
            this.dgvLibrary = new System.Windows.Forms.DataGridView();
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.lblStudentSelExam = new System.Windows.Forms.Label();
            this.cmbStudentIdExam = new System.Windows.Forms.ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblMarks = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.lblGradeLabel = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblSGPA = new System.Windows.Forms.Label();
            this.txtSGPA = new System.Windows.Forms.TextBox();
            this.lblCGPA = new System.Windows.Forms.Label();
            this.txtCGPA = new System.Windows.Forms.TextBox();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.btnLoadResults = new System.Windows.Forms.Button();
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.lblPlacementTitle = new System.Windows.Forms.Label();
            this.lblStudentSelPlace = new System.Windows.Forms.Label();
            this.cmbStudentIdPlace = new System.Windows.Forms.ComboBox();
            this.lblResume = new System.Windows.Forms.Label();
            this.lblResumeName = new System.Windows.Forms.Label();
            this.btnUploadResume = new System.Windows.Forms.Button();
            this.lblPlacementType = new System.Windows.Forms.Label();
            this.cmbPlacementType = new System.Windows.Forms.ComboBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnSubmitPlacement = new System.Windows.Forms.Button();

            this.tabMain.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tabLibrary.SuspendLayout();
            this.tabExam.SuspendLayout();
            this.tabPlacement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
            this.SuspendLayout();

            // tabMain
            this.tabMain.Controls.Add(this.tabStudent);
            this.tabMain.Controls.Add(this.tabAccount);
            this.tabMain.Controls.Add(this.tabLibrary);
            this.tabMain.Controls.Add(this.tabExam);
            this.tabMain.Controls.Add(this.tabPlacement);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(960, 650);
            this.tabMain.TabIndex = 0;

            // tabStudent
            this.tabStudent.BackColor = System.Drawing.Color.White;
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Text = "Student Registration";
            this.tabStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.ApplyGradient);

            // tabAccount
            this.tabAccount.BackColor = System.Drawing.Color.White;
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Text = "Accounts & Fees";
            this.tabAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.ApplyGradient);

            // tabLibrary
            this.tabLibrary.BackColor = System.Drawing.Color.White;
            this.tabLibrary.Name = "tabLibrary";
            this.tabLibrary.Text = "Library System";
            this.tabLibrary.Paint += new System.Windows.Forms.PaintEventHandler(this.ApplyGradient);

            // tabExam
            this.tabExam.BackColor = System.Drawing.Color.White;
            this.tabExam.Name = "tabExam";
            this.tabExam.Text = "Examination";
            this.tabExam.Paint += new System.Windows.Forms.PaintEventHandler(this.ApplyGradient);

            // tabPlacement
            this.tabPlacement.BackColor = System.Drawing.Color.White;
            this.tabPlacement.Name = "tabPlacement";
            this.tabPlacement.Text = "Placement Cell";
            this.tabPlacement.Paint += new System.Windows.Forms.PaintEventHandler(this.ApplyGradient);

            // ===== STUDENT TAB =====
            this.lblStudentTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentTitle.AutoSize = true;
            this.lblStudentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblStudentTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblStudentTitle.Location = new System.Drawing.Point(20, 15);
            this.lblStudentTitle.Text = "Student Registration";

            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 65);
            this.lblName.Text = "Full Name:";

            this.txtFullName.Location = new System.Drawing.Point(165, 62);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(220, 22);

            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(20, 102);
            this.lblDOB.Text = "Date of Birth:";

            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(165, 99);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(220, 22);

            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 139);
            this.lblGender.Text = "Gender:";

            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            this.cmbGender.Location = new System.Drawing.Point(165, 136);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(220, 24);

            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 176);
            this.lblAddress.Text = "Address:";

            this.txtAddress.Location = new System.Drawing.Point(165, 173);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(220, 55);

            this.lblContact.BackColor = System.Drawing.Color.Transparent;
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(20, 246);
            this.lblContact.Text = "Contact No:";

            this.txtContact.Location = new System.Drawing.Point(165, 243);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(220, 22);

            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 283);
            this.lblEmail.Text = "Email:";

            this.txtEmail.Location = new System.Drawing.Point(165, 280);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 22);

            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(20, 320);
            this.lblCourse.Text = "Course/Branch:";

            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.Items.AddRange(new object[] { "Computer Engineering", "Information Technology", "Mechanical Engineering", "Civil Engineering", "Electronics Engineering" });
            this.cmbCourse.Location = new System.Drawing.Point(165, 317);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(220, 24);

            this.lblAdmDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmDate.AutoSize = true;
            this.lblAdmDate.Location = new System.Drawing.Point(20, 357);
            this.lblAdmDate.Text = "Admission Date:";

            this.dtpAdmission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdmission.Location = new System.Drawing.Point(165, 354);
            this.dtpAdmission.Name = "dtpAdmission";
            this.dtpAdmission.Size = new System.Drawing.Size(220, 22);

            this.lblPhoto.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblPhoto.Location = new System.Drawing.Point(450, 55);
            this.lblPhoto.Text = "Passport Size Photo:";

            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(450, 80);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(150, 180);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.btnUploadPhoto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUploadPhoto.ForeColor = System.Drawing.Color.White;
            this.btnUploadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadPhoto.Location = new System.Drawing.Point(450, 270);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(150, 30);
            this.btnUploadPhoto.Text = "Upload Photo";
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);

            this.btnSaveStudent.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveStudent.ForeColor = System.Drawing.Color.White;
            this.btnSaveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveStudent.Location = new System.Drawing.Point(165, 400);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(140, 35);
            this.btnSaveStudent.Text = "Save Student";
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);

            this.btnClearStudent.BackColor = System.Drawing.Color.Tomato;
            this.btnClearStudent.ForeColor = System.Drawing.Color.White;
            this.btnClearStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearStudent.Location = new System.Drawing.Point(320, 400);
            this.btnClearStudent.Name = "btnClearStudent";
            this.btnClearStudent.Size = new System.Drawing.Size(90, 35);
            this.btnClearStudent.Text = "Clear";
            this.btnClearStudent.Click += new System.EventHandler(this.btnClearStudent_Click);

            this.tabStudent.Controls.Add(this.lblStudentTitle);
            this.tabStudent.Controls.Add(this.lblName);
            this.tabStudent.Controls.Add(this.txtFullName);
            this.tabStudent.Controls.Add(this.lblDOB);
            this.tabStudent.Controls.Add(this.dtpDOB);
            this.tabStudent.Controls.Add(this.lblGender);
            this.tabStudent.Controls.Add(this.cmbGender);
            this.tabStudent.Controls.Add(this.lblAddress);
            this.tabStudent.Controls.Add(this.txtAddress);
            this.tabStudent.Controls.Add(this.lblContact);
            this.tabStudent.Controls.Add(this.txtContact);
            this.tabStudent.Controls.Add(this.lblEmail);
            this.tabStudent.Controls.Add(this.txtEmail);
            this.tabStudent.Controls.Add(this.lblCourse);
            this.tabStudent.Controls.Add(this.cmbCourse);
            this.tabStudent.Controls.Add(this.lblAdmDate);
            this.tabStudent.Controls.Add(this.dtpAdmission);
            this.tabStudent.Controls.Add(this.lblPhoto);
            this.tabStudent.Controls.Add(this.picPhoto);
            this.tabStudent.Controls.Add(this.btnUploadPhoto);
            this.tabStudent.Controls.Add(this.btnSaveStudent);
            this.tabStudent.Controls.Add(this.btnClearStudent);

            // ===== ACCOUNT TAB =====
            this.lblAccountTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountTitle.AutoSize = true;
            this.lblAccountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblAccountTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAccountTitle.Location = new System.Drawing.Point(20, 15);
            this.lblAccountTitle.Text = "Student Account Details";

            this.lblStudentSelAcc.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentSelAcc.AutoSize = true;
            this.lblStudentSelAcc.Location = new System.Drawing.Point(20, 65);
            this.lblStudentSelAcc.Text = "Select Student:";

            this.cmbStudentIdAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentIdAcc.Location = new System.Drawing.Point(165, 62);
            this.cmbStudentIdAcc.Name = "cmbStudentIdAcc";
            this.cmbStudentIdAcc.Size = new System.Drawing.Size(250, 24);

            this.btnLoadAccount.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoadAccount.ForeColor = System.Drawing.Color.White;
            this.btnLoadAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadAccount.Location = new System.Drawing.Point(430, 59);
            this.btnLoadAccount.Name = "btnLoadAccount";
            this.btnLoadAccount.Size = new System.Drawing.Size(90, 28);
            this.btnLoadAccount.Text = "Load";
            this.btnLoadAccount.Click += new System.EventHandler(this.btnLoadAccount_Click);

            this.lblTotalFees.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(20, 110);
            this.lblTotalFees.Text = "Total Fees (Rs):";

            this.txtTotalFees.Location = new System.Drawing.Point(165, 107);
            this.txtTotalFees.Name = "txtTotalFees";
            this.txtTotalFees.Size = new System.Drawing.Size(200, 22);

            this.lblFeesPaid.BackColor = System.Drawing.Color.Transparent;
            this.lblFeesPaid.AutoSize = true;
            this.lblFeesPaid.Location = new System.Drawing.Point(20, 148);
            this.lblFeesPaid.Text = "Fees Paid (Rs):";

            this.txtFeesPaid.Location = new System.Drawing.Point(165, 145);
            this.txtFeesPaid.Name = "txtFeesPaid";
            this.txtFeesPaid.Size = new System.Drawing.Size(200, 22);

            this.lblPending.BackColor = System.Drawing.Color.Transparent;
            this.lblPending.AutoSize = true;
            this.lblPending.ForeColor = System.Drawing.Color.Red;
            this.lblPending.Location = new System.Drawing.Point(20, 186);
            this.lblPending.Text = "Pending Fees (Rs):";

            this.txtPendingFees.BackColor = System.Drawing.Color.MistyRose;
            this.txtPendingFees.Location = new System.Drawing.Point(165, 183);
            this.txtPendingFees.Name = "txtPendingFees";
            this.txtPendingFees.ReadOnly = true;
            this.txtPendingFees.Size = new System.Drawing.Size(200, 22);

            this.lblScholarship.BackColor = System.Drawing.Color.Transparent;
            this.lblScholarship.AutoSize = true;
            this.lblScholarship.Location = new System.Drawing.Point(20, 224);
            this.lblScholarship.Text = "Scholarship (Rs):";

            this.txtScholarship.Location = new System.Drawing.Point(165, 221);
            this.txtScholarship.Name = "txtScholarship";
            this.txtScholarship.Size = new System.Drawing.Size(200, 22);

            this.lblFine.BackColor = System.Drawing.Color.Transparent;
            this.lblFine.AutoSize = true;
            this.lblFine.Location = new System.Drawing.Point(20, 262);
            this.lblFine.Text = "Fine Imposed (Rs):";

            this.txtFine.Location = new System.Drawing.Point(165, 259);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(200, 22);

            this.btnUpdateAccount.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAccount.Location = new System.Drawing.Point(165, 305);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(160, 35);
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);

            this.tabAccount.Controls.Add(this.lblAccountTitle);
            this.tabAccount.Controls.Add(this.lblStudentSelAcc);
            this.tabAccount.Controls.Add(this.cmbStudentIdAcc);
            this.tabAccount.Controls.Add(this.btnLoadAccount);
            this.tabAccount.Controls.Add(this.lblTotalFees);
            this.tabAccount.Controls.Add(this.txtTotalFees);
            this.tabAccount.Controls.Add(this.lblFeesPaid);
            this.tabAccount.Controls.Add(this.txtFeesPaid);
            this.tabAccount.Controls.Add(this.lblPending);
            this.tabAccount.Controls.Add(this.txtPendingFees);
            this.tabAccount.Controls.Add(this.lblScholarship);
            this.tabAccount.Controls.Add(this.txtScholarship);
            this.tabAccount.Controls.Add(this.lblFine);
            this.tabAccount.Controls.Add(this.txtFine);
            this.tabAccount.Controls.Add(this.btnUpdateAccount);

            // ===== LIBRARY TAB =====
            this.lblLibraryTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLibraryTitle.AutoSize = true;
            this.lblLibraryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblLibraryTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLibraryTitle.Location = new System.Drawing.Point(20, 15);
            this.lblLibraryTitle.Text = "Library Management";

            this.lblStudentSelLib.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentSelLib.AutoSize = true;
            this.lblStudentSelLib.Location = new System.Drawing.Point(20, 65);
            this.lblStudentSelLib.Text = "Select Student:";

            this.cmbStudentIdLib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentIdLib.Location = new System.Drawing.Point(165, 62);
            this.cmbStudentIdLib.Name = "cmbStudentIdLib";
            this.cmbStudentIdLib.Size = new System.Drawing.Size(250, 24);

            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(20, 105);
            this.lblBookName.Text = "Book Name:";

            this.txtBookName.Location = new System.Drawing.Point(165, 102);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(250, 22);

            this.lblIssueDate.BackColor = System.Drawing.Color.Transparent;
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(20, 143);
            this.lblIssueDate.Text = "Issue Date:";

            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(165, 140);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(200, 22);

            this.lblReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(20, 181);
            this.lblReturnDate.Text = "Return Date:";

            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(165, 178);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 22);

            this.btnAddBook.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.Location = new System.Drawing.Point(165, 218);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(120, 30);
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);

            this.btnLoadBooks.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoadBooks.ForeColor = System.Drawing.Color.White;
            this.btnLoadBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadBooks.Location = new System.Drawing.Point(300, 218);
            this.btnLoadBooks.Name = "btnLoadBooks";
            this.btnLoadBooks.Size = new System.Drawing.Size(130, 30);
            this.btnLoadBooks.Text = "Load Records";
            this.btnLoadBooks.Click += new System.EventHandler(this.btnLoadBooks_Click);

            this.dgvLibrary.AllowUserToAddRows = false;
            this.dgvLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibrary.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibrary.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.dgvLibrary.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLibrary.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.dgvLibrary.Location = new System.Drawing.Point(20, 265);
            this.dgvLibrary.Name = "dgvLibrary";
            this.dgvLibrary.ReadOnly = true;
            this.dgvLibrary.Size = new System.Drawing.Size(880, 270);
            this.dgvLibrary.TabIndex = 0;

            this.tabLibrary.Controls.Add(this.lblLibraryTitle);
            this.tabLibrary.Controls.Add(this.lblStudentSelLib);
            this.tabLibrary.Controls.Add(this.cmbStudentIdLib);
            this.tabLibrary.Controls.Add(this.lblBookName);
            this.tabLibrary.Controls.Add(this.txtBookName);
            this.tabLibrary.Controls.Add(this.lblIssueDate);
            this.tabLibrary.Controls.Add(this.dtpIssueDate);
            this.tabLibrary.Controls.Add(this.lblReturnDate);
            this.tabLibrary.Controls.Add(this.dtpReturnDate);
            this.tabLibrary.Controls.Add(this.btnAddBook);
            this.tabLibrary.Controls.Add(this.btnLoadBooks);
            this.tabLibrary.Controls.Add(this.dgvLibrary);

            // ===== EXAM TAB =====
            this.lblExamTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblExamTitle.AutoSize = true;
            this.lblExamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblExamTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblExamTitle.Location = new System.Drawing.Point(20, 15);
            this.lblExamTitle.Text = "Exam Cell - Academic Results";

            this.lblStudentSelExam.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentSelExam.AutoSize = true;
            this.lblStudentSelExam.Location = new System.Drawing.Point(20, 65);
            this.lblStudentSelExam.Text = "Select Student:";

            this.cmbStudentIdExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentIdExam.Location = new System.Drawing.Point(165, 62);
            this.cmbStudentIdExam.Name = "cmbStudentIdExam";
            this.cmbStudentIdExam.Size = new System.Drawing.Size(250, 24);

            this.lblSemester.BackColor = System.Drawing.Color.Transparent;
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(20, 105);
            this.lblSemester.Text = "Semester:";

            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.Items.AddRange(new object[] { "Semester 1", "Semester 2", "Semester 3", "Semester 4", "Semester 5", "Semester 6", "Semester 7", "Semester 8" });
            this.cmbSemester.Location = new System.Drawing.Point(165, 102);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(200, 24);

            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(20, 145);
            this.lblSubject.Text = "Subject:";

            this.txtSubject.Location = new System.Drawing.Point(165, 142);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(220, 22);

            this.lblMarks.BackColor = System.Drawing.Color.Transparent;
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(20, 183);
            this.lblMarks.Text = "Marks:";

            this.txtMarks.Location = new System.Drawing.Point(165, 180);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 22);

            this.lblGradeLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblGradeLabel.AutoSize = true;
            this.lblGradeLabel.Location = new System.Drawing.Point(285, 183);
            this.lblGradeLabel.Text = "Grade:";

            this.txtGrade.Location = new System.Drawing.Point(345, 180);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(80, 22);

            this.lblSGPA.BackColor = System.Drawing.Color.Transparent;
            this.lblSGPA.AutoSize = true;
            this.lblSGPA.Location = new System.Drawing.Point(20, 221);
            this.lblSGPA.Text = "SGPA:";

            this.txtSGPA.Location = new System.Drawing.Point(165, 218);
            this.txtSGPA.Name = "txtSGPA";
            this.txtSGPA.Size = new System.Drawing.Size(100, 22);

            this.lblCGPA.BackColor = System.Drawing.Color.Transparent;
            this.lblCGPA.AutoSize = true;
            this.lblCGPA.Location = new System.Drawing.Point(285, 221);
            this.lblCGPA.Text = "CGPA:";

            this.txtCGPA.Location = new System.Drawing.Point(345, 218);
            this.txtCGPA.Name = "txtCGPA";
            this.txtCGPA.Size = new System.Drawing.Size(100, 22);

            this.btnAddResult.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddResult.ForeColor = System.Drawing.Color.White;
            this.btnAddResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddResult.Location = new System.Drawing.Point(165, 258);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(120, 30);
            this.btnAddResult.Text = "Add Result";
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);

            this.btnLoadResults.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoadResults.ForeColor = System.Drawing.Color.White;
            this.btnLoadResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadResults.Location = new System.Drawing.Point(300, 258);
            this.btnLoadResults.Name = "btnLoadResults";
            this.btnLoadResults.Size = new System.Drawing.Size(130, 30);
            this.btnLoadResults.Text = "Load Results";
            this.btnLoadResults.Click += new System.EventHandler(this.btnLoadResults_Click);

            this.dgvExam.AllowUserToAddRows = false;
            this.dgvExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExam.BackgroundColor = System.Drawing.Color.White;
            this.dgvExam.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.dgvExam.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExam.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.dgvExam.Location = new System.Drawing.Point(20, 305);
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.ReadOnly = true;
            this.dgvExam.Size = new System.Drawing.Size(880, 235);
            this.dgvExam.TabIndex = 0;

            this.tabExam.Controls.Add(this.lblExamTitle);
            this.tabExam.Controls.Add(this.lblStudentSelExam);
            this.tabExam.Controls.Add(this.cmbStudentIdExam);
            this.tabExam.Controls.Add(this.lblSemester);
            this.tabExam.Controls.Add(this.cmbSemester);
            this.tabExam.Controls.Add(this.lblSubject);
            this.tabExam.Controls.Add(this.txtSubject);
            this.tabExam.Controls.Add(this.lblMarks);
            this.tabExam.Controls.Add(this.txtMarks);
            this.tabExam.Controls.Add(this.lblGradeLabel);
            this.tabExam.Controls.Add(this.txtGrade);
            this.tabExam.Controls.Add(this.lblSGPA);
            this.tabExam.Controls.Add(this.txtSGPA);
            this.tabExam.Controls.Add(this.lblCGPA);
            this.tabExam.Controls.Add(this.txtCGPA);
            this.tabExam.Controls.Add(this.btnAddResult);
            this.tabExam.Controls.Add(this.btnLoadResults);
            this.tabExam.Controls.Add(this.dgvExam);

            // ===== PLACEMENT TAB =====
            this.lblPlacementTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacementTitle.AutoSize = true;
            this.lblPlacementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblPlacementTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPlacementTitle.Location = new System.Drawing.Point(20, 15);
            this.lblPlacementTitle.Text = "Placement Cell";

            this.lblStudentSelPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentSelPlace.AutoSize = true;
            this.lblStudentSelPlace.Location = new System.Drawing.Point(20, 65);
            this.lblStudentSelPlace.Text = "Select Student:";

            this.cmbStudentIdPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentIdPlace.Location = new System.Drawing.Point(165, 62);
            this.cmbStudentIdPlace.Name = "cmbStudentIdPlace";
            this.cmbStudentIdPlace.Size = new System.Drawing.Size(250, 24);

            this.lblResume.BackColor = System.Drawing.Color.Transparent;
            this.lblResume.AutoSize = true;
            this.lblResume.Location = new System.Drawing.Point(20, 110);
            this.lblResume.Text = "Upload Resume (PDF):";

            this.btnUploadResume.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUploadResume.ForeColor = System.Drawing.Color.White;
            this.btnUploadResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadResume.Location = new System.Drawing.Point(165, 105);
            this.btnUploadResume.Name = "btnUploadResume";
            this.btnUploadResume.Size = new System.Drawing.Size(140, 30);
            this.btnUploadResume.Text = "Browse PDF";
            this.btnUploadResume.Click += new System.EventHandler(this.btnUploadResume_Click);

            this.lblResumeName.BackColor = System.Drawing.Color.Transparent;
            this.lblResumeName.AutoSize = false;
            this.lblResumeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblResumeName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResumeName.Location = new System.Drawing.Point(165, 145);
            this.lblResumeName.Name = "lblResumeName";
            this.lblResumeName.Size = new System.Drawing.Size(380, 22);
            this.lblResumeName.Text = "No file selected";

            this.lblPlacementType.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacementType.AutoSize = true;
            this.lblPlacementType.Location = new System.Drawing.Point(20, 183);
            this.lblPlacementType.Text = "Placement Type:";

            this.cmbPlacementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlacementType.Items.AddRange(new object[] { "Internship", "Campus Placement" });
            this.cmbPlacementType.Location = new System.Drawing.Point(165, 180);
            this.cmbPlacementType.Name = "cmbPlacementType";
            this.cmbPlacementType.Size = new System.Drawing.Size(200, 24);

            this.lblDomain.BackColor = System.Drawing.Color.Transparent;
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(20, 221);
            this.lblDomain.Text = "Interested Domain:";

            this.txtDomain.Location = new System.Drawing.Point(165, 218);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(250, 22);

            this.btnSubmitPlacement.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSubmitPlacement.ForeColor = System.Drawing.Color.White;
            this.btnSubmitPlacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmitPlacement.Location = new System.Drawing.Point(165, 265);
            this.btnSubmitPlacement.Name = "btnSubmitPlacement";
            this.btnSubmitPlacement.Size = new System.Drawing.Size(180, 35);
            this.btnSubmitPlacement.Text = "Submit Application";
            this.btnSubmitPlacement.Click += new System.EventHandler(this.btnSubmitPlacement_Click);

            this.tabPlacement.Controls.Add(this.lblPlacementTitle);
            this.tabPlacement.Controls.Add(this.lblStudentSelPlace);
            this.tabPlacement.Controls.Add(this.cmbStudentIdPlace);
            this.tabPlacement.Controls.Add(this.lblResume);
            this.tabPlacement.Controls.Add(this.btnUploadResume);
            this.tabPlacement.Controls.Add(this.lblResumeName);
            this.tabPlacement.Controls.Add(this.lblPlacementType);
            this.tabPlacement.Controls.Add(this.cmbPlacementType);
            this.tabPlacement.Controls.Add(this.lblDomain);
            this.tabPlacement.Controls.Add(this.txtDomain);
            this.tabPlacement.Controls.Add(this.btnSubmitPlacement);

            // ===== FORM =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.tabMain.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabStudent.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.tabLibrary.ResumeLayout(false);
            this.tabLibrary.PerformLayout();
            this.tabExam.ResumeLayout(false);
            this.tabExam.PerformLayout();
            this.tabPlacement.ResumeLayout(false);
            this.tabPlacement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabStudent, tabAccount, tabLibrary, tabExam, tabPlacement;
        private System.Windows.Forms.Label lblStudentTitle, lblName, lblDOB, lblGender, lblAddress, lblContact, lblEmail, lblCourse, lblAdmDate, lblPhoto;
        private System.Windows.Forms.TextBox txtFullName, txtAddress, txtContact, txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDOB, dtpAdmission;
        private System.Windows.Forms.ComboBox cmbGender, cmbCourse;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnUploadPhoto, btnSaveStudent, btnClearStudent;
        private System.Windows.Forms.Label lblAccountTitle, lblStudentSelAcc, lblTotalFees, lblFeesPaid, lblPending, lblScholarship, lblFine;
        private System.Windows.Forms.ComboBox cmbStudentIdAcc;
        private System.Windows.Forms.TextBox txtTotalFees, txtFeesPaid, txtPendingFees, txtScholarship, txtFine;
        private System.Windows.Forms.Button btnLoadAccount, btnUpdateAccount;
        private System.Windows.Forms.Label lblLibraryTitle, lblStudentSelLib, lblBookName, lblIssueDate, lblReturnDate;
        private System.Windows.Forms.ComboBox cmbStudentIdLib;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.DateTimePicker dtpIssueDate, dtpReturnDate;
        private System.Windows.Forms.Button btnAddBook, btnLoadBooks;
        private System.Windows.Forms.DataGridView dgvLibrary;
        private System.Windows.Forms.Label lblExamTitle, lblStudentSelExam, lblSemester, lblSubject, lblMarks, lblGradeLabel, lblSGPA, lblCGPA;
        private System.Windows.Forms.ComboBox cmbStudentIdExam, cmbSemester;
        private System.Windows.Forms.TextBox txtSubject, txtMarks, txtGrade, txtSGPA, txtCGPA;
        private System.Windows.Forms.Button btnAddResult, btnLoadResults;
        private System.Windows.Forms.DataGridView dgvExam;
        private System.Windows.Forms.Label lblPlacementTitle, lblStudentSelPlace, lblResume, lblResumeName, lblPlacementType, lblDomain;
        private System.Windows.Forms.ComboBox cmbStudentIdPlace, cmbPlacementType;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnUploadResume, btnSubmitPlacement;
    }
}