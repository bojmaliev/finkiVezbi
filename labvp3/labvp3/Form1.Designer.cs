namespace labvp3
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
            this.components = new System.ComponentModel.Container();
            this.tbIgrac = new System.Windows.Forms.TextBox();
            this.tbOp1 = new System.Windows.Forms.TextBox();
            this.tbOp = new System.Windows.Forms.TextBox();
            this.tbOp2 = new System.Windows.Forms.TextBox();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIgraci = new System.Windows.Forms.Button();
            this.btnCao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbIgrac
            // 
            this.tbIgrac.Location = new System.Drawing.Point(12, 12);
            this.tbIgrac.Name = "tbIgrac";
            this.tbIgrac.Size = new System.Drawing.Size(100, 22);
            this.tbIgrac.TabIndex = 0;
            // 
            // tbOp1
            // 
            this.tbOp1.Location = new System.Drawing.Point(12, 70);
            this.tbOp1.Name = "tbOp1";
            this.tbOp1.ReadOnly = true;
            this.tbOp1.Size = new System.Drawing.Size(100, 22);
            this.tbOp1.TabIndex = 0;
            // 
            // tbOp
            // 
            this.tbOp.Location = new System.Drawing.Point(118, 70);
            this.tbOp.Name = "tbOp";
            this.tbOp.ReadOnly = true;
            this.tbOp.Size = new System.Drawing.Size(66, 22);
            this.tbOp.TabIndex = 0;
            // 
            // tbOp2
            // 
            this.tbOp2.Location = new System.Drawing.Point(190, 71);
            this.tbOp2.Name = "tbOp2";
            this.tbOp2.ReadOnly = true;
            this.tbOp2.Size = new System.Drawing.Size(100, 22);
            this.tbOp2.TabIndex = 0;
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(321, 70);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.Size = new System.Drawing.Size(100, 22);
            this.tbRezultat.TabIndex = 0;
            this.tbRezultat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRezultat_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "nova igra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 163);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(522, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 229);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(522, 23);
            this.progressBar2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label1";
            // 
            // btnIgraci
            // 
            this.btnIgraci.Location = new System.Drawing.Point(190, 320);
            this.btnIgraci.Name = "btnIgraci";
            this.btnIgraci.Size = new System.Drawing.Size(87, 40);
            this.btnIgraci.TabIndex = 4;
            this.btnIgraci.Text = "Igraci";
            this.btnIgraci.UseVisualStyleBackColor = true;
            this.btnIgraci.Click += new System.EventHandler(this.btnIgraci_Click);
            // 
            // btnCao
            // 
            this.btnCao.Location = new System.Drawing.Point(335, 306);
            this.btnCao.Name = "btnCao";
            this.btnCao.Size = new System.Drawing.Size(164, 97);
            this.btnCao.TabIndex = 5;
            this.btnCao.Text = "Cao";
            this.btnCao.UseVisualStyleBackColor = true;
            this.btnCao.Click += new System.EventHandler(this.btnCao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.btnCao);
            this.Controls.Add(this.btnIgraci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbRezultat);
            this.Controls.Add(this.tbOp2);
            this.Controls.Add(this.tbOp);
            this.Controls.Add(this.tbOp1);
            this.Controls.Add(this.tbIgrac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIgrac;
        private System.Windows.Forms.TextBox tbOp1;
        private System.Windows.Forms.TextBox tbOp;
        private System.Windows.Forms.TextBox tbOp2;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIgraci;
        private System.Windows.Forms.Button btnCao;
    }
}

