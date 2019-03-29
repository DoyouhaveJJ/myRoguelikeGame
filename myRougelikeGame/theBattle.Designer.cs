namespace myRougelikeGame
{
    partial class theBattle
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BattleMsg = new System.Windows.Forms.ListBox();
            this.fallBackBtn = new System.Windows.Forms.Button();
            this.moveTowardBtn = new System.Windows.Forms.Button();
            this.heroName = new System.Windows.Forms.Label();
            this.enemyName = new System.Windows.Forms.Label();
            this.heroStatus = new System.Windows.Forms.Label();
            this.enemyStatus = new System.Windows.Forms.Label();
            this.heroVisable = new System.Windows.Forms.Label();
            this.enemyVisable = new System.Windows.Forms.Label();
            this.heroLastAction = new System.Windows.Forms.Label();
            this.enemyLastAction = new System.Windows.Forms.Label();
            this.asasasa = new System.Windows.Forms.Label();
            this.Distence = new System.Windows.Forms.Label();
            this.attackBtn = new System.Windows.Forms.Button();
            this.escapeBtn = new System.Windows.Forms.Button();
            this.chargeBtn = new System.Windows.Forms.Button();
            this.waitBtn = new System.Windows.Forms.Button();
            this.WinBtn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.enemyLevel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.weapon = new System.Windows.Forms.Label();
            this.hero_search = new System.Windows.Forms.Button();
            this.attack_aimless = new System.Windows.Forms.Button();
            this.after = new System.Windows.Forms.Button();
            this.before = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "你：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(449, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "敌人：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "你的上一步行动：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(449, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "敌人的上一步行动：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(5, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "是否看见敌人:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(449, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "是否看见你:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(5, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "状态:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(449, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "状态:";
            // 
            // BattleMsg
            // 
            this.BattleMsg.FormattingEnabled = true;
            this.BattleMsg.ItemHeight = 12;
            this.BattleMsg.Location = new System.Drawing.Point(175, 148);
            this.BattleMsg.Name = "BattleMsg";
            this.BattleMsg.Size = new System.Drawing.Size(501, 172);
            this.BattleMsg.TabIndex = 2;
            this.BattleMsg.SelectedIndexChanged += new System.EventHandler(this.BattleMsg_SelectedIndexChanged);
            // 
            // fallBackBtn
            // 
            this.fallBackBtn.Location = new System.Drawing.Point(23, 148);
            this.fallBackBtn.Name = "fallBackBtn";
            this.fallBackBtn.Size = new System.Drawing.Size(62, 26);
            this.fallBackBtn.TabIndex = 3;
            this.fallBackBtn.Text = "后退";
            this.fallBackBtn.UseVisualStyleBackColor = true;
            this.fallBackBtn.Click += new System.EventHandler(this.fallBackBtn_Click);
            // 
            // moveTowardBtn
            // 
            this.moveTowardBtn.Location = new System.Drawing.Point(91, 148);
            this.moveTowardBtn.Name = "moveTowardBtn";
            this.moveTowardBtn.Size = new System.Drawing.Size(62, 26);
            this.moveTowardBtn.TabIndex = 3;
            this.moveTowardBtn.Text = "前进";
            this.moveTowardBtn.UseVisualStyleBackColor = true;
            this.moveTowardBtn.Click += new System.EventHandler(this.moveTowardBtn_Click);
            // 
            // heroName
            // 
            this.heroName.AutoSize = true;
            this.heroName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.heroName.Location = new System.Drawing.Point(44, 13);
            this.heroName.Name = "heroName";
            this.heroName.Size = new System.Drawing.Size(80, 16);
            this.heroName.TabIndex = 4;
            this.heroName.Text = "hero_Name";
            // 
            // enemyName
            // 
            this.enemyName.AutoSize = true;
            this.enemyName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enemyName.Location = new System.Drawing.Point(503, 9);
            this.enemyName.Name = "enemyName";
            this.enemyName.Size = new System.Drawing.Size(56, 16);
            this.enemyName.TabIndex = 4;
            this.enemyName.Text = "label9";
            // 
            // heroStatus
            // 
            this.heroStatus.AutoSize = true;
            this.heroStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.heroStatus.Location = new System.Drawing.Point(53, 65);
            this.heroStatus.Name = "heroStatus";
            this.heroStatus.Size = new System.Drawing.Size(56, 16);
            this.heroStatus.TabIndex = 5;
            this.heroStatus.Text = "label9";
            this.heroStatus.Click += new System.EventHandler(this.heroStatus_Click);
            // 
            // enemyStatus
            // 
            this.enemyStatus.AutoSize = true;
            this.enemyStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enemyStatus.Location = new System.Drawing.Point(503, 65);
            this.enemyStatus.Name = "enemyStatus";
            this.enemyStatus.Size = new System.Drawing.Size(56, 16);
            this.enemyStatus.TabIndex = 5;
            this.enemyStatus.Text = "label9";
            // 
            // heroVisable
            // 
            this.heroVisable.AutoSize = true;
            this.heroVisable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.heroVisable.Location = new System.Drawing.Point(115, 85);
            this.heroVisable.Name = "heroVisable";
            this.heroVisable.Size = new System.Drawing.Size(56, 16);
            this.heroVisable.TabIndex = 5;
            this.heroVisable.Text = "label9";
            // 
            // enemyVisable
            // 
            this.enemyVisable.AutoSize = true;
            this.enemyVisable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enemyVisable.Location = new System.Drawing.Point(545, 89);
            this.enemyVisable.Name = "enemyVisable";
            this.enemyVisable.Size = new System.Drawing.Size(56, 16);
            this.enemyVisable.TabIndex = 5;
            this.enemyVisable.Text = "label9";
            // 
            // heroLastAction
            // 
            this.heroLastAction.AutoSize = true;
            this.heroLastAction.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.heroLastAction.Location = new System.Drawing.Point(123, 101);
            this.heroLastAction.Name = "heroLastAction";
            this.heroLastAction.Size = new System.Drawing.Size(56, 16);
            this.heroLastAction.TabIndex = 5;
            this.heroLastAction.Text = "label9";
            // 
            // enemyLastAction
            // 
            this.enemyLastAction.AutoSize = true;
            this.enemyLastAction.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enemyLastAction.Location = new System.Drawing.Point(597, 106);
            this.enemyLastAction.Name = "enemyLastAction";
            this.enemyLastAction.Size = new System.Drawing.Size(56, 16);
            this.enemyLastAction.TabIndex = 5;
            this.enemyLastAction.Text = "label9";
            // 
            // asasasa
            // 
            this.asasasa.AutoSize = true;
            this.asasasa.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.asasasa.Location = new System.Drawing.Point(229, 65);
            this.asasasa.Name = "asasasa";
            this.asasasa.Size = new System.Drawing.Size(51, 16);
            this.asasasa.TabIndex = 6;
            this.asasasa.Text = "距离:";
            // 
            // Distence
            // 
            this.Distence.AutoSize = true;
            this.Distence.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Distence.Location = new System.Drawing.Point(286, 65);
            this.Distence.Name = "Distence";
            this.Distence.Size = new System.Drawing.Size(80, 16);
            this.Distence.TabIndex = 7;
            this.Distence.Text = "Distence";
            // 
            // attackBtn
            // 
            this.attackBtn.Location = new System.Drawing.Point(23, 213);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(62, 27);
            this.attackBtn.TabIndex = 8;
            this.attackBtn.Text = "攻击";
            this.attackBtn.UseVisualStyleBackColor = true;
            this.attackBtn.Click += new System.EventHandler(this.attackBtn_Click);
            // 
            // escapeBtn
            // 
            this.escapeBtn.Location = new System.Drawing.Point(23, 180);
            this.escapeBtn.Name = "escapeBtn";
            this.escapeBtn.Size = new System.Drawing.Size(62, 27);
            this.escapeBtn.TabIndex = 8;
            this.escapeBtn.Text = "逃跑";
            this.escapeBtn.UseVisualStyleBackColor = true;
            this.escapeBtn.Click += new System.EventHandler(this.escapeBtn_Click);
            // 
            // chargeBtn
            // 
            this.chargeBtn.Location = new System.Drawing.Point(91, 180);
            this.chargeBtn.Name = "chargeBtn";
            this.chargeBtn.Size = new System.Drawing.Size(62, 27);
            this.chargeBtn.TabIndex = 8;
            this.chargeBtn.Text = "冲锋";
            this.chargeBtn.UseVisualStyleBackColor = true;
            this.chargeBtn.Click += new System.EventHandler(this.chargeBtn_Click);
            // 
            // waitBtn
            // 
            this.waitBtn.Location = new System.Drawing.Point(91, 213);
            this.waitBtn.Name = "waitBtn";
            this.waitBtn.Size = new System.Drawing.Size(62, 27);
            this.waitBtn.TabIndex = 8;
            this.waitBtn.Text = "等待";
            this.waitBtn.UseVisualStyleBackColor = true;
            this.waitBtn.Click += new System.EventHandler(this.waitBtn_Click);
            // 
            // WinBtn
            // 
            this.WinBtn.Location = new System.Drawing.Point(56, 284);
            this.WinBtn.Name = "WinBtn";
            this.WinBtn.Size = new System.Drawing.Size(68, 36);
            this.WinBtn.TabIndex = 9;
            this.WinBtn.Text = "胜利";
            this.WinBtn.UseVisualStyleBackColor = true;
            this.WinBtn.Visible = false;
            this.WinBtn.Click += new System.EventHandler(this.WinBtn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "左手";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(65, 126);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "右手";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(118, 126);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "双手";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(449, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "等级:";
            // 
            // enemyLevel
            // 
            this.enemyLevel.AutoSize = true;
            this.enemyLevel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enemyLevel.Location = new System.Drawing.Point(503, 38);
            this.enemyLevel.Name = "enemyLevel";
            this.enemyLevel.Size = new System.Drawing.Size(56, 16);
            this.enemyLevel.TabIndex = 5;
            this.enemyLevel.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(5, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "武器:";
            // 
            // weapon
            // 
            this.weapon.AutoSize = true;
            this.weapon.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weapon.Location = new System.Drawing.Point(53, 38);
            this.weapon.Name = "weapon";
            this.weapon.Size = new System.Drawing.Size(56, 16);
            this.weapon.TabIndex = 5;
            this.weapon.Text = "label9";
            this.weapon.Click += new System.EventHandler(this.heroStatus_Click);
            // 
            // hero_search
            // 
            this.hero_search.Location = new System.Drawing.Point(23, 246);
            this.hero_search.Name = "hero_search";
            this.hero_search.Size = new System.Drawing.Size(63, 23);
            this.hero_search.TabIndex = 12;
            this.hero_search.Text = "寻找";
            this.hero_search.UseVisualStyleBackColor = true;
            this.hero_search.Click += new System.EventHandler(this.hero_search_Click);
            // 
            // attack_aimless
            // 
            this.attack_aimless.Location = new System.Drawing.Point(90, 246);
            this.attack_aimless.Name = "attack_aimless";
            this.attack_aimless.Size = new System.Drawing.Size(63, 23);
            this.attack_aimless.TabIndex = 13;
            this.attack_aimless.Text = "乱打";
            this.attack_aimless.UseVisualStyleBackColor = true;
            this.attack_aimless.Click += new System.EventHandler(this.attack_aimless_Click);
            // 
            // after
            // 
            this.after.Location = new System.Drawing.Point(548, 123);
            this.after.Name = "after";
            this.after.Size = new System.Drawing.Size(53, 23);
            this.after.TabIndex = 14;
            this.after.Text = "下一个敌人";
            this.after.UseVisualStyleBackColor = true;
            this.after.Click += new System.EventHandler(this.after_Click);
            // 
            // before
            // 
            this.before.Location = new System.Drawing.Point(492, 123);
            this.before.Name = "before";
            this.before.Size = new System.Drawing.Size(53, 23);
            this.before.TabIndex = 15;
            this.before.Text = "上一个";
            this.before.UseVisualStyleBackColor = true;
            this.before.Click += new System.EventHandler(this.before_Click);
            // 
            // theBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 332);
            this.Controls.Add(this.before);
            this.Controls.Add(this.after);
            this.Controls.Add(this.attack_aimless);
            this.Controls.Add(this.hero_search);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.WinBtn);
            this.Controls.Add(this.chargeBtn);
            this.Controls.Add(this.escapeBtn);
            this.Controls.Add(this.waitBtn);
            this.Controls.Add(this.attackBtn);
            this.Controls.Add(this.Distence);
            this.Controls.Add(this.asasasa);
            this.Controls.Add(this.enemyLevel);
            this.Controls.Add(this.enemyStatus);
            this.Controls.Add(this.enemyVisable);
            this.Controls.Add(this.enemyLastAction);
            this.Controls.Add(this.heroLastAction);
            this.Controls.Add(this.heroVisable);
            this.Controls.Add(this.weapon);
            this.Controls.Add(this.heroStatus);
            this.Controls.Add(this.enemyName);
            this.Controls.Add(this.heroName);
            this.Controls.Add(this.moveTowardBtn);
            this.Controls.Add(this.fallBackBtn);
            this.Controls.Add(this.BattleMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "theBattle";
            this.Text = "theBattle";
            this.Load += new System.EventHandler(this.theBattle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox BattleMsg;
        private System.Windows.Forms.Button fallBackBtn;
        private System.Windows.Forms.Button moveTowardBtn;
        private System.Windows.Forms.Label heroName;
        private System.Windows.Forms.Label enemyName;
        private System.Windows.Forms.Label heroStatus;
        private System.Windows.Forms.Label enemyStatus;
        private System.Windows.Forms.Label heroVisable;
        private System.Windows.Forms.Label enemyVisable;
        private System.Windows.Forms.Label heroLastAction;
        private System.Windows.Forms.Label enemyLastAction;
        private System.Windows.Forms.Label asasasa;
        private System.Windows.Forms.Label Distence;
        private System.Windows.Forms.Button attackBtn;
        private System.Windows.Forms.Button escapeBtn;
        private System.Windows.Forms.Button chargeBtn;
        private System.Windows.Forms.Button waitBtn;
        private System.Windows.Forms.Button WinBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label enemyLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label weapon;
        private System.Windows.Forms.Button hero_search;
        private System.Windows.Forms.Button attack_aimless;
        private System.Windows.Forms.Button after;
        private System.Windows.Forms.Button before;
    }
}