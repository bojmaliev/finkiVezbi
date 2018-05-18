namespace WindowsFormsApp1
{
    partial class dodadiAvtobus
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
            this.components = new System.ComponentModel.Container();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLokalen = new System.Windows.Forms.CheckBox();
            this.tbRegistracija = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(12, 28);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(207, 22);
            this.tbIme.TabIndex = 1;
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име\r\n";
            // 
            // cbLokalen
            // 
            this.cbLokalen.AutoSize = true;
            this.cbLokalen.Location = new System.Drawing.Point(12, 101);
            this.cbLokalen.Name = "cbLokalen";
            this.cbLokalen.Size = new System.Drawing.Size(87, 21);
            this.cbLokalen.TabIndex = 3;
            this.cbLokalen.Text = "Локален";
            this.cbLokalen.UseVisualStyleBackColor = true;
            // 
            // tbRegistracija
            // 
            this.tbRegistracija.Location = new System.Drawing.Point(12, 73);
            this.tbRegistracija.Name = "tbRegistracija";
            this.tbRegistracija.Size = new System.Drawing.Size(207, 22);
            this.tbRegistracija.TabIndex = 2;
            this.tbRegistracija.Validating += new System.ComponentModel.CancelEventHandler(this.tbRegistracija_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Регистрација";
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(11, 128);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(120, 41);
            this.btnDodadi.TabIndex = 4;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(137, 128);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(120, 41);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dodadiAvtobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 196);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.cbLokalen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRegistracija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIme);
            this.Name = "dodadiAvtobus";
            this.Text = "Додади автобус";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbLokalen;
        private System.Windows.Forms.TextBox tbRegistracija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}