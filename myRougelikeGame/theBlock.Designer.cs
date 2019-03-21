namespace myRougelikeGame
{
    partial class theBlock
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
            this.TakeAllBtn = new System.Windows.Forms.Button();
            this.TakeOne = new System.Windows.Forms.Button();
            this.giveBackOne = new System.Windows.Forms.Button();
            this.heroBagList = new System.Windows.Forms.ListBox();
            this.blockItemList = new System.Windows.Forms.ListBox();
            this.heroBagListTrue = new System.Windows.Forms.ListBox();
            this.blockItemListTrue = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leftSpace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TakeAllBtn
            // 
            this.TakeAllBtn.Location = new System.Drawing.Point(188, 62);
            this.TakeAllBtn.Name = "TakeAllBtn";
            this.TakeAllBtn.Size = new System.Drawing.Size(76, 37);
            this.TakeAllBtn.TabIndex = 1;
            this.TakeAllBtn.Text = "------>\r\n全部拿走\r\n";
            this.TakeAllBtn.UseVisualStyleBackColor = true;
            this.TakeAllBtn.Click += new System.EventHandler(this.TakeAllBtn_Click);
            // 
            // TakeOne
            // 
            this.TakeOne.Location = new System.Drawing.Point(188, 114);
            this.TakeOne.Name = "TakeOne";
            this.TakeOne.Size = new System.Drawing.Size(76, 37);
            this.TakeOne.TabIndex = 1;
            this.TakeOne.Text = "------>\r\n拿走一个\r\n\r\n";
            this.TakeOne.UseVisualStyleBackColor = true;
            this.TakeOne.Click += new System.EventHandler(this.TakeOne_Click);
            // 
            // giveBackOne
            // 
            this.giveBackOne.Location = new System.Drawing.Point(188, 167);
            this.giveBackOne.Name = "giveBackOne";
            this.giveBackOne.Size = new System.Drawing.Size(76, 37);
            this.giveBackOne.TabIndex = 1;
            this.giveBackOne.Text = "<------\r\n拿走一个\r\n\r\n";
            this.giveBackOne.UseVisualStyleBackColor = true;
            this.giveBackOne.Click += new System.EventHandler(this.giveBackOne_Click);
            // 
            // heroBagList
            // 
            this.heroBagList.FormattingEnabled = true;
            this.heroBagList.ItemHeight = 12;
            this.heroBagList.Location = new System.Drawing.Point(283, 63);
            this.heroBagList.Name = "heroBagList";
            this.heroBagList.Size = new System.Drawing.Size(158, 208);
            this.heroBagList.TabIndex = 3;
            // 
            // blockItemList
            // 
            this.blockItemList.FormattingEnabled = true;
            this.blockItemList.ItemHeight = 12;
            this.blockItemList.Location = new System.Drawing.Point(12, 62);
            this.blockItemList.Name = "blockItemList";
            this.blockItemList.Size = new System.Drawing.Size(158, 208);
            this.blockItemList.TabIndex = 3;
            // 
            // heroBagListTrue
            // 
            this.heroBagListTrue.FormattingEnabled = true;
            this.heroBagListTrue.ItemHeight = 12;
            this.heroBagListTrue.Location = new System.Drawing.Point(283, 31);
            this.heroBagListTrue.Name = "heroBagListTrue";
            this.heroBagListTrue.Size = new System.Drawing.Size(21, 16);
            this.heroBagListTrue.TabIndex = 3;
            this.heroBagListTrue.Visible = false;
            // 
            // blockItemListTrue
            // 
            this.blockItemListTrue.FormattingEnabled = true;
            this.blockItemListTrue.ItemHeight = 12;
            this.blockItemListTrue.Location = new System.Drawing.Point(310, 31);
            this.blockItemListTrue.Name = "blockItemListTrue";
            this.blockItemListTrue.Size = new System.Drawing.Size(19, 16);
            this.blockItemListTrue.TabIndex = 3;
            this.blockItemListTrue.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "剩余容量:";
            // 
            // leftSpace
            // 
            this.leftSpace.AutoSize = true;
            this.leftSpace.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftSpace.Location = new System.Drawing.Point(385, 31);
            this.leftSpace.Name = "leftSpace";
            this.leftSpace.Size = new System.Drawing.Size(56, 16);
            this.leftSpace.TabIndex = 5;
            this.leftSpace.Text = "label2";
            // 
            // theBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 288);
            this.Controls.Add(this.leftSpace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blockItemList);
            this.Controls.Add(this.blockItemListTrue);
            this.Controls.Add(this.heroBagListTrue);
            this.Controls.Add(this.heroBagList);
            this.Controls.Add(this.giveBackOne);
            this.Controls.Add(this.TakeOne);
            this.Controls.Add(this.TakeAllBtn);
            this.Name = "theBlock";
            this.Text = "theBlock";
            this.Load += new System.EventHandler(this.theBlock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TakeAllBtn;
        private System.Windows.Forms.Button TakeOne;
        private System.Windows.Forms.Button giveBackOne;
        private System.Windows.Forms.ListBox heroBagList;
        private System.Windows.Forms.ListBox blockItemList;
        private System.Windows.Forms.ListBox heroBagListTrue;
        private System.Windows.Forms.ListBox blockItemListTrue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leftSpace;
    }
}