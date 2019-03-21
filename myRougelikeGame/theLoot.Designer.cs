namespace myRougelikeGame
{
    partial class theLoot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blockName = new System.Windows.Forms.Label();
            this.lootBar = new System.Windows.Forms.ProgressBar();
            this.lootMsg = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "地区：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "搜刮值：";
            // 
            // blockName
            // 
            this.blockName.AutoSize = true;
            this.blockName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blockName.Location = new System.Drawing.Point(43, 38);
            this.blockName.Name = "blockName";
            this.blockName.Size = new System.Drawing.Size(75, 19);
            this.blockName.TabIndex = 1;
            this.blockName.Text = "label3";
            // 
            // lootBar
            // 
            this.lootBar.Location = new System.Drawing.Point(30, 108);
            this.lootBar.Name = "lootBar";
            this.lootBar.Size = new System.Drawing.Size(100, 23);
            this.lootBar.TabIndex = 2;
            // 
            // lootMsg
            // 
            this.lootMsg.FormattingEnabled = true;
            this.lootMsg.ItemHeight = 12;
            this.lootMsg.Location = new System.Drawing.Point(229, 12);
            this.lootMsg.Name = "lootMsg";
            this.lootMsg.Size = new System.Drawing.Size(246, 244);
            this.lootMsg.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "搜刮";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // theLoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lootMsg);
            this.Controls.Add(this.lootBar);
            this.Controls.Add(this.blockName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "theLoot";
            this.Text = "theLoot";
            this.Load += new System.EventHandler(this.theLoot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label blockName;
        private System.Windows.Forms.ProgressBar lootBar;
        private System.Windows.Forms.ListBox lootMsg;
        private System.Windows.Forms.Button button1;
    }
}