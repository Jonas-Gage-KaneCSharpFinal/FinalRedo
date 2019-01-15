using System;
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
            //CardArray();

            Random rand = new Random();
            int card = rand.Next(1, 52);
            if (card == 1)
                picAceClubs.BringToFront();
            else if (card == 2)
                picAceDiamonds.BringToFront();
            else if (card == 3)
                picAceSpades.BringToFront();
            else if (card == 4)
                picJackHearts.BringToFront();
            else if (card == 5)
                picJackDiamonds.BringToFront();
            else if (card == 6)
                picJackClubs.BringToFront();
            else if (card == 7)
                picJackSpades.BringToFront();
            else if (card == 8)
                picQueenofhearts.BringToFront();
            else if (card == 9)
                picQueenOfSpades.BringToFront();
            else if (card == 10)
                picQueenOfClubs.BringToFront();
            else if (card == 11)
                picQueenOfDiamonds.BringToFront();
            else if (card == 12)
                pic2heats.BringToFront();
            else if (card == 13)
                pic2Diamonds.BringToFront();
            else if (card == 14)
                pic2Clubs.BringToFront();
            else if (card == 15)
                pic2Spades.BringToFront();
            else if (card == 16)
                pic3Hearts.BringToFront();
            else if (card == 17)
                pic3Clubs.BringToFront();
            else if (card == 18)
                pic3Diamonds.BringToFront();
            else if (card == 19)
                pic3Spades.BringToFront();
            else if (card == 20)
                picKingOfHearts.BringToFront();
            else if (card == 21)
                picKingOfSpades.BringToFront();
            else if (card == 22)
                picKingOfDiamonds.BringToFront();
            else if (card == 23)
                picKingOfClubs.BringToFront();
            else if (card == 24)
                pic9Hearts.BringToFront();
            else if (card == 25)
                pic9Clubs.BringToFront();
            else if (card == 26)
                pic9Diamonds.BringToFront();
            else if (card == 27)
                pic8diamonds.BringToFront();
            else if (card == 28)
                pic8Hearts.BringToFront();
            else if (card == 29)
                pic8Spades.BringToFront();
            else if (card == 30)
                pic8Clubs.BringToFront();
            else if (card == 31)
                pic7Diamonds.BringToFront();
            else if (card == 32)
                pic7Hearts.BringToFront();
            else if (card == 33)
                pic7Spades.BringToFront();
            else if (card == 34)
                pic7Clubs.BringToFront();
            else if (card == 35)
                pic6Diamonds.BringToFront();
            else if (card == 36)
                pic6Hearts.BringToFront();
            else if (card == 37)
                pic6Spades.BringToFront();
            else if (card == 38)
                pic6Clubs.BringToFront();
            else if (card == 39)
                pic5Hearts.BringToFront();
            else if (card == 40)
                pic5Diamonds.BringToFront();
            else if (card == 41)
                pic5Spades.BringToFront();
            else if (card == 42)
                pic5Clubs.BringToFront();
            else if (card == 43)
                pic4Hearts.BringToFront();
            else if (card == 44)
                pic4Diamonds.BringToFront();
            else if (card == 45)
                pic4Spades.BringToFront();
            else if (card == 46)
                pic4Clubs.BringToFront();
            else if (card == 47)
                pic10Spades.BringToFront();
            else if (card == 48)
                pic10Hearts.BringToFront();
            else if (card == 49)
                pic10Clubs.BringToFront();
            
            
        }
        public void CardArray()//Array For card choosing
        {
            int[] playersCards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 };//ArrayForPlayer

            Random rand = new Random();//rnd#gen for player
            int num1 = rand.Next(playersCards.Length);
            Random rnd = new Random();//rnd#gen for pc
            Cards();

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
        public void Cards()
        {
            Random rand = new Random();
            int card = rand.Next(1, 52);
            if (card == 1)
            {

                double picAceClubs = 1;
                picAceClubs = Convert.ToDouble(picAceClubs);
            }

        }
    }
}
