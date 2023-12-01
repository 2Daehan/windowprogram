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
namespace scheduler
{
    public partial class Form4 : Form
    {
        private string userId;
        private MySqlConnection connection;  // MySQL 연결 변수 추가
        public Form4(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1교시(9시~10시)");
            dataGridView1.Rows.Add("2교시(10시~11시)");
            dataGridView1.Rows.Add("3교시(11시~12시)");
            dataGridView1.Rows.Add("4교시(12시~13시)");
            dataGridView1.Rows.Add("5교시(13시~14시)");
            dataGridView1.Rows.Add("6교시(14시~15시)");
            dataGridView1.Rows.Add("7교시(15시~16시)");
            dataGridView1.Rows.Add("8교시(16시~17시)");
            dataGridView1.Rows.Add("9교시(17시~18시)");
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            if(textBox1 != null && comboBox1 != null && comboBox2 != null) 
            {
                dataGridView1[comboBox1.SelectedIndex,comboBox2.SelectedIndex].Value = textBox1.Text;
                dataGridView1[comboBox1.SelectedIndex, comboBox2.SelectedIndex].Style.BackColor = Color.FromArgb(rnd1.Next(0, 255), rnd1.Next(0,256),rnd1.Next(0,256));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*for (int Column = 0; Column < 4; Column++)
            {
                for (int Row = 0; Row < 8; Row++)
                {
                    if (textBox2 == dataGridView1[Column, Row].Value)
                    {
                        dataGridView1[Column, Row].Value = (""); break;
                    }
                }
            }*/
        }
    }
}
