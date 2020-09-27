namespace orderprocessing
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
            this.lblOutPut = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.rdb6 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdbOne = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Order Processing";
            // 
            // lblOutPut
            // 
            this.lblOutPut.AutoSize = true;
            this.lblOutPut.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutPut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblOutPut.Location = new System.Drawing.Point(43, 404);
            this.lblOutPut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(2, 19);
            this.lblOutPut.TabIndex = 32;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(202, 325);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(179, 29);
            this.btnProcess.TabIndex = 31;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // rdb6
            // 
            this.rdb6.AutoSize = true;
            this.rdb6.Location = new System.Drawing.Point(202, 278);
            this.rdb6.Margin = new System.Windows.Forms.Padding(2);
            this.rdb6.Name = "rdb6";
            this.rdb6.Size = new System.Drawing.Size(175, 17);
            this.rdb6.TabIndex = 30;
            this.rdb6.TabStop = true;
            this.rdb6.Text = "5. Video Payment(Learn To Ski)";
            this.rdb6.UseVisualStyleBackColor = true;
            this.rdb6.CheckedChanged += new System.EventHandler(this.rdb6_CheckedChanged);
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(202, 233);
            this.rdb4.Margin = new System.Windows.Forms.Padding(2);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(158, 17);
            this.rdb4.TabIndex = 29;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "4.  Membership Upgradation";
            this.rdb4.UseVisualStyleBackColor = true;
            this.rdb4.CheckedChanged += new System.EventHandler(this.rdb4_CheckedChanged);
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(202, 184);
            this.rdb3.Margin = new System.Windows.Forms.Padding(2);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(147, 17);
            this.rdb3.TabIndex = 28;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "3.  Membership Activation";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.CheckedChanged += new System.EventHandler(this.rdb3_CheckedChanged);
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(202, 141);
            this.rdb2.Margin = new System.Windows.Forms.Padding(2);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(109, 17);
            this.rdb2.TabIndex = 27;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "2.  Book Payment";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // rdbOne
            // 
            this.rdbOne.AutoSize = true;
            this.rdbOne.Location = new System.Drawing.Point(202, 97);
            this.rdbOne.Margin = new System.Windows.Forms.Padding(2);
            this.rdbOne.Name = "rdbOne";
            this.rdbOne.Size = new System.Drawing.Size(163, 17);
            this.rdbOne.TabIndex = 26;
            this.rdbOne.TabStop = true;
            this.rdbOne.Text = "1.  Physical Product Payment";
            this.rdbOne.UseVisualStyleBackColor = true;
            this.rdbOne.CheckedChanged += new System.EventHandler(this.rdbOne_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.rdb6);
            this.Controls.Add(this.rdb4);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdbOne);
            this.Name = "Form1";
            this.Text = "Order Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.RadioButton rdb6;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdbOne;
    }
}