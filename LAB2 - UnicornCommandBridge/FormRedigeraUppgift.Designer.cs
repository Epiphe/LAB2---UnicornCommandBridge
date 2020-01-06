namespace LAB2___UnicornCommandBridge
{
    partial class FormRedigeraUppgift
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
            this.textBoxUppgiftNamn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.btnSparaUppgift = new System.Windows.Forms.Button();
            this.richTextBoxUppgiftsBeskrivning = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVisaKurser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxUppgiftNamn
            // 
            this.textBoxUppgiftNamn.Location = new System.Drawing.Point(91, 36);
            this.textBoxUppgiftNamn.Name = "textBoxUppgiftNamn";
            this.textBoxUppgiftNamn.Size = new System.Drawing.Size(144, 20);
            this.textBoxUppgiftNamn.TabIndex = 15;
            this.textBoxUppgiftNamn.TextChanged += new System.EventHandler(this.textBoxUppgiftNamn_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Uppgift namn:";
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(15, 218);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(75, 23);
            this.btnTillbaka.TabIndex = 13;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnSparaUppgift
            // 
            this.btnSparaUppgift.Location = new System.Drawing.Point(323, 218);
            this.btnSparaUppgift.Name = "btnSparaUppgift";
            this.btnSparaUppgift.Size = new System.Drawing.Size(75, 23);
            this.btnSparaUppgift.TabIndex = 12;
            this.btnSparaUppgift.Text = "Spara";
            this.btnSparaUppgift.UseVisualStyleBackColor = true;
            this.btnSparaUppgift.Click += new System.EventHandler(this.btnSparaUppgift_Click);
            // 
            // richTextBoxUppgiftsBeskrivning
            // 
            this.richTextBoxUppgiftsBeskrivning.Location = new System.Drawing.Point(15, 87);
            this.richTextBoxUppgiftsBeskrivning.Name = "richTextBoxUppgiftsBeskrivning";
            this.richTextBoxUppgiftsBeskrivning.Size = new System.Drawing.Size(384, 124);
            this.richTextBoxUppgiftsBeskrivning.TabIndex = 11;
            this.richTextBoxUppgiftsBeskrivning.Text = "";
            this.richTextBoxUppgiftsBeskrivning.TextChanged += new System.EventHandler(this.richTextBoxUppgiftsBeskrivning_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Uppgiftsbeskrivning:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Uppgifts ID:";
            // 
            // comboBoxVisaKurser
            // 
            this.comboBoxVisaKurser.FormattingEnabled = true;
            this.comboBoxVisaKurser.Location = new System.Drawing.Point(91, 6);
            this.comboBoxVisaKurser.Name = "comboBoxVisaKurser";
            this.comboBoxVisaKurser.Size = new System.Drawing.Size(144, 21);
            this.comboBoxVisaKurser.TabIndex = 30;
            this.comboBoxVisaKurser.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisaKurser_SelectedIndexChanged);
            // 
            // FormRedigeraUppgift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 255);
            this.Controls.Add(this.comboBoxVisaKurser);
            this.Controls.Add(this.textBoxUppgiftNamn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnSparaUppgift);
            this.Controls.Add(this.richTextBoxUppgiftsBeskrivning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRedigeraUppgift";
            this.Text = "Redigera uppgift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUppgiftNamn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnSparaUppgift;
        private System.Windows.Forms.RichTextBox richTextBoxUppgiftsBeskrivning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVisaKurser;
    }
}