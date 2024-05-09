using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69003_Yuliya_Yafimava_T5
{
    public partial class Form2 : Form
    {
        int time = Game.time;
        bool isGameRunnimg = false;
        int randomNum;
        int userNum;
        
        
        public Form2()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
             if(!isGameRunnimg)
            {
            button1.Text = "Guess!";
            timer1.Start();
            lbTime.Text = time.ToString();
                
            isGameRunnimg = true;
                randomNum = GenerateNumber();

            }

             else
            {
            userNum = Convert.ToInt32(tbGuess.Text);
            if(userNum == randomNum)
            {
                timer1.Stop();
                MessageBox.Show("You won!", "Winner");
                
                this.Close();
            } else if(userNum < randomNum)
                {
                    lbTip.Text = "Guess higher!";
                } else if(userNum > randomNum)
                {
                    lbTip.Text = "Guess lower";
                }
            
            }

           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time > 0)
            {
            time--;
            lbTime.Text = time.ToString();
            }
            else if (time == 0)
            {
                timer1.Stop();
                MessageBox.Show("You lost", "Loser");
                this.Close();
            }
            
        }

        private int GenerateNumber()
        {
            Random random = new Random();
            int rand = random.Next(Game.min, Game.max);
            return rand;
        }

    
    }
}
