using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiscEmailAutomationToolV1
{
    class Email
    {
        //Customer Info
        public string custTitle {get; set;}
        public string custName { get; set; }
        public string carReg { get; set; }
        public string vehicleName { get; set; }

        public string custEmail { get; set; }

        public string newOrUsed { get; set; }

        public string financeType { get; set; }
        public string paymentsLeft { get; set; }


        //Appointment Info
        public string apptType { get; set; }
        public string apptDate { get; set; }
        public string apptTime { get; set; }
        public string apptNotes { get; set; }

        public string dealershipName { get; set; }


    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
