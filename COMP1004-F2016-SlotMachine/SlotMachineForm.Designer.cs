namespace COMP1004_F2016_SlotMachine
{
    partial class SlotMachineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotMachineForm));
            this.pictureBox_Reel1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Reel2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Reel3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Spin = new System.Windows.Forms.PictureBox();
            this.lbl_Credits = new System.Windows.Forms.Label();
            this.lbl_Bet = new System.Windows.Forms.Label();
            this.lbl_Paid = new System.Windows.Forms.Label();
            this.pictureBox_Quit = new System.Windows.Forms.PictureBox();
            this.pictureBox_Reset = new System.Windows.Forms.PictureBox();
            this.lbl_Jackpot = new System.Windows.Forms.Label();
            this.pictureBox_Bet1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bet5 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bet25 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bet50 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bet100 = new System.Windows.Forms.PictureBox();
            this.btn_Stats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Spin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bet50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bet100)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Reel1
            // 
            this.pictureBox_Reel1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Reel1.Image")));
            this.pictureBox_Reel1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Reel1.InitialImage")));
            this.pictureBox_Reel1.Location = new System.Drawing.Point(162, 298);
            this.pictureBox_Reel1.Name = "pictureBox_Reel1";
            this.pictureBox_Reel1.Size = new System.Drawing.Size(95, 72);
            this.pictureBox_Reel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Reel1.TabIndex = 0;
            this.pictureBox_Reel1.TabStop = false;
            // 
            // pictureBox_Reel2
            // 
            this.pictureBox_Reel2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Reel2.Image")));
            this.pictureBox_Reel2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Reel2.InitialImage")));
            this.pictureBox_Reel2.Location = new System.Drawing.Point(292, 298);
            this.pictureBox_Reel2.Name = "pictureBox_Reel2";
            this.pictureBox_Reel2.Size = new System.Drawing.Size(95, 72);
            this.pictureBox_Reel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Reel2.TabIndex = 1;
            this.pictureBox_Reel2.TabStop = false;
            // 
            // pictureBox_Reel3
            // 
            this.pictureBox_Reel3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Reel3.Image")));
            this.pictureBox_Reel3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Reel3.InitialImage")));
            this.pictureBox_Reel3.Location = new System.Drawing.Point(424, 298);
            this.pictureBox_Reel3.Name = "pictureBox_Reel3";
            this.pictureBox_Reel3.Size = new System.Drawing.Size(95, 72);
            this.pictureBox_Reel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Reel3.TabIndex = 2;
            this.pictureBox_Reel3.TabStop = false;
            // 
            // pictureBox_Spin
            // 
            this.pictureBox_Spin.Image = global::COMP1004_F2016_SlotMachine.Properties.Resources.spin;
            this.pictureBox_Spin.InitialImage = null;
            this.pictureBox_Spin.Location = new System.Drawing.Point(485, 519);
            this.pictureBox_Spin.Name = "pictureBox_Spin";
            this.pictureBox_Spin.Size = new System.Drawing.Size(49, 52);
            this.pictureBox_Spin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Spin.TabIndex = 3;
            this.pictureBox_Spin.TabStop = false;
            this.pictureBox_Spin.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // lbl_Credits
            // 
            this.lbl_Credits.AutoSize = true;
            this.lbl_Credits.BackColor = System.Drawing.Color.Black;
            this.lbl_Credits.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Credits.ForeColor = System.Drawing.Color.Red;
            this.lbl_Credits.Location = new System.Drawing.Point(160, 437);
            this.lbl_Credits.Name = "lbl_Credits";
            this.lbl_Credits.Size = new System.Drawing.Size(77, 24);
            this.lbl_Credits.TabIndex = 4;
            this.lbl_Credits.Text = "Credits";
            // 
            // lbl_Bet
            // 
            this.lbl_Bet.AutoSize = true;
            this.lbl_Bet.BackColor = System.Drawing.Color.Black;
            this.lbl_Bet.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bet.ForeColor = System.Drawing.Color.Red;
            this.lbl_Bet.Location = new System.Drawing.Point(305, 436);
            this.lbl_Bet.Name = "lbl_Bet";
            this.lbl_Bet.Size = new System.Drawing.Size(41, 24);
            this.lbl_Bet.TabIndex = 5;
            this.lbl_Bet.Text = "Bet";
            // 
            // lbl_Paid
            // 
            this.lbl_Paid.AutoSize = true;
            this.lbl_Paid.BackColor = System.Drawing.Color.Black;
            this.lbl_Paid.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid.ForeColor = System.Drawing.Color.Red;
            this.lbl_Paid.Location = new System.Drawing.Point(410, 437);
            this.lbl_Paid.Name = "lbl_Paid";
            this.lbl_Paid.Size = new System.Drawing.Size(99, 24);
            this.lbl_Paid.TabIndex = 6;
            this.lbl_Paid.Text = "Winnings";
            // 
            // pictureBox_Quit
            // 
            this.pictureBox_Quit.Image = global::COMP1004_F2016_SlotMachine.Properties.Resources.powerbutton;
            this.pictureBox_Quit.InitialImage = null;
            this.pictureBox_Quit.Location = new System.Drawing.Point(162, 519);
            this.pictureBox_Quit.Name = "pictureBox_Quit";
            this.pictureBox_Quit.Size = new System.Drawing.Size(49, 52);
            this.pictureBox_Quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Quit.TabIndex = 7;
            this.pictureBox_Quit.TabStop = false;
            this.pictureBox_Quit.Click += new System.EventHandler(this.pictureBox_Quit_Click);
            // 
            // pictureBox_Reset
            // 
            this.pictureBox_Reset.Image = global::COMP1004_F2016_SlotMachine.Properties.Resources.reset;
            this.pictureBox_Reset.InitialImage = null;
            this.pictureBox_Reset.Location = new System.Drawing.Point(217, 519);
            this.pictureBox_Reset.Name = "pictureBox_Reset";
            this.pictureBox_Reset.Size = new System.Drawing.Size(49, 52);
            this.pictureBox_Reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Reset.TabIndex = 8;
            this.pictureBox_Reset.TabStop = false;
            this.pictureBox_Reset.Click += new System.EventHandler(this.pictureBox_Reset_Click);
            // 
            // lbl_Jackpot
            // 
            this.lbl_Jackpot.AutoSize = true;
            this.lbl_Jackpot.BackColor = System.Drawing.Color.Black;
            this.lbl_Jackpot.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jackpot.ForeColor = System.Drawing.Color.Red;
            this.lbl_Jackpot.Location = new System.Drawing.Point(288, 190);
            this.lbl_Jackpot.Name = "lbl_Jackpot";
            this.lbl_Jackpot.Size = new System.Drawing.Size(82, 24);
            this.lbl_Jackpot.TabIndex = 9;
            this.lbl_Jackpot.Text = "Jackpot";
            // 
            // pictureBox_Bet1
            // 
            this.pictureBox_Bet1.Image = global::COMP1004_F2016_SlotMachine.Properties.Resources.bet1;
            this.pictureBox_Bet1.Location = new System.Drawing.Point(272, 540);
            this.pictureBox_Bet1.Name = "pictureBox_Bet1";
            this.pictureBox_Bet1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox_Bet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Bet1.TabIndex = 10;
            this.pictureBox_Bet1.TabStop = false;
            this.pictureBox_Bet1.Click += new System.EventHandler(this.pictureBox_Bet1_Click);
            // 
            // pictureBox_Bet5
            // 
            this.pictureBox_Bet5.Image = global::COMP1004_F2016_SlotMachine.Properties.Resources.bet5;
            this.pictureBox_Bet5.Location = new System.Drawing.Point(314, 540);
            this.pictureBox_Bet5.Name = "pictureBox_Bet5";
            this.pictureBox_Bet5.Size = new System.Drawing.Size(36, 31);
            this.pictureBox_Bet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Bet5.TabIndex = 11;
            this.pictureBox_Bet5.TabStop = false;
            this.pictureBox_Bet5.Click += new System.EventHandler(this.pictureBox_Bet5_Click);
            // 
            // pictureBox_Bet25
            // 
            this.pictureBox_Bet25.Image = global::COMP1004_F2016_SlotMachine.Properties.Resources.bet25;
            this.pictureBox_Bet25.Location = new System.Drawing.Point(356, 540);
            this.pictureBox_Bet25.Name = "pictureBox_Bet25";
            this.pictureBox_Bet25.Size = new System.Drawing.Size(36, 31);
            this.pictureBox_Bet25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Bet25.TabIndex = 12;
            this.pictureBox_Bet25.TabStop = false;
            this.pictureBox_Bet25.Click += new System.EventHandler(this.pictureBox_Bet25_Click);
            // 
            // pictureBox_Bet50
            // 
            this.pictureBox_Bet50.Image = global::COMP1004_F2016_SlotMachine.Properties.Resources.bet50;
            this.pictureBox_Bet50.Location = new System.Drawing.Point(398, 540);
            this.pictureBox_Bet50.Name = "pictureBox_Bet50";
            this.pictureBox_Bet50.Size = new System.Drawing.Size(36, 31);
            this.pictureBox_Bet50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Bet50.TabIndex = 13;
            this.pictureBox_Bet50.TabStop = false;
            this.pictureBox_Bet50.Click += new System.EventHandler(this.pictureBox_Bet50_Click);
            // 
            // pictureBox_Bet100
            // 
            this.pictureBox_Bet100.Image = global::COMP1004_F2016_SlotMachine.Properties.Resources.bet100;
            this.pictureBox_Bet100.Location = new System.Drawing.Point(440, 540);
            this.pictureBox_Bet100.Name = "pictureBox_Bet100";
            this.pictureBox_Bet100.Size = new System.Drawing.Size(36, 31);
            this.pictureBox_Bet100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Bet100.TabIndex = 14;
            this.pictureBox_Bet100.TabStop = false;
            this.pictureBox_Bet100.Click += new System.EventHandler(this.pictureBox_Bet100_Click);
            // 
            // btn_Stats
            // 
            this.btn_Stats.BackColor = System.Drawing.Color.Black;
            this.btn_Stats.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stats.ForeColor = System.Drawing.Color.Red;
            this.btn_Stats.Location = new System.Drawing.Point(398, 509);
            this.btn_Stats.Name = "btn_Stats";
            this.btn_Stats.Size = new System.Drawing.Size(75, 23);
            this.btn_Stats.TabIndex = 16;
            this.btn_Stats.Text = "STATS";
            this.btn_Stats.UseVisualStyleBackColor = false;
            this.btn_Stats.Click += new System.EventHandler(this.btn_Stats_Click);
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::COMP1004_F2016_SlotMachine.Properties.Resources.slotmachine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(682, 620);
            this.Controls.Add(this.btn_Stats);
            this.Controls.Add(this.pictureBox_Bet100);
            this.Controls.Add(this.pictureBox_Bet50);
            this.Controls.Add(this.pictureBox_Bet25);
            this.Controls.Add(this.pictureBox_Bet5);
            this.Controls.Add(this.pictureBox_Bet1);
            this.Controls.Add(this.lbl_Jackpot);
            this.Controls.Add(this.pictureBox_Reset);
            this.Controls.Add(this.pictureBox_Quit);
            this.Controls.Add(this.lbl_Paid);
            this.Controls.Add(this.lbl_Bet);
            this.Controls.Add(this.lbl_Credits);
            this.Controls.Add(this.pictureBox_Spin);
            this.Controls.Add(this.pictureBox_Reel3);
            this.Controls.Add(this.pictureBox_Reel2);
            this.Controls.Add(this.pictureBox_Reel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SlotMachineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Spin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bet50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bet100)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Reel1;
        private System.Windows.Forms.PictureBox pictureBox_Reel2;
        private System.Windows.Forms.PictureBox pictureBox_Reel3;
        private System.Windows.Forms.PictureBox pictureBox_Spin;
        private System.Windows.Forms.Label lbl_Credits;
        private System.Windows.Forms.Label lbl_Bet;
        private System.Windows.Forms.Label lbl_Paid;
        private System.Windows.Forms.PictureBox pictureBox_Quit;
        private System.Windows.Forms.PictureBox pictureBox_Reset;
        private System.Windows.Forms.Label lbl_Jackpot;
        private System.Windows.Forms.PictureBox pictureBox_Bet1;
        private System.Windows.Forms.PictureBox pictureBox_Bet5;
        private System.Windows.Forms.PictureBox pictureBox_Bet25;
        private System.Windows.Forms.PictureBox pictureBox_Bet50;
        private System.Windows.Forms.PictureBox pictureBox_Bet100;
        private System.Windows.Forms.Button btn_Stats;
    }
}