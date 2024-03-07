namespace BlackJack_TWO_Solution
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBlackJackField = new System.Windows.Forms.Panel();
            this.btnNewMatch = new System.Windows.Forms.Button();
            this.pnlDealerField = new System.Windows.Forms.Panel();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.pnlDealerScore = new System.Windows.Forms.Panel();
            this.lblDealCardScoreTxt = new System.Windows.Forms.Label();
            this.lblDealCardScoreTitle = new System.Windows.Forms.Label();
            this.pnlDealerRound = new System.Windows.Forms.Panel();
            this.lblDealRoundScr = new System.Windows.Forms.Label();
            this.lblDealRoundTitle = new System.Windows.Forms.Label();
            this.pnlPlayerRound = new System.Windows.Forms.Panel();
            this.lblPlayRoundScr = new System.Windows.Forms.Label();
            this.lblPlayRound = new System.Windows.Forms.Label();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.pnlPlayerField = new System.Windows.Forms.Panel();
            this.picPlayCard5 = new System.Windows.Forms.PictureBox();
            this.picPlayCard4 = new System.Windows.Forms.PictureBox();
            this.picPlayCard3 = new System.Windows.Forms.PictureBox();
            this.picPlayCard2 = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pnlPlayerScore = new System.Windows.Forms.Panel();
            this.lblPlayCardScoreTxt = new System.Windows.Forms.Label();
            this.lblPlayCardScoreTitle = new System.Windows.Forms.Label();
            this.picPlayCard1 = new System.Windows.Forms.PictureBox();
            this.picDealCard4 = new System.Windows.Forms.PictureBox();
            this.picDealCard5 = new System.Windows.Forms.PictureBox();
            this.picDealCard1 = new System.Windows.Forms.PictureBox();
            this.picDealCard2 = new System.Windows.Forms.PictureBox();
            this.picDealCard3 = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            this.pnlBlackJackField.SuspendLayout();
            this.pnlDealerField.SuspendLayout();
            this.pnlDealerScore.SuspendLayout();
            this.pnlDealerRound.SuspendLayout();
            this.pnlPlayerRound.SuspendLayout();
            this.pnlPlayerField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayCard2)).BeginInit();
            this.pnlPlayerScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard3)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1177, 30);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileReset,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(224, 26);
            this.mnuFileNew.Text = "New Match";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileReset
            // 
            this.mnuFileReset.Name = "mnuFileReset";
            this.mnuFileReset.Size = new System.Drawing.Size(224, 26);
            this.mnuFileReset.Text = "Reset Game";
            this.mnuFileReset.Click += new System.EventHandler(this.mnuFileReset_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(224, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // pnlBlackJackField
            // 
            this.pnlBlackJackField.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlBlackJackField.Controls.Add(this.btnNewMatch);
            this.pnlBlackJackField.Controls.Add(this.pnlDealerField);
            this.pnlBlackJackField.Controls.Add(this.pnlDealerRound);
            this.pnlBlackJackField.Controls.Add(this.pnlPlayerRound);
            this.pnlBlackJackField.Controls.Add(this.btnStay);
            this.pnlBlackJackField.Controls.Add(this.btnHit);
            this.pnlBlackJackField.Controls.Add(this.pnlPlayerField);
            this.pnlBlackJackField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBlackJackField.Location = new System.Drawing.Point(0, 30);
            this.pnlBlackJackField.Name = "pnlBlackJackField";
            this.pnlBlackJackField.Size = new System.Drawing.Size(1177, 605);
            this.pnlBlackJackField.TabIndex = 1;
            // 
            // btnNewMatch
            // 
            this.btnNewMatch.BackColor = System.Drawing.Color.Teal;
            this.btnNewMatch.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMatch.Location = new System.Drawing.Point(390, 76);
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.Size = new System.Drawing.Size(399, 72);
            this.btnNewMatch.TabIndex = 0;
            this.btnNewMatch.Text = "New Match";
            this.btnNewMatch.UseVisualStyleBackColor = false;
            this.btnNewMatch.Click += new System.EventHandler(this.btnNewMatch_Click);
            // 
            // pnlDealerField
            // 
            this.pnlDealerField.Controls.Add(this.picDealCard4);
            this.pnlDealerField.Controls.Add(this.picDealCard5);
            this.pnlDealerField.Controls.Add(this.picDealCard1);
            this.pnlDealerField.Controls.Add(this.picDealCard2);
            this.pnlDealerField.Controls.Add(this.picDealCard3);
            this.pnlDealerField.Controls.Add(this.lblDealerName);
            this.pnlDealerField.Controls.Add(this.pnlDealerScore);
            this.pnlDealerField.Location = new System.Drawing.Point(593, 108);
            this.pnlDealerField.Name = "pnlDealerField";
            this.pnlDealerField.Size = new System.Drawing.Size(560, 369);
            this.pnlDealerField.TabIndex = 20;
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerName.Location = new System.Drawing.Point(330, 28);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(200, 64);
            this.lblDealerName.TabIndex = 20;
            this.lblDealerName.Text = "Dealer";
            // 
            // pnlDealerScore
            // 
            this.pnlDealerScore.Controls.Add(this.lblDealCardScoreTxt);
            this.pnlDealerScore.Controls.Add(this.lblDealCardScoreTitle);
            this.pnlDealerScore.Location = new System.Drawing.Point(23, 15);
            this.pnlDealerScore.Name = "pnlDealerScore";
            this.pnlDealerScore.Size = new System.Drawing.Size(273, 90);
            this.pnlDealerScore.TabIndex = 9;
            // 
            // lblDealCardScoreTxt
            // 
            this.lblDealCardScoreTxt.AutoSize = true;
            this.lblDealCardScoreTxt.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealCardScoreTxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDealCardScoreTxt.Location = new System.Drawing.Point(153, 18);
            this.lblDealCardScoreTxt.Name = "lblDealCardScoreTxt";
            this.lblDealCardScoreTxt.Size = new System.Drawing.Size(114, 55);
            this.lblDealCardScoreTxt.TabIndex = 1;
            this.lblDealCardScoreTxt.Text = "999";
            // 
            // lblDealCardScoreTitle
            // 
            this.lblDealCardScoreTitle.AutoSize = true;
            this.lblDealCardScoreTitle.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealCardScoreTitle.Location = new System.Drawing.Point(4, 14);
            this.lblDealCardScoreTitle.Name = "lblDealCardScoreTitle";
            this.lblDealCardScoreTitle.Size = new System.Drawing.Size(172, 55);
            this.lblDealCardScoreTitle.TabIndex = 0;
            this.lblDealCardScoreTitle.Text = "Score: ";
            // 
            // pnlDealerRound
            // 
            this.pnlDealerRound.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlDealerRound.Controls.Add(this.lblDealRoundScr);
            this.pnlDealerRound.Controls.Add(this.lblDealRoundTitle);
            this.pnlDealerRound.Location = new System.Drawing.Point(593, 3);
            this.pnlDealerRound.Name = "pnlDealerRound";
            this.pnlDealerRound.Size = new System.Drawing.Size(560, 102);
            this.pnlDealerRound.TabIndex = 3;
            // 
            // lblDealRoundScr
            // 
            this.lblDealRoundScr.AutoSize = true;
            this.lblDealRoundScr.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealRoundScr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDealRoundScr.Location = new System.Drawing.Point(407, 19);
            this.lblDealRoundScr.Name = "lblDealRoundScr";
            this.lblDealRoundScr.Size = new System.Drawing.Size(132, 64);
            this.lblDealRoundScr.TabIndex = 1;
            this.lblDealRoundScr.Text = "999";
            // 
            // lblDealRoundTitle
            // 
            this.lblDealRoundTitle.AutoSize = true;
            this.lblDealRoundTitle.Font = new System.Drawing.Font("Elephant", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealRoundTitle.Location = new System.Drawing.Point(9, 16);
            this.lblDealRoundTitle.Name = "lblDealRoundTitle";
            this.lblDealRoundTitle.Size = new System.Drawing.Size(406, 64);
            this.lblDealRoundTitle.TabIndex = 0;
            this.lblDealRoundTitle.Text = "Rounds Won: ";
            // 
            // pnlPlayerRound
            // 
            this.pnlPlayerRound.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlPlayerRound.Controls.Add(this.lblPlayRoundScr);
            this.pnlPlayerRound.Controls.Add(this.lblPlayRound);
            this.pnlPlayerRound.Location = new System.Drawing.Point(21, 3);
            this.pnlPlayerRound.Name = "pnlPlayerRound";
            this.pnlPlayerRound.Size = new System.Drawing.Size(560, 102);
            this.pnlPlayerRound.TabIndex = 2;
            // 
            // lblPlayRoundScr
            // 
            this.lblPlayRoundScr.AutoSize = true;
            this.lblPlayRoundScr.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayRoundScr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayRoundScr.Location = new System.Drawing.Point(401, 19);
            this.lblPlayRoundScr.Name = "lblPlayRoundScr";
            this.lblPlayRoundScr.Size = new System.Drawing.Size(132, 64);
            this.lblPlayRoundScr.TabIndex = 1;
            this.lblPlayRoundScr.Text = "999";
            // 
            // lblPlayRound
            // 
            this.lblPlayRound.AutoSize = true;
            this.lblPlayRound.Font = new System.Drawing.Font("Elephant", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayRound.Location = new System.Drawing.Point(6, 15);
            this.lblPlayRound.Name = "lblPlayRound";
            this.lblPlayRound.Size = new System.Drawing.Size(406, 64);
            this.lblPlayRound.TabIndex = 0;
            this.lblPlayRound.Text = "Rounds Won: ";
            // 
            // btnStay
            // 
            this.btnStay.BackColor = System.Drawing.Color.Teal;
            this.btnStay.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(775, 501);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(193, 72);
            this.btnStay.TabIndex = 4;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = false;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Teal;
            this.btnHit.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(199, 501);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(193, 72);
            this.btnHit.TabIndex = 3;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // pnlPlayerField
            // 
            this.pnlPlayerField.Controls.Add(this.picPlayCard5);
            this.pnlPlayerField.Controls.Add(this.picPlayCard4);
            this.pnlPlayerField.Controls.Add(this.picPlayCard3);
            this.pnlPlayerField.Controls.Add(this.picPlayCard2);
            this.pnlPlayerField.Controls.Add(this.lblPlayerName);
            this.pnlPlayerField.Controls.Add(this.pnlPlayerScore);
            this.pnlPlayerField.Controls.Add(this.picPlayCard1);
            this.pnlPlayerField.Location = new System.Drawing.Point(21, 108);
            this.pnlPlayerField.Name = "pnlPlayerField";
            this.pnlPlayerField.Size = new System.Drawing.Size(560, 369);
            this.pnlPlayerField.TabIndex = 0;
            // 
            // picPlayCard5
            // 
            this.picPlayCard5.Image = ((System.Drawing.Image)(resources.GetObject("picPlayCard5.Image")));
            this.picPlayCard5.Location = new System.Drawing.Point(118, 165);
            this.picPlayCard5.Name = "picPlayCard5";
            this.picPlayCard5.Size = new System.Drawing.Size(131, 196);
            this.picPlayCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayCard5.TabIndex = 24;
            this.picPlayCard5.TabStop = false;
            // 
            // picPlayCard4
            // 
            this.picPlayCard4.Image = ((System.Drawing.Image)(resources.GetObject("picPlayCard4.Image")));
            this.picPlayCard4.Location = new System.Drawing.Point(303, 162);
            this.picPlayCard4.Name = "picPlayCard4";
            this.picPlayCard4.Size = new System.Drawing.Size(131, 196);
            this.picPlayCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayCard4.TabIndex = 23;
            this.picPlayCard4.TabStop = false;
            // 
            // picPlayCard3
            // 
            this.picPlayCard3.Image = ((System.Drawing.Image)(resources.GetObject("picPlayCard3.Image")));
            this.picPlayCard3.Location = new System.Drawing.Point(31, 112);
            this.picPlayCard3.Name = "picPlayCard3";
            this.picPlayCard3.Size = new System.Drawing.Size(131, 196);
            this.picPlayCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayCard3.TabIndex = 22;
            this.picPlayCard3.TabStop = false;
            // 
            // picPlayCard2
            // 
            this.picPlayCard2.Image = ((System.Drawing.Image)(resources.GetObject("picPlayCard2.Image")));
            this.picPlayCard2.Location = new System.Drawing.Point(209, 112);
            this.picPlayCard2.Name = "picPlayCard2";
            this.picPlayCard2.Size = new System.Drawing.Size(131, 196);
            this.picPlayCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayCard2.TabIndex = 21;
            this.picPlayCard2.TabStop = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(326, 28);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(192, 64);
            this.lblPlayerName.TabIndex = 20;
            this.lblPlayerName.Text = "Player";
            // 
            // pnlPlayerScore
            // 
            this.pnlPlayerScore.Controls.Add(this.lblPlayCardScoreTxt);
            this.pnlPlayerScore.Controls.Add(this.lblPlayCardScoreTitle);
            this.pnlPlayerScore.Location = new System.Drawing.Point(23, 15);
            this.pnlPlayerScore.Name = "pnlPlayerScore";
            this.pnlPlayerScore.Size = new System.Drawing.Size(273, 90);
            this.pnlPlayerScore.TabIndex = 9;
            // 
            // lblPlayCardScoreTxt
            // 
            this.lblPlayCardScoreTxt.AutoSize = true;
            this.lblPlayCardScoreTxt.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayCardScoreTxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayCardScoreTxt.Location = new System.Drawing.Point(153, 20);
            this.lblPlayCardScoreTxt.Name = "lblPlayCardScoreTxt";
            this.lblPlayCardScoreTxt.Size = new System.Drawing.Size(106, 51);
            this.lblPlayCardScoreTxt.TabIndex = 1;
            this.lblPlayCardScoreTxt.Text = "999";
            // 
            // lblPlayCardScoreTitle
            // 
            this.lblPlayCardScoreTitle.AutoSize = true;
            this.lblPlayCardScoreTitle.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayCardScoreTitle.Location = new System.Drawing.Point(6, 16);
            this.lblPlayCardScoreTitle.Name = "lblPlayCardScoreTitle";
            this.lblPlayCardScoreTitle.Size = new System.Drawing.Size(164, 51);
            this.lblPlayCardScoreTitle.TabIndex = 0;
            this.lblPlayCardScoreTitle.Text = "Score: ";
            // 
            // picPlayCard1
            // 
            this.picPlayCard1.Image = ((System.Drawing.Image)(resources.GetObject("picPlayCard1.Image")));
            this.picPlayCard1.Location = new System.Drawing.Point(393, 111);
            this.picPlayCard1.Name = "picPlayCard1";
            this.picPlayCard1.Size = new System.Drawing.Size(131, 196);
            this.picPlayCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayCard1.TabIndex = 2;
            this.picPlayCard1.TabStop = false;
            // 
            // picDealCard4
            // 
            this.picDealCard4.Image = ((System.Drawing.Image)(resources.GetObject("picDealCard4.Image")));
            this.picDealCard4.Location = new System.Drawing.Point(120, 165);
            this.picDealCard4.Name = "picDealCard4";
            this.picDealCard4.Size = new System.Drawing.Size(131, 196);
            this.picDealCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealCard4.TabIndex = 29;
            this.picDealCard4.TabStop = false;
            // 
            // picDealCard5
            // 
            this.picDealCard5.Image = ((System.Drawing.Image)(resources.GetObject("picDealCard5.Image")));
            this.picDealCard5.Location = new System.Drawing.Point(305, 162);
            this.picDealCard5.Name = "picDealCard5";
            this.picDealCard5.Size = new System.Drawing.Size(131, 196);
            this.picDealCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealCard5.TabIndex = 28;
            this.picDealCard5.TabStop = false;
            // 
            // picDealCard1
            // 
            this.picDealCard1.Image = ((System.Drawing.Image)(resources.GetObject("picDealCard1.Image")));
            this.picDealCard1.Location = new System.Drawing.Point(33, 112);
            this.picDealCard1.Name = "picDealCard1";
            this.picDealCard1.Size = new System.Drawing.Size(131, 196);
            this.picDealCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealCard1.TabIndex = 27;
            this.picDealCard1.TabStop = false;
            // 
            // picDealCard2
            // 
            this.picDealCard2.Image = ((System.Drawing.Image)(resources.GetObject("picDealCard2.Image")));
            this.picDealCard2.Location = new System.Drawing.Point(211, 112);
            this.picDealCard2.Name = "picDealCard2";
            this.picDealCard2.Size = new System.Drawing.Size(131, 196);
            this.picDealCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealCard2.TabIndex = 26;
            this.picDealCard2.TabStop = false;
            // 
            // picDealCard3
            // 
            this.picDealCard3.Image = ((System.Drawing.Image)(resources.GetObject("picDealCard3.Image")));
            this.picDealCard3.Location = new System.Drawing.Point(395, 111);
            this.picDealCard3.Name = "picDealCard3";
            this.picDealCard3.Size = new System.Drawing.Size(131, 196);
            this.picDealCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealCard3.TabIndex = 25;
            this.picDealCard3.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 635);
            this.Controls.Add(this.pnlBlackJackField);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "TWO : BlackJack Mania";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlBlackJackField.ResumeLayout(false);
            this.pnlDealerField.ResumeLayout(false);
            this.pnlDealerField.PerformLayout();
            this.pnlDealerScore.ResumeLayout(false);
            this.pnlDealerScore.PerformLayout();
            this.pnlDealerRound.ResumeLayout(false);
            this.pnlDealerRound.PerformLayout();
            this.pnlPlayerRound.ResumeLayout(false);
            this.pnlPlayerRound.PerformLayout();
            this.pnlPlayerField.ResumeLayout(false);
            this.pnlPlayerField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayCard2)).EndInit();
            this.pnlPlayerScore.ResumeLayout(false);
            this.pnlPlayerScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileReset;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Panel pnlBlackJackField;
        private System.Windows.Forms.Panel pnlPlayerField;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnNewMatch;
        private System.Windows.Forms.Panel pnlPlayerRound;
        private System.Windows.Forms.Panel pnlPlayerScore;
        private System.Windows.Forms.PictureBox picPlayCard1;
        private System.Windows.Forms.Panel pnlDealerRound;
        private System.Windows.Forms.Panel pnlDealerField;
        private System.Windows.Forms.Panel pnlDealerScore;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.Label lblDealCardScoreTitle;
        private System.Windows.Forms.Label lblDealRoundScr;
        private System.Windows.Forms.Label lblDealRoundTitle;
        private System.Windows.Forms.Label lblPlayRoundScr;
        private System.Windows.Forms.Label lblPlayRound;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayCardScoreTxt;
        private System.Windows.Forms.Label lblPlayCardScoreTitle;
        private System.Windows.Forms.Label lblDealCardScoreTxt;
        private System.Windows.Forms.PictureBox picPlayCard5;
        private System.Windows.Forms.PictureBox picPlayCard4;
        private System.Windows.Forms.PictureBox picPlayCard3;
        private System.Windows.Forms.PictureBox picPlayCard2;
        private System.Windows.Forms.PictureBox picDealCard4;
        private System.Windows.Forms.PictureBox picDealCard5;
        private System.Windows.Forms.PictureBox picDealCard1;
        private System.Windows.Forms.PictureBox picDealCard2;
        private System.Windows.Forms.PictureBox picDealCard3;
    }
}

