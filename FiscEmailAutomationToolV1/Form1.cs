using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
2022 release - June - Josh Storrs

 Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following condition:

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
OR OTHER DEALINGS IN THE SOFTWARE.
 */



namespace FiscEmailAutomationToolV1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            
        }

        public static class morningAftFunctionClass
        {
            public static string morningAfternoon()
            {
                if(DateTime.Now.Hour<12)
                {
                    return "Good morning ";
                }
                else
                {
                    return "Good afternoon ";
                }
            }
        }

       
        private void btnCreateCustEmail_Click(object sender, EventArgs e)
        {

            tbEmailBody.Font = new Font("Ariel", 12);

            Email custEmailObj = new Email();   //instantiate object

            string custEmailSubjectString = "";

            tbEmailSubject.Clear();
            tbEmailBody.Clear();    //Clear Email

            //set obj properties
            custEmailObj.custTitle = cboCustTitle.Text; //Set customer title in obj to combobox obj
            custEmailObj.custName = tbCustSurname.Text;

            custEmailObj.carReg = tbVehicleReg.Text;
            custEmailObj.vehicleName = tbVehicleName.Text;
            custEmailObj.newOrUsed = cboNewOrUsed.Text;
            custEmailObj.bmwOrMini = cboBmwOrMini.Text;

            custEmailObj.financeType = cboFinaceType.Text;
            custEmailObj.paymentsLeft = tbPaymentsLeft.Text;

            custEmailObj.apptDate = dtpApptDate.Value.ToString("dddd, dd-MMMM");

            custEmailObj.apptTimeHour = cboApptTimeHour.Text;
            custEmailObj.apptTimeMin = cboApptTimeMinute.Text;
            custEmailObj.apptTimeAmPm = cboApptTimeAMPM.Text;

            custEmailObj.apptType = cboAppointmentType.Text;
            custEmailObj.dealershipName = tbDealershipName.Text;

            custEmailObj.apptNotes = tbApptNotes.Text;
            //end set

            //CREATE SUBJECT----------------------------------------------------------------------------------------------------------------

            custEmailSubjectString = custEmailObj.apptType + " - " + custEmailObj.carReg + " - " + custEmailObj.dealershipName;

            tbEmailSubject.Text = custEmailSubjectString.ToUpper();

            //CREATE SUBJECT COMPLETE-------------------------------------------------------------------------------------------------------


            //CREATE EMAIL BODY-------------------------------------------------------------------------------------------------------------

            tbEmailBody.Text = morningAftFunctionClass.morningAfternoon() + custEmailObj.custTitle + " " +
                                System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(custEmailObj.custName.ToLower()) + "," + "\r\n";

            tbEmailBody.Text += "\r\n";
            tbEmailBody.Text += "It was a pleasure speaking with you today.";

            tbEmailBody.Text += "\r\n" + "\r\n";
            tbEmailBody.Text += "I am delighted to confirm your appointment with " + custEmailObj.dealershipName.ToUpper() + " on " + custEmailObj.apptDate
                                 + " at " + custEmailObj.apptTimeHour + ":" + custEmailObj.apptTimeMin + custEmailObj.apptTimeAmPm
                                 + " for an account review of your " + custEmailObj.bmwOrMini.ToUpper() + " - " + custEmailObj.carReg.ToUpper()
                                 + " finance agreement.";

            tbEmailBody.Text += "\r\n" + "\r\n";
            tbEmailBody.Text += "The team will be in touch in due course to confirm further details of your appointment.";

            tbEmailBody.Text += "\r\n" + "\r\n";
            tbEmailBody.Text += "In the meantime, if you have any questions please do not hesitate to contact us via email or telephone.";

            //CREATE EMAIL BODY COMPLETE----------------------------------------------------------------------------------------------------

            if (dtpApptDate.Value > DateTime.Now)
            {
                DateTime endDate = Convert.ToDateTime(custEmailObj.apptDate);
                int days = 0;

                for (DateTime date = DateTime.Now; date <= endDate; date = date.AddDays(1))
                {
                    days++;
                }


                string mboxDateTitle = "Appointment date notification";
                string mboxDateMessage = "This appointment is set for: " + "\r\n" + custEmailObj.apptDate + "\r\n" + "\r\n"
                                         + "Which is in: " + "\r\n" + days + " days" + "\r\n" + "\r\n" + "And is for the Dealership: "
                                         + "\r\n"+ custEmailObj.dealershipName.ToUpper();

                MessageBox.Show(mboxDateMessage, mboxDateTitle);
            }

            if(dtpApptDate.Value < DateTime.Now)
            {
                string mboxErrorTitle = "You cannot select a date before today." + "\r\n" + "Please select a date in the future."
                                        + "\r\n" + "\r\n" + "Date will now reset." + "\r\n" + "\r\n" + "Please ensure to generate email again.";
                string mboxErrorMessage = "Date Selection Error";
                MessageBox.Show(mboxErrorTitle, mboxErrorMessage, MessageBoxButtons.RetryCancel ,MessageBoxIcon.Error);

                dtpApptDate.Text = string.Empty;
            }

            if(dtpApptDate.Value == DateTime.Now)
            {
                MessageBox.Show("Actually, what I meant to say was, the date is set for today. Please ensure the time is after " + DateTime.Now.ToLongTimeString() + " while I figure out what I've done wrong :)");
            }


        }

        private void btnCreateDealerEmail_Click(object sender, EventArgs e)
        {

            tbEmailBody.Font = new Font("Ariel", 12);

            Email dealershipEmailObj = new Email(); //Instantiate object

            string dealerEmailSubjectString = "";

            string appointmentInfoBoldDealer = "";

            tbEmailSubject.Clear();
            tbEmailBody.Clear();    //Clear Email

            //set obj properties
            dealershipEmailObj.custTitle = cboCustTitle.Text; //Set customer title in obj to combobox obj
            dealershipEmailObj.custName = tbCustSurname.Text;
            
            dealershipEmailObj.carReg = tbVehicleReg.Text;
            dealershipEmailObj.vehicleName = tbVehicleName.Text;
            dealershipEmailObj.newOrUsed = cboNewOrUsed.Text;
            dealershipEmailObj.bmwOrMini = cboBmwOrMini.Text;
            
            dealershipEmailObj.financeType = cboFinaceType.Text;
            dealershipEmailObj.paymentsLeft = tbPaymentsLeft.Text;
            
            dealershipEmailObj.apptDate = dtpApptDate.Value.ToString("dddd dd-MMMM");
            
            dealershipEmailObj.apptTimeHour = cboApptTimeHour.Text;
            dealershipEmailObj.apptTimeMin = cboApptTimeMinute.Text;
            dealershipEmailObj.apptTimeAmPm = cboApptTimeAMPM.Text;
            
            dealershipEmailObj.apptType = cboAppointmentType.Text;
            dealershipEmailObj.dealershipName = tbDealershipName.Text;
            
            dealershipEmailObj.apptNotes = tbApptNotes.Text;
            //end set

            //CREATE DEALERSHIP SUBJECT------------------------------------------------------------------------------------------------------
            dealerEmailSubjectString = dealershipEmailObj.custTitle + " " + dealershipEmailObj.custName + " - " + dealershipEmailObj.carReg + 
                                       " - " + dealershipEmailObj.apptType + " - " + dealershipEmailObj.apptDate + " @ " + 
                                       dealershipEmailObj.apptTimeHour + ":" + dealershipEmailObj.apptTimeMin + dealershipEmailObj.apptTimeAmPm;

            tbEmailSubject.Text = dealerEmailSubjectString.ToUpper();
            //CREATE DEALERSHIP SUBJECT COMPLETE---------------------------------------------------------------------------------------------

            appointmentInfoBoldDealer = dealershipEmailObj.apptType + " on " + dealershipEmailObj.apptDate + " at " + dealershipEmailObj.apptTimeHour + ":" +
                             dealershipEmailObj.apptTimeMin + dealershipEmailObj.apptTimeAmPm + " with " + dealershipEmailObj.dealershipName.ToUpper();


            //CREATE DEALER EMAIL BODY-------------------------------------------------------------------------------------------------------

            tbEmailBody.Text = "Hi All,";

            tbEmailBody.Text += "\r\n" + "\r\n";

            tbEmailBody.Text += dealershipEmailObj.custTitle + " " + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dealershipEmailObj.custName.ToLower()) + " is driving a " + dealershipEmailObj.vehicleName.ToUpper()
                             + " - " + dealershipEmailObj.carReg.ToUpper() + " - " + dealershipEmailObj.paymentsLeft + " Payments left on " +
                             dealershipEmailObj.financeType.ToUpper();

            tbEmailBody.Text += "\r\n" + "\r\n";

            appointmentInfoBoldDealer = dealershipEmailObj.apptType + " on " + dealershipEmailObj.apptDate + " at " + dealershipEmailObj.apptTimeHour + ":" +
                               dealershipEmailObj.apptTimeMin + dealershipEmailObj.apptTimeAmPm + " with " + dealershipEmailObj.dealershipName.ToUpper();

            tbEmailBody.Text += appointmentInfoBoldDealer;

            tbEmailBody.Text += "\r\n" + "\r\n";

            tbEmailBody.Text += dealershipEmailObj.apptNotes;

            tbEmailBody.Text += "\r\n" + "\r\n";

            tbEmailBody.Text += "Appointment is set in eMaster. Please update with the outcome.";
            //DEALER EMAIL BODY COMPLETE-----------------------------------------------------------------------------------------------------


            if (dtpApptDate.Value > DateTime.Now)
            {
                DateTime endDate = Convert.ToDateTime(dealershipEmailObj.apptDate);
                int days = 0;

                for (DateTime date = DateTime.Now; date <= endDate; date = date.AddDays(1))
                {
                    days++;
                }


                string mboxDateTitle = "Appointment date notification";
                string mboxDateMessage = "This appointment is set for: " + "\r\n" + dealershipEmailObj.apptDate + "\r\n" + "\r\n"
                                         + "Which is in: " + "\r\n" + days + " days" + "\r\n" + "\r\n" + "And is for the Dealership: "
                                         + "\r\n" + dealershipEmailObj.dealershipName.ToUpper();

                MessageBox.Show(mboxDateMessage, mboxDateTitle);
            }

            if (dtpApptDate.Value < DateTime.Now)
            {
                string mboxErrorTitle = "You cannot select a date before today." + "\r\n" + "Please select a date in the future."
                                        + "\r\n" + "\r\n" + "Date will now reset." + "\r\n" + "\r\n" + "Please ensure to generate email again.";
                string mboxErrorMessage = "Date Selection Error";
                MessageBox.Show(mboxErrorTitle, mboxErrorMessage, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                dtpApptDate.Text = string.Empty;
            }

            if (dtpApptDate.Value == DateTime.Now)
            {
                MessageBox.Show("Actually, what I meant to say was, the date is set for today. Please ensure the time is after " + DateTime.Now.ToLongTimeString() + " while I figure out what I've done wrong :)");
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {            
            DialogResult dialogResultYesNo = MessageBox.Show("You are about to clear the Form, the Email, and the Subject. Are you sure?", "Clear Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResultYesNo == DialogResult.Yes)
            {
                cboCustTitle.Text = ""; //Set customer title in obj to combobox obj
                tbCustSurname.Text = "";

                tbVehicleReg.Text = "";
                tbVehicleName.Text = "";
                cboNewOrUsed.Text = "";
                cboBmwOrMini.Text = "";

                cboFinaceType.Text = "";
                tbPaymentsLeft.Text = "";

                dtpApptDate.Text = string.Empty;

                cboApptTimeHour.Text = "";
                cboApptTimeMinute.Text = "";
                cboApptTimeAMPM.Text = "";

                cboAppointmentType.Text = "";
                tbDealershipName.Text = "";

                tbApptNotes.Text = "";


                tbEmailBody.Clear();
                tbEmailSubject.Clear();

                MessageBox.Show("Form Cleared", "Done");
            }
            else
            {
                return;
            }
            
        }
    }
}
