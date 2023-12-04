using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using winProExam;

namespace 프로젝트
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = localhost;Database=dbtest;Uid=root;Pwd=1234;");
                connection.Open();

                string insertQuery = "INSERT INTO account_info (name, studentnum,id, pwd) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "');";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(textBox1.Text + "님 회원가입 완료, 사용할 아이디는 " + textBox3.Text + "입니다.");
                    connection.Close();
                   
                    Close();
                }
                else
                {
                    MessageBox.Show("비정상 입력 정보, 재확인 요망");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}