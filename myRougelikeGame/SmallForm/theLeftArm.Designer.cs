namespace myRougelikeGame.SmallForm
{
    partial class theLeftArm
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
            this.SignShow = new System.Windows.Forms.Label();
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
            this.injuredLevel.Location = new System.Drawing.Point(66, 27);
            this.injuredLevel.Name = "injuredLevel";
            this.injuredLevel.Size = new System.Drawing.Size(11, 12);
            this.injuredLevel.TabIndex = 40;
            this.injuredLevel.Text = " ";
            // 
            // Defense
            // 
            this.Defense.AutoSize = true;
            this.Defense.Location = new System.Drawing.Point(55, 42);
            this.Defense.Name = "Defense";
            this.Defense.Size = new System.Drawing.Size(11, 12);
            this.Defense.TabIndex = 43;
            this.Defense.Text = " ";
            // 
            // magicDefense
            // 
            this.magicDefense.AutoSize = true;
            this.magicDefense.Location = new System.Drawing.Point(77, 56);
            this.magicDefense.Name = "magicDefense";
            this.magicDefense.Size = new System.Drawing.Size(11, 12);
            this.magicDefense.TabIndex = 42;
            this.magicDefense.Text = " ";
            // 
            // SignShow
            // 
            this.SignShow.AutoSize = true;
            this.SignShow.Location = new System.Drawing.Point(66, 78);
            this.SignShow.Name = "SignShow";
            this.SignShow.Size = new System.Drawing.Size(11, 12);
            this.SignShow.TabIndex = 41;
            this.SignShow.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "臂章部位:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "魔法防御力:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "防御力:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "受伤状况:";
            // 
            // EnduranceShow
            // 
            this.EnduranceShow.AutoSize = true;
            this.EnduranceShow.Location = new System.Drawing.Point(166, 12);
            this.EnduranceShow.Name = "EnduranceShow";
            this.EnduranceShow.Size = new System.Drawing.Size(11, 12);
            this.EnduranceShow.TabIndex = 35;
            this.EnduranceShow.Text = " ";
            // 
            // EnduranceBar
            // 
            this.EnduranceBar.Location = new System.Drawing.Point(59, 12);
            this.EnduranceBar.Name = "EnduranceBar";
            this.EnduranceBar.Size = new System.Drawing.Size(100, 12);
            this.EnduranceBar.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "耐久值：";
            // 
            // theLeftArm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 105);
            this.Controls.Add(this.injuredLevel);
            this.Controls.Add(this.Defense);
            this.Controls.Add(this.magicDefense);
            this.Controls.Add(this.SignShow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnduranceShow);
            this.Controls.Add(this.EnduranceBar);
            this.Controls.Add(this.label1);
            this.Name = "theLeftArm";
            this.Text = "左臂";
            this.Load += new System.EventHandler(this.theLeftArm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label injuredLevel;
        private System.Windows.Forms.Label Defense;
        private System.Windows.Forms.Label magicDefense;
        private System.Windows.Forms.Label SignShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EnduranceShow;
        private System.Windows.Forms.ProgressBar EnduranceBar;
        private System.Windows.Forms.Label label1;
    }
}