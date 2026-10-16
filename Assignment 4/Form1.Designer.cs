namespace Assignment_4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpassname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtticket = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.rdofirst = new System.Windows.Forms.RadioButton();
            this.rdonormal = new System.Windows.Forms.RadioButton();
            this.rdobusiness = new System.Windows.Forms.RadioButton();
            this.checkInsurance = new System.Windows.Forms.CheckBox();
            this.bookingdetail = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtweight);
            this.groupBox1.Controls.Add(this.txtticket);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtpassname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdobusiness);
            this.groupBox2.Controls.Add(this.rdonormal);
            this.groupBox2.Controls.Add(this.rdofirst);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Travel Class";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkInsurance);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 131);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Option ";
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(116, 579);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(142, 56);
            this.btncalc.TabIndex = 3;
            this.btncalc.Text = "Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(310, 579);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(142, 56);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(502, 579);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(142, 56);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passenger Name  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Passenger Age  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of tickets :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Baggage weight (kg)  :";
            // 
            // txtpassname
            // 
            this.txtpassname.Location = new System.Drawing.Point(348, 39);
            this.txtpassname.Multiline = true;
            this.txtpassname.Name = "txtpassname";
            this.txtpassname.Size = new System.Drawing.Size(312, 33);
            this.txtpassname.TabIndex = 6;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(348, 95);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(312, 35);
            this.txtage.TabIndex = 10;
            // 
            // txtticket
            // 
            this.txtticket.Location = new System.Drawing.Point(348, 152);
            this.txtticket.Multiline = true;
            this.txtticket.Name = "txtticket";
            this.txtticket.Size = new System.Drawing.Size(312, 43);
            this.txtticket.TabIndex = 11;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(348, 219);
            this.txtweight.Multiline = true;
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(312, 40);
            this.txtweight.TabIndex = 12;
            // 
            // rdofirst
            // 
            this.rdofirst.AutoSize = true;
            this.rdofirst.Location = new System.Drawing.Point(63, 56);
            this.rdofirst.Name = "rdofirst";
            this.rdofirst.Size = new System.Drawing.Size(162, 33);
            this.rdofirst.TabIndex = 0;
            this.rdofirst.TabStop = true;
            this.rdofirst.Text = "First Class";
            this.rdofirst.UseVisualStyleBackColor = true;
            // 
            // rdonormal
            // 
            this.rdonormal.AutoSize = true;
            this.rdonormal.Location = new System.Drawing.Point(272, 56);
            this.rdonormal.Name = "rdonormal";
            this.rdonormal.Size = new System.Drawing.Size(181, 33);
            this.rdonormal.TabIndex = 1;
            this.rdonormal.TabStop = true;
            this.rdonormal.Text = "Nomal class";
            this.rdonormal.UseVisualStyleBackColor = true;
            // 
            // rdobusiness
            // 
            this.rdobusiness.AutoSize = true;
            this.rdobusiness.Location = new System.Drawing.Point(490, 56);
            this.rdobusiness.Name = "rdobusiness";
            this.rdobusiness.Size = new System.Drawing.Size(211, 33);
            this.rdobusiness.TabIndex = 2;
            this.rdobusiness.TabStop = true;
            this.rdobusiness.Text = "Business class";
            this.rdobusiness.UseVisualStyleBackColor = true;
            // 
            // checkInsurance
            // 
            this.checkInsurance.AutoSize = true;
            this.checkInsurance.Location = new System.Drawing.Point(47, 62);
            this.checkInsurance.Name = "checkInsurance";
            this.checkInsurance.Size = new System.Drawing.Size(429, 30);
            this.checkInsurance.TabIndex = 6;
            this.checkInsurance.Text = "Add Travel insurance (25$ per ticket)";
            this.checkInsurance.UseVisualStyleBackColor = true;
            // 
            // bookingdetail
            // 
            this.bookingdetail.FormattingEnabled = true;
            this.bookingdetail.ItemHeight = 20;
            this.bookingdetail.Location = new System.Drawing.Point(719, 21);
            this.bookingdetail.Name = "bookingdetail";
            this.bookingdetail.Size = new System.Drawing.Size(347, 484);
            this.bookingdetail.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 647);
            this.Controls.Add(this.bookingdetail);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtticket;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtpassname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdobusiness;
        private System.Windows.Forms.RadioButton rdonormal;
        private System.Windows.Forms.RadioButton rdofirst;
        private System.Windows.Forms.CheckBox checkInsurance;
        private System.Windows.Forms.ListBox bookingdetail;
    }
}

