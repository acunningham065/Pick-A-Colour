namespace Pick_A_Colour
{
    partial class frm_PickAColour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PickAColour));
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.btn_EasyLevel = new System.Windows.Forms.Button();
            this.btn_IntermediateLevel = new System.Windows.Forms.Button();
            this.btn_HardLevel = new System.Windows.Forms.Button();
            this.btn_PlayGame = new System.Windows.Forms.Button();
            this.grp_ScoringSystem = new System.Windows.Forms.GroupBox();
            this.lbl_NumberOfTriesAllowed = new System.Windows.Forms.Label();
            this.lbl_TriesHad = new System.Windows.Forms.Label();
            this.lbl_ShowPlayerScore = new System.Windows.Forms.Label();
            this.lbl_PlayerLives = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.flp_GameBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ColoursGame = new System.Windows.Forms.Button();
            this.btn_PicturesGame = new System.Windows.Forms.Button();
            this.btn_NumbersGame = new System.Windows.Forms.Button();
            this.imglst_TypeOfFruit = new System.Windows.Forms.ImageList(this.components);
            this.imglst_Numbers = new System.Windows.Forms.ImageList(this.components);
            this.imglst_Ships = new System.Windows.Forms.ImageList(this.components);
            this.grp_ScoringSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instructions.ForeColor = System.Drawing.Color.Black;
            this.lbl_Instructions.Location = new System.Drawing.Point(12, 28);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(304, 19);
            this.lbl_Instructions.TabIndex = 0;
            this.lbl_Instructions.Text = "Instructions: Choose a level. Then click play";
            // 
            // btn_EasyLevel
            // 
            this.btn_EasyLevel.BackColor = System.Drawing.Color.LightBlue;
            this.btn_EasyLevel.Location = new System.Drawing.Point(16, 65);
            this.btn_EasyLevel.Name = "btn_EasyLevel";
            this.btn_EasyLevel.Size = new System.Drawing.Size(104, 33);
            this.btn_EasyLevel.TabIndex = 1;
            this.btn_EasyLevel.Text = "&Easy Level";
            this.btn_EasyLevel.UseVisualStyleBackColor = false;
            this.btn_EasyLevel.Click += new System.EventHandler(this.btn_EasyLevel_Click);
            // 
            // btn_IntermediateLevel
            // 
            this.btn_IntermediateLevel.BackColor = System.Drawing.Color.LightBlue;
            this.btn_IntermediateLevel.Location = new System.Drawing.Point(16, 123);
            this.btn_IntermediateLevel.Name = "btn_IntermediateLevel";
            this.btn_IntermediateLevel.Size = new System.Drawing.Size(104, 33);
            this.btn_IntermediateLevel.TabIndex = 2;
            this.btn_IntermediateLevel.Text = "&Intermediate Level";
            this.btn_IntermediateLevel.UseVisualStyleBackColor = false;
            this.btn_IntermediateLevel.Click += new System.EventHandler(this.btn_IntermediateLevel_Click);
            // 
            // btn_HardLevel
            // 
            this.btn_HardLevel.BackColor = System.Drawing.Color.LightBlue;
            this.btn_HardLevel.Location = new System.Drawing.Point(16, 181);
            this.btn_HardLevel.Name = "btn_HardLevel";
            this.btn_HardLevel.Size = new System.Drawing.Size(104, 33);
            this.btn_HardLevel.TabIndex = 3;
            this.btn_HardLevel.Text = "&Hard Level";
            this.btn_HardLevel.UseVisualStyleBackColor = false;
            this.btn_HardLevel.Click += new System.EventHandler(this.btn_HardLevel_Click);
            // 
            // btn_PlayGame
            // 
            this.btn_PlayGame.BackColor = System.Drawing.Color.LightBlue;
            this.btn_PlayGame.Enabled = false;
            this.btn_PlayGame.Location = new System.Drawing.Point(633, 202);
            this.btn_PlayGame.Name = "btn_PlayGame";
            this.btn_PlayGame.Size = new System.Drawing.Size(104, 33);
            this.btn_PlayGame.TabIndex = 4;
            this.btn_PlayGame.Text = "&Play";
            this.btn_PlayGame.UseVisualStyleBackColor = false;
            this.btn_PlayGame.Click += new System.EventHandler(this.btn_PlayGame_Click);
            // 
            // grp_ScoringSystem
            // 
            this.grp_ScoringSystem.Controls.Add(this.lbl_NumberOfTriesAllowed);
            this.grp_ScoringSystem.Controls.Add(this.lbl_TriesHad);
            this.grp_ScoringSystem.Controls.Add(this.lbl_ShowPlayerScore);
            this.grp_ScoringSystem.Controls.Add(this.lbl_PlayerLives);
            this.grp_ScoringSystem.Controls.Add(this.lbl_Score);
            this.grp_ScoringSystem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ScoringSystem.Location = new System.Drawing.Point(534, 70);
            this.grp_ScoringSystem.Name = "grp_ScoringSystem";
            this.grp_ScoringSystem.Size = new System.Drawing.Size(203, 113);
            this.grp_ScoringSystem.TabIndex = 5;
            this.grp_ScoringSystem.TabStop = false;
            this.grp_ScoringSystem.Text = "Player Score and Lives";
            // 
            // lbl_NumberOfTriesAllowed
            // 
            this.lbl_NumberOfTriesAllowed.AutoSize = true;
            this.lbl_NumberOfTriesAllowed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberOfTriesAllowed.Location = new System.Drawing.Point(153, 66);
            this.lbl_NumberOfTriesAllowed.Name = "lbl_NumberOfTriesAllowed";
            this.lbl_NumberOfTriesAllowed.Size = new System.Drawing.Size(0, 19);
            this.lbl_NumberOfTriesAllowed.TabIndex = 10;
            // 
            // lbl_TriesHad
            // 
            this.lbl_TriesHad.AutoSize = true;
            this.lbl_TriesHad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TriesHad.Location = new System.Drawing.Point(130, 66);
            this.lbl_TriesHad.Name = "lbl_TriesHad";
            this.lbl_TriesHad.Size = new System.Drawing.Size(17, 19);
            this.lbl_TriesHad.TabIndex = 9;
            this.lbl_TriesHad.Text = "0";
            // 
            // lbl_ShowPlayerScore
            // 
            this.lbl_ShowPlayerScore.AutoSize = true;
            this.lbl_ShowPlayerScore.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowPlayerScore.Location = new System.Drawing.Point(22, 25);
            this.lbl_ShowPlayerScore.Name = "lbl_ShowPlayerScore";
            this.lbl_ShowPlayerScore.Size = new System.Drawing.Size(57, 19);
            this.lbl_ShowPlayerScore.TabIndex = 6;
            this.lbl_ShowPlayerScore.Text = "Score:";
            // 
            // lbl_PlayerLives
            // 
            this.lbl_PlayerLives.AutoSize = true;
            this.lbl_PlayerLives.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerLives.Location = new System.Drawing.Point(22, 66);
            this.lbl_PlayerLives.Name = "lbl_PlayerLives";
            this.lbl_PlayerLives.Size = new System.Drawing.Size(93, 19);
            this.lbl_PlayerLives.TabIndex = 8;
            this.lbl_PlayerLives.Text = "No of tries:";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(141, 25);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(17, 19);
            this.lbl_Score.TabIndex = 7;
            this.lbl_Score.Text = "0";
            // 
            // flp_GameBoard
            // 
            this.flp_GameBoard.Location = new System.Drawing.Point(171, 70);
            this.flp_GameBoard.Name = "flp_GameBoard";
            this.flp_GameBoard.Size = new System.Drawing.Size(325, 310);
            this.flp_GameBoard.TabIndex = 6;
            // 
            // btn_ColoursGame
            // 
            this.btn_ColoursGame.BackColor = System.Drawing.Color.LightBlue;
            this.btn_ColoursGame.Location = new System.Drawing.Point(16, 239);
            this.btn_ColoursGame.Name = "btn_ColoursGame";
            this.btn_ColoursGame.Size = new System.Drawing.Size(104, 33);
            this.btn_ColoursGame.TabIndex = 7;
            this.btn_ColoursGame.Text = "Colours Game";
            this.btn_ColoursGame.UseVisualStyleBackColor = false;
            this.btn_ColoursGame.Click += new System.EventHandler(this.btn_ColoursGame_Click);
            // 
            // btn_PicturesGame
            // 
            this.btn_PicturesGame.BackColor = System.Drawing.Color.LightBlue;
            this.btn_PicturesGame.Location = new System.Drawing.Point(16, 297);
            this.btn_PicturesGame.Name = "btn_PicturesGame";
            this.btn_PicturesGame.Size = new System.Drawing.Size(104, 33);
            this.btn_PicturesGame.TabIndex = 8;
            this.btn_PicturesGame.Text = "Picture Game";
            this.btn_PicturesGame.UseVisualStyleBackColor = false;
            this.btn_PicturesGame.Click += new System.EventHandler(this.btn_PicturesGame_Click);
            // 
            // btn_NumbersGame
            // 
            this.btn_NumbersGame.BackColor = System.Drawing.Color.LightBlue;
            this.btn_NumbersGame.Location = new System.Drawing.Point(16, 355);
            this.btn_NumbersGame.Name = "btn_NumbersGame";
            this.btn_NumbersGame.Size = new System.Drawing.Size(104, 33);
            this.btn_NumbersGame.TabIndex = 9;
            this.btn_NumbersGame.Text = "Numbers Game";
            this.btn_NumbersGame.UseVisualStyleBackColor = false;
            this.btn_NumbersGame.Click += new System.EventHandler(this.btn_NumbersGame_Click);
            // 
            // imglst_TypeOfFruit
            // 
            this.imglst_TypeOfFruit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst_TypeOfFruit.ImageStream")));
            this.imglst_TypeOfFruit.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst_TypeOfFruit.Images.SetKeyName(0, "apple.png");
            this.imglst_TypeOfFruit.Images.SetKeyName(1, "banana.png");
            this.imglst_TypeOfFruit.Images.SetKeyName(2, "kiwi.jpg");
            this.imglst_TypeOfFruit.Images.SetKeyName(3, "lemon.jpg");
            this.imglst_TypeOfFruit.Images.SetKeyName(4, "orange.png");
            this.imglst_TypeOfFruit.Images.SetKeyName(5, "pinapple.jpg");
            this.imglst_TypeOfFruit.Images.SetKeyName(6, "strawberry.jpg");
            this.imglst_TypeOfFruit.Images.SetKeyName(7, "watermelon.jpg");
            // 
            // imglst_Numbers
            // 
            this.imglst_Numbers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst_Numbers.ImageStream")));
            this.imglst_Numbers.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst_Numbers.Images.SetKeyName(0, "one.png");
            this.imglst_Numbers.Images.SetKeyName(1, "two.png");
            this.imglst_Numbers.Images.SetKeyName(2, "three.png");
            this.imglst_Numbers.Images.SetKeyName(3, "four.jpg");
            this.imglst_Numbers.Images.SetKeyName(4, "five.jpg");
            this.imglst_Numbers.Images.SetKeyName(5, "six.png");
            this.imglst_Numbers.Images.SetKeyName(6, "seven.png");
            this.imglst_Numbers.Images.SetKeyName(7, "eight.png");
            // 
            // imglst_Ships
            // 
            this.imglst_Ships.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst_Ships.ImageStream")));
            this.imglst_Ships.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst_Ships.Images.SetKeyName(0, "miss.jpg");
            this.imglst_Ships.Images.SetKeyName(1, "destroyer.jpg");
            this.imglst_Ships.Images.SetKeyName(2, "submarine.jpg");
            this.imglst_Ships.Images.SetKeyName(3, "battleship.jpg");
            this.imglst_Ships.Images.SetKeyName(4, "Aircraft carrier.jpg");
            // 
            // frm_PickAColour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.btn_NumbersGame);
            this.Controls.Add(this.btn_PicturesGame);
            this.Controls.Add(this.btn_ColoursGame);
            this.Controls.Add(this.flp_GameBoard);
            this.Controls.Add(this.grp_ScoringSystem);
            this.Controls.Add(this.btn_PlayGame);
            this.Controls.Add(this.btn_HardLevel);
            this.Controls.Add(this.btn_IntermediateLevel);
            this.Controls.Add(this.btn_EasyLevel);
            this.Controls.Add(this.lbl_Instructions);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_PickAColour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick A Colour Game";
            this.grp_ScoringSystem.ResumeLayout(false);
            this.grp_ScoringSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.Button btn_EasyLevel;
        private System.Windows.Forms.Button btn_IntermediateLevel;
        private System.Windows.Forms.Button btn_HardLevel;
        private System.Windows.Forms.Button btn_PlayGame;
        private System.Windows.Forms.GroupBox grp_ScoringSystem;
        private System.Windows.Forms.Label lbl_ShowPlayerScore;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_PlayerLives;
        private System.Windows.Forms.Label lbl_TriesHad;
        private System.Windows.Forms.FlowLayoutPanel flp_GameBoard;
        private System.Windows.Forms.Label lbl_NumberOfTriesAllowed;
        private System.Windows.Forms.Button btn_ColoursGame;
        private System.Windows.Forms.Button btn_PicturesGame;
        private System.Windows.Forms.Button btn_NumbersGame;
        private System.Windows.Forms.ImageList imglst_TypeOfFruit;
        private System.Windows.Forms.ImageList imglst_Numbers;
        private System.Windows.Forms.ImageList imglst_Ships;
    }
}

