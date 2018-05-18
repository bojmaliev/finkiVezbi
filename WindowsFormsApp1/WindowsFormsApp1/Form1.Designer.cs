namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbAvtobusi = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbDestinacii = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNajskapa = new System.Windows.Forms.TextBox();
            this.tbProsecna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автобуси";
            // 
            // lbAvtobusi
            // 
            this.lbAvtobusi.FormattingEnabled = true;
            this.lbAvtobusi.ItemHeight = 16;
            this.lbAvtobusi.Location = new System.Drawing.Point(15, 29);
            this.lbAvtobusi.Name = "lbAvtobusi";
            this.lbAvtobusi.Size = new System.Drawing.Size(280, 276);
            this.lbAvtobusi.TabIndex = 1;
            this.lbAvtobusi.SelectedIndexChanged += new System.EventHandler(this.lbAvtobusi_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Додади автобус";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbDestinacii
            // 
            this.lbDestinacii.FormattingEnabled = true;
            this.lbDestinacii.ItemHeight = 16;
            this.lbDestinacii.Location = new System.Drawing.Point(354, 29);
            this.lbDestinacii.Name = "lbDestinacii";
            this.lbDestinacii.Size = new System.Drawing.Size(280, 276);
            this.lbDestinacii.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Линии";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(15, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Избриши автобус";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(15, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Додади дестинација";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbProsecna);
            this.groupBox1.Controls.Add(this.tbNajskapa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(354, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информации";
            // 
            // tbNajskapa
            // 
            this.tbNajskapa.Location = new System.Drawing.Point(9, 36);
            this.tbNajskapa.Name = "tbNajskapa";
            this.tbNajskapa.ReadOnly = true;
            this.tbNajskapa.Size = new System.Drawing.Size(265, 22);
            this.tbNajskapa.TabIndex = 0;
            // 
            // tbProsecna
            // 
            this.tbProsecna.Location = new System.Drawing.Point(9, 83);
            this.tbProsecna.Name = "tbProsecna";
            this.tbProsecna.ReadOnly = true;
            this.tbProsecna.Size = new System.Drawing.Size(265, 22);
            this.tbProsecna.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Најскапа дестинација";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Просечна цена";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDestinacii);
            this.Controls.Add(this.lbAvtobusi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAvtobusi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbDestinacii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbProsecna;
        private System.Windows.Forms.TextBox tbNajskapa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

