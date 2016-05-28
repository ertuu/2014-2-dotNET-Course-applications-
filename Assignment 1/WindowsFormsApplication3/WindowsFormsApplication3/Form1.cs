using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace WindowsFormsApplication3
{
     

    public partial class Form1 : Form
    {
       int thenumber=5;
       int guess;
       int choosenbutton;

  
        private void GenerateRandoms()
{
    // create random number variable
    Random random = new Random();
    thenumber = random.Next(0, 1000);
            
        } 

        public Form1()
        {
            InitializeComponent();
            GenerateRandoms();
            

                    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           // label1.Text = thenumber.ToString();
           // label2.Text = guess.ToString();
           Int32.TryParse(textBox1.Text, out guess);

           if (guess > thenumber)
               label2.Text = "It's high, get lower !";
           
           if (guess < thenumber)
               label2.Text = "It's low, get higher !";

           if (guess == thenumber)
           {
               label2.Text = "Correct !";
               this.BackColor = System.Drawing.Color.Green;
               textBox1.Enabled = false;

               DialogResult choosenbutton = MessageBox.Show("Do you want to play again?","Game Ended", MessageBoxButtons.YesNo);
               if (choosenbutton == DialogResult.Yes)
                   Application.Restart();
               else
                   Application.Exit();
           }

           if (guess > thenumber + 100 || guess < thenumber - 100 )
           {
               textBox1.BackColor = Color.Turquoise;
                         }
               else
           {
               textBox1.BackColor =  Color.Red;
           
}
           
               


           

            
           


        }


    
    }
}
