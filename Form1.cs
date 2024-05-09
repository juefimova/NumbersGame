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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string item = cbDifficulty.SelectedItem.ToString();
            defineTime(item);
            Game.min = Convert.ToInt32(tbMin.Text);
            Game.max = Convert.ToInt32(tbMax.Text);



            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void defineTime(string difficulty)
        {
            
            switch(difficulty)
            {
                case "Easy":
                    Game.time = 70;
                    break;
                case "Medium":
                    Game.time = 50;
                    break;
                case "Hard":
                    Game.time = 30;
                    break;

            }
        }
    }
}
