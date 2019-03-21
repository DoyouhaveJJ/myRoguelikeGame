namespace myRougelikeGame.SmallForm
{
    partial class theNeck
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
            this.injuredLevel = new System.Windows.Forms.Label();
            this.Defense = new System.Windows.Forms.Label();
            this.magicDefense = new System.Windows.Forms.Label();
            this.NecklaceShow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnduranceShow = new System.Windows.Forms.Label();
            this.EnduranceBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // injuredLevel
            // 
            this.injuredLevel.AutoSize = true;
            this.injuredLevel.Location = new System.Drawing.Point(67, 24);
            this.injuredLevel.Name = "injuredLevel";
            this.injuredLevel.Size = new System.Drawing.Size(11, 12);
            this.injuredLevel.TabIndex = 29;
            this.injuredLevel.Text = " ";
            // 
            // Defense
            // 
            this.Defense.AutoSize = true;
            this.Defense.Location = new System.Drawing.Point(56, 39);
            this.Defense.Name = "Defense";
            this.Defense.Size = new System.Drawing.Size(11, 12);
            this.Defense.TabIndex = 32;
            this.Defense.Text = " ";
            // 
            // magicDefense
            // 
            this.magicDefense.AutoSize = true;
            this.magicDefense.Location = new System.Drawing.Point(78, 53);
            this.magicDefense.Name = "magicDefense";
            this.magicDefense.Size = new System.Drawing.Size(11, 12);
            this.magicDefense.TabIndex = 31;
            this.magicDefense.Text = " ";
            // 
            // NecklaceShow
            // 
            this.NecklaceShow.AutoSize = true;
            this.NecklaceShow.Location = new System.Drawing.Point(67, 75);
            this.NecklaceShow.Name = "NecklaceShow";
            this.NecklaceShow.Size = new System.Drawing.Size(11, 12);
            this.NecklaceShow.TabIndex = 30;
            this.NecklaceShow.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "项链部位:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "魔法防御力:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "防御力:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "受伤状况:";
            // 
            // EnduranceShow
            // 
            this.EnduranceShow.AutoSize = true;
            this.EnduranceShow.Location = new System.Drawing.Point(167, 9);
            this.EnduranceShow.Name = "EnduranceShow";
            this.EnduranceShow.Size = new System.Drawing.Size(11, 12);
            this.EnduranceShow.TabIndex = 24;
            this.EnduranceShow.Text = " ";
            // 
            // EnduranceBar
            // 
            this.EnduranceBar.Location = new System.Drawing.Point(60, 9);
            this.EnduranceBar.Name = "EnduranceBar";
            this.EnduranceBar.Size = new System.Drawing.Size(100, 12);
            this.EnduranceBar.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "耐久值：";
            // 
            // theNeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 99);
            this.Controls.Add(this.injuredLevel);
            this.Controls.Add(this.Defense);
            this.Controls.Add(this.magicDefense);
            this.Controls.Add(this.NecklaceShow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnduranceShow);
            this.Controls.Add(this.EnduranceBar);
            this.Controls.Add(this.label1);
            this.Name = "theNeck";
            this.Text = "脖子";
            this.Load += new System.EventHandler(this.theNeck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label injuredLevel;
        private System.Windows.Forms.Label Defense;
        private System.Windows.Forms.Label magicDefense;
        private System.Windows.Forms.Label NecklaceShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EnduranceShow;
        private System.Windows.Forms.ProgressBar EnduranceBar;
        private System.Windows.Forms.Label label1;
    }
}