namespace LAB2___UnicornCommandBridge
{
    partial class FormRedigeraKurs
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
            this.btnLaggTillKurs = new System.Windows.Forms.Button();
            this.txtBoxLaggTillKursNamn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKurser = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKursID = new System.Windows.Forms.TextBox();
            this.comboBoxAnsvLarare = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LaggTillListaStud = new System.Windows.Forms.Button();
            this.LaggTillListaLarare = new System.Windows.Forms.Button();
            this.listBoxLaggTillStud = new System.Windows.Forms.ListBox();
            this.comboBoxLaggTillStud = new System.Windows.Forms.ComboBox();
            this.listBoxLaggTillLarare = new System.Windows.Forms.ListBox();
            this.comboBoxLaggTillLarare = new System.Windows.Forms.ComboBox();
            this.comboBoxLaggTillUppgift = new System.Windows.Forms.ComboBox();
            this.SparaLaggTill = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxVisaUppgifterIKursen = new System.Windows.Forms.ComboBox();
            this.comboBoxVisaStudenterIKursen = new System.Windows.Forms.ComboBox();
            this.comboBoxVisaLarareIKursen = new System.Windows.Forms.ComboBox();
            this.btnRaderaValdData = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LaddaKurs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(15, 393);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(75, 23);
            this.btnTillbaka.TabIndex = 27;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnLaggTillKurs
            // 
            this.btnLaggTillKurs.Location = new System.Drawing.Point(181, 97);
            this.btnLaggTillKurs.Name = "btnLaggTillKurs";
            this.btnLaggTillKurs.Size = new System.Drawing.Size(75, 23);
            this.btnLaggTillKurs.TabIndex = 26;
            this.btnLaggTillKurs.Text = "Spara";
            this.btnLaggTillKurs.UseVisualStyleBackColor = true;
            this.btnLaggTillKurs.Click += new System.EventHandler(this.btnAndraKursEllerAnsvarigLarare_Click);
            // 
            // txtBoxLaggTillKursNamn
            // 
            this.txtBoxLaggTillKursNamn.Location = new System.Drawing.Point(95, 44);
            this.txtBoxLaggTillKursNamn.Name = "txtBoxLaggTillKursNamn";
            this.txtBoxLaggTillKursNamn.Size = new System.Drawing.Size(157, 20);
            this.txtBoxLaggTillKursNamn.TabIndex = 21;
            this.txtBoxLaggTillKursNamn.TextChanged += new System.EventHandler(this.txtBoxAndraKursNamn);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Uppgift:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Studenter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kurs namn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Övriga lärare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ansvarig lärare:";
            // 
            // comboBoxKurser
            // 
            this.comboBoxKurser.DisplayMember = "kursNamn";
            this.comboBoxKurser.FormattingEnabled = true;
            this.comboBoxKurser.Location = new System.Drawing.Point(110, 6);
            this.comboBoxKurser.Name = "comboBoxKurser";
            this.comboBoxKurser.Size = new System.Drawing.Size(157, 21);
            this.comboBoxKurser.TabIndex = 29;
            this.comboBoxKurser.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisaKurser_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Välj kurs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxKursID);
            this.groupBox1.Controls.Add(this.comboBoxAnsvLarare);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxLaggTillKursNamn);
            this.groupBox1.Controls.Add(this.btnLaggTillKurs);
            this.groupBox1.Location = new System.Drawing.Point(15, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 128);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ändra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kurs ID:";
            // 
            // textBoxKursID
            // 
            this.textBoxKursID.Location = new System.Drawing.Point(95, 18);
            this.textBoxKursID.Name = "textBoxKursID";
            this.textBoxKursID.Size = new System.Drawing.Size(157, 20);
            this.textBoxKursID.TabIndex = 28;
            // 
            // comboBoxAnsvLarare
            // 
            this.comboBoxAnsvLarare.FormattingEnabled = true;
            this.comboBoxAnsvLarare.Location = new System.Drawing.Point(95, 70);
            this.comboBoxAnsvLarare.Name = "comboBoxAnsvLarare";
            this.comboBoxAnsvLarare.Size = new System.Drawing.Size(157, 21);
            this.comboBoxAnsvLarare.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LaggTillListaStud);
            this.groupBox2.Controls.Add(this.LaggTillListaLarare);
            this.groupBox2.Controls.Add(this.listBoxLaggTillStud);
            this.groupBox2.Controls.Add(this.comboBoxLaggTillStud);
            this.groupBox2.Controls.Add(this.listBoxLaggTillLarare);
            this.groupBox2.Controls.Add(this.comboBoxLaggTillLarare);
            this.groupBox2.Controls.Add(this.comboBoxLaggTillUppgift);
            this.groupBox2.Controls.Add(this.SparaLaggTill);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(336, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 422);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lägg till";
            // 
            // LaggTillListaStud
            // 
            this.LaggTillListaStud.Location = new System.Drawing.Point(99, 318);
            this.LaggTillListaStud.Name = "LaggTillListaStud";
            this.LaggTillListaStud.Size = new System.Drawing.Size(157, 23);
            this.LaggTillListaStud.TabIndex = 34;
            this.LaggTillListaStud.Text = "Lägg till i lista";
            this.LaggTillListaStud.UseVisualStyleBackColor = true;
            this.LaggTillListaStud.Click += new System.EventHandler(this.LaggTillListaStud_Click);
            // 
            // LaggTillListaLarare
            // 
            this.LaggTillListaLarare.Location = new System.Drawing.Point(99, 150);
            this.LaggTillListaLarare.Name = "LaggTillListaLarare";
            this.LaggTillListaLarare.Size = new System.Drawing.Size(157, 23);
            this.LaggTillListaLarare.TabIndex = 33;
            this.LaggTillListaLarare.Text = "Lägg till i lista";
            this.LaggTillListaLarare.UseVisualStyleBackColor = true;
            this.LaggTillListaLarare.Click += new System.EventHandler(this.LaggTillListaLarare_Click);
            // 
            // listBoxLaggTillStud
            // 
            this.listBoxLaggTillStud.FormattingEnabled = true;
            this.listBoxLaggTillStud.Location = new System.Drawing.Point(99, 217);
            this.listBoxLaggTillStud.Name = "listBoxLaggTillStud";
            this.listBoxLaggTillStud.Size = new System.Drawing.Size(157, 95);
            this.listBoxLaggTillStud.TabIndex = 32;
            // 
            // comboBoxLaggTillStud
            // 
            this.comboBoxLaggTillStud.FormattingEnabled = true;
            this.comboBoxLaggTillStud.Location = new System.Drawing.Point(99, 190);
            this.comboBoxLaggTillStud.Name = "comboBoxLaggTillStud";
            this.comboBoxLaggTillStud.Size = new System.Drawing.Size(157, 21);
            this.comboBoxLaggTillStud.TabIndex = 31;
            // 
            // listBoxLaggTillLarare
            // 
            this.listBoxLaggTillLarare.FormattingEnabled = true;
            this.listBoxLaggTillLarare.Location = new System.Drawing.Point(99, 49);
            this.listBoxLaggTillLarare.Name = "listBoxLaggTillLarare";
            this.listBoxLaggTillLarare.Size = new System.Drawing.Size(157, 95);
            this.listBoxLaggTillLarare.TabIndex = 30;
            // 
            // comboBoxLaggTillLarare
            // 
            this.comboBoxLaggTillLarare.FormattingEnabled = true;
            this.comboBoxLaggTillLarare.Location = new System.Drawing.Point(99, 22);
            this.comboBoxLaggTillLarare.Name = "comboBoxLaggTillLarare";
            this.comboBoxLaggTillLarare.Size = new System.Drawing.Size(157, 21);
            this.comboBoxLaggTillLarare.TabIndex = 29;
            // 
            // comboBoxLaggTillUppgift
            // 
            this.comboBoxLaggTillUppgift.FormattingEnabled = true;
            this.comboBoxLaggTillUppgift.Location = new System.Drawing.Point(99, 357);
            this.comboBoxLaggTillUppgift.Name = "comboBoxLaggTillUppgift";
            this.comboBoxLaggTillUppgift.Size = new System.Drawing.Size(157, 21);
            this.comboBoxLaggTillUppgift.TabIndex = 28;
            // 
            // SparaLaggTill
            // 
            this.SparaLaggTill.Location = new System.Drawing.Point(181, 384);
            this.SparaLaggTill.Name = "SparaLaggTill";
            this.SparaLaggTill.Size = new System.Drawing.Size(75, 23);
            this.SparaLaggTill.TabIndex = 27;
            this.SparaLaggTill.Text = "Spara";
            this.SparaLaggTill.UseVisualStyleBackColor = true;
            this.SparaLaggTill.Click += new System.EventHandler(this.btnSparaLaggaTillAndraKurs_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxVisaUppgifterIKursen);
            this.groupBox3.Controls.Add(this.comboBoxVisaStudenterIKursen);
            this.groupBox3.Controls.Add(this.comboBoxVisaLarareIKursen);
            this.groupBox3.Controls.Add(this.btnRaderaValdData);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(15, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 154);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ta bort";
            // 
            // comboBoxVisaUppgifterIKursen
            // 
            this.comboBoxVisaUppgifterIKursen.FormattingEnabled = true;
            this.comboBoxVisaUppgifterIKursen.Location = new System.Drawing.Point(95, 89);
            this.comboBoxVisaUppgifterIKursen.Name = "comboBoxVisaUppgifterIKursen";
            this.comboBoxVisaUppgifterIKursen.Size = new System.Drawing.Size(157, 21);
            this.comboBoxVisaUppgifterIKursen.TabIndex = 35;
            this.comboBoxVisaUppgifterIKursen.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisaUppgifterIKursen_SelectedIndexChanged);
            // 
            // comboBoxVisaStudenterIKursen
            // 
            this.comboBoxVisaStudenterIKursen.FormattingEnabled = true;
            this.comboBoxVisaStudenterIKursen.Location = new System.Drawing.Point(95, 57);
            this.comboBoxVisaStudenterIKursen.Name = "comboBoxVisaStudenterIKursen";
            this.comboBoxVisaStudenterIKursen.Size = new System.Drawing.Size(157, 21);
            this.comboBoxVisaStudenterIKursen.TabIndex = 34;
            this.comboBoxVisaStudenterIKursen.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisaStudenterIKursen_SelectedIndexChanged);
            // 
            // comboBoxVisaLarareIKursen
            // 
            this.comboBoxVisaLarareIKursen.FormattingEnabled = true;
            this.comboBoxVisaLarareIKursen.Location = new System.Drawing.Point(95, 22);
            this.comboBoxVisaLarareIKursen.Name = "comboBoxVisaLarareIKursen";
            this.comboBoxVisaLarareIKursen.Size = new System.Drawing.Size(157, 21);
            this.comboBoxVisaLarareIKursen.TabIndex = 33;
            this.comboBoxVisaLarareIKursen.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisaLarareIKursen_SelectedIndexChanged);
            // 
            // btnRaderaValdData
            // 
            this.btnRaderaValdData.Location = new System.Drawing.Point(181, 118);
            this.btnRaderaValdData.Name = "btnRaderaValdData";
            this.btnRaderaValdData.Size = new System.Drawing.Size(75, 23);
            this.btnRaderaValdData.TabIndex = 27;
            this.btnRaderaValdData.Text = "Radera";
            this.btnRaderaValdData.UseVisualStyleBackColor = true;
            this.btnRaderaValdData.Click += new System.EventHandler(this.btnRaderaValdData_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Övriga lärare:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Studenter:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Uppgift:";
            // 
            // LaddaKurs
            // 
            this.LaddaKurs.Location = new System.Drawing.Point(110, 33);
            this.LaddaKurs.Name = "LaddaKurs";
            this.LaddaKurs.Size = new System.Drawing.Size(157, 23);
            this.LaddaKurs.TabIndex = 33;
            this.LaddaKurs.Text = "Ladda in kurs";
            this.LaddaKurs.UseVisualStyleBackColor = true;
            this.LaddaKurs.Click += new System.EventHandler(this.LaddaKurs_Click);
            // 
            // FormRedigeraKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 459);
            this.Controls.Add(this.LaddaKurs);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxKurser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTillbaka);
            this.Name = "FormRedigeraKurs";
            this.Text = "Form Redigera Kurs";
            this.Load += new System.EventHandler(this.FormRedigeraKurs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnLaggTillKurs;
        private System.Windows.Forms.TextBox txtBoxLaggTillKursNamn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKurser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SparaLaggTill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxVisaUppgifterIKursen;
        private System.Windows.Forms.ComboBox comboBoxVisaStudenterIKursen;
        private System.Windows.Forms.ComboBox comboBoxVisaLarareIKursen;
        private System.Windows.Forms.Button btnRaderaValdData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxAnsvLarare;
        private System.Windows.Forms.ListBox listBoxLaggTillStud;
        private System.Windows.Forms.ComboBox comboBoxLaggTillStud;
        private System.Windows.Forms.ListBox listBoxLaggTillLarare;
        private System.Windows.Forms.ComboBox comboBoxLaggTillLarare;
        private System.Windows.Forms.ComboBox comboBoxLaggTillUppgift;
        private System.Windows.Forms.Button LaggTillListaStud;
        private System.Windows.Forms.Button LaggTillListaLarare;
        private System.Windows.Forms.Button LaddaKurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKursID;
    }
}