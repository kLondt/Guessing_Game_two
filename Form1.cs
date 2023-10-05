using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game_two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          //eckusersanswer();
            InitializeComponent();
            GenerateRandomHint();

        }
        int index = 0;
        public string[] objects = { "Tigger ", "Rabbit ", "Eeyore","Piglet" , "Owl", "Roo", "Winnie-the-Pooh" };
        public string[] Hints = { "ADHD", "OCD", "Depresion", "Anxiety ", "Narcasim", "Dyslexic", "Eating Disorder" };
        public string currenthint;
        int score = 0;
       
       
       
    
     
        public string GenerateRandomHint()
        {
            Random random = new Random();
             index = random.Next(0,Hints.Length);
            currenthint = Hints[index];
          return currenthint;

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            LblHint.Text = "";

            TxtUinput.Text = "";
            LstOut.Items.Clear();
            LstOutS.Items.Clear();
        }

        public void BtnGenerateHint_Click(object sender, EventArgs e)
        {
            string randomHint = GenerateRandomHint();
            LblHint.Text = currenthint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblGeneratedHint_Click(object sender, EventArgs e)
        {

        }

        private void LblHint_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TxtUinput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

         string userinput=TxtUinput.Text.Trim();

            if (userinput==objects[index])
            {
                MessageBox.Show("Congratulations, your answer is correct for the current hint!");
                  LstOut.Items.Add(userinput);
                TxtUinput.Text = "";
                LstOutS.Items.Clear();
                    score = score + 1;
           LstOutS.Items.Add(score) ;
              ; index++;}
            else { MessageBox.Show("incorrect ");LstOutS.Items.Clear(); }

        }

        public void LblScoreNum_Click(object sender, EventArgs e)
        {

        }

        private void LstOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LstOutS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
