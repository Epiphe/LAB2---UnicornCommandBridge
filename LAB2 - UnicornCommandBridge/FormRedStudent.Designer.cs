namespace LAB2___UnicornCommandBridge
{
    partial class FormRedStudentLarare
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
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.btnSparaRedStudent = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNamn = new System.Windows.Forms.Label();
            this.textBoxLaggTillNamn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnSparaRedLarare = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Betalt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(12, 188);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(75, 23);
            this.btnTillbaka.TabIndex = 15;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnSparaRedStudent
            // 
            this.btnSparaRedStudent.Location = new System.Drawing.Point(274, 58);
            this.btnSparaRedStudent.Name = "btnSparaRedStudent";
            this.btnSparaRedStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSparaRedStudent.TabIndex = 14;
            this.btnSparaRedStudent.Text = "Spara";
            this.btnSparaRedStudent.UseVisualStyleBackColor = true;
            this.btnSparaRedStudent.Click += new System.EventHandler(this.btnSparaRedStudent_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBoxValjStudent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Välj student";
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Location = new System.Drawing.Point(12, 35);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(38, 13);
            this.labelNamn.TabIndex = 17;
            this.labelNamn.Text = "Namn:";
            // 
            // textBoxLaggTillNamn
            // 
            this.textBoxLaggTillNamn.Location = new System.Drawing.Point(122, 32);
            this.textBoxLaggTillNamn.Name = "textBoxLaggTillNamn";
            this.textBoxLaggTillNamn.Size = new System.Drawing.Size(227, 20);
            this.textBoxLaggTillNamn.TabIndex = 16;
            this.textBoxLaggTillNamn.TextChanged += new System.EventHandler(this.textBoxRedStudentNamn);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Namn:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBoxRedLarernamn);
            // 
            // BtnSparaRedLarare
            // 
            this.BtnSparaRedLarare.Location = new System.Drawing.Point(274, 188);
            this.BtnSparaRedLarare.Name = "BtnSparaRedLarare";
            this.BtnSparaRedLarare.Size = new System.Drawing.Size(75, 23);
            this.BtnSparaRedLarare.TabIndex = 20;
            this.BtnSparaRedLarare.Text = "Spara";
            this.BtnSparaRedLarare.UseVisualStyleBackColor = true;
            this.BtnSparaRedLarare.Click += new System.EventHandler(this.BtnSparaRedLarare_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(227, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBoxValjLarare);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Välj lärare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nuvarande lön: ";
            // 
            // Betalt
            // 
            this.Betalt.AutoSize = true;
            this.Betalt.Location = new System.Drawing.Point(126, 162);
            this.Betalt.Name = "Betalt";
            this.Betalt.Size = new System.Drawing.Size(0, 13);
            this.Betalt.TabIndex = 25;
            // 
            // FormRedStudentLarare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 226);
            this.Controls.Add(this.Betalt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSparaRedLarare);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNamn);
            this.Controls.Add(this.textBoxLaggTillNamn);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnSparaRedStudent);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormRedStudentLarare";
            this.Text = "Redigera student/Lärare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnSparaRedStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.TextBox textBoxLaggTillNamn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnSparaRedLarare;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Betalt;
    }
}