namespace Lab3VP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPica3 = new System.Windows.Forms.TextBox();
            this.tbPica2 = new System.Windows.Forms.TextBox();
            this.tbPica1 = new System.Windows.Forms.TextBox();
            this.rbGolema = new System.Windows.Forms.RadioButton();
            this.rbSredna = new System.Windows.Forms.RadioButton();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbD3 = new System.Windows.Forms.CheckBox();
            this.cbD2 = new System.Windows.Forms.CheckBox();
            this.cbD1 = new System.Windows.Forms.CheckBox();
            this.tbDodatok3 = new System.Windows.Forms.TextBox();
            this.tbDodatok2 = new System.Windows.Forms.TextBox();
            this.tbDodatok1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPijalok3vkupno = new System.Windows.Forms.TextBox();
            this.tbPijalok2vkupno = new System.Windows.Forms.TextBox();
            this.tbPijalok3cen = new System.Windows.Forms.TextBox();
            this.tbPijalok2cen = new System.Windows.Forms.TextBox();
            this.tbPijalok1vkupno = new System.Windows.Forms.TextBox();
            this.tbPijalok3kol = new System.Windows.Forms.TextBox();
            this.tbPijalok1cen = new System.Windows.Forms.TextBox();
            this.tbPijalok2kol = new System.Windows.Forms.TextBox();
            this.tbPijalok1kol = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCenaDesert = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbVrakanje = new System.Windows.Forms.TextBox();
            this.tbNaplateno = new System.Windows.Forms.TextBox();
            this.tbVkupno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPica3);
            this.groupBox1.Controls.Add(this.tbPica2);
            this.groupBox1.Controls.Add(this.tbPica1);
            this.groupBox1.Controls.Add(this.rbGolema);
            this.groupBox1.Controls.Add(this.rbSredna);
            this.groupBox1.Controls.Add(this.rbMala);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Големина";
            // 
            // tbPica3
            // 
            this.tbPica3.Location = new System.Drawing.Point(204, 98);
            this.tbPica3.Name = "tbPica3";
            this.tbPica3.Size = new System.Drawing.Size(100, 22);
            this.tbPica3.TabIndex = 5;
            this.tbPica3.Text = "500";
            this.tbPica3.TextChanged += new System.EventHandler(this.tbPica3_TextChanged);
            // 
            // tbPica2
            // 
            this.tbPica2.Location = new System.Drawing.Point(204, 60);
            this.tbPica2.Name = "tbPica2";
            this.tbPica2.Size = new System.Drawing.Size(100, 22);
            this.tbPica2.TabIndex = 4;
            this.tbPica2.Text = "300";
            this.tbPica2.TextChanged += new System.EventHandler(this.tbPica2_TextChanged);
            // 
            // tbPica1
            // 
            this.tbPica1.Location = new System.Drawing.Point(204, 20);
            this.tbPica1.Name = "tbPica1";
            this.tbPica1.Size = new System.Drawing.Size(100, 22);
            this.tbPica1.TabIndex = 3;
            this.tbPica1.Text = "200";
            this.tbPica1.TextChanged += new System.EventHandler(this.tbPica1_TextChanged);
            // 
            // rbGolema
            // 
            this.rbGolema.AutoSize = true;
            this.rbGolema.Location = new System.Drawing.Point(6, 98);
            this.rbGolema.Name = "rbGolema";
            this.rbGolema.Size = new System.Drawing.Size(78, 21);
            this.rbGolema.TabIndex = 2;
            this.rbGolema.TabStop = true;
            this.rbGolema.Text = "Голема";
            this.rbGolema.UseVisualStyleBackColor = true;
            this.rbGolema.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbSredna
            // 
            this.rbSredna.AutoSize = true;
            this.rbSredna.Location = new System.Drawing.Point(6, 60);
            this.rbSredna.Name = "rbSredna";
            this.rbSredna.Size = new System.Drawing.Size(78, 21);
            this.rbSredna.TabIndex = 2;
            this.rbSredna.TabStop = true;
            this.rbSredna.Text = "Средна";
            this.rbSredna.UseVisualStyleBackColor = true;
            this.rbSredna.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Location = new System.Drawing.Point(6, 21);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(64, 21);
            this.rbMala.TabIndex = 1;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Мала";
            this.rbMala.UseVisualStyleBackColor = true;
            this.rbMala.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbD3);
            this.groupBox2.Controls.Add(this.cbD2);
            this.groupBox2.Controls.Add(this.cbD1);
            this.groupBox2.Controls.Add(this.tbDodatok3);
            this.groupBox2.Controls.Add(this.tbDodatok2);
            this.groupBox2.Controls.Add(this.tbDodatok1);
            this.groupBox2.Location = new System.Drawing.Point(364, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатоци";
            // 
            // cbD3
            // 
            this.cbD3.AutoSize = true;
            this.cbD3.Location = new System.Drawing.Point(6, 100);
            this.cbD3.Name = "cbD3";
            this.cbD3.Size = new System.Drawing.Size(71, 21);
            this.cbD3.TabIndex = 2;
            this.cbD3.Text = "Кечап";
            this.cbD3.UseVisualStyleBackColor = true;
            this.cbD3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbD2
            // 
            this.cbD2.AutoSize = true;
            this.cbD2.Location = new System.Drawing.Point(6, 60);
            this.cbD2.Name = "cbD2";
            this.cbD2.Size = new System.Drawing.Size(131, 21);
            this.cbD2.TabIndex = 1;
            this.cbD2.Text = "Екстра сирење";
            this.cbD2.UseVisualStyleBackColor = true;
            this.cbD2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbD1
            // 
            this.cbD1.AutoSize = true;
            this.cbD1.Location = new System.Drawing.Point(6, 22);
            this.cbD1.Name = "cbD1";
            this.cbD1.Size = new System.Drawing.Size(109, 21);
            this.cbD1.TabIndex = 0;
            this.cbD1.Text = "Феферонки";
            this.cbD1.UseVisualStyleBackColor = true;
            this.cbD1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbDodatok3
            // 
            this.tbDodatok3.Location = new System.Drawing.Point(191, 98);
            this.tbDodatok3.Name = "tbDodatok3";
            this.tbDodatok3.Size = new System.Drawing.Size(100, 22);
            this.tbDodatok3.TabIndex = 5;
            this.tbDodatok3.Text = "20";
            this.tbDodatok3.TextChanged += new System.EventHandler(this.tbDodatok3_TextChanged);
            // 
            // tbDodatok2
            // 
            this.tbDodatok2.Location = new System.Drawing.Point(191, 60);
            this.tbDodatok2.Name = "tbDodatok2";
            this.tbDodatok2.Size = new System.Drawing.Size(100, 22);
            this.tbDodatok2.TabIndex = 4;
            this.tbDodatok2.Text = "30";
            this.tbDodatok2.TextChanged += new System.EventHandler(this.tbDodatok2_TextChanged);
            // 
            // tbDodatok1
            // 
            this.tbDodatok1.Location = new System.Drawing.Point(191, 20);
            this.tbDodatok1.Name = "tbDodatok1";
            this.tbDodatok1.Size = new System.Drawing.Size(100, 22);
            this.tbDodatok1.TabIndex = 3;
            this.tbDodatok1.Text = "40";
            this.tbDodatok1.TextChanged += new System.EventHandler(this.tbDodatok1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbPijalok3vkupno);
            this.groupBox3.Controls.Add(this.tbPijalok2vkupno);
            this.groupBox3.Controls.Add(this.tbPijalok3cen);
            this.groupBox3.Controls.Add(this.tbPijalok2cen);
            this.groupBox3.Controls.Add(this.tbPijalok1vkupno);
            this.groupBox3.Controls.Add(this.tbPijalok3kol);
            this.groupBox3.Controls.Add(this.tbPijalok1cen);
            this.groupBox3.Controls.Add(this.tbPijalok2kol);
            this.groupBox3.Controls.Add(this.tbPijalok1kol);
            this.groupBox3.Location = new System.Drawing.Point(12, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 159);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пијалок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Вкупно";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Пиво";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Сок од јаболко / портокал";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Кока Кола / Фанта / Спрајт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Количина";
            // 
            // tbPijalok3vkupno
            // 
            this.tbPijalok3vkupno.Location = new System.Drawing.Point(543, 120);
            this.tbPijalok3vkupno.Name = "tbPijalok3vkupno";
            this.tbPijalok3vkupno.ReadOnly = true;
            this.tbPijalok3vkupno.Size = new System.Drawing.Size(100, 22);
            this.tbPijalok3vkupno.TabIndex = 11;
            this.tbPijalok3vkupno.TextChanged += new System.EventHandler(this.tbPijalok3vkupno_TextChanged);
            // 
            // tbPijalok2vkupno
            // 
            this.tbPijalok2vkupno.Location = new System.Drawing.Point(543, 82);
            this.tbPijalok2vkupno.Name = "tbPijalok2vkupno";
            this.tbPijalok2vkupno.ReadOnly = true;
            this.tbPijalok2vkupno.Size = new System.Drawing.Size(100, 22);
            this.tbPijalok2vkupno.TabIndex = 10;
            this.tbPijalok2vkupno.TextChanged += new System.EventHandler(this.tbPijalok2vkupno_TextChanged);
            // 
            // tbPijalok3cen
            // 
            this.tbPijalok3cen.Location = new System.Drawing.Point(377, 120);
            this.tbPijalok3cen.Name = "tbPijalok3cen";
            this.tbPijalok3cen.Size = new System.Drawing.Size(100, 22);
            this.tbPijalok3cen.TabIndex = 8;
            this.tbPijalok3cen.Text = "80";
            this.tbPijalok3cen.TextChanged += new System.EventHandler(this.tbPijalok3cen_TextChanged);
            // 
            // tbPijalok2cen
            // 
            this.tbPijalok2cen.Location = new System.Drawing.Point(377, 82);
            this.tbPijalok2cen.Name = "tbPijalok2cen";
            this.tbPijalok2cen.Size = new System.Drawing.Size(100, 22);
            this.tbPijalok2cen.TabIndex = 7;
            this.tbPijalok2cen.Text = "70";
            this.tbPijalok2cen.TextChanged += new System.EventHandler(this.tbPijalok2cen_TextChanged);
            // 
            // tbPijalok1vkupno
            // 
            this.tbPijalok1vkupno.Location = new System.Drawing.Point(543, 42);
            this.tbPijalok1vkupno.Name = "tbPijalok1vkupno";
            this.tbPijalok1vkupno.ReadOnly = true;
            this.tbPijalok1vkupno.Size = new System.Drawing.Size(100, 22);
            this.tbPijalok1vkupno.TabIndex = 9;
            this.tbPijalok1vkupno.TextChanged += new System.EventHandler(this.tbPijalok1vkupno_TextChanged);
            // 
            // tbPijalok3kol
            // 
            this.tbPijalok3kol.Location = new System.Drawing.Point(204, 120);
            this.tbPijalok3kol.Name = "tbPijalok3kol";
            this.tbPijalok3kol.Size = new System.Drawing.Size(100, 22);
            this.tbPijalok3kol.TabIndex = 5;
            this.tbPijalok3kol.Text = "0";
            this.tbPijalok3kol.TextChanged += new System.EventHandler(this.tbPijalok3kol_TextChanged);
            // 
            // tbPijalok1cen
            // 
            this.tbPijalok1cen.Location = new System.Drawing.Point(377, 42);
            this.tbPijalok1cen.Name = "tbPijalok1cen";
            this.tbPijalok1cen.Size = new System.Drawing.Size(100, 22);
            this.tbPijalok1cen.TabIndex = 6;
            this.tbPijalok1cen.Text = "60";
            this.tbPijalok1cen.TextChanged += new System.EventHandler(this.tbPijalok1cen_TextChanged);
            // 
            // tbPijalok2kol
            // 
            this.tbPijalok2kol.Location = new System.Drawing.Point(204, 82);
            this.tbPijalok2kol.Name = "tbPijalok2kol";
            this.tbPijalok2kol.Size = new System.Drawing.Size(100, 22);
            this.tbPijalok2kol.TabIndex = 4;
            this.tbPijalok2kol.Text = "0";
            this.tbPijalok2kol.TextChanged += new System.EventHandler(this.tbPijalok2kol_TextChanged);
            // 
            // tbPijalok1kol
            // 
            this.tbPijalok1kol.Location = new System.Drawing.Point(204, 42);
            this.tbPijalok1kol.Name = "tbPijalok1kol";
            this.tbPijalok1kol.Size = new System.Drawing.Size(100, 22);
            this.tbPijalok1kol.TabIndex = 3;
            this.tbPijalok1kol.Text = "0";
            this.tbPijalok1kol.TextChanged += new System.EventHandler(this.tbPijalok1kol_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tbCenaDesert);
            this.groupBox4.Location = new System.Drawing.Point(12, 339);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 156);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Десерт";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.listBox1.Location = new System.Drawing.Point(1, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 116);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Откажи";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Нарачај";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Цена на десерт:";
            // 
            // tbCenaDesert
            // 
            this.tbCenaDesert.Location = new System.Drawing.Point(170, 38);
            this.tbCenaDesert.Name = "tbCenaDesert";
            this.tbCenaDesert.Size = new System.Drawing.Size(134, 22);
            this.tbCenaDesert.TabIndex = 2;
            this.tbCenaDesert.TextChanged += new System.EventHandler(this.tbCenaDesert_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbVrakanje);
            this.groupBox5.Controls.Add(this.tbNaplateno);
            this.groupBox5.Controls.Add(this.tbVkupno);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(364, 339);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 156);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Наплата";
            // 
            // tbVrakanje
            // 
            this.tbVrakanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVrakanje.Location = new System.Drawing.Point(177, 122);
            this.tbVrakanje.Name = "tbVrakanje";
            this.tbVrakanje.Size = new System.Drawing.Size(114, 28);
            this.tbVrakanje.TabIndex = 5;
            this.tbVrakanje.Text = "0";
            // 
            // tbNaplateno
            // 
            this.tbNaplateno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNaplateno.Location = new System.Drawing.Point(177, 77);
            this.tbNaplateno.Name = "tbNaplateno";
            this.tbNaplateno.Size = new System.Drawing.Size(114, 28);
            this.tbNaplateno.TabIndex = 3;
            this.tbNaplateno.Text = "0";
            this.tbNaplateno.TextChanged += new System.EventHandler(this.tbNaplateno_TextChanged);
            // 
            // tbVkupno
            // 
            this.tbVkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVkupno.Location = new System.Drawing.Point(177, 32);
            this.tbVkupno.Name = "tbVkupno";
            this.tbVkupno.ReadOnly = true;
            this.tbVkupno.Size = new System.Drawing.Size(114, 28);
            this.tbVkupno.TabIndex = 1;
            this.tbVkupno.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "За враќање:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Наплатено:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Вкупно за плаќање";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 509);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGolema;
        private System.Windows.Forms.RadioButton rbSredna;
        private System.Windows.Forms.RadioButton rbMala;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbPica3;
        private System.Windows.Forms.TextBox tbPica2;
        private System.Windows.Forms.TextBox tbPica1;
        private System.Windows.Forms.CheckBox cbD3;
        private System.Windows.Forms.CheckBox cbD2;
        private System.Windows.Forms.CheckBox cbD1;
        private System.Windows.Forms.TextBox tbDodatok3;
        private System.Windows.Forms.TextBox tbDodatok2;
        private System.Windows.Forms.TextBox tbDodatok1;
        private System.Windows.Forms.TextBox tbPijalok3kol;
        private System.Windows.Forms.TextBox tbPijalok2kol;
        private System.Windows.Forms.TextBox tbPijalok1kol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPijalok3vkupno;
        private System.Windows.Forms.TextBox tbPijalok2vkupno;
        private System.Windows.Forms.TextBox tbPijalok3cen;
        private System.Windows.Forms.TextBox tbPijalok2cen;
        private System.Windows.Forms.TextBox tbPijalok1vkupno;
        private System.Windows.Forms.TextBox tbPijalok1cen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCenaDesert;
        private System.Windows.Forms.TextBox tbVrakanje;
        private System.Windows.Forms.TextBox tbNaplateno;
        private System.Windows.Forms.TextBox tbVkupno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
    }
}

