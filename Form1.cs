using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using winProExam;

namespace 프로젝트
{

    public partial class Form1 : Form

    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_click_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = localhost;Database=dbtest;Uid=root;Pwd=1234;");
                connection.Open();//sql 서버 연결
                int login_status = 0;//로그인 상태 변수 
                string loginid = textBox1.Text;
                string loginpwd = textBox2.Text;
                string selectQuery = "SELECT * FROM account_info WHERE id = '" + loginid + "'";
                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);
                MySqlDataReader userAccount = Selectcommand.ExecuteReader();
                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["id"] && loginpwd == (string)userAccount["pwd"])
                    {
                        login_status = 1;
                    }

                }
                connection.Clone();
                if (login_status == 1)
                {
                    MessageBox.Show("로그인 성공");
                    this.Hide(); // 현재 폼 숨기기
                    Form3 form3 = new Form3();
                    form3.Show();
                   

                }
                else
                {
                    MessageBox.Show("회원 정보를 다시 확인해 주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CLOSEBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor=SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor=Color.White;
            panel3.BackColor=Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel2.BackColor=SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 showform2 = new Form2();
            showform2.Show();
            

        }
    }
}
