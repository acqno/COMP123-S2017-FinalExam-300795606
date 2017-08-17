using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Alvin Quijano  
 * Date:Aug 17, 2017
 * StudentID: 300795606 
 * Description: This is the ScoreBoard class
 * Version: 0.2 - Added the Scoreboard public properties, constructor and UpdateTime method
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    class ScoreBoard
    {
        // PRIVATE INSTANCE VARIABLES 

        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        // PUBLIC PROPERTIES 

        public TextBox FinalScoreTextBox
        {
            get
            {
                return _finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }

        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this.Score = Convert.ToInt32(this.FinalScoreTextBox.Text);
            }
        }

        public TextBox ScoreTextBox
        {
            get
            {
                return _scoreTextBox;
            }
            set
            {
                this.ScoreTextBox = value;
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = Convert.ToInt32(TimeTextBox.Text);
            }
        }

        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        // CONSTRUCTORS 
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }

        // PUBLIC METHODS 

        public void UpdateTime()
        {
            int timeText = Convert.ToInt32(TimeTextBox.Text);
            timeText -= 1;

            this.Time = timeText;

            this.TimeTextBox.Text = Convert.ToString(Time);
        }

    }
}
