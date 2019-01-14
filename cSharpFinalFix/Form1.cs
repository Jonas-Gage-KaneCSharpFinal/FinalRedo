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

            double picAceClubs = 1;
            picAceClubs = Convert.ToDouble(picAceClubs);

            double picAceDiamonds = 2;
            picAceDiamonds = Convert.ToDouble(picAceDiamonds);

            double picAceSpades = 3;
            picAceSpades = Convert.ToDouble(picAceSpades);

            double picAceHearts = 4;
            picAceHearts = Convert.ToDouble(picAceHearts);

            double picJackHearts = 5;
            picJackHearts = Convert.ToDouble(picJackHearts);

            double picJackDiamonds = 6;
            picJackDiamonds = Convert.ToDouble(picJackDiamonds);

            double picJackClubs = 7;
            picJackClubs = Convert.ToDouble(picJackClubs);

            double picJackSpades = 8;
            picJackSpades = Convert.ToDouble(picJackSpades);

            double picQueenHearts = 9;
            picQueenHearts = Convert.ToDouble(picQueenHearts);

            double picQueenSpades = 10;
            picQueenSpades = Convert.ToDouble(picQueenSpades);

            double picQueenClubs = 11;
            picQueenClubs = Convert.ToDouble(picQueenClubs);

            double picQueenDiamonds = 12;
            picQueenDiamonds = Convert.ToDouble(picQueenDiamonds);

            double pic2Hearts = 13;
            pic2Hearts = Convert.ToDouble(pic2Hearts);

            double pic2Diamonds = 14;
            pic2Diamonds = Convert.ToDouble(pic2Diamonds);

            double pic2Clubs = 15;
            pic2Clubs = Convert.ToDouble(pic2Clubs);

            double pic2Spades = 16;
            pic2Spades = Convert.ToDouble(pic2Spades);

            double pic3Hearts = 17;
            pic3Hearts = Convert.ToDouble(pic3Hearts);

            double pic3Clubs = 18;
            pic3Clubs = Convert.ToDouble(pic3Clubs);

            double pic3Diamonds = 19;
            pic3Diamonds = Convert.ToDouble(pic3Diamonds);

            double pic3Spades = 20;
            pic3Spades = Convert.ToDouble(pic3Spades);

            double picKingOfHearts = 21;
            picKingOfHearts = Convert.ToDouble(picKingOfHearts);

            double picKingOfSpades = 22;
            picKingOfSpades = Convert.ToDouble(picKingOfSpades);

            double picKingOfDiamonds = 23;
            picKingOfDiamonds = Convert.ToDouble(picKingOfDiamonds);

            double picKingOfClubs = 24;
            picKingOfClubs = Convert.ToDouble(picKingOfClubs);

            double pic9Spades = 25;
            pic9Spades = Convert.ToDouble(pic9Spades);

            double pic9Hearts = 26;
            pic9Hearts = Convert.ToDouble(pic9Hearts);

            double pic9Clubs = 27;
            pic9Clubs = Convert.ToDouble(pic9Clubs);

            double pic9Diamonds = 28;
            pic9Diamonds = Convert.ToDouble(pic9Diamonds);

            double pic8Diamonds = 29;
            pic8Diamonds = Convert.ToDouble(pic8Diamonds);

            double pic8Hearts = 30;
            pic8Hearts = Convert.ToDouble(pic8Hearts);

            double pic8Spades = 31;
            pic8Spades = Convert.ToDouble(pic8Spades);

            double pic8Clubs = 32;
            pic8Clubs = Convert.ToDouble(pic8Clubs);

            double pic7Diamonds = 33;
            pic7Diamonds = Convert.ToDouble(pic7Diamonds);

            double pic7Hearts = 34;
            pic7Hearts = Convert.ToDouble(pic7Hearts);

            double pic7Spades = 35;
            pic7Spades = Convert.ToDouble(pic7Spades);

            double pic7Clubs = 36;
            pic7Clubs = Convert.ToDouble(pic7Clubs);

            double pic6Diamonds = 37;
            pic6Diamonds = Convert.ToDouble(pic6Diamonds);

            double pic6Hearts = 38;
            pic6Hearts = Convert.ToDouble(pic6Hearts);

            double pic6Spades = 39;
            pic6Spades = Convert.ToDouble(pic6Spades);

            double pic6Clubs = 40;
            pic6Clubs = Convert.ToDouble(pic6Clubs);

            double pic5Hearts = 41;
            pic5Hearts = Convert.ToDouble(pic5Hearts);

            double pic5Diamonds = 42;
            pic5Diamonds = Convert.ToDouble(pic5Diamonds);

            double pic5Spades = 43;
            pic5Spades = Convert.ToDouble(pic5Spades);

            double pic5Clubs = 44;
            pic5Clubs = Convert.ToDouble(pic5Clubs);

            double pic4Hearts = 45;
            pic4Hearts = Convert.ToDouble(pic4Hearts);

            double pic4Diamonds = 44;
            pic4Diamonds = Convert.ToDouble(pic4Diamonds);

            double pic4Spades = 45;
            pic4Spades = Convert.ToDouble(pic4Spades);

            double pic4Clubs = 46;
            pic4Clubs = Convert.ToDouble(pic4Clubs);

            double pic10Spades = 47;
            pic10Spades = Convert.ToDouble(pic10Spades);

            double pic10Hearts = 48;
            pic10Hearts = Convert.ToDouble(pic10Hearts);

            double pic10Diamonds = 49;
            pic10Diamonds = Convert.ToDouble(pic10Diamonds);

            double pic10Clubs = 50;
            pic10Clubs = Convert.ToDouble(pic10Clubs);


        }
    }
}
