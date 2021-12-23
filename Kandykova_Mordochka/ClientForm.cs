using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kandykova_Mordochka
{
    public partial class ClientForm : Form
    {        
        int pageNumber = 0; // текущая страница
        int pageSize = 13; // размер страницы


       
        public ClientForm()
        {
            InitializeComponent();

        }


        string countlabel2;
        string countlabel1;
        //Связь с БД
        string conStr = "Data Source=10.10.1.24;Initial Catalog=Kandikova_YP;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";

        void View ( string sql)
        {
            ClientDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClientDataGridView.AllowUserToAddRows = false;
            // запрос на таблицу из БД
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ClientDataGridView.DataSource = ds.Tables[0];
                con.Close();
            }
            string sqlExpression = "SELECT COUNT(*) FROM Client";
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int count = (int)command.ExecuteScalar();
                countlabel2 = count.ToString();
                connection.Close();
            }
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            View("SELECT * FROM Client");
        }



        int str = 0;
        string list;
        int viewtop;
        string toplist;
        int top = 10;
        int rows;
        //string gender = null;
        //string sortFN = null;
        string sort;
        int topstat;


        void sheets(int topstr, int str)
        {
            viewtop = topstr * str;
            toplist = Convert.ToString(viewtop);
            list = Convert.ToString(topstr);
            //View("SELECT * FROM Client ORDER BY " + sort + " ID  OFFSET " + toplist + " ROWS FETCH NEXT " + list + " ROWS ONLY");
            View("SELECT Client.ID, " + starttime + "  FirstName, LastName, Patronymic, Birthday,RegistrationDate, Email, Phone, GenderCode  FROM Client " + where + " ORDER BY " + sort + " Client.ID  OFFSET " + toplist + " ROWS FETCH NEXT " + list + " ROWS ONLY");
            labelcount.Text = countlabel1 + "/" + countlabel2;
        }


        void labelrows()
        {
            rows = ClientDataGridView.Rows.Count - 0;
            countlabel1 = rows.ToString();
            labelcount.Text = countlabel1 + "/" + countlabel2;
            if (Convert.ToInt32(countlabel1) == Convert.ToInt32(countlabel2))
            {
                nextButton.Enabled = false;
            }
            else
            { nextButton.Enabled = true; }
            backButton.Enabled = true;
        }



        //обработчик страница назад
        private void backButton_Click(object sender, EventArgs e)
        {
            if (str > 0)
            {
                str = str - 1;
                sheets(top, str);
                rows = Convert.ToInt32(countlabel1) - ClientDataGridView.Rows.Count + 1;
                countlabel1 = rows.ToString();
                labelcount.Text = countlabel1 + "/" + countlabel2;

            }
            else
            {
                str = 0;
                backButton.Enabled = false;

            }
            if (Convert.ToInt32(countlabel1) == Convert.ToInt32(countlabel2))
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }

            //if (pageNumber == 0) return;
            //pageNumber--;

            //using (SqlConnection connection = new SqlConnection(conStr))
            //{
            //    adapter = new SqlDataAdapter(GetSql(), connection);
            //    ds.Tables["Client"].Rows.Clear();
            //    adapter.Fill(ds, "Client");
            //}
        }
        //обработчик страница вперёд
        private void nextButton_Click(object sender, EventArgs e)
        {
            str = str + 1;
            sheets(top, str);
            backButton.Enabled = true;
            rows = rows + ClientDataGridView.Rows.Count - 1;
            countlabel1 = rows.ToString();
            labelcount.Text = countlabel1 + "/" + countlabel2;
            if (Convert.ToInt32(countlabel1) == Convert.ToInt32(countlabel2))
            { nextButton.Enabled = false; }

            //if (ds.Tables["Client"].Rows.Count < pageSize) return;

            //pageNumber++;
            //using (SqlConnection connection = new SqlConnection(conStr))
            //{
            //    adapter = new SqlDataAdapter(GetSql(), connection);
            //    ds.Tables["Client"].Rows.Clear();
            //    adapter.Fill(ds, "Client");
            //}
        }
        private string GetSql()
        {
            return "SELECT * FROM Client ORDER BY Id OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY";
        }

        private void TenButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
            top = 10;
            str = 0;
            sheets(top, str);
            labelrows();
            topstat = 10;
            //pageSize = pageSazeTen;
            //using (SqlConnection connection = new SqlConnection(conStr))
            //{
            //    adapter = new SqlDataAdapter(GetSql(), connection);
            //    ds = new DataSet();
            //    adapter.Fill(ds, "Client");
            //    ClientDataGridView.DataSource = ds.Tables[0];
            //    ClientDataGridView.Columns["ID"].ReadOnly = true;
            //}
        }

        private void FiftyButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
            top = 50;
            str = 0;
            sheets(top, str);
            labelrows();
            topstat = 50;

            //pageSize = pageSazeFifty;
            //using (SqlConnection connection = new SqlConnection(conStr))
            //{
            //    adapter = new SqlDataAdapter(GetSql(), connection);
            //    ds = new DataSet();
            //    adapter.Fill(ds, "Client");
            //    ClientDataGridView.DataSource = ds.Tables[0];
            //    ClientDataGridView.Columns["ID"].ReadOnly = true;
            //} 

        }

        private void twoHunButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
            top = 200;
            str = 0;
            sheets(top, str);
            labelrows();
            topstat = 200;


            //pageSize = pageSazeTwoHun;
            //using (SqlConnection connection = new SqlConnection(conStr))
            //{
            //    adapter = new SqlDataAdapter(GetSql(), connection);
            //    ds = new DataSet();
            //    adapter.Fill(ds, "Client");
            //    ClientDataGridView.DataSource = ds.Tables[0];
            //    ClientDataGridView.Columns["ID"].ReadOnly = true;
            //}
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            View("SELECT * FROM Client");
            labelrows();
            topstat = 0;
        }

        private void recordLabel_Click(object sender, EventArgs e)
        {
         
        }
        private void thenButton_Click(object sender, EventArgs e)
        {

        }

        void topstats(int topstat)
        {
            if (topstat == 10)
            {
                top = 10;
                str = 0;
                sheets(top, str);
                if (topstat == 50)
                {
                    top = 50;
                    str = 0;
                    sheets(top, str);
                    if (topstat == 100)
                    {
                        top = 100;
                        str = 0;
                        sheets(top, str);
                    }
                }

            }
            else
            {
                View("SELECT Client.ID, " + starttime + " FirstName, LastName, Patronymic, Birthday,RegistrationDate, Email, Phone, GenderCode FROM Client " + where + " ORDER BY " + sort + " ID");
            }

        }

        string starttime;
        string where;
        string genderSearch;
        private void manButton_Click(object sender, EventArgs e)
        {
            sort = "GenderCode DESC,";
            genderSearch = "ORDER BY GenderCode DESC";
            topstats(topstat);
            //View("SELECT * FROM Client ORDER BY GenderCode DESC");
            labelrows();
        }

        private void womanButton_Click(object sender, EventArgs e)
        {
            //sortFN = null;
            //gender = "GenderCode ASC,";
            sort = "GenderCode ASC,";
            genderSearch = "ORDER BY GenderCode ASC";
            //View("SELECT * FROM Client ORDER BY GenderCode ASC");
            topstats(topstat);
            labelrows();
        }

        private void allGenderButton_Click(object sender, EventArgs e)
        {
            //View("SELECT * FROM Client");
            //sortFN = null;
            //gender = null;
            sort = null;
            topstats(topstat);
            labelrows();
        }

        private void sortFnameButton_Click(object sender, EventArgs e)
        {
            sort = "FirstName ASC,";
            topstats(topstat);
            //View("SELECT * FROM Client ORDER BY FirstName ASC");
            labelrows();
        }

        private void lastdateButton_Click(object sender, EventArgs e)
        {
            sort = "StartTime DESC,";
            starttime = "StartTime,";
            where = ",ClientService WHERE Client.ID = ClientService.ClientID";
            topstats(topstat);
            //View("SELECT StartTime, FirstName, LastName, Patronymic, Birthday,RegistrationDate, Email, Phone, GenderCode FROM ClientService,Client WHERE Client.ID = ClientService.ClientID ORDER BY StartTime DESC ");
            labelrows();
            starttime = null;
            where = null;
        }

        private void visitsButton_Click(object sender, EventArgs e)
        {
            View("SELECT COUNT(*) AS visit, FirstName, LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode FROM ClientService,Client WHERE Client.ID = ClientService.ClientID GROUP BY FirstName, LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode ORDER BY visit DESC");
            labelrows();
        }

        private void searchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            View("SELECT * FROM Client  WHERE (FirstName LIKE '" + searchNameTextBox.Text + "%') OR (LastName LIKE '" + searchNameTextBox.Text + "%') OR (Patronymic LIKE '" + searchNameTextBox.Text + "%') " + genderSearch + "");
            labelrows();
        }

        private void searchMailTextBox_TextChanged(object sender, EventArgs e)
        {
            View("SELECT * FROM Client WHERE Email LIKE '" + searchMailTextBox.Text + "%'");
            labelrows();
        }

        private void searchPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            View("SELECT * FROM Client WHERE Phone LIKE '" + searchPhoneTextBox.Text + "%'");
            labelrows();
        }

        AddClientForm AddForm = new AddClientForm();
        public string stat;
        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm = new AddClientForm();
            AddForm.stat = "add";    
            AddForm.Show();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            AddForm = new AddClientForm();
            AddForm.stat = "upd";
            int rowindex = ClientDataGridView.CurrentCell.RowIndex;
            AddForm.idTextBox.Text = ClientDataGridView.Rows[rowindex].Cells[0].Value.ToString();
            AddForm.firstNameTextBox.Text = ClientDataGridView.Rows[rowindex].Cells[1].Value.ToString();
            AddForm.lastNameTextBox.Text = ClientDataGridView.Rows[rowindex].Cells[2].Value.ToString();
            AddForm.patronymicTextBox.Text = ClientDataGridView.Rows[rowindex].Cells[3].Value.ToString();
            string date = ClientDataGridView.Rows[rowindex].Cells[4].Value.ToString();
            var parcedDate = DateTime.Parse(date);
            AddForm.birthDateTimePicker.Value = parcedDate;
            AddForm.emailTextBox.Text = ClientDataGridView.Rows[rowindex].Cells[6].Value.ToString();
            AddForm.phoneTextBox.Text = ClientDataGridView.Rows[rowindex].Cells[7].Value.ToString();
            AddForm.gender = ClientDataGridView.Rows[rowindex].Cells[8].Value.ToString();
            try
            {
                AddForm.photoPictureBox.Image = Image.FromFile("d:\\users\\is12306\\Desktop\\Кандыкова УП_0102\\" + ClientDataGridView.Rows[rowindex].Cells[9].Value.ToString() + "");
            }
            catch
            {
                AddForm.photoPictureBox.Image = Image.FromFile("d:\\users\\is12306\\Desktop\\Кандыкова УП_0102\\Клиенты\\image.jpg");
            }



            AddForm.Show();
        }

        int c;
        int visit;
        private void deleteButton_Click(object sender, EventArgs e)
        {
            visit = Convert.ToInt32(nameLabel.Text);
            if (visit == 0)
            {
                DialogResult result = MessageBox.Show(
            "Удалить пользователя " + nameDelLabel.Text + "?",
            "Сообщение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    string sqlExpression = "DELETE FROM Client WHERE ID = " + idTextBox.Text + "";
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, con);
                        int number = command.ExecuteNonQuery();
                        con.Close();

                    }
                    ClientDataGridView.Rows.RemoveAt(c);
                    MessageBox.Show("Успешно");
                }
            }
            else
            {
                MessageBox.Show("У пользователя есть посещения");
            }


            this.TopMost = true;
        }

        private void birthButton_Click(object sender, EventArgs e)
        {
            starttime = null;
            where = null;
            sort = "DAY(Birthday) DESC,";
            where = "WHERE ABS(Month(GETDATE()) - MONTH(Birthday)) = 0";
            topstats(topstat);
            labelrows();
        }

        private void ClientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
