
namespace Connect4_MainMenu
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.btn_1Player = new System.Windows.Forms.Button();
            this.btn_2player = new System.Windows.Forms.Button();
            this.stats = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pic_connect4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_connect4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_1Player
            // 
            this.btn_1Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_1Player.BackgroundImage")));
            this.btn_1Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_1Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1Player.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_1Player.FlatAppearance.BorderSize = 0;
            this.btn_1Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1Player.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_1Player.Location = new System.Drawing.Point(563, 371);
            this.btn_1Player.Name = "btn_1Player";
            this.btn_1Player.Size = new System.Drawing.Size(632, 135);
            this.btn_1Player.TabIndex = 0;
            this.btn_1Player.UseVisualStyleBackColor = false;
            this.btn_1Player.Click += new System.EventHandler(this.btn_1Player_Click);
            // 
            // btn_2player
            // 
            this.btn_2player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_2player.BackgroundImage")));
            this.btn_2player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_2player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_2player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2player.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_2player.Location = new System.Drawing.Point(563, 528);
            this.btn_2player.Name = "btn_2player";
            this.btn_2player.Size = new System.Drawing.Size(632, 135);
            this.btn_2player.TabIndex = 1;
            this.btn_2player.UseVisualStyleBackColor = false;
            this.btn_2player.Click += new System.EventHandler(this.btn_2player_Click);
            // 
            // stats
            // 
            this.stats.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stats.BackgroundImage")));
            this.stats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stats.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.stats.Location = new System.Drawing.Point(563, 681);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(632, 135);
            this.stats.TabIndex = 2;
            this.stats.UseVisualStyleBackColor = false;
            this.stats.Click += new System.EventHandler(this.stats_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.exit.Location = new System.Drawing.Point(762, 822);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(264, 90);
            this.exit.TabIndex = 3;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pic_connect4
            // 
            this.pic_connect4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_connect4.BackgroundImage")));
            this.pic_connect4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_connect4.Location = new System.Drawing.Point(229, 65);
            this.pic_connect4.Name = "pic_connect4";
            this.pic_connect4.Size = new System.Drawing.Size(1298, 184);
            this.pic_connect4.TabIndex = 4;
            this.pic_connect4.TabStop = false;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1756, 929);
            this.Controls.Add(this.pic_connect4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.btn_2player);
            this.Controls.Add(this.btn_1Player);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Main_Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_connect4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_1Player;
        private System.Windows.Forms.Button btn_2player;
        private System.Windows.Forms.Button stats;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pic_connect4;
    }
}

