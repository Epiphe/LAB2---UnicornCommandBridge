namespace LAB2___UnicornCommandBridge
{
    partial class FormUppgift
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
            this.txtBoxUppgiftsID = new System.Windows.Forms.TextBox();
            this.richTextBoxUppgiftsBeskrivning = new System.Windows.Forms.RichTextBox();
            this.btnSparaUppgift = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uppgifts ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uppgiftsbeskrivning:";
            // 
            // txtBoxUppgiftsID
            // 
            this.txtBoxUppgiftsID.Location = new System.Drawing.Point(83, 12);
            this.txtBoxUppgiftsID.Name = "txtBoxUppgiftsID";
            this.txtBoxUppgiftsID.Size = new System.Drawing.Size(144, 20);
            this.txtBoxUppgiftsID.TabIndex = 2;
            // 
            // richTextBoxUppgiftsBeskrivning
            // 
            this.richTextBoxUppgiftsBeskrivning.Location = new System.Drawing.Point(17, 55);
            this.richTextBoxUppgiftsBeskrivning.Name = "richTextBoxUppgiftsBeskrivning";
            this.richTextBoxUppgiftsBeskrivning.Size = new System.Drawing.Size(384, 163);
            this.richTextBoxUppgiftsBeskrivning.TabIndex = 3;
            this.richTextBoxUppgiftsBeskrivning.Text = "";
            this.richTextBoxUppgiftsBeskrivning.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnSparaUppgift
            // 
            this.btnSparaUppgift.Location = new System.Drawing.Point(325, 225);
            this.btnSparaUppgift.Name = "btnSparaUppgift";
            this.btnSparaUppgift.Size = new System.Drawing.Size(75, 23);
            this.btnSparaUppgift.TabIndex = 4;
            this.btnSparaUppgift.Text = "Spara";
            this.btnSparaUppgift.UseVisualStyleBackColor = true;
            this.btnSparaUppgift.Click += new System.EventHandler(this.btnSparaUppgift_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(17, 225);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(75, 23);
            this.btnTillbaka.TabIndex = 5;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // FormUppgift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 269);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnSparaUppgift);
            this.Controls.Add(this.richTextBoxUppgiftsBeskrivning);
            this.Controls.Add(this.txtBoxUppgiftsID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUppgift";
            this.Text = "Lägga in uppgift";
            this.Load += new System.EventHandler(this.FormUppgift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUppgiftsID;
        private System.Windows.Forms.RichTextBox richTextBoxUppgiftsBeskrivning;
        private System.Windows.Forms.Button btnSparaUppgift;
        private System.Windows.Forms.Button btnTillbaka;
    }
}