using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Preferences : Form
    {
        User myUser = new User();
        

        public string romPref;
        public string comPref;
        public string horPref;
        public string dramPref;

        public Preferences()
        {
            InitializeComponent();
        }

        public Preferences(User newUser)
        {
            
            myUser = newUser;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
            radioHorrorNeutral.Select();
            radioComedyNeutral.Select();
            radioDramaNeutral.Select();
            radioRomanceNeutral.Select();
        }

        public void setPref()
        {
            if (radioHorrorSL.Checked == true)
            {
                horPref = "SL";
            }

            else if (radioHorrorLike.Checked == true)
            {
                horPref = "Like";
            }
            else if (radioHorrorNeutral.Checked == true)
            {
                horPref = "Neutral";
            }
            else if (radioHorrorDislike.Checked == true)
            {
                horPref = "Dislike";
            }
            else if (radioHorrorSD.Checked == true)
            {
                horPref = "SD";
            }

            if (radioComedySL.Checked == true)
            {
                comPref = "SL";
            }

            else if (radioComedyLike.Checked == true)
            {
                comPref = "Like";
            }
            else if (radioComedyNeutral.Checked == true)
            {
                comPref = "Neutral";
            }
            else if (radioComedyDislike.Checked == true)
            {
                comPref = "Dislike";
            }
            else if (radioComedySD.Checked == true)
            {
                comPref = "SD";
            }

            if (radioDramaSL.Checked == true)
            {
                dramPref = "SL";
            }

            else if (radioDramaLike.Checked == true)
            {
                dramPref = "Like";
            }
            else if (radioDramaNeutral.Checked == true)
            {
                dramPref = "Neutral";
            }
            else if (radioDramaDislike.Checked == true)
            {
                dramPref = "Dislike";
            }
            else if (radioDramaSD.Checked == true)
            {
                dramPref = "SD";
            }

            if (radioRomanceSL.Checked == true)
            {
                romPref = "SL";
            }

            else if (radioRomanceLike.Checked == true)
            {
                romPref = "Like";
            }
            else if (radioRomanceNeutral.Checked == true)
            {
                romPref = "Neutral";
            }
            else if (radioRomanceDislike.Checked == true)
            {
                romPref = "Dislike";
            }
            else if (radioRomanceSD.Checked == true)
            {
                romPref = "SD";
            }
        }

        public int prefConvert(string pref, int prefScore = 0)
        {
            switch (pref)
            {
                case "SL":
                    prefScore = 2;
                    break;

                case "Like":
                    prefScore = 1;
                    break;

                case "Neutral":
                    prefScore = 0;
                    break;

                case "Dislike":
                    prefScore = -1;
                    break;

                case "SD":
                    prefScore = -2;
                    break;

                default:
                    break;
            }
            return prefScore;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            setPref();
            myUser.horror += prefConvert(horPref);
            myUser.drama += prefConvert(dramPref);
            myUser.romance += prefConvert(romPref);
            myUser.comedy += prefConvert(comPref);

            MoviePics submitButton = new MoviePics(myUser);

            submitButton.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}