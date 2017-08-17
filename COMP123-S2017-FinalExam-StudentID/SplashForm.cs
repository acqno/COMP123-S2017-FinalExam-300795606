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
 * Name: Alvin Quijano
 * Student No.: 300795606
 * Date: Aug 17, 2017
 * Description: This is the SplashForm interface
 * Version: 0.2 - Implemented the SplashFormTimer_tick event 
 */ 


namespace COMP123_S2017_FinalExam_StudentID
{
    public partial class CardSplashForm : Form
    {
        // PUBLIC PROPERTIES 

        public PickHighestCardForm PickHighestCardForm
        {
            get
            {
                return Program.CardForm;
            }
        }

        public CardSplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();
            this.Hide();

            SplashFormTimer.Enabled = true;
        }
    }
}
