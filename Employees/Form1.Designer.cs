namespace Employees
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.bornDay = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.lblSelphon = new System.Windows.Forms.Label();
            this.homePhon = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.numberHome = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.txtCelphon = new System.Windows.Forms.TextBox();
            this.txtTelephon = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFindById = new System.Windows.Forms.Button();
            this.btnFindByCode = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.rdbMereed = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.rdbWidow = new System.Windows.Forms.RadioButton();
            this.rdbTheWorse = new System.Windows.Forms.RadioButton();
            this.panelGander = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.dtpDateOfBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.panelGander.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(674, 113);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "1";
            this.txtCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(549, 113);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(414, 113);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(280, 113);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(748, 87);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(27, 16);
            this.code.TabIndex = 4;
            this.code.Text = "קוד";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(576, 87);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(76, 16);
            this.id.TabIndex = 5;
            this.id.Text = "תעודת זהות";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(463, 87);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(54, 16);
            this.firstName.TabIndex = 6;
            this.firstName.Text = "שם פרטי";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(316, 87);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(67, 16);
            this.lastName.TabIndex = 7;
            this.lastName.Text = "שם משפחה";
            // 
            // bornDay
            // 
            this.bornDay.AutoSize = true;
            this.bornDay.Location = new System.Drawing.Point(192, 87);
            this.bornDay.Name = "bornDay";
            this.bornDay.Size = new System.Drawing.Size(76, 16);
            this.bornDay.TabIndex = 8;
            this.bornDay.Text = "תאריך לידה";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(439, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(49, 16);
            this.title.TabIndex = 10;
            this.title.Text = "עובדים";
            // 
            // lblSelphon
            // 
            this.lblSelphon.AutoSize = true;
            this.lblSelphon.Location = new System.Drawing.Point(709, 392);
            this.lblSelphon.Name = "lblSelphon";
            this.lblSelphon.Size = new System.Drawing.Size(66, 16);
            this.lblSelphon.TabIndex = 11;
            this.lblSelphon.Text = "טלפון נייד";
            // 
            // homePhon
            // 
            this.homePhon.AutoSize = true;
            this.homePhon.Location = new System.Drawing.Point(579, 392);
            this.homePhon.Name = "homePhon";
            this.homePhon.Size = new System.Drawing.Size(73, 16);
            this.homePhon.TabIndex = 12;
            this.homePhon.Text = "טלפון בבית";
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Location = new System.Drawing.Point(482, 392);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(35, 16);
            this.street.TabIndex = 13;
            this.street.Text = "רחוב";
            // 
            // numberHome
            // 
            this.numberHome.AutoSize = true;
            this.numberHome.Location = new System.Drawing.Point(358, 392);
            this.numberHome.Name = "numberHome";
            this.numberHome.Size = new System.Drawing.Size(37, 16);
            this.numberHome.TabIndex = 14;
            this.numberHome.Text = "מספר";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(241, 392);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(27, 16);
            this.city.TabIndex = 15;
            this.city.Text = "עיר";
            // 
            // txtCelphon
            // 
            this.txtCelphon.Location = new System.Drawing.Point(674, 432);
            this.txtCelphon.Name = "txtCelphon";
            this.txtCelphon.Size = new System.Drawing.Size(100, 22);
            this.txtCelphon.TabIndex = 16;
            // 
            // txtTelephon
            // 
            this.txtTelephon.Location = new System.Drawing.Point(549, 432);
            this.txtTelephon.Name = "txtTelephon";
            this.txtTelephon.Size = new System.Drawing.Size(100, 22);
            this.txtTelephon.TabIndex = 17;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(414, 432);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 22);
            this.txtStreet.TabIndex = 18;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(292, 432);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 19;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(165, 432);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 20;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(668, 532);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 23);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(542, 532);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "הוספת עובד";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(298, 532);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "עדכון";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(165, 532);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 23);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "מחיקת עובד";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(697, 345);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = "<<<";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(165, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = ">>>";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnFindById
            // 
            this.btnFindById.Location = new System.Drawing.Point(430, 609);
            this.btnFindById.Name = "btnFindById";
            this.btnFindById.Size = new System.Drawing.Size(165, 23);
            this.btnFindById.TabIndex = 27;
            this.btnFindById.Text = "חיפוש לפי תעודת זהות ";
            this.btnFindById.UseVisualStyleBackColor = true;
            this.btnFindById.Click += new System.EventHandler(this.btnFindById_Click);
            // 
            // btnFindByCode
            // 
            this.btnFindByCode.Location = new System.Drawing.Point(639, 609);
            this.btnFindByCode.Name = "btnFindByCode";
            this.btnFindByCode.Size = new System.Drawing.Size(133, 23);
            this.btnFindByCode.TabIndex = 28;
            this.btnFindByCode.Text = "חיפוש לפי קוד ";
            this.btnFindByCode.UseVisualStyleBackColor = true;
            this.btnFindByCode.Click += new System.EventHandler(this.btnFindByCode_Click);
            // 
            // rdbMereed
            // 
            this.rdbMereed.AutoSize = true;
            this.rdbMereed.Location = new System.Drawing.Point(19, 47);
            this.rdbMereed.Name = "rdbMereed";
            this.rdbMereed.Size = new System.Drawing.Size(52, 20);
            this.rdbMereed.TabIndex = 29;
            this.rdbMereed.TabStop = true;
            this.rdbMereed.Text = "נשוי";
            this.rdbMereed.UseVisualStyleBackColor = true;
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(19, 19);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(52, 20);
            this.rdbSingle.TabIndex = 30;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "רווק";
            this.rdbSingle.UseVisualStyleBackColor = true;
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Location = new System.Drawing.Point(26, 19);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(47, 20);
            this.rdbMan.TabIndex = 31;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "זכר";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // rdbWoman
            // 
            this.rdbWoman.AutoSize = true;
            this.rdbWoman.Location = new System.Drawing.Point(17, 54);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(56, 20);
            this.rdbWoman.TabIndex = 32;
            this.rdbWoman.TabStop = true;
            this.rdbWoman.Text = "נקבה";
            this.rdbWoman.UseVisualStyleBackColor = true;
            this.rdbWoman.CheckedChanged += new System.EventHandler(this.woman_CheckedChanged);
            // 
            // rdbWidow
            // 
            this.rdbWidow.AutoSize = true;
            this.rdbWidow.Location = new System.Drawing.Point(14, 77);
            this.rdbWidow.Name = "rdbWidow";
            this.rdbWidow.Size = new System.Drawing.Size(57, 20);
            this.rdbWidow.TabIndex = 33;
            this.rdbWidow.TabStop = true;
            this.rdbWidow.Text = "אלמן";
            this.rdbWidow.UseVisualStyleBackColor = true;
            // 
            // rdbTheWorse
            // 
            this.rdbTheWorse.AutoSize = true;
            this.rdbTheWorse.Location = new System.Drawing.Point(16, 103);
            this.rdbTheWorse.Name = "rdbTheWorse";
            this.rdbTheWorse.Size = new System.Drawing.Size(55, 20);
            this.rdbTheWorse.TabIndex = 34;
            this.rdbTheWorse.TabStop = true;
            this.rdbTheWorse.Text = "גרוש";
            this.rdbTheWorse.UseVisualStyleBackColor = true;
            // 
            // panelGander
            // 
            this.panelGander.Controls.Add(this.rdbWoman);
            this.panelGander.Controls.Add(this.rdbMan);
            this.panelGander.Location = new System.Drawing.Point(558, 186);
            this.panelGander.Name = "panelGander";
            this.panelGander.Size = new System.Drawing.Size(91, 100);
            this.panelGander.TabIndex = 35;
            this.panelGander.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGander_Paint);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.rdbSingle);
            this.panelStatus.Controls.Add(this.rdbMereed);
            this.panelStatus.Controls.Add(this.rdbTheWorse);
            this.panelStatus.Controls.Add(this.rdbWidow);
            this.panelStatus.Location = new System.Drawing.Point(430, 186);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(104, 147);
            this.panelStatus.TabIndex = 36;
            // 
            // dtpDateOfBirthday
            // 
            this.dtpDateOfBirthday.Location = new System.Drawing.Point(65, 113);
            this.dtpDateOfBirthday.Name = "dtpDateOfBirthday";
            this.dtpDateOfBirthday.Size = new System.Drawing.Size(200, 22);
            this.dtpDateOfBirthday.TabIndex = 39;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(165, 186);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 40;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(241, 158);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 16);
            this.lblAge.TabIndex = 41;
            this.lblAge.Text = "גיל";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 681);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.dtpDateOfBirthday);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelGander);
            this.Controls.Add(this.btnFindByCode);
            this.Controls.Add(this.btnFindById);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtTelephon);
            this.Controls.Add(this.txtCelphon);
            this.Controls.Add(this.city);
            this.Controls.Add(this.numberHome);
            this.Controls.Add(this.street);
            this.Controls.Add(this.homePhon);
            this.Controls.Add(this.lblSelphon);
            this.Controls.Add(this.title);
            this.Controls.Add(this.bornDay);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.id);
            this.Controls.Add(this.code);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCode);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGander.ResumeLayout(false);
            this.panelGander.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label bornDay;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lblSelphon;
        private System.Windows.Forms.Label homePhon;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label numberHome;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox txtCelphon;
        private System.Windows.Forms.TextBox txtTelephon;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFindById;
        private System.Windows.Forms.Button btnFindByCode;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.RadioButton rdbMereed;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.RadioButton rdbWidow;
        private System.Windows.Forms.RadioButton rdbTheWorse;
        private System.Windows.Forms.Panel panelGander;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirthday;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
    }
}

