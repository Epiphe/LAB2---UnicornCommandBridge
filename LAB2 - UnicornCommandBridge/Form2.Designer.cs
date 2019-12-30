namespace LAB2___UnicornCommandBridge
{
    partial class Form2_Create
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
            this.textBoxLaggTillNamn = new System.Windows.Forms.TextBox();
            this.labelNamn = new System.Windows.Forms.Label();
            this.label_uniktId = new System.Windows.Forms.Label();
            this.textBoxLaggTillId = new System.Windows.Forms.TextBox();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLaggTillNamn
            // 
            this.textBoxLaggTillNamn.Location = new System.Drawing.Point(67, 16);
            this.textBoxLaggTillNamn.Name = "textBoxLaggTillNamn";
            this.textBoxLaggTillNamn.Size = new System.Drawing.Size(227, 20);
            this.textBoxLaggTillNamn.TabIndex = 0;
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Location = new System.Drawing.Point(14, 19);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(38, 13);
            this.labelNamn.TabIndex = 1;
            this.labelNamn.Text = "Namn:";
            // 
            // label_uniktId
            // 
            this.label_uniktId.AutoSize = true;
            this.label_uniktId.Location = new System.Drawing.Point(14, 45);
            this.label_uniktId.Name = "label_uniktId";
            this.label_uniktId.Size = new System.Drawing.Size(49, 13);
            this.label_uniktId.TabIndex = 3;
            this.label_uniktId.Text = "Unikt ID:";
            // 
            // textBoxLaggTillId
            // 
            this.textBoxLaggTillId.Location = new System.Drawing.Point(67, 42);
            this.textBoxLaggTillId.Name = "textBoxLaggTillId";
            this.textBoxLaggTillId.Size = new System.Drawing.Size(227, 20);
            this.textBoxLaggTillId.TabIndex = 2;
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(17, 68);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(75, 23);
            this.btnTillbaka.TabIndex = 4;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(219, 68);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(75, 23);
            this.btnSpara.TabIndex = 5;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // Form2_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 105);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.label_uniktId);
            this.Controls.Add(this.textBoxLaggTillId);
            this.Controls.Add(this.labelNamn);
            this.Controls.Add(this.textBoxLaggTillNamn);
            this.Name = "Form2_Create";
            this.Text = "Skapa/Lägga till";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLaggTillNamn;
        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.Label label_uniktId;
        private System.Windows.Forms.TextBox textBoxLaggTillId;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnSpara;
    }
}