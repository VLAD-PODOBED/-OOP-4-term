
namespace lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.sex = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.age = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.apartnum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.housenum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.avgrade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.spec = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.NumericUpDown();
            this.grade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.NSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avgrade)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sex);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateBD);
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 146);
            this.panel1.TabIndex = 0;
            // 
            // sex
            // 
            this.sex.Items.Add("М");
            this.sex.Items.Add("Ж");
            this.sex.Location = new System.Drawing.Point(5, 87);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(44, 27);
            this.sex.TabIndex = 8;
            this.sex.Text = "М";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(52, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата рождения";
            // 
            // dateBD
            // 
            this.dateBD.Location = new System.Drawing.Point(52, 87);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(195, 27);
            this.dateBD.TabIndex = 1;
            this.dateBD.ValueChanged += new System.EventHandler(this.dateBD_ValueChanged);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.age.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.age.Location = new System.Drawing.Point(83, 117);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(19, 23);
            this.age.TabIndex = 6;
            this.age.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Возраст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пол";
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(5, 31);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(242, 27);
            this.fio.TabIndex = 3;
            this.fio.Text = "-";
            this.fio.Validating += new System.ComponentModel.CancelEventHandler(this.fio_V);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.apartnum);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.housenum);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.index);
            this.panel2.Controls.Add(this.street);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.city);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 177);
            this.panel2.TabIndex = 8;
            // 
            // apartnum
            // 
            this.apartnum.Location = new System.Drawing.Point(59, 143);
            this.apartnum.Name = "apartnum";
            this.apartnum.Size = new System.Drawing.Size(84, 27);
            this.apartnum.TabIndex = 11;
            this.apartnum.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(59, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Квартира";
            // 
            // housenum
            // 
            this.housenum.Location = new System.Drawing.Point(5, 143);
            this.housenum.Name = "housenum";
            this.housenum.Size = new System.Drawing.Size(48, 27);
            this.housenum.TabIndex = 9;
            this.housenum.Text = "0";
            this.housenum.Validated += new System.EventHandler(this.housenum_V);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(5, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Дом";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(149, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Индекс";
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(149, 143);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(98, 27);
            this.index.TabIndex = 5;
            this.index.Text = "-";
            this.index.Validating += new System.ComponentModel.CancelEventHandler(this.index_V);
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(5, 87);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(242, 27);
            this.street.TabIndex = 7;
            this.street.Text = "-";
            this.street.Validating += new System.ComponentModel.CancelEventHandler(this.street_V);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(5, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Улица";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(5, 31);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(242, 27);
            this.city.TabIndex = 3;
            this.city.Text = "-";
            this.city.Validating += new System.ComponentModel.CancelEventHandler(this.city_V);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(5, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Город";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.avgrade);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.group);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.course);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.spec);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(270, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 122);
            this.panel3.TabIndex = 8;
            // 
            // avgrade
            // 
            this.avgrade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.avgrade.Location = new System.Drawing.Point(128, 88);
            this.avgrade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.avgrade.Name = "avgrade";
            this.avgrade.Size = new System.Drawing.Size(119, 27);
            this.avgrade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(126, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Средний балл";
            // 
            // group
            // 
            this.group.FormattingEnabled = true;
            this.group.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.group.Location = new System.Drawing.Point(57, 88);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(65, 28);
            this.group.TabIndex = 6;
            this.group.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(57, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "Группа";
            // 
            // course
            // 
            this.course.FormattingEnabled = true;
            this.course.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.course.Location = new System.Drawing.Point(5, 87);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(46, 28);
            this.course.TabIndex = 4;
            this.course.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(5, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Курс";
            // 
            // spec
            // 
            this.spec.FormattingEnabled = true;
            this.spec.Items.AddRange(new object[] {
            "ИСИТ",
            "ПОИТ",
            "ПОИБМС",
            "ДЭИВИ"});
            this.spec.Location = new System.Drawing.Point(5, 31);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(242, 28);
            this.spec.TabIndex = 2;
            this.spec.Text = "ИСИТ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(5, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "Специальность";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.exp);
            this.panel4.Controls.Add(this.grade);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.company);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(270, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 123);
            this.panel4.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(5, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 23);
            this.label14.TabIndex = 7;
            this.label14.Text = "Стаж";
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(5, 88);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(50, 27);
            this.exp.TabIndex = 7;
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(61, 88);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(186, 27);
            this.grade.TabIndex = 6;
            this.grade.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(61, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 23);
            this.label13.TabIndex = 5;
            this.label13.Text = "Должность";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(5, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 23);
            this.label17.TabIndex = 4;
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(5, 31);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(242, 27);
            this.company.TabIndex = 3;
            this.company.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(5, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 23);
            this.label18.TabIndex = 1;
            this.label18.Text = "Компания";
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save.Location = new System.Drawing.Point(270, 269);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(80, 72);
            this.save.TabIndex = 9;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // read
            // 
            this.read.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.read.Location = new System.Drawing.Point(356, 269);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(80, 72);
            this.read.TabIndex = 10;
            this.read.Text = "READ";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NSL,
            this.Birth,
            this.Agee,
            this.Crs,
            this.Grp,
            this.Avg,
            this.Adr,
            this.Com});
            this.dataGridView1.Location = new System.Drawing.Point(528, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(451, 322);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(442, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 72);
            this.button1.TabIndex = 12;
            this.button1.Text = "✓";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NSL
            // 
            this.NSL.HeaderText = "ФИО";
            this.NSL.MinimumWidth = 6;
            this.NSL.Name = "NSL";
            this.NSL.Width = 125;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Дата рождения";
            this.Birth.MinimumWidth = 6;
            this.Birth.Name = "Birth";
            this.Birth.Width = 125;
            // 
            // Agee
            // 
            this.Agee.HeaderText = "Возраст";
            this.Agee.MinimumWidth = 6;
            this.Agee.Name = "Agee";
            this.Agee.Width = 125;
            // 
            // Crs
            // 
            this.Crs.HeaderText = "Курс";
            this.Crs.MinimumWidth = 6;
            this.Crs.Name = "Crs";
            this.Crs.Width = 125;
            // 
            // Grp
            // 
            this.Grp.HeaderText = "Группа";
            this.Grp.MinimumWidth = 6;
            this.Grp.Name = "Grp";
            this.Grp.Width = 125;
            // 
            // Avg
            // 
            this.Avg.HeaderText = "Средний балл";
            this.Avg.MinimumWidth = 6;
            this.Avg.Name = "Avg";
            this.Avg.Width = 125;
            // 
            // Adr
            // 
            this.Adr.HeaderText = "Адрес";
            this.Adr.MinimumWidth = 6;
            this.Adr.Name = "Adr";
            this.Adr.Width = 125;
            // 
            // Com
            // 
            this.Com.HeaderText = "Компания";
            this.Com.MinimumWidth = 6;
            this.Com.Name = "Com";
            this.Com.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.read);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avgrade)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateBD;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox apartnum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox housenum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox group;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox spec;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox company;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown exp;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown avgrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Com;
    }
}

