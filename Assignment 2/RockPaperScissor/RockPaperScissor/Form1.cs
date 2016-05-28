using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissor
{
    public partial class Form1 : Form
    {

        int npc;
        int player;
        int sc_player=0;
        int sc_npc=0;
        int choosen;
        private void play_npc()
        {
            // create random number variable
            Random random = new Random();
            npc= random.Next(0, 3);

        } 


        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text != "Rock" && comboBox1.Text != "Paper" && comboBox1.Text != "Scissor")
                MessageBox.Show("Choose an attack style !", "Error");
            else
            {

                play_npc();


                if (npc == 0)
                {
                    Paper2.Visible = true;
                    Scissor2.Visible = false;
                    Rock2.Visible = false;
                }
                if (npc == 1)
                {
                    Paper2.Visible = false;
                    Scissor2.Visible = true;
                    Rock2.Visible = false;
                }
                if (npc == 2)
                {
                    Paper2.Visible = false;
                    Scissor2.Visible = false;
                    Rock2.Visible = true;
                }

                if (player == npc)
                {
                    sc_player++;
                    sc_npc++;
                }
                if (player == 0 && npc == 1)
                    sc_npc++;
                if (player == 0 && npc == 2)
                    sc_player++;
                if (player == 1 && npc == 0)
                    sc_player++;
                if (player == 1 && npc == 2)
                    sc_npc++;
                if (player == 2 && npc == 0)
                    sc_npc++;
                if (player == 2 && npc == 1)
                    sc_player++;

                label1.Text = "You: " + sc_player.ToString();
                label2.Text = "Johnny: " + sc_npc.ToString();

                if (sc_player == 10 || sc_npc == 10)
                {
                    DialogResult choosenbutton = MessageBox.Show("Do you want to play again?", "Game Ended", MessageBoxButtons.YesNo);
                    if (choosenbutton == DialogResult.Yes)
                        Application.Restart();
                    else
                        Application.Exit();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Paper")
            { 
              Paper1.Visible = true;
              Scissor1.Visible = false;
              Rock1.Visible = false;
              player = 0;
            }
           if (comboBox1.Text == "Scissor")
           {
               Paper1.Visible = false;
               Scissor1.Visible = true;
               Rock1.Visible = false;
               player = 1;
           }
            if (comboBox1.Text == "Rock")
            {
                Paper1.Visible = false;
                Scissor1.Visible = false;
                Rock1.Visible = true;
                player = 2;
            }
          

        }
    }
}
