namespace assignment_one
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
            this.btnshow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdayofweek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdayofmonth = new System.Windows.Forms.TextBox();
            this.txtnumofmonth = new System.Windows.Forms.TextBox();
            this.txttheyear = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(115, 348);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(204, 61);
            this.btnshow.TabIndex = 0;
            this.btnshow.Text = "SHOW";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Day of the week";
            // 
            // txtdayofweek
            // 
            this.txtdayofweek.Location = new System.Drawing.Point(282, 41);
            this.txtdayofweek.Multiline = true;
            this.txtdayofweek.Name = "txtdayofweek";
            this.txtdayofweek.Size = new System.Drawing.Size(286, 45);
            this.txtdayofweek.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Day of the month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter numeric month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter the year";
            // 
            // txtdayofmonth
            // 
            this.txtdayofmonth.Location = new System.Drawing.Point(282, 92);
            this.txtdayofmonth.Multiline = true;
            this.txtdayofmonth.Name = "txtdayofmonth";
            this.txtdayofmonth.Size = new System.Drawing.Size(286, 45);
            this.txtdayofmonth.TabIndex = 6;
            // 
            // txtnumofmonth
            // 
            this.txtnumofmonth.Location = new System.Drawing.Point(282, 146);
            this.txtnumofmonth.Multiline = true;
            this.txtnumofmonth.Name = "txtnumofmonth";
            this.txtnumofmonth.Size = new System.Drawing.Size(286, 45);
            this.txtnumofmonth.TabIndex = 7;
            // 
            // txttheyear
            // 
            this.txttheyear.Location = new System.Drawing.Point(282, 197);
            this.txttheyear.Multiline = true;
            this.txttheyear.Name = "txttheyear";
            this.txttheyear.Size = new System.Drawing.Size(286, 45);
            this.txttheyear.TabIndex = 8;
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(115, 261);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(431, 48);
            this.lbloutput.TabIndex = 9;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(342, 348);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(204, 61);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txttheyear);
            this.Controls.Add(this.txtnumofmonth);
            this.Controls.Add(this.txtdayofmonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdayofweek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdayofweek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdayofmonth;
        private System.Windows.Forms.TextBox txtnumofmonth;
        private System.Windows.Forms.TextBox txttheyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnclear;
    }
}

