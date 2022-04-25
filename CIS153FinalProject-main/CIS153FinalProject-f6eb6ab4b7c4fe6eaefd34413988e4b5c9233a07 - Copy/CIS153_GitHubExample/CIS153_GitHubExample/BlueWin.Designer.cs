
namespace CIS153_GitHubExample
{
    partial class BlueWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlueWin));
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Stats = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.BlueWon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BlueWon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Menu
            // 
            this.btn_Menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Menu.BackgroundImage")));
            this.btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Menu.Location = new System.Drawing.Point(552, 513);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(558, 135);
            this.btn_Menu.TabIndex = 6;
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Stats
            // 
            this.btn_Stats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Stats.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Stats.BackgroundImage")));
            this.btn_Stats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stats.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Stats.Location = new System.Drawing.Point(552, 663);
            this.btn_Stats.Name = "btn_Stats";
            this.btn_Stats.Size = new System.Drawing.Size(558, 135);
            this.btn_Stats.TabIndex = 7;
            this.btn_Stats.UseVisualStyleBackColor = true;
            this.btn_Stats.Click += new System.EventHandler(this.btn_Stats_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Exit.Location = new System.Drawing.Point(679, 813);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(322, 135);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // BlueWon
            // 
            this.BlueWon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlueWon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BlueWon.BackgroundImage")));
            this.BlueWon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlueWon.Location = new System.Drawing.Point(394, 71);
            this.BlueWon.Name = "BlueWon";
            this.BlueWon.Size = new System.Drawing.Size(860, 362);
            this.BlueWon.TabIndex = 9;
            this.BlueWon.TabStop = false;
            // 
            // BlueWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1636, 960);
            this.Controls.Add(this.BlueWon);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Stats);
            this.Controls.Add(this.btn_Menu);
            this.Name = "BlueWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.BlueWon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Stats;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox BlueWon;
    }
}