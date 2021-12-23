using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;

namespace Kandykova_Mordochka
{
    public partial class AddClientForm : Form
    {

        public AddClientForm()
        {
            InitializeComponent();
        }
        void add (string sqlExpr)
        {
            string conStr = "Data Source = 10.10.1.24; Initial Catalog = Kandikova_YP; Persist Security Info = True; User ID = pro - 41; Password = Pro_41student";
            string sqlExpression = sqlExpr;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlExpression, con);
                int number = command.ExecuteNonQuery();
            }
        }
        public string gender;
        private void AddClientForm_Load(object sender, EventArgs e)
        {
            if (gender == null)
            { manRadioButton.Checked = true; }
            else
            { if (gender == "м") manRadioButton.Checked = true; else womanRadioButton.Checked = true; }
        }

        // требования к полям заполнения
        string conditionsFIO(string textbox)
        {
            if (Regex.IsMatch(textbox, @"[1\\2\\3\\4\\5\\6\\7\\8\\9\\0\\!\#\$\%\^\&\*\(\)\}\{\,\.\,\/\\?\'\+\=\:\;\№@]"))
            {
                textbox = Regex.Replace(textbox, @"[1\\2\\3\\4\\5\\6\\7\\8\\9\\0\\!\#\$\%\^\&\*\(\)\}\{\,\.\,\/\\?\'\+\=\:\;\№@]", "");
            }
            if (textbox.Length > 50)
            {
                MessageBox.Show("Длина поля ограничена 50 еденицами");
                textbox = textbox.Substring(0, 50);
            }
            return textbox;
        }
       
        //поля ввода данных 
        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            firstNameTextBox.Text = conditionsFIO(firstNameTextBox.Text);
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            lastNameTextBox.Text = conditionsFIO(lastNameTextBox.Text);
        }

        private void patronymicTextBox_TextChanged(object sender, EventArgs e)
        {
            patronymicTextBox.Text = conditionsFIO(patronymicTextBox.Text);
        }
        
        bool rightEmail;
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(emailTextBox.Text, @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$"))
            {
                rightEmail = true;
            }
            else
            {
                rightEmail = false;
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '-')
                e.Handled = true;
        }

        private void manRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (manRadioButton.Checked == true) gender = "м";
        }

        private void womanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (womanRadioButton.Checked == true) gender = "ж";
        }
        OpenFileDialog open = new OpenFileDialog();
 
        private void photoButton_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = open.FileName;
            try { File.Copy(open.FileName, Path.Combine(@"d:\users\is12306\Desktop\Кандыкова УП_0102\", Path.GetFileName(open.FileName))); }
            catch { MessageBox.Show("Изображение с таким именем существует."); }
            string part = Path.GetFileName(open.FileName);
            Photoname = @"Клиенты\" + part;
            photoPictureBox.Image = Image.FromFile("d:\\users\\is12306\\Desktop\\Кандыкова УП_0102\\" + Photoname + "");
        }

        public string stat;
        string Photoname;
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (rightEmail == true)
            {
                try
                {
                    if (stat == "add")
                    {
                        add("INSERT INTO Client (FirstName,LastName,Patronymic,Birthday,RegistrationDate,Email," +
                            "Phone,GenderCode, PhotoPath) Values ('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "'," +
                            "'" + patronymicTextBox.Text + "','" + birthDateTimePicker.Text + "' ,GETDATE(), '" + emailTextBox.Text + "', " +
                            "'" + phoneTextBox.Text + "', '" + gender + "', '" + Photoname + "')");
                        MessageBox.Show("Регистрация завершена.");
                    }
                    else
                    {
                        add("UPDATE Client SET FirstName= '" + firstNameTextBox.Text + "', LastName = '" + lastNameTextBox.Text + "', " +
                            "Patronymic ='" + patronymicTextBox.Text + "', Birthday ='" + birthDateTimePicker.Text + "', Email = '" + emailTextBox.Text + "', " +
                            "Phone ='" + phoneTextBox.Text + "', GenderCode = '" + gender + "', PhotoPath ='" + Photoname + "'  WHERE ID= " + idTextBox.Text + "");
                        MessageBox.Show("Изменения сохранены.");
                    }
                }
                catch
                {
                    MessageBox.Show("Выявлена ошибка сохранения. Все ли поля заполнены?");
                }
            }
            else { MessageBox.Show("Неверный формат электронной почты!"); }
        }

        private void birthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            birthDateTimePicker.Format = DateTimePickerFormat.Custom;
            birthDateTimePicker.CustomFormat = "dd.MM.yyyy";
        }

    }
}
