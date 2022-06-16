using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            tbEmailBody.Text = morningAftFunctionClass.morningAfternoon() + custEmailObj.custTitle + " " + custEmailObj.custName + "," + "\r\n";

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

        }

        private void btnCreateDealerEmail_Click(object sender, EventArgs e)
        {
            Email dealershipEmailObj = new Email(); //Instantiate object

            string dealerEmailSubjectString = "";

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
                                       " " + dealershipEmailObj.apptType + " - " + dealershipEmailObj.apptDate + " @ " + 
                                       dealershipEmailObj.apptTimeHour + ":" + dealershipEmailObj.apptTimeMin + dealershipEmailObj.apptTimeAmPm;

            tbEmailSubject.Text = dealerEmailSubjectString.ToUpper();
            //CREATE DEALERSHIP SUBJECT COMPLETE---------------------------------------------------------------------------------------------


            //CREATE DEALER EMAIL BODY-------------------------------------------------------------------------------------------------------

            tbEmailBody.Text = "Hi All,";

            tbEmailBody.Text += "\r\n" + "\r\n";

            tbEmailBody.Text += dealershipEmailObj.custTitle + " " + dealershipEmailObj.custName + " is driving a " + dealershipEmailObj.vehicleName.ToUpper()
                             + " - " + dealershipEmailObj.carReg.ToUpper() + " - " + dealershipEmailObj.paymentsLeft + " Payments left on " +
                             dealershipEmailObj.financeType.ToUpper();

            tbEmailBody.Text += "\r\n" + "\r\n";

            tbEmailBody.Text += dealershipEmailObj.apptType + " on " + dealershipEmailObj.apptDate + " at " + dealershipEmailObj.apptTimeHour + ":" +
                             dealershipEmailObj.apptTimeMin + dealershipEmailObj.apptTimeAmPm + " with " + dealershipEmailObj.dealershipName.ToUpper();

            tbEmailBody.Text += "\r\n" + "\r\n";

            tbEmailBody.Text += dealershipEmailObj.apptNotes;

            tbEmailBody.Text += "\r\n" + "\r\n";

            tbEmailBody.Text += "Appointment is set in eMaster. Please update with the outcome.";

            //DEALER EMAIL BODY COMPLETE-----------------------------------------------------------------------------------------------------

        }
    }
}
