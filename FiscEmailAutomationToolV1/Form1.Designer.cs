
namespace FiscEmailAutomationToolV1
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
            this.cboCustTitle = new System.Windows.Forms.ComboBox();
            this.lbCustTitleHeader = new System.Windows.Forms.Label();
            this.tbCustSurname = new System.Windows.Forms.TextBox();
            this.lbCustSurnameHeader = new System.Windows.Forms.Label();
            this.lbVehicleRegHeader = new System.Windows.Forms.Label();
            this.lbVehicleNameHeader = new System.Windows.Forms.Label();
            this.tbVehicleReg = new System.Windows.Forms.TextBox();
            this.tbVehicleName = new System.Windows.Forms.TextBox();
            this.cboNewOrUsed = new System.Windows.Forms.ComboBox();
            this.lbNewOrUsedHeader = new System.Windows.Forms.Label();
            this.tbPaymentsLeftHeader = new System.Windows.Forms.Label();
            this.tbFinanceTypeHeader = new System.Windows.Forms.Label();
            this.cboFinaceType = new System.Windows.Forms.ComboBox();
            this.tbPaymentsLeft = new System.Windows.Forms.TextBox();
            this.dtpApptDate = new System.Windows.Forms.DateTimePicker();
            this.lbApptDateHeader = new System.Windows.Forms.Label();
            this.lbAppointmentTimeHeader = new System.Windows.Forms.Label();
            this.cboApptTimeHour = new System.Windows.Forms.ComboBox();
            this.cboApptTimeMinute = new System.Windows.Forms.ComboBox();
            this.cboApptTimeAMPM = new System.Windows.Forms.ComboBox();
            this.lbApptTypeHeader = new System.Windows.Forms.Label();
            this.lbDealershipNameHeader = new System.Windows.Forms.Label();
            this.cboAppointmentType = new System.Windows.Forms.ComboBox();
            this.tbDealershipName = new System.Windows.Forms.TextBox();
            this.lbApptNotesHeader = new System.Windows.Forms.Label();
            this.tbApptNotes = new System.Windows.Forms.TextBox();
            this.lbVehicleType = new System.Windows.Forms.Label();
            this.cboBmwOrMini = new System.Windows.Forms.ComboBox();
            this.btnCreateCustEmail = new System.Windows.Forms.Button();
            this.btnCreateDealerEmail = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.tbEmailSubject = new System.Windows.Forms.TextBox();
            this.tbEmailBody = new System.Windows.Forms.TextBox();
            this.lbEmailSubjectHeader = new System.Windows.Forms.Label();
            this.lbEmailBodyHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCustTitle
            // 
            this.cboCustTitle.FormattingEnabled = true;
            this.cboCustTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs ",
            "Miss",
            "Ms"});
            this.cboCustTitle.Location = new System.Drawing.Point(32, 85);
            this.cboCustTitle.Margin = new System.Windows.Forms.Padding(2);
            this.cboCustTitle.Name = "cboCustTitle";
            this.cboCustTitle.Size = new System.Drawing.Size(49, 21);
            this.cboCustTitle.TabIndex = 0;
            // 
            // lbCustTitleHeader
            // 
            this.lbCustTitleHeader.AutoSize = true;
            this.lbCustTitleHeader.Location = new System.Drawing.Point(29, 66);
            this.lbCustTitleHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustTitleHeader.Name = "lbCustTitleHeader";
            this.lbCustTitleHeader.Size = new System.Drawing.Size(27, 13);
            this.lbCustTitleHeader.TabIndex = 1;
            this.lbCustTitleHeader.Text = "Title";
            // 
            // tbCustSurname
            // 
            this.tbCustSurname.Location = new System.Drawing.Point(86, 85);
            this.tbCustSurname.Name = "tbCustSurname";
            this.tbCustSurname.Size = new System.Drawing.Size(100, 20);
            this.tbCustSurname.TabIndex = 2;
            // 
            // lbCustSurnameHeader
            // 
            this.lbCustSurnameHeader.AutoSize = true;
            this.lbCustSurnameHeader.Location = new System.Drawing.Point(83, 69);
            this.lbCustSurnameHeader.Name = "lbCustSurnameHeader";
            this.lbCustSurnameHeader.Size = new System.Drawing.Size(49, 13);
            this.lbCustSurnameHeader.TabIndex = 3;
            this.lbCustSurnameHeader.Text = "Surname";
            // 
            // lbVehicleRegHeader
            // 
            this.lbVehicleRegHeader.AutoSize = true;
            this.lbVehicleRegHeader.Location = new System.Drawing.Point(29, 135);
            this.lbVehicleRegHeader.Name = "lbVehicleRegHeader";
            this.lbVehicleRegHeader.Size = new System.Drawing.Size(47, 13);
            this.lbVehicleRegHeader.TabIndex = 4;
            this.lbVehicleRegHeader.Text = "Reg No.";
            // 
            // lbVehicleNameHeader
            // 
            this.lbVehicleNameHeader.AutoSize = true;
            this.lbVehicleNameHeader.Location = new System.Drawing.Point(98, 135);
            this.lbVehicleNameHeader.Name = "lbVehicleNameHeader";
            this.lbVehicleNameHeader.Size = new System.Drawing.Size(45, 13);
            this.lbVehicleNameHeader.TabIndex = 5;
            this.lbVehicleNameHeader.Text = "Vehicle ";
            // 
            // tbVehicleReg
            // 
            this.tbVehicleReg.Location = new System.Drawing.Point(32, 151);
            this.tbVehicleReg.Name = "tbVehicleReg";
            this.tbVehicleReg.Size = new System.Drawing.Size(63, 20);
            this.tbVehicleReg.TabIndex = 6;
            // 
            // tbVehicleName
            // 
            this.tbVehicleName.Location = new System.Drawing.Point(101, 151);
            this.tbVehicleName.Name = "tbVehicleName";
            this.tbVehicleName.Size = new System.Drawing.Size(226, 20);
            this.tbVehicleName.TabIndex = 7;
            // 
            // cboNewOrUsed
            // 
            this.cboNewOrUsed.FormattingEnabled = true;
            this.cboNewOrUsed.Items.AddRange(new object[] {
            "NEW",
            "USED"});
            this.cboNewOrUsed.Location = new System.Drawing.Point(333, 150);
            this.cboNewOrUsed.Name = "cboNewOrUsed";
            this.cboNewOrUsed.Size = new System.Drawing.Size(62, 21);
            this.cboNewOrUsed.TabIndex = 8;
            // 
            // lbNewOrUsedHeader
            // 
            this.lbNewOrUsedHeader.AutoSize = true;
            this.lbNewOrUsedHeader.Location = new System.Drawing.Point(330, 134);
            this.lbNewOrUsedHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewOrUsedHeader.Name = "lbNewOrUsedHeader";
            this.lbNewOrUsedHeader.Size = new System.Drawing.Size(65, 13);
            this.lbNewOrUsedHeader.TabIndex = 9;
            this.lbNewOrUsedHeader.Text = "New / Used";
            // 
            // tbPaymentsLeftHeader
            // 
            this.tbPaymentsLeftHeader.AutoSize = true;
            this.tbPaymentsLeftHeader.Location = new System.Drawing.Point(116, 197);
            this.tbPaymentsLeftHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tbPaymentsLeftHeader.Name = "tbPaymentsLeftHeader";
            this.tbPaymentsLeftHeader.Size = new System.Drawing.Size(106, 13);
            this.tbPaymentsLeftHeader.TabIndex = 10;
            this.tbPaymentsLeftHeader.Text = "Payments Remaining";
            // 
            // tbFinanceTypeHeader
            // 
            this.tbFinanceTypeHeader.AutoSize = true;
            this.tbFinanceTypeHeader.Location = new System.Drawing.Point(29, 196);
            this.tbFinanceTypeHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tbFinanceTypeHeader.Name = "tbFinanceTypeHeader";
            this.tbFinanceTypeHeader.Size = new System.Drawing.Size(72, 13);
            this.tbFinanceTypeHeader.TabIndex = 11;
            this.tbFinanceTypeHeader.Text = "Finance Type";
            // 
            // cboFinaceType
            // 
            this.cboFinaceType.FormattingEnabled = true;
            this.cboFinaceType.Items.AddRange(new object[] {
            "SELECT",
            "HP",
            "SELECT(RF)",
            "HP(RF)",
            "CH",
            ""});
            this.cboFinaceType.Location = new System.Drawing.Point(32, 212);
            this.cboFinaceType.Name = "cboFinaceType";
            this.cboFinaceType.Size = new System.Drawing.Size(81, 21);
            this.cboFinaceType.TabIndex = 12;
            // 
            // tbPaymentsLeft
            // 
            this.tbPaymentsLeft.Location = new System.Drawing.Point(119, 213);
            this.tbPaymentsLeft.Name = "tbPaymentsLeft";
            this.tbPaymentsLeft.Size = new System.Drawing.Size(47, 20);
            this.tbPaymentsLeft.TabIndex = 13;
            // 
            // dtpApptDate
            // 
            this.dtpApptDate.Location = new System.Drawing.Point(32, 278);
            this.dtpApptDate.Name = "dtpApptDate";
            this.dtpApptDate.Size = new System.Drawing.Size(142, 20);
            this.dtpApptDate.TabIndex = 14;
            // 
            // lbApptDateHeader
            // 
            this.lbApptDateHeader.AutoSize = true;
            this.lbApptDateHeader.Location = new System.Drawing.Point(29, 262);
            this.lbApptDateHeader.Name = "lbApptDateHeader";
            this.lbApptDateHeader.Size = new System.Drawing.Size(92, 13);
            this.lbApptDateHeader.TabIndex = 15;
            this.lbApptDateHeader.Text = "Appointment Date";
            // 
            // lbAppointmentTimeHeader
            // 
            this.lbAppointmentTimeHeader.AutoSize = true;
            this.lbAppointmentTimeHeader.Location = new System.Drawing.Point(192, 262);
            this.lbAppointmentTimeHeader.Name = "lbAppointmentTimeHeader";
            this.lbAppointmentTimeHeader.Size = new System.Drawing.Size(92, 13);
            this.lbAppointmentTimeHeader.TabIndex = 17;
            this.lbAppointmentTimeHeader.Text = "Appointment Time";
            // 
            // cboApptTimeHour
            // 
            this.cboApptTimeHour.FormattingEnabled = true;
            this.cboApptTimeHour.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboApptTimeHour.Location = new System.Drawing.Point(195, 278);
            this.cboApptTimeHour.Name = "cboApptTimeHour";
            this.cboApptTimeHour.Size = new System.Drawing.Size(47, 21);
            this.cboApptTimeHour.TabIndex = 18;
            // 
            // cboApptTimeMinute
            // 
            this.cboApptTimeMinute.FormattingEnabled = true;
            this.cboApptTimeMinute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cboApptTimeMinute.Location = new System.Drawing.Point(248, 278);
            this.cboApptTimeMinute.Name = "cboApptTimeMinute";
            this.cboApptTimeMinute.Size = new System.Drawing.Size(53, 21);
            this.cboApptTimeMinute.TabIndex = 19;
            // 
            // cboApptTimeAMPM
            // 
            this.cboApptTimeAMPM.FormattingEnabled = true;
            this.cboApptTimeAMPM.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.cboApptTimeAMPM.Location = new System.Drawing.Point(307, 278);
            this.cboApptTimeAMPM.Name = "cboApptTimeAMPM";
            this.cboApptTimeAMPM.Size = new System.Drawing.Size(47, 21);
            this.cboApptTimeAMPM.TabIndex = 20;
            // 
            // lbApptTypeHeader
            // 
            this.lbApptTypeHeader.AutoSize = true;
            this.lbApptTypeHeader.Location = new System.Drawing.Point(29, 324);
            this.lbApptTypeHeader.Name = "lbApptTypeHeader";
            this.lbApptTypeHeader.Size = new System.Drawing.Size(93, 13);
            this.lbApptTypeHeader.TabIndex = 22;
            this.lbApptTypeHeader.Text = "Appointment Type";
            // 
            // lbDealershipNameHeader
            // 
            this.lbDealershipNameHeader.AutoSize = true;
            this.lbDealershipNameHeader.Location = new System.Drawing.Point(192, 324);
            this.lbDealershipNameHeader.Name = "lbDealershipNameHeader";
            this.lbDealershipNameHeader.Size = new System.Drawing.Size(110, 13);
            this.lbDealershipNameHeader.TabIndex = 25;
            this.lbDealershipNameHeader.Text = "Appointment Location";
            // 
            // cboAppointmentType
            // 
            this.cboAppointmentType.FormattingEnabled = true;
            this.cboAppointmentType.Items.AddRange(new object[] {
            "SHOWROOM APPOINTMENT",
            "TELEPHONE APPOINTMENT"});
            this.cboAppointmentType.Location = new System.Drawing.Point(32, 340);
            this.cboAppointmentType.Name = "cboAppointmentType";
            this.cboAppointmentType.Size = new System.Drawing.Size(154, 21);
            this.cboAppointmentType.TabIndex = 26;
            // 
            // tbDealershipName
            // 
            this.tbDealershipName.Location = new System.Drawing.Point(195, 341);
            this.tbDealershipName.Name = "tbDealershipName";
            this.tbDealershipName.Size = new System.Drawing.Size(200, 20);
            this.tbDealershipName.TabIndex = 27;
            // 
            // lbApptNotesHeader
            // 
            this.lbApptNotesHeader.AutoSize = true;
            this.lbApptNotesHeader.Location = new System.Drawing.Point(29, 384);
            this.lbApptNotesHeader.Name = "lbApptNotesHeader";
            this.lbApptNotesHeader.Size = new System.Drawing.Size(97, 13);
            this.lbApptNotesHeader.TabIndex = 28;
            this.lbApptNotesHeader.Text = "Appointment Notes";
            // 
            // tbApptNotes
            // 
            this.tbApptNotes.Location = new System.Drawing.Point(32, 400);
            this.tbApptNotes.Multiline = true;
            this.tbApptNotes.Name = "tbApptNotes";
            this.tbApptNotes.Size = new System.Drawing.Size(363, 120);
            this.tbApptNotes.TabIndex = 29;
            // 
            // lbVehicleType
            // 
            this.lbVehicleType.AutoSize = true;
            this.lbVehicleType.Location = new System.Drawing.Point(227, 196);
            this.lbVehicleType.Name = "lbVehicleType";
            this.lbVehicleType.Size = new System.Drawing.Size(68, 13);
            this.lbVehicleType.TabIndex = 30;
            this.lbVehicleType.Text = "BMW / MINI";
            // 
            // cboBmwOrMini
            // 
            this.cboBmwOrMini.FormattingEnabled = true;
            this.cboBmwOrMini.Items.AddRange(new object[] {
            "BMW",
            "MINI"});
            this.cboBmwOrMini.Location = new System.Drawing.Point(230, 212);
            this.cboBmwOrMini.Name = "cboBmwOrMini";
            this.cboBmwOrMini.Size = new System.Drawing.Size(72, 21);
            this.cboBmwOrMini.TabIndex = 31;
            // 
            // btnCreateCustEmail
            // 
            this.btnCreateCustEmail.Location = new System.Drawing.Point(32, 538);
            this.btnCreateCustEmail.Name = "btnCreateCustEmail";
            this.btnCreateCustEmail.Size = new System.Drawing.Size(81, 57);
            this.btnCreateCustEmail.TabIndex = 32;
            this.btnCreateCustEmail.Text = "Create Customer Email";
            this.btnCreateCustEmail.UseVisualStyleBackColor = true;
            this.btnCreateCustEmail.Click += new System.EventHandler(this.btnCreateCustEmail_Click);
            // 
            // btnCreateDealerEmail
            // 
            this.btnCreateDealerEmail.Location = new System.Drawing.Point(180, 538);
            this.btnCreateDealerEmail.Name = "btnCreateDealerEmail";
            this.btnCreateDealerEmail.Size = new System.Drawing.Size(81, 57);
            this.btnCreateDealerEmail.TabIndex = 33;
            this.btnCreateDealerEmail.Text = "Create Dealership Email";
            this.btnCreateDealerEmail.UseVisualStyleBackColor = true;
            this.btnCreateDealerEmail.Click += new System.EventHandler(this.btnCreateDealerEmail_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(314, 538);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(81, 57);
            this.btnClearForm.TabIndex = 34;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            // 
            // tbEmailSubject
            // 
            this.tbEmailSubject.Location = new System.Drawing.Point(442, 86);
            this.tbEmailSubject.Name = "tbEmailSubject";
            this.tbEmailSubject.Size = new System.Drawing.Size(684, 20);
            this.tbEmailSubject.TabIndex = 35;
            // 
            // tbEmailBody
            // 
            this.tbEmailBody.AcceptsReturn = true;
            this.tbEmailBody.Location = new System.Drawing.Point(442, 135);
            this.tbEmailBody.Multiline = true;
            this.tbEmailBody.Name = "tbEmailBody";
            this.tbEmailBody.Size = new System.Drawing.Size(684, 460);
            this.tbEmailBody.TabIndex = 36;
            // 
            // lbEmailSubjectHeader
            // 
            this.lbEmailSubjectHeader.AutoSize = true;
            this.lbEmailSubjectHeader.Location = new System.Drawing.Point(439, 70);
            this.lbEmailSubjectHeader.Name = "lbEmailSubjectHeader";
            this.lbEmailSubjectHeader.Size = new System.Drawing.Size(71, 13);
            this.lbEmailSubjectHeader.TabIndex = 37;
            this.lbEmailSubjectHeader.Text = "Email Subject";
            // 
            // lbEmailBodyHeader
            // 
            this.lbEmailBodyHeader.AutoSize = true;
            this.lbEmailBodyHeader.Location = new System.Drawing.Point(439, 119);
            this.lbEmailBodyHeader.Name = "lbEmailBodyHeader";
            this.lbEmailBodyHeader.Size = new System.Drawing.Size(59, 13);
            this.lbEmailBodyHeader.TabIndex = 38;
            this.lbEmailBodyHeader.Text = "Email Body";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 627);
            this.Controls.Add(this.lbEmailBodyHeader);
            this.Controls.Add(this.lbEmailSubjectHeader);
            this.Controls.Add(this.tbEmailBody);
            this.Controls.Add(this.tbEmailSubject);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnCreateDealerEmail);
            this.Controls.Add(this.btnCreateCustEmail);
            this.Controls.Add(this.cboBmwOrMini);
            this.Controls.Add(this.lbVehicleType);
            this.Controls.Add(this.tbApptNotes);
            this.Controls.Add(this.lbApptNotesHeader);
            this.Controls.Add(this.tbDealershipName);
            this.Controls.Add(this.cboAppointmentType);
            this.Controls.Add(this.lbDealershipNameHeader);
            this.Controls.Add(this.lbApptTypeHeader);
            this.Controls.Add(this.cboApptTimeAMPM);
            this.Controls.Add(this.cboApptTimeMinute);
            this.Controls.Add(this.cboApptTimeHour);
            this.Controls.Add(this.lbAppointmentTimeHeader);
            this.Controls.Add(this.lbApptDateHeader);
            this.Controls.Add(this.dtpApptDate);
            this.Controls.Add(this.tbPaymentsLeft);
            this.Controls.Add(this.cboFinaceType);
            this.Controls.Add(this.tbFinanceTypeHeader);
            this.Controls.Add(this.tbPaymentsLeftHeader);
            this.Controls.Add(this.lbNewOrUsedHeader);
            this.Controls.Add(this.cboNewOrUsed);
            this.Controls.Add(this.tbVehicleName);
            this.Controls.Add(this.tbVehicleReg);
            this.Controls.Add(this.lbVehicleNameHeader);
            this.Controls.Add(this.lbVehicleRegHeader);
            this.Controls.Add(this.lbCustSurnameHeader);
            this.Controls.Add(this.tbCustSurname);
            this.Controls.Add(this.lbCustTitleHeader);
            this.Controls.Add(this.cboCustTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Email Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCustTitle;
        private System.Windows.Forms.Label lbCustTitleHeader;
        private System.Windows.Forms.TextBox tbCustSurname;
        private System.Windows.Forms.Label lbCustSurnameHeader;
        private System.Windows.Forms.Label lbVehicleRegHeader;
        private System.Windows.Forms.Label lbVehicleNameHeader;
        private System.Windows.Forms.TextBox tbVehicleReg;
        private System.Windows.Forms.TextBox tbVehicleName;
        private System.Windows.Forms.ComboBox cboNewOrUsed;
        private System.Windows.Forms.Label lbNewOrUsedHeader;
        private System.Windows.Forms.Label tbPaymentsLeftHeader;
        private System.Windows.Forms.Label tbFinanceTypeHeader;
        private System.Windows.Forms.ComboBox cboFinaceType;
        private System.Windows.Forms.TextBox tbPaymentsLeft;
        private System.Windows.Forms.DateTimePicker dtpApptDate;
        private System.Windows.Forms.Label lbApptDateHeader;
        private System.Windows.Forms.Label lbAppointmentTimeHeader;
        private System.Windows.Forms.ComboBox cboApptTimeHour;
        private System.Windows.Forms.ComboBox cboApptTimeMinute;
        private System.Windows.Forms.ComboBox cboApptTimeAMPM;
        private System.Windows.Forms.Label lbApptTypeHeader;
        private System.Windows.Forms.Label lbDealershipNameHeader;
        private System.Windows.Forms.ComboBox cboAppointmentType;
        private System.Windows.Forms.TextBox tbDealershipName;
        private System.Windows.Forms.Label lbApptNotesHeader;
        private System.Windows.Forms.TextBox tbApptNotes;
        private System.Windows.Forms.Label lbVehicleType;
        private System.Windows.Forms.ComboBox cboBmwOrMini;
        private System.Windows.Forms.Button btnCreateCustEmail;
        private System.Windows.Forms.Button btnCreateDealerEmail;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.TextBox tbEmailSubject;
        private System.Windows.Forms.TextBox tbEmailBody;
        private System.Windows.Forms.Label lbEmailSubjectHeader;
        private System.Windows.Forms.Label lbEmailBodyHeader;
    }
}

