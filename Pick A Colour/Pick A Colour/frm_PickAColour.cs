using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pick_A_Colour
{
    public partial class frm_PickAColour : Form
    {
        //---------------------------Declaration of Global Variables---------------------------\\
        PictureBox firstBoxClicked = new PictureBox();

        bool firstBoxWasClicked = false;

        int firstBoxTag = 0;
        int score = 0;
        int levelSelected = 0;
        int triesTaken = 0;
        int triesAllowed = 0;

        char gameType = 'c';

        int[] coloursGenerated = new int[100];
        int[] boardPositions = new int[100];

        //---------------------------End of The Declaration of Global Variables---------------------------\\


        public frm_PickAColour()
        {
            InitializeComponent();
        }



        private void btn_EasyLevel_Click(object sender, EventArgs e)
        {
            //Set variable as this determines how many different colours are created
            levelSelected = 5;
            triesAllowed = 50;

            //Enable play button
            EnablePlayButton();
            

        }//End btn_EasyLevel_Click

        

        private void btn_IntermediateLevel_Click(object sender, EventArgs e)
        {
            //Set variable as this determines how many different colours are created
            levelSelected = 7;
            triesAllowed = 40;

            //Enable play button
            EnablePlayButton();


        }//End btn_IntermediateLevel_Click



        private void btn_HardLevel_Click(object sender, EventArgs e)
        {
            //Set variable as this determines how many different colours are created
            levelSelected = 9;
            triesAllowed = 30;

            //Enable play button
            EnablePlayButton();            

        }//End btn_HardLevel_Click
                
        

        private void btn_PlayGame_Click(object sender, EventArgs e)
        {
            //------------------------Declaration of Variables and Objects------------------------\\           
            Random rnd = new Random();

            int maxBoxes = 100;
            int boxWidth = 25;
            //------------------------End Declaration of Variables and Objects------------------------\\

            //Disable all buttons
            btn_PlayGame.Enabled = false;
            btn_EasyLevel.Enabled = false;
            btn_IntermediateLevel.Enabled = false;
            btn_HardLevel.Enabled = false;

            //show how many tries allowed
            lbl_NumberOfTriesAllowed.Text = "/" + triesAllowed.ToString();

            for (int currentBox = 0; currentBox < maxBoxes; currentBox++)
            {
                //1. Create a picture box object to hold the colour for an individual square on the board
                PictureBox p = new PictureBox();

                //Set box dimensions
                p.Width = boxWidth;
                p.Height = p.Width;

                //Set Box Colour
                p.BackColor = Color.Black;
                
                //Set name for ensuring you cannot click the same box twice
                p.Name = currentBox.ToString();

                //According to the level selected, more or less different colours will be used
                //Add to the array
                coloursGenerated[currentBox] = rnd.Next(1, levelSelected);

                //add a box to form layout panel control
                flp_GameBoard.Controls.Add(p);

                //Add a click event handler
                p.MouseClick += p_MouseClick;
                
            }//End For
            
        }//End btn_PlayGame_Click



        void p_MouseClick(object sender, MouseEventArgs e)
        {
            //mouse click event code handler
            //get the object clicked
            PictureBox boxClicked = sender as PictureBox;

            //Ensure picture is positioned and sized correctly
            boxClicked.SizeMode = PictureBoxSizeMode.StretchImage;

            int boxName = Convert.ToInt32(boxClicked.Name);

            int boxTag = coloursGenerated[boxName];

            //Increase tries
            triesTaken++;

            lbl_TriesHad.Text = triesTaken.ToString();

            //If tries left
            if (triesTaken < triesAllowed)
            {

                //Check if first box was clicked
                if (firstBoxWasClicked == false)
                {

                    //Saving the first box
                    firstBoxClicked = boxClicked;
                    firstBoxTag = coloursGenerated[boxName];


                    //Change boolean
                    firstBoxWasClicked = true;


                    //Put message to screen
                    //MessageBox.Show("Message box tag is " + boxNumber);

                    if (gameType == 'c')
                    {
                        //Expecting a number between 1 and 8
                        changeToColour(boxClicked, boxTag);

                    }
                    else if (gameType == 'p')
                    {
                        //Expecting a number between 1 and 8
                        changeToPicture(boxClicked, boxTag);
                    }
                    else
                    {
                        changeToNumber(boxClicked, boxTag);
                    }
                    
                }
                else if (boxClicked.Name.ToString() != firstBoxClicked.Name.ToString())
                {
                    //Second box clicked

                    //Set colour and check if first box tag = second box tag

                    //Pickup tag number from box
                    string boxNumber = boxTag.ToString();


                    //Depending on game type change from black to image/colour
                    if (gameType == 'c')
                    {
                        //Expecting a number between 1 and 8
                        changeToColour(boxClicked, boxTag);

                    }
                    else if (gameType == 'p')
                    {
                        //Expecting a number between 1 and 8
                        changeToPicture(boxClicked, boxTag);
                    }
                    else
                    {
                        changeToNumber(boxClicked, boxTag);
                    }

                    if (firstBoxTag == boxTag)
                    {
                        MessageBox.Show("Match");

                        //Increase tries and score
                        triesTaken++;
                        score++;

                        //Assign to the appropriate labels
                        lbl_Score.Text = score.ToString();
                        lbl_TriesHad.Text = triesTaken.ToString();


                        //Ensure the box cannot be chosen more than once
                        coloursGenerated[Convert.ToInt32(firstBoxClicked.Name)] = 0;
                        coloursGenerated[Convert.ToInt32(boxClicked.Name)] = 0;

                    }
                    else
                    {
                        //If a box was already selected then set the other back to black but not the already selected one
                        if (firstBoxTag == 0)
                        {
                            boxClicked.BackColor = Color.Black;
                            boxClicked.Image = null;
                        }
                        else if (boxTag == 0)
                        {
                            firstBoxClicked.BackColor = Color.Black;
                            firstBoxClicked.Image = null;
                        }
                        else
                        {
                            //If neither of the boxes have been clicked then set both back to black
                            MessageBox.Show("Not a match");
                            boxClicked.BackColor = Color.Black;
                            boxClicked.Image = null;
                            firstBoxClicked.BackColor = Color.Black;
                            firstBoxClicked.Image = null;

                        }//end if

                    }//end if          

                    //Set to false so as it resets properly and selection is reset
                    firstBoxWasClicked = false;

                }
                else
                {
                    //Inform them of their cheating ways
                    MessageBox.Show("That box was already clicked");

                    //Set to false so as it resets properly and selection is reset
                    firstBoxWasClicked = false;

                    //Set it back to black
                    boxClicked.BackColor = Color.Black;
                    boxClicked.Image = null;
                    firstBoxClicked.BackColor = Color.Black;
                    firstBoxClicked.Image = null;
                }

            }
            else
            {
                MessageBox.Show("Game over\nYour Score: " + score.ToString());

                //Clear the panel
                flp_GameBoard.Controls.Clear();

                //Reset all the variables and labels
                lbl_NumberOfTriesAllowed.Text = null;
                lbl_TriesHad.Text = null;
                lbl_Score.Text = null;
                triesTaken = 0;
                score = 0;

                //Enable all the buttons again
                btn_PlayGame.Enabled = true;
                btn_EasyLevel.Enabled = true;
                btn_IntermediateLevel.Enabled = true;
                btn_HardLevel.Enabled = true;
            }

        }//End p_MouseClick     


        
        private void changeToNumber(PictureBox boxClicked, int tagValue)
        {
            switch (tagValue)
            {
                case 0: MessageBox.Show("Already Clicked.\nDon't push your luck");
                    break;

                case 1: boxClicked.Image = imglst_Numbers.Images[0];
                    break;

                case 2: boxClicked.Image = imglst_Numbers.Images[1];
                    break;

                case 3: boxClicked.Image = imglst_Numbers.Images[2];
                    break;

                case 4: boxClicked.Image = imglst_Numbers.Images[3];
                    break;

                case 5: boxClicked.Image = imglst_Numbers.Images[4];
                    break;

                case 6: boxClicked.Image = imglst_Numbers.Images[5];
                    break;

                case 7: boxClicked.Image = imglst_Numbers.Images[6];
                    break;

                case 8: boxClicked.Image = imglst_Numbers.Images[7];
                    break;

            }//End Colour change Switch
        }



        private void changeToPicture(PictureBox boxClicked, int tagValue)
        {
            switch (tagValue)
            {
                case 0: MessageBox.Show("Already Clicked.\nDon't push your luck");
                    break;

                case 1: boxClicked.Image = imglst_TypeOfFruit.Images[0];
                    break;

                case 2: boxClicked.Image = imglst_TypeOfFruit.Images[1];
                    break;

                case 3: boxClicked.Image = imglst_TypeOfFruit.Images[2];
                    break;

                case 4: boxClicked.Image = imglst_TypeOfFruit.Images[3];
                    break;

                case 5: boxClicked.Image = imglst_TypeOfFruit.Images[4];
                    break;

                case 6: boxClicked.Image = imglst_TypeOfFruit.Images[5];
                    break;

                case 7: boxClicked.Image = imglst_TypeOfFruit.Images[6];
                    break;

                case 8: boxClicked.Image = imglst_TypeOfFruit.Images[7];
                    break;

            }//End Colour change Switch
        }



        private static void changeToColour(PictureBox boxClicked, int tagValue)
        {
            switch (tagValue)
            {
                case 0: MessageBox.Show("Already Clicked.\nDon't push your luck");
                    break;

                case 1: boxClicked.BackColor = Color.Red;
                    break;

                case 2: boxClicked.BackColor = Color.Blue;
                    break;

                case 3: boxClicked.BackColor = Color.Green;
                    break;

                case 4: boxClicked.BackColor = Color.Yellow;
                    break;

                case 5: boxClicked.BackColor = Color.Aqua;
                    break;

                case 6: boxClicked.BackColor = Color.Indigo;
                    break;

                case 7: boxClicked.BackColor = Color.DarkMagenta;
                    break;

                case 8: boxClicked.BackColor = Color.Lime;
                    break;

            }//End Colour change Switch
        }

        

        private void EnablePlayButton()
        {
            btn_PlayGame.Enabled = true;

        }//End EnablePlayButton



        private void btn_ColoursGame_Click(object sender, EventArgs e)
        {
            gameType = 'c';
        }



        private void btn_PicturesGame_Click(object sender, EventArgs e)
        {
            gameType = 'p';
        }



        private void btn_NumbersGame_Click(object sender, EventArgs e)
        {
            gameType = 'n';
        }

    }//End Partial class

}//End Namespace
