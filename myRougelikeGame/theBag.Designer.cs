namespace myRougelikeGame
{
    partial class theBag
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.UseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.itemLevel = new System.Windows.Forms.Label();
            this.itemEnduranceShow = new System.Windows.Forms.Label();
            this.itemWeight = new System.Windows.Forms.Label();
            this.itemType = new System.Windows.Forms.Label();
            this.itemEffectDescribe = new System.Windows.Forms.Label();
            this.itemEnduranceBar = new System.Windows.Forms.ProgressBar();
            this.itemDescribe = new System.Windows.Forms.Label();
            this.itemCost = new System.Windows.Forms.Label();
            this.burdenInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.spaceInfo = new System.Windows.Forms.Label();
            this.DIYLabel_1 = new System.Windows.Forms.Label();
            this.EquipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "defaultItem";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 184);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "defaultItem";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(13, 200);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(33, 16);
            this.listBox2.TabIndex = 1;
            this.listBox2.Visible = false;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // UseButton
            // 
            this.UseButton.Location = new System.Drawing.Point(190, 231);
            this.UseButton.Name = "UseButton";
            this.UseButton.Size = new System.Drawing.Size(75, 23);
            this.UseButton.TabIndex = 2;
            this.UseButton.Text = "使用";
            this.UseButton.UseVisualStyleBackColor = true;
            this.UseButton.Visible = false;
            this.UseButton.Click += new System.EventHandler(this.UseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "名字：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "级别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "耐久值：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "效果：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "描述：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "价值：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "重量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "种类：";
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Location = new System.Drawing.Point(159, 13);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(0, 12);
            this.itemName.TabIndex = 4;
            // 
            // itemLevel
            // 
            this.itemLevel.AutoSize = true;
            this.itemLevel.Location = new System.Drawing.Point(159, 25);
            this.itemLevel.Name = "itemLevel";
            this.itemLevel.Size = new System.Drawing.Size(0, 12);
            this.itemLevel.TabIndex = 4;
            // 
            // itemEnduranceShow
            // 
            this.itemEnduranceShow.AutoSize = true;
            this.itemEnduranceShow.Location = new System.Drawing.Point(233, 36);
            this.itemEnduranceShow.Name = "itemEnduranceShow";
            this.itemEnduranceShow.Size = new System.Drawing.Size(0, 12);
            this.itemEnduranceShow.TabIndex = 4;
            // 
            // itemWeight
            // 
            this.itemWeight.AutoSize = true;
            this.itemWeight.Location = new System.Drawing.Point(159, 49);
            this.itemWeight.Name = "itemWeight";
            this.itemWeight.Size = new System.Drawing.Size(0, 12);
            this.itemWeight.TabIndex = 4;
            // 
            // itemType
            // 
            this.itemType.AutoSize = true;
            this.itemType.Location = new System.Drawing.Point(159, 61);
            this.itemType.Name = "itemType";
            this.itemType.Size = new System.Drawing.Size(0, 12);
            this.itemType.TabIndex = 4;
            // 
            // itemEffectDescribe
            // 
            this.itemEffectDescribe.AutoSize = true;
            this.itemEffectDescribe.Location = new System.Drawing.Point(159, 73);
            this.itemEffectDescribe.Name = "itemEffectDescribe";
            this.itemEffectDescribe.Size = new System.Drawing.Size(0, 12);
            this.itemEffectDescribe.TabIndex = 4;
            // 
            // itemEnduranceBar
            // 
            this.itemEnduranceBar.Location = new System.Drawing.Point(172, 37);
            this.itemEnduranceBar.Name = "itemEnduranceBar";
            this.itemEnduranceBar.Size = new System.Drawing.Size(58, 11);
            this.itemEnduranceBar.TabIndex = 5;
            // 
            // itemDescribe
            // 
            this.itemDescribe.AutoSize = true;
            this.itemDescribe.Location = new System.Drawing.Point(159, 106);
            this.itemDescribe.Name = "itemDescribe";
            this.itemDescribe.Size = new System.Drawing.Size(0, 12);
            this.itemDescribe.TabIndex = 4;
            // 
            // itemCost
            // 
            this.itemCost.AutoSize = true;
            this.itemCost.Location = new System.Drawing.Point(159, 157);
            this.itemCost.Name = "itemCost";
            this.itemCost.Size = new System.Drawing.Size(0, 12);
            this.itemCost.TabIndex = 4;
            // 
            // burdenInfo
            // 
            this.burdenInfo.AutoSize = true;
            this.burdenInfo.Location = new System.Drawing.Point(41, 204);
            this.burdenInfo.Name = "burdenInfo";
            this.burdenInfo.Size = new System.Drawing.Size(41, 12);
            this.burdenInfo.TabIndex = 6;
            this.burdenInfo.Text = "label9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "负重";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "容量";
            // 
            // spaceInfo
            // 
            this.spaceInfo.AutoSize = true;
            this.spaceInfo.Location = new System.Drawing.Point(41, 216);
            this.spaceInfo.Name = "spaceInfo";
            this.spaceInfo.Size = new System.Drawing.Size(41, 12);
            this.spaceInfo.TabIndex = 6;
            this.spaceInfo.Text = "label9";
            // 
            // DIYLabel_1
            // 
            this.DIYLabel_1.AutoSize = true;
            this.DIYLabel_1.Location = new System.Drawing.Point(297, 13);
            this.DIYLabel_1.Name = "DIYLabel_1";
            this.DIYLabel_1.Size = new System.Drawing.Size(0, 12);
            this.DIYLabel_1.TabIndex = 8;
            // 
            // EquipButton
            // 
            this.EquipButton.Location = new System.Drawing.Point(271, 231);
            this.EquipButton.Name = "EquipButton";
            this.EquipButton.Size = new System.Drawing.Size(75, 23);
            this.EquipButton.TabIndex = 9;
            this.EquipButton.Text = "装备";
            this.EquipButton.UseVisualStyleBackColor = true;
            this.EquipButton.Visible = false;
            this.EquipButton.Click += new System.EventHandler(this.EquipButton_Click);
            // 
            // theBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 266);
            this.Controls.Add(this.EquipButton);
            this.Controls.Add(this.DIYLabel_1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.spaceInfo);
            this.Controls.Add(this.burdenInfo);
            this.Controls.Add(this.itemEnduranceBar);
            this.Controls.Add(this.itemCost);
            this.Controls.Add(this.itemDescribe);
            this.Controls.Add(this.itemEffectDescribe);
            this.Controls.Add(this.itemType);
            this.Controls.Add(this.itemWeight);
            this.Controls.Add(this.itemEnduranceShow);
            this.Controls.Add(this.itemLevel);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UseButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "theBag";
            this.Text = "theBag";
            this.Load += new System.EventHandler(this.theBag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button UseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label itemLevel;
        private System.Windows.Forms.Label itemEnduranceShow;
        private System.Windows.Forms.Label itemWeight;
        private System.Windows.Forms.Label itemType;
        private System.Windows.Forms.Label itemEffectDescribe;
        private System.Windows.Forms.ProgressBar itemEnduranceBar;
        private System.Windows.Forms.Label itemDescribe;
        private System.Windows.Forms.Label itemCost;
        private System.Windows.Forms.Label burdenInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label spaceInfo;
        private System.Windows.Forms.Label DIYLabel_1;
        private System.Windows.Forms.Button EquipButton;
    }
}