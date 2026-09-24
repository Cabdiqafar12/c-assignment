namespace assignment_two
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbloutputass = new System.Windows.Forms.Label();
            this.txtofstudent = new System.Windows.Forms.TextBox();
            this.txtofstuID = new System.Windows.Forms.TextBox();
            this.txtofdepat = new System.Windows.Forms.TextBox();
            this.txtofsem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the student ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter the department";
            // 
            // lbloutputass
            // 
            this.lbloutputass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutputass.Location = new System.Drawing.Point(140, 295);
            this.lbloutputass.Name = "lbloutputass";
            this.lbloutputass.Size = new System.Drawing.Size(468, 54);
            this.lbloutputass.TabIndex = 4;
            // 
            // txtofstudent
            // 
            this.txtofstudent.Location = new System.Drawing.Point(367, 93);
            this.txtofstudent.Multiline = true;
            this.txtofstudent.Name = "txtofstudent";
            this.txtofstudent.Size = new System.Drawing.Size(293, 38);
            this.txtofstudent.TabIndex = 5;
            this.txtofstudent.TextChanged += new System.EventHandler(this.txtofstudent_TextChanged);
            // 
            // txtofstuID
            // 
            this.txtofstuID.Location = new System.Drawing.Point(367, 137);
            this.txtofstuID.Multiline = true;
            this.txtofstuID.Name = "txtofstuID";
            this.txtofstuID.Size = new System.Drawing.Size(293, 38);
            this.txtofstuID.TabIndex = 6;
            this.txtofstuID.TextChanged += new System.EventHandler(this.txtofstuID_TextChanged);
            // 
            // txtofdepat
            // 
            this.txtofdepat.Location = new System.Drawing.Point(367, 181);
            this.txtofdepat.Multiline = true;
            this.txtofdepat.Name = "txtofdepat";
            this.txtofdepat.Size = new System.Drawing.Size(293, 39);
            this.txtofdepat.TabIndex = 7;
            // 
            // txtofsem
            // 
            this.txtofsem.Location = new System.Drawing.Point(367, 226);
            this.txtofsem.Multiline = true;
            this.txtofsem.Name = "txtofsem";
            this.txtofsem.Size = new System.Drawing.Size(293, 42);
            this.txtofsem.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Enter the semester";
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(104, 375);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(177, 45);
            this.btnshow.TabIndex = 10;
            this.btnshow.Text = "Show Information";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(304, 375);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(175, 45);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(505, 375);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(170, 45);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 505);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtofsem);
            this.Controls.Add(this.txtofdepat);
            this.Controls.Add(this.txtofstuID);
            this.Controls.Add(this.txtofstudent);
            this.Controls.Add(this.lbloutputass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbloutputass;
        private System.Windows.Forms.TextBox txtofstudent;
        private System.Windows.Forms.TextBox txtofstuID;
        private System.Windows.Forms.TextBox txtofdepat;
        private System.Windows.Forms.TextBox txtofsem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

