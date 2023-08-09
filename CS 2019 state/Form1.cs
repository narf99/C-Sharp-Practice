using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_2019_state
{

    public partial class Form1 : Form
    {
        readonly string backImg = "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/BPALogo.jpg";
        string[] imgs = new string[12];
        bool playing = false;
        readonly string[] frontImgs = new string[12];
        int totalFlipped = 0;
        string[] flippedImgs = new string[2];
        int scoreValue = 0;
        List<int> matchedIndexs = new List<int> {};

        public string ToggleImage(string imageToToggle, string defaultImg)
        {
            // this function toggles the image
            if (imageToToggle != backImg)
            {
                return backImg;
            }
            else
            {
                return defaultImg;
            }
        }

        public void UpdateImgs()
        {
            // this function updates all the images
            pictureBox1.ImageLocation = imgs[0];
            pictureBox2.ImageLocation = imgs[1];
            pictureBox3.ImageLocation = imgs[2];
            pictureBox4.ImageLocation = imgs[3];
            pictureBox5.ImageLocation = imgs[4];
            pictureBox6.ImageLocation = imgs[5];
            pictureBox7.ImageLocation = imgs[6];
            pictureBox8.ImageLocation = imgs[7];
            pictureBox9.ImageLocation = imgs[8];
            pictureBox10.ImageLocation = imgs[9];
            pictureBox11.ImageLocation = imgs[10];
            pictureBox12.ImageLocation = imgs[11];
    }

        public void FlipCard(int cardIndex)
        {
            // this function handles the logic of fliping cards
            if (playing == true && matchedIndexs.Contains(cardIndex) == false) // this first if statment makes sure the game has started and that the card that was clicked on hasn't already been flipped
            {
                // if two cards have already been flipped
                if (totalFlipped >= 2)
                {
                    return;
                }
                // this is the second card flipped
                else if (totalFlipped == 1)
                {
                    totalFlipped += 1; // increase the total number of cards flipped. This prevents the user from flipping more than 2 cards
                    imgs[cardIndex] = ToggleImage(imgs[cardIndex], frontImgs[cardIndex]); // actually flip the card the user clicked on
                    flippedImgs[1] = frontImgs[cardIndex]; // add this card to the flipped images so we can see if the two flipped cards are the same
                    UpdateImgs();

                    // if the two flipped cards are the same
                    if (flippedImgs[0] == flippedImgs[1])
                    {
                        scoreValue += 100;
                        Score.Text = "Score: " + scoreValue; // update the score text
                        flippedImgs = new string[2]; // reset the flipped cards back to none
                        totalFlipped = 0; // reset the total flipped
                        matchedIndexs.Add(cardIndex); // add the card indexs to the matched cards so we can't flip them again

                        // if all of the cards have been flipped
                        if (matchedIndexs.Count == 12)
                        {
                            MessageBox.Show("Final Score: " + scoreValue, "Game Over");
                        }
                    }
                    // if the two flipped cards don't match end the game
                    else
                    {
                        MessageBox.Show("Final Score: " + scoreValue, "Game Over");
                        playing = false;
                    }
                }
                // this is the first card flipped
                else
                {
                    totalFlipped += 1; // tell the program that a card has been flipped and the next one to flip will be the second card
                    imgs[cardIndex] = ToggleImage(imgs[cardIndex], frontImgs[cardIndex]); // flipp the card
                    flippedImgs[0] = frontImgs[cardIndex]; // add this card to the flipped cards so we don't flip his card again
                    UpdateImgs();
                    matchedIndexs.Add(cardIndex); // add this cards index to the matched indexs so that if it matches another card later we can keep it from flipping
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        // all of these flip their specific card. As far as i am aware there is no better way to do this but maybe with a better understanding of windows forms there would be
        private void pictureBox1_Click(object sender, EventArgs e) => FlipCard(0);

        private void pictureBox2_Click(object sender, EventArgs e) => FlipCard(1);

        private void pictureBox3_Click(object sender, EventArgs e) => FlipCard(2);
        
        private void pictureBox4_Click(object sender, EventArgs e) => FlipCard(3);
        
        private void pictureBox5_Click(object sender, EventArgs e) => FlipCard(4);
        
        private void pictureBox6_Click(object sender, EventArgs e) => FlipCard(5);
        
        private void pictureBox7_Click(object sender, EventArgs e) => FlipCard(6);
        
        private void pictureBox8_Click(object sender, EventArgs e) => FlipCard(7);
        
        private void pictureBox9_Click(object sender, EventArgs e) => FlipCard(8);
        
        private void pictureBox10_Click(object sender, EventArgs e) => FlipCard(9);
        
        private void pictureBox11_Click(object sender, EventArgs e) => FlipCard(10);
        
        private void pictureBox12_Click(object sender, EventArgs e) => FlipCard(11);
        
        private async void startBtn_Click(object sender, EventArgs e)
        {
            // this function starts/restarts the game

            // this section of code is used to shuffle the location of images and copy those to the permenant location
            imgs = new string[] {
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/cat1.jpg",
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/cat1.jpg",
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/cat2.jpg",
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/cat2.jpg",
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/cat3.jpg",
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/cat3.jpg",
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/cat4.jpg",
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/cat4.jpg",
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/cat5.jpg",
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/cat5.jpg",
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/city5.jpg",
                "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 state/Images/cats/city5.jpg"
             };
            var rng = new Random();
            rng.Shuffle(imgs);
            Array.Copy(imgs, frontImgs, 12);

            // this section shows the images for 3 seconds before hiding them
            UpdateImgs();

            // this resets all the variables back to their starting values
            scoreValue = 0;
            matchedIndexs = new List<int> { }; // matched images
            totalFlipped = 0;
            flippedImgs = new string[2];
            playing = true; // tell the program its ok to flip cards
            Score.Text = "Score: " + scoreValue; // displayed score text

            await Task.Delay(3000);

            // reset and update the pictures
            // this for loop resets the imgs to their back imgs
            for (int i = 0; i < 12; i++)
            {
                if (matchedIndexs.Contains(i) == false)
                {
                    imgs[i] = backImg;
                }
            }
            UpdateImgs();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // confirm that the user wants to exit
            if (MessageBox.Show("Are you sure you wish to exit?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }

    static class RandomExtensions
    {
        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
