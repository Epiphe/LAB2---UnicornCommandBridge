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
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Övriga lärare:";
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
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Studenter:";
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
            this.btnLaggTillKurs.Location = new System.Drawing.Point(188, 309);
            this.btnLaggTillKurs.Name = "btnLaggTillKurs";
            this.btnLaggTillKurs.Size = new System.Drawing.Size(75, 23);
            this.btnLaggTillKurs.TabIndex = 12;
            this.btnLaggTillKurs.Text = "Spara";
            this.btnLaggTillKurs.UseVisualStyleBackColor = true;
            this.btnLaggTillKurs.Click += new System.EventHandler(this.btnLaggTillKurs_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(12, 309);
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
            this.listBoxLarare.Location = new System.Drawing.Point(106, 88);
            this.listBoxLarare.Name = "listBoxLarare";
            this.listBoxLarare.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxLarare.Size = new System.Drawing.Size(157, 95);
            this.listBoxLarare.TabIndex = 15;
            this.listBoxLarare.SelectedIndexChanged += new System.EventHandler(this.listBoxLarare_SelectedIndexChanged);
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.Location = new System.Drawing.Point(106, 189);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxStudent.Size = new System.Drawing.Size(157, 95);
            this.listBoxStudent.TabIndex = 16;
            this.listBoxStudent.SelectedIndexChanged += new System.EventHandler(this.listBoxStudent_SelectedIndexChanged);
            // 
            // KursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 351);
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
    }
}