namespace StatePattern
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMoneyAmount = new System.Windows.Forms.Label();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.labelWinBoxVal = new System.Windows.Forms.Label();
            this.labelWinBoxText = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make a try";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 87);
            this.button2.TabIndex = 1;
            this.button2.Text = "Put some money";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(328, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(439, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(542, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 69);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(683, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "You put:";
            // 
            // labelMoneyAmount
            // 
            this.labelMoneyAmount.AutoSize = true;
            this.labelMoneyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoneyAmount.Location = new System.Drawing.Point(806, 146);
            this.labelMoneyAmount.Name = "labelMoneyAmount";
            this.labelMoneyAmount.Size = new System.Drawing.Size(26, 29);
            this.labelMoneyAmount.TabIndex = 7;
            this.labelMoneyAmount.Text = "0";
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInfo.Location = new System.Drawing.Point(294, 48);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(353, 29);
            this.LabelInfo.TabIndex = 8;
            this.LabelInfo.Text = "Put some money and make a try";
            // 
            // labelWinBoxVal
            // 
            this.labelWinBoxVal.AutoSize = true;
            this.labelWinBoxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWinBoxVal.Location = new System.Drawing.Point(201, 237);
            this.labelWinBoxVal.Name = "labelWinBoxVal";
            this.labelWinBoxVal.Size = new System.Drawing.Size(26, 29);
            this.labelWinBoxVal.TabIndex = 10;
            this.labelWinBoxVal.Text = "0";
            // 
            // labelWinBoxText
            // 
            this.labelWinBoxText.AutoSize = true;
            this.labelWinBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWinBoxText.Location = new System.Drawing.Point(93, 176);
            this.labelWinBoxText.Name = "labelWinBoxText";
            this.labelWinBoxText.Size = new System.Drawing.Size(130, 29);
            this.labelWinBoxText.TabIndex = 9;
            this.labelWinBoxText.Text = "Money box";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(851, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 115);
            this.button3.TabIndex = 11;
            this.button3.Text = "Get money back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 29);
            this.button4.TabIndex = 12;
            this.button4.Text = "Take money";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 396);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelWinBoxVal);
            this.Controls.Add(this.labelWinBoxText);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.labelMoneyAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMoneyAmount;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Label labelWinBoxVal;
        private System.Windows.Forms.Label labelWinBoxText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        



    }
}

