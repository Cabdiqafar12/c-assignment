namespace assignment_four
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
            this.grppersonal = new System.Windows.Forms.GroupBox();
            this.grproom = new System.Windows.Forms.GroupBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.rdostan = new System.Windows.Forms.RadioButton();
            this.checkbreak = new System.Windows.Forms.CheckBox();
            this.rdonormal = new System.Windows.Forms.RadioButton();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdohight = new System.Windows.Forms.RadioButton();
            this.grpadditional = new System.Windows.Forms.GroupBox();
            this.txtnight = new System.Windows.Forms.TextBox();
            this.txtguest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grppersonal.SuspendLayout();
            this.grproom.SuspendLayout();
            this.grpadditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // grppersonal
            // 
            this.grppersonal.Controls.Add(this.txtguest);
            this.grppersonal.Controls.Add(this.txtnight);
            this.grppersonal.Controls.Add(this.label4);
            this.grppersonal.Controls.Add(this.label3);
            this.grppersonal.Controls.Add(this.label2);
            this.grppersonal.Controls.Add(this.label1);
            this.grppersonal.Controls.Add(this.txtage);
            this.grppersonal.Controls.Add(this.txtname);
            this.grppersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grppersonal.Location = new System.Drawing.Point(26, 93);
            this.grppersonal.Name = "grppersonal";
            this.grppersonal.Size = new System.Drawing.Size(626, 240);
            this.grppersonal.TabIndex = 0;
            this.grppersonal.TabStop = false;
            this.grppersonal.Text = "Personal Information ";
            this.grppersonal.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grproom
            // 
            this.grproom.Controls.Add(this.rdostan);
            this.grproom.Controls.Add(this.rdohight);
            this.grproom.Controls.Add(this.rdonormal);
            this.grproom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grproom.Location = new System.Drawing.Point(26, 339);
            this.grproom.Name = "grproom";
            this.grproom.Size = new System.Drawing.Size(626, 136);
            this.grproom.TabIndex = 1;
            this.grproom.TabStop = false;
            this.grproom.Text = "Room Type   :";
            this.grproom.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(314, 34);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(242, 38);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listbox1
            // 
            this.listbox1.FormattingEnabled = true;
            this.listbox1.ItemHeight = 20;
            this.listbox1.Location = new System.Drawing.Point(697, 116);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(428, 444);
            this.listbox1.TabIndex = 3;
            this.listbox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rdostan
            // 
            this.rdostan.AutoSize = true;
            this.rdostan.Location = new System.Drawing.Point(66, 69);
            this.rdostan.Name = "rdostan";
            this.rdostan.Size = new System.Drawing.Size(143, 33);
            this.rdostan.TabIndex = 4;
            this.rdostan.TabStop = true;
            this.rdostan.Text = "Standard";
            this.rdostan.UseVisualStyleBackColor = true;
            // 
            // checkbreak
            // 
            this.checkbreak.AutoSize = true;
            this.checkbreak.Location = new System.Drawing.Point(49, 46);
            this.checkbreak.Name = "checkbreak";
            this.checkbreak.Size = new System.Drawing.Size(456, 33);
            this.checkbreak.TabIndex = 5;
            this.checkbreak.Text = "Break fast (10 per guest per night)  :";
            this.checkbreak.UseVisualStyleBackColor = true;
            // 
            // rdonormal
            // 
            this.rdonormal.AutoSize = true;
            this.rdonormal.Location = new System.Drawing.Point(235, 69);
            this.rdonormal.Name = "rdonormal";
            this.rdonormal.Size = new System.Drawing.Size(123, 33);
            this.rdonormal.TabIndex = 5;
            this.rdonormal.TabStop = true;
            this.rdonormal.Text = "Normal";
            this.rdonormal.UseVisualStyleBackColor = true;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(314, 94);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(242, 38);
            this.txtage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Guest Name   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Guest age  :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(165, 605);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(163, 50);
            this.btncalc.TabIndex = 4;
            this.btncalc.Text = "Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(402, 605);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(163, 50);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(647, 605);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(163, 50);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of night   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of guest   :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rdohight
            // 
            this.rdohight.AutoSize = true;
            this.rdohight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdohight.Location = new System.Drawing.Point(416, 69);
            this.rdohight.Name = "rdohight";
            this.rdohight.Size = new System.Drawing.Size(99, 33);
            this.rdohight.TabIndex = 7;
            this.rdohight.TabStop = true;
            this.rdohight.Text = "Hight";
            this.rdohight.UseVisualStyleBackColor = true;
            // 
            // grpadditional
            // 
            this.grpadditional.Controls.Add(this.checkbreak);
            this.grpadditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpadditional.Location = new System.Drawing.Point(26, 481);
            this.grpadditional.Name = "grpadditional";
            this.grpadditional.Size = new System.Drawing.Size(626, 118);
            this.grpadditional.TabIndex = 8;
            this.grpadditional.TabStop = false;
            this.grpadditional.Text = "Additional Options  :";
            // 
            // txtnight
            // 
            this.txtnight.Location = new System.Drawing.Point(314, 149);
            this.txtnight.Multiline = true;
            this.txtnight.Name = "txtnight";
            this.txtnight.Size = new System.Drawing.Size(242, 38);
            this.txtnight.TabIndex = 10;
            // 
            // txtguest
            // 
            this.txtguest.Location = new System.Drawing.Point(314, 202);
            this.txtguest.Multiline = true;
            this.txtguest.Name = "txtguest";
            this.txtguest.Size = new System.Drawing.Size(242, 38);
            this.txtguest.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(238, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hotel Room Booking System ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1149, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpadditional);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.listbox1);
            this.Controls.Add(this.grproom);
            this.Controls.Add(this.grppersonal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grppersonal.ResumeLayout(false);
            this.grppersonal.PerformLayout();
            this.grproom.ResumeLayout(false);
            this.grproom.PerformLayout();
            this.grpadditional.ResumeLayout(false);
            this.grpadditional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grppersonal;
        private System.Windows.Forms.GroupBox grproom;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.RadioButton rdostan;
        private System.Windows.Forms.CheckBox checkbreak;
        private System.Windows.Forms.RadioButton rdonormal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdohight;
        private System.Windows.Forms.GroupBox grpadditional;
        private System.Windows.Forms.TextBox txtguest;
        private System.Windows.Forms.TextBox txtnight;
        private System.Windows.Forms.Label label5;
    }
}

