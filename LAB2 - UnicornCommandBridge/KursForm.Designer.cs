namespace LAB2___UnicornCommandBridge
{
    partial class KursForm
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
            this.kursID = new System.Windows.Forms.TextBox();
            this.KursNamn = new System.Windows.Forms.TextBox();
            this.btnLaggTillKurs = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.comboBoxAnsvLarare = new System.Windows.Forms.ComboBox();
            this.listBoxLarare = new System.Windows.Forms.ListBox();
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.comboBoxValjLarare = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLaggTillLarare = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLaggTillStudent = new System.Windows.Forms.Button();
            this.comboBoxValjStudent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurs ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ansvarig lärare:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Välj lärare";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kurs namn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Välj student";
            // 
            // kursID
            // 
            this.kursID.Location = new System.Drawing.Point(106, 10);
            this.kursID.Name = "kursID";
            this.kursID.Size = new System.Drawing.Size(157, 20);
            this.kursID.TabIndex = 6;
            // 
            // KursNamn
            // 
            this.KursNamn.Location = new System.Drawing.Point(106, 35);
            this.KursNamn.Name = "KursNamn";
            this.KursNamn.Size = new System.Drawing.Size(157, 20);
            this.KursNamn.TabIndex = 7;
            // 
            // btnLaggTillKurs
            // 
            this.btnLaggTillKurs.Location = new System.Drawing.Point(196, 458);
            this.btnLaggTillKurs.Name = "btnLaggTillKurs";
            this.btnLaggTillKurs.Size = new System.Drawing.Size(75, 23);
            this.btnLaggTillKurs.TabIndex = 12;
            this.btnLaggTillKurs.Text = "Spara";
            this.btnLaggTillKurs.UseVisualStyleBackColor = true;
            this.btnLaggTillKurs.Click += new System.EventHandler(this.btnLaggTillKurs_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(18, 458);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(75, 23);
            this.btnTillbaka.TabIndex = 13;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // comboBoxAnsvLarare
            // 
            this.comboBoxAnsvLarare.FormattingEnabled = true;
            this.comboBoxAnsvLarare.Location = new System.Drawing.Point(106, 61);
            this.comboBoxAnsvLarare.Name = "comboBoxAnsvLarare";
            this.comboBoxAnsvLarare.Size = new System.Drawing.Size(157, 21);
            this.comboBoxAnsvLarare.TabIndex = 14;
            // 
            // listBoxLarare
            // 
            this.listBoxLarare.FormattingEnabled = true;
            this.listBoxLarare.Location = new System.Drawing.Point(106, 169);
            this.listBoxLarare.Name = "listBoxLarare";
            this.listBoxLarare.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxLarare.Size = new System.Drawing.Size(157, 95);
            this.listBoxLarare.TabIndex = 15;
            this.listBoxLarare.SelectedIndexChanged += new System.EventHandler(this.listBoxLarare_SelectedIndexChanged);
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.Location = new System.Drawing.Point(106, 348);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxStudent.Size = new System.Drawing.Size(157, 95);
            this.listBoxStudent.TabIndex = 16;
            this.listBoxStudent.SelectedIndexChanged += new System.EventHandler(this.listBoxStudent_SelectedIndexChanged);
            // 
            // comboBoxValjLarare
            // 
            this.comboBoxValjLarare.FormattingEnabled = true;
            this.comboBoxValjLarare.Location = new System.Drawing.Point(106, 109);
            this.comboBoxValjLarare.Name = "comboBoxValjLarare";
            this.comboBoxValjLarare.Size = new System.Drawing.Size(157, 21);
            this.comboBoxValjLarare.TabIndex = 17;
            this.comboBoxValjLarare.SelectedIndexChanged += new System.EventHandler(this.comboBoxValjLarare_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Studenter på\r\nkursen.";
            // 
            // btnLaggTillLarare
            // 
            this.btnLaggTillLarare.Location = new System.Drawing.Point(106, 136);
            this.btnLaggTillLarare.Name = "btnLaggTillLarare";
            this.btnLaggTillLarare.Size = new System.Drawing.Size(157, 23);
            this.btnLaggTillLarare.TabIndex = 19;
            this.btnLaggTillLarare.Text = "Lägg till lärare";
            this.btnLaggTillLarare.UseVisualStyleBackColor = true;
            this.btnLaggTillLarare.Click += new System.EventHandler(this.btnLaggTillLarare_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Övriga lärare\r\ni kursen.";
            // 
            // btnLaggTillStudent
            // 
            this.btnLaggTillStudent.Location = new System.Drawing.Point(106, 319);
            this.btnLaggTillStudent.Name = "btnLaggTillStudent";
            this.btnLaggTillStudent.Size = new System.Drawing.Size(157, 23);
            this.btnLaggTillStudent.TabIndex = 22;
            this.btnLaggTillStudent.Text = "Lägg till student";
            this.btnLaggTillStudent.UseVisualStyleBackColor = true;
            this.btnLaggTillStudent.Click += new System.EventHandler(this.btnLaggTillStudent_Click);
            // 
            // comboBoxValjStudent
            // 
            this.comboBoxValjStudent.FormattingEnabled = true;
            this.comboBoxValjStudent.Location = new System.Drawing.Point(106, 292);
            this.comboBoxValjStudent.Name = "comboBoxValjStudent";
            this.comboBoxValjStudent.Size = new System.Drawing.Size(157, 21);
            this.comboBoxValjStudent.TabIndex = 21;
            this.comboBoxValjStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxValjStudent_SelectedIndexChanged);
            // 
            // KursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 503);
            this.Controls.Add(this.btnLaggTillStudent);
            this.Controls.Add(this.comboBoxValjStudent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLaggTillLarare);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxValjLarare);
            this.Controls.Add(this.listBoxStudent);
            this.Controls.Add(this.listBoxLarare);
            this.Controls.Add(this.comboBoxAnsvLarare);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnLaggTillKurs);
            this.Controls.Add(this.KursNamn);
            this.Controls.Add(this.kursID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KursForm";
            this.Text = "Lägga till kurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kursID;
        private System.Windows.Forms.TextBox KursNamn;
        private System.Windows.Forms.Button btnLaggTillKurs;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.ComboBox comboBoxAnsvLarare;
        private System.Windows.Forms.ListBox listBoxLarare;
        private System.Windows.Forms.ListBox listBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxValjLarare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLaggTillLarare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLaggTillStudent;
        private System.Windows.Forms.ComboBox comboBoxValjStudent;
    }
}