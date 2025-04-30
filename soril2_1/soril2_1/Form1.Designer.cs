namespace soril2_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTake7 = new System.Windows.Forms.Button();
            this.btnTake6 = new System.Windows.Forms.Button();
            this.btnTake5 = new System.Windows.Forms.Button();
            this.btnTake4 = new System.Windows.Forms.Button();
            this.btnTake3 = new System.Windows.Forms.Button();
            this.btnTake2 = new System.Windows.Forms.Button();
            this.btnTake1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRemainingDice = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "DICE GAME 2025";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(63, 670);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(157, 57);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Дахин эхлэх";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(63, 474);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(246, 170);
            this.txtLog.TabIndex = 13;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTake7);
            this.groupBox3.Controls.Add(this.btnTake6);
            this.groupBox3.Controls.Add(this.btnTake5);
            this.groupBox3.Controls.Add(this.btnTake4);
            this.groupBox3.Controls.Add(this.btnTake3);
            this.groupBox3.Controls.Add(this.btnTake2);
            this.groupBox3.Controls.Add(this.btnTake1);
            this.groupBox3.Location = new System.Drawing.Point(63, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 121);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Та хэдэн шоо авах вэ?";
            // 
            // btnTake7
            // 
            this.btnTake7.Location = new System.Drawing.Point(452, 34);
            this.btnTake7.Name = "btnTake7";
            this.btnTake7.Size = new System.Drawing.Size(58, 56);
            this.btnTake7.TabIndex = 6;
            this.btnTake7.Text = "7";
            this.btnTake7.UseVisualStyleBackColor = true;
            this.btnTake7.Click += new System.EventHandler(this.btnTake7_Click);
            // 
            // btnTake6
            // 
            this.btnTake6.Location = new System.Drawing.Point(379, 34);
            this.btnTake6.Name = "btnTake6";
            this.btnTake6.Size = new System.Drawing.Size(58, 56);
            this.btnTake6.TabIndex = 5;
            this.btnTake6.Text = "6";
            this.btnTake6.UseVisualStyleBackColor = true;
            this.btnTake6.Click += new System.EventHandler(this.btnTake6_Click);
            // 
            // btnTake5
            // 
            this.btnTake5.Location = new System.Drawing.Point(306, 34);
            this.btnTake5.Name = "btnTake5";
            this.btnTake5.Size = new System.Drawing.Size(58, 56);
            this.btnTake5.TabIndex = 4;
            this.btnTake5.Text = "5";
            this.btnTake5.UseVisualStyleBackColor = true;
            this.btnTake5.Click += new System.EventHandler(this.btnTake5_Click);
            // 
            // btnTake4
            // 
            this.btnTake4.Location = new System.Drawing.Point(233, 34);
            this.btnTake4.Name = "btnTake4";
            this.btnTake4.Size = new System.Drawing.Size(58, 56);
            this.btnTake4.TabIndex = 3;
            this.btnTake4.Text = "4";
            this.btnTake4.UseVisualStyleBackColor = true;
            this.btnTake4.Click += new System.EventHandler(this.btnTake4_Click);
            // 
            // btnTake3
            // 
            this.btnTake3.Location = new System.Drawing.Point(160, 34);
            this.btnTake3.Name = "btnTake3";
            this.btnTake3.Size = new System.Drawing.Size(58, 56);
            this.btnTake3.TabIndex = 2;
            this.btnTake3.Text = "3";
            this.btnTake3.UseVisualStyleBackColor = true;
            this.btnTake3.Click += new System.EventHandler(this.btnTake3_Click);
            // 
            // btnTake2
            // 
            this.btnTake2.Location = new System.Drawing.Point(90, 34);
            this.btnTake2.Name = "btnTake2";
            this.btnTake2.Size = new System.Drawing.Size(58, 56);
            this.btnTake2.TabIndex = 1;
            this.btnTake2.Text = "2";
            this.btnTake2.UseVisualStyleBackColor = true;
            this.btnTake2.Click += new System.EventHandler(this.btnTake2_Click);
            // 
            // btnTake1
            // 
            this.btnTake1.Location = new System.Drawing.Point(17, 34);
            this.btnTake1.Name = "btnTake1";
            this.btnTake1.Size = new System.Drawing.Size(58, 56);
            this.btnTake1.TabIndex = 0;
            this.btnTake1.Text = "1";
            this.btnTake1.UseVisualStyleBackColor = true;
            this.btnTake1.Click += new System.EventHandler(this.btnTake1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTurn);
            this.groupBox2.Location = new System.Drawing.Point(360, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 85);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тоглогчийн ээлж";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(71, 40);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(44, 16);
            this.lblTurn.TabIndex = 1;
            this.lblTurn.Text = "label2";
            this.lblTurn.Click += new System.EventHandler(this.lblTurn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRemainingDice);
            this.groupBox1.Location = new System.Drawing.Point(63, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Үлдсэн шоо";
            // 
            // lblRemainingDice
            // 
            this.lblRemainingDice.AutoSize = true;
            this.lblRemainingDice.Location = new System.Drawing.Point(71, 40);
            this.lblRemainingDice.Name = "lblRemainingDice";
            this.lblRemainingDice.Size = new System.Drawing.Size(44, 16);
            this.lblRemainingDice.TabIndex = 1;
            this.lblRemainingDice.Text = "label2";
            this.lblRemainingDice.Click += new System.EventHandler(this.lblRemainingDice_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(352, 474);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(247, 170);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "Hint";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Image = global::soril2_1.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(468, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 131);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(663, 796);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTake7;
        private System.Windows.Forms.Button btnTake6;
        private System.Windows.Forms.Button btnTake5;
        private System.Windows.Forms.Button btnTake4;
        private System.Windows.Forms.Button btnTake3;
        private System.Windows.Forms.Button btnTake2;
        private System.Windows.Forms.Button btnTake1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRemainingDice;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

