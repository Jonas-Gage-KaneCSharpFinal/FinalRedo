﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace cSharpFinalFix
{
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void btnDraw_Click(object sender, EventArgs e)//Main Button Click
        {
            SoundPlayer splayer = new SoundPlayer(cSharpFinalFix.Properties.Resources.Clashing);
            splayer.Play();
            CardArray();

                picAceClubs.BringToFront();
        }
        public void CardArray()//Array For card choosing
        {
            int[] playersCards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 };//ArrayForPlayer

            Random rand = new Random();//rnd#gen for player
            int num1 = rand.Next(playersCards.Length);
            Random rnd = new Random();//rnd#gen for pc


            {

                score++;

            }

            {
                totalWar();
            }
        }
        public void totalWar()
        {

            int[] playersCards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 };//ArrayForPlayer
            int[] pcCards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 };//ArraryForComputer
            //PictureBox[] pictures = { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            int warScore = 6;

            Random rand = new Random();//rnd#gen for player
            int num1 = rand.Next(playersCards.Length);
            Random rnd = new Random();//rnd#gen for pc
            int num2 = rand.Next(pcCards.Length);
            if (num1 > num2)
            {
                score = score + warScore;
                CardArray();
            }
            if (num1 < num2)//PcWin
            {
                score = score - warScore;
                CardArray();
            }
            if (num1 == num2)
            {
                warScore = warScore + 6;
                totalWar();
            }

           
        
        }
    }
}
