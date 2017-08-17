using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Alvin Quijano  
 * Date:Aug 17, 2017
 * StudentID: 300795606 
 * Description: This is the diver class program
 * Version: 0.1 - Added the SplashForm to the driver class
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public static class Program
    {
        public static PickHighestCardForm CardForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CardForm = new PickHighestCardForm();

            Application.Run(new CardSplashForm());
        }
    }
}
