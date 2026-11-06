namespace Snake
{
    partial class Form1
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
            this.leftBTN = new System.Windows.Forms.Button();
            this.downBTN = new System.Windows.Forms.Button();
            this.upBTN = new System.Windows.Forms.Button();
            this.rightBTN = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.downrightBTN = new System.Windows.Forms.Button();
            this.uprightBTN = new System.Windows.Forms.Button();
            this.downleftBTN = new System.Windows.Forms.Button();
            this.upleftBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.levelLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLBL = new System.Windows.Forms.Label();
            this.pauseBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.modeLBL = new System.Windows.Forms.Label();
            this.timerLBL = new System.Windows.Forms.Label();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftBTN
            // 
            this.leftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBTN.Location = new System.Drawing.Point(307, 61);
            this.leftBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftBTN.Name = "leftBTN";
            this.leftBTN.Size = new System.Drawing.Size(35, 32);
            this.leftBTN.TabIndex = 1;
            this.leftBTN.Text = "🢀";
            this.leftBTN.UseVisualStyleBackColor = true;
            this.leftBTN.Click += new System.EventHandler(this.leftBTN_Click);
            // 
            // downBTN
            // 
            this.downBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downBTN.Location = new System.Drawing.Point(405, 105);
            this.downBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downBTN.Name = "downBTN";
            this.downBTN.Size = new System.Drawing.Size(35, 32);
            this.downBTN.TabIndex = 3;
            this.downBTN.Text = "🢃";
            this.downBTN.UseVisualStyleBackColor = true;
            this.downBTN.Click += new System.EventHandler(this.downBTN_Click);
            // 
            // upBTN
            // 
            this.upBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upBTN.Location = new System.Drawing.Point(405, 20);
            this.upBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upBTN.Name = "upBTN";
            this.upBTN.Size = new System.Drawing.Size(35, 31);
            this.upBTN.TabIndex = 4;
            this.upBTN.Text = "🢁";
            this.upBTN.UseVisualStyleBackColor = true;
            this.upBTN.Click += new System.EventHandler(this.upBTN_Click);
            // 
            // rightBTN
            // 
            this.rightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBTN.Location = new System.Drawing.Point(512, 61);
            this.rightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightBTN.Name = "rightBTN";
            this.rightBTN.Size = new System.Drawing.Size(35, 32);
            this.rightBTN.TabIndex = 5;
            this.rightBTN.Text = "🢂";
            this.rightBTN.UseVisualStyleBackColor = true;
            this.rightBTN.Click += new System.EventHandler(this.rightBTN_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.controlPanel.Controls.Add(this.downrightBTN);
            this.controlPanel.Controls.Add(this.uprightBTN);
            this.controlPanel.Controls.Add(this.downleftBTN);
            this.controlPanel.Controls.Add(this.upleftBTN);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.levelLBL);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.scoreLBL);
            this.controlPanel.Controls.Add(this.pauseBTN);
            this.controlPanel.Controls.Add(this.startBTN);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.modeLBL);
            this.controlPanel.Controls.Add(this.timerLBL);
            this.controlPanel.Controls.Add(this.upBTN);
            this.controlPanel.Controls.Add(this.leftBTN);
            this.controlPanel.Controls.Add(this.downBTN);
            this.controlPanel.Controls.Add(this.rightBTN);
            this.controlPanel.Location = new System.Drawing.Point(0, 407);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(791, 150);
            this.controlPanel.TabIndex = 18;
            // 
            // downrightBTN
            // 
            this.downrightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downrightBTN.Location = new System.Drawing.Point(477, 105);
            this.downrightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downrightBTN.Name = "downrightBTN";
            this.downrightBTN.Size = new System.Drawing.Size(35, 31);
            this.downrightBTN.TabIndex = 31;
            this.downrightBTN.Text = "🢆\r\n";
            this.downrightBTN.UseVisualStyleBackColor = true;
            this.downrightBTN.Click += new System.EventHandler(this.downrightBTN_Click);
            // 
            // uprightBTN
            // 
            this.uprightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uprightBTN.Location = new System.Drawing.Point(477, 20);
            this.uprightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uprightBTN.Name = "uprightBTN";
            this.uprightBTN.Size = new System.Drawing.Size(35, 31);
            this.uprightBTN.TabIndex = 30;
            this.uprightBTN.Text = "🢅";
            this.uprightBTN.UseVisualStyleBackColor = true;
            this.uprightBTN.Click += new System.EventHandler(this.uprightBTN_Click);
            // 
            // downleftBTN
            // 
            this.downleftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downleftBTN.Location = new System.Drawing.Point(343, 105);
            this.downleftBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downleftBTN.Name = "downleftBTN";
            this.downleftBTN.Size = new System.Drawing.Size(35, 31);
            this.downleftBTN.TabIndex = 29;
            this.downleftBTN.Text = "🢇";
            this.downleftBTN.UseVisualStyleBackColor = true;
            this.downleftBTN.Click += new System.EventHandler(this.downleftBTN_Click);
            // 
            // upleftBTN
            // 
            this.upleftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upleftBTN.Location = new System.Drawing.Point(343, 20);
            this.upleftBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upleftBTN.Name = "upleftBTN";
            this.upleftBTN.Size = new System.Drawing.Size(35, 31);
            this.upleftBTN.TabIndex = 28;
            this.upleftBTN.Text = "🢄\r\n";
            this.upleftBTN.UseVisualStyleBackColor = true;
            this.upleftBTN.Click += new System.EventHandler(this.upleftBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Level";
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.BackColor = System.Drawing.SystemColors.Control;
            this.levelLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.levelLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLBL.Location = new System.Drawing.Point(96, 20);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(72, 19);
            this.levelLBL.TabIndex = 26;
            this.levelLBL.Text = "levelLBL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Score";
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.BackColor = System.Drawing.SystemColors.Control;
            this.scoreLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLBL.Location = new System.Drawing.Point(96, 48);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(78, 19);
            this.scoreLBL.TabIndex = 24;
            this.scoreLBL.Text = "scoreLBL";
            // 
            // pauseBTN
            // 
            this.pauseBTN.Location = new System.Drawing.Point(624, 94);
            this.pauseBTN.Margin = new System.Windows.Forms.Padding(4);
            this.pauseBTN.Name = "pauseBTN";
            this.pauseBTN.Size = new System.Drawing.Size(100, 28);
            this.pauseBTN.TabIndex = 23;
            this.pauseBTN.Text = "End Game";
            this.pauseBTN.UseVisualStyleBackColor = true;
            this.pauseBTN.Click += new System.EventHandler(this.pauseBTN_Click);
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(624, 42);
            this.startBTN.Margin = new System.Windows.Forms.Padding(4);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(100, 28);
            this.startBTN.TabIndex = 22;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Timer";
            // 
            // modeLBL
            // 
            this.modeLBL.AutoSize = true;
            this.modeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLBL.Location = new System.Drawing.Point(365, 71);
            this.modeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modeLBL.Name = "modeLBL";
            this.modeLBL.Size = new System.Drawing.Size(75, 17);
            this.modeLBL.TabIndex = 6;
            this.modeLBL.Text = "modeLBL";
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.BackColor = System.Drawing.SystemColors.Control;
            this.timerLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLBL.Location = new System.Drawing.Point(96, 76);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(74, 19);
            this.timerLBL.TabIndex = 20;
            this.timerLBL.Text = "timerLBL";
            // 
            // boardPanel
            // 
            this.boardPanel.BackColor = System.Drawing.Color.Transparent;
            this.boardPanel.Location = new System.Drawing.Point(0, 41);
            this.boardPanel.Margin = new System.Windows.Forms.Padding(4);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(791, 360);
            this.boardPanel.TabIndex = 19;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(71, 12);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(146, 22);
            this.nameTB.TabIndex = 20;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.Genshin;
            this.ClientSize = new System.Drawing.Size(789, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.controlPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button leftBTN;
        private System.Windows.Forms.Button downBTN;
        private System.Windows.Forms.Button upBTN;
        private System.Windows.Forms.Button rightBTN;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label modeLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timerLBL;
        private System.Windows.Forms.Button pauseBTN;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.Button downrightBTN;
        private System.Windows.Forms.Button uprightBTN;
        private System.Windows.Forms.Button downleftBTN;
        private System.Windows.Forms.Button upleftBTN;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label4;
    }
}

