using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        DateTime thisDate = DateTime.Now;
        List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            dateBD.MaxDate = thisDate.AddYears(-15);
            fio.Tag = false;
            city.Tag = false;
            street.Tag = false;
            housenum.Tag = false;
            apartnum.Tag = false;
            index.Tag = false;
        }
        private void EnableButton()
        {
            //button1.Enabled = ((bool)fio.Tag && (bool)city.Tag && (bool)street.Tag && (bool)housenum.Tag && (bool)apartnum.Tag && (bool)index.Tag);
            if ((bool)fio.Tag && (bool)city.Tag && (bool)street.Tag && (bool)housenum.Tag && (bool)index.Tag /*&& (bool)apartnum.Tag */)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            if (Regex.IsMatch(filename, $".xml$"))
                xmlSerialization.Serialize(studentList, filename);
            else
            {
                MessageBox.Show("Неверный формат файла!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            if (Regex.IsMatch(filename, $".xml$"))
            {
                studentList = xmlSerialization.Deserialize<List<Student>>(filename);
                dataGridView1.Rows.Clear();
                foreach (Student x in studentList)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["NSL"].Value = x.FullName;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Crs"].Value = x.Course;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Grp"].Value = x.Group;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Avg"].Value = x.AverageGrade;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Birth"].Value = x.Birthday;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Agee"].Value = x.Age;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Adr"].Value = x.adress;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Com"].Value = x.company;
                }
            }
            else
            {
                MessageBox.Show("Неверный формат файла!");
            }
        }

        private void dateBD_ValueChanged(object sender, EventArgs e)
        {
            
            age.Text = (thisDate.Year - dateBD.Value.Year).ToString();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Student student = new Student(
                   fio.Text,//ФИО
                   age.Text,//Возраст
                   spec.Text,//Профессия
                   dateBD.Value.ToString(),//Дата рождения
                   course.Text,//курс
                   group.Text,//группа
                   avgrade.Value,//средняя
                   sex.Text,//пол
                   new Adress(city.Text, index.Text, street.Text, int.Parse(housenum.Text), int.Parse(apartnum.Text)),
                   new Company(company.Text,exp.Value,grade.Text)
                   );
            studentList.Add(student);
            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["NSL"].Value = student.FullName;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Crs"].Value = student.Course;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Grp"].Value = student.Group;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Avg"].Value = student.AverageGrade;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Birth"].Value = student.Birthday;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Agee"].Value = student.Age;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Adr"].Value = student.adress;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Com"].Value = student.company;

            fio.Clear();
            sex.SelectedIndex = 0;
            dateBD.Value = thisDate.AddYears(-15);

            spec.ResetText();
            course.ResetText();
            group.ResetText();
            avgrade.ResetText();

            city.Clear();
            street.Clear();
            housenum.Clear();
            apartnum.Clear();
            index.Clear();

            company.Clear();
            grade.Clear();
            exp.ResetText();

            fio.Tag = false; 
            city.Tag = false; 
            street.Tag = false;
            housenum.Tag = false; 
            apartnum.Tag = false; 
            index.Tag = false;

            EnableButton();
        }

        private void fio_V(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(fio.Text, @"[А-Я][а-я]+\s[А-Я][а-я]+\s[А-Я][а-я]+$"))
            {
                fio.BackColor = ColorTranslator.FromHtml("#ff8d8d");
                fio.Tag = false;
            }
            else
            {
                fio.BackColor = Color.White;
                fio.Tag = true;
            }
            EnableButton();
        }
        //--------------------------------------------------------------------------------------------------------//
        private void city_V(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(city.Text, @"[А-Я][а-я]+$"))
            {
                city.BackColor = ColorTranslator.FromHtml("#ff8d8d");
                city.Tag = false;
            }
            else
            {
                city.BackColor = Color.White;
                city.Tag = true;
            }
            EnableButton();
        }
        private void street_V(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(street.Text, @"(([А-Я][а-я]+(\s?))+$)|([А-Я][а-я]+(-?)([А-Я]?)([а-я]+)$)"))
            {
                street.BackColor = ColorTranslator.FromHtml("#ff8d8d");
                street.Tag = false;
            }
            else
            {
                street.BackColor = Color.White;
                street.Tag = true;
            }
            EnableButton();
        }
        private void housenum_V(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(housenum.Text, @"[0-9]+[а-я]*$"))
            {
                housenum.BackColor = ColorTranslator.FromHtml("#ff8d8d");
                housenum.Tag = false;
            }
            else
            {
                housenum.BackColor = Color.White;
                housenum.Tag = true;
            }
            EnableButton();
        }
        private void apartnum_V(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(apartnum.Text, @"[1-9][0-9]*$"))
            {
                apartnum.BackColor = ColorTranslator.FromHtml("#ff8d8d");
                apartnum.Tag = false;
            }
            else
            {
                apartnum.BackColor = Color.White;
                apartnum.Tag = true;
            }
            EnableButton();
        }
        private void index_V(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(index.Text, @"[1-9][0-9][0-9][0-9][0-9][0-9]$"))
            {
                index.BackColor = ColorTranslator.FromHtml("#ff8d8d");
                index.Tag = false;
            }
            else
            {
                index.BackColor = Color.White;
                index.Tag = true;
            }
            EnableButton();
        }

    }
}
