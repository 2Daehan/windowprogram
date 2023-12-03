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
            // MySQL 연결 초기화
            string connectionString = "Server=localhost;Database=dbtest;Uid=root;Pwd=1234;";
            connection = new MySqlConnection(connectionString);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1교시(9시~10시)");
            dataGridView1.Rows[0].Visible = false;
            dataGridView1.Rows.Add("1교시(9시~10시)");
            dataGridView1.Rows.Add("2교시(10시~11시)");
            dataGridView1.Rows.Add("3교시(11시~12시)");
            dataGridView1.Rows.Add("4교시(12시~13시)");
            dataGridView1.Rows.Add("6교시(14시~15시)");
            dataGridView1.Rows.Add("7교시(15시~16시)");
            dataGridView1.Rows.Add("8교시(16시~17시)");
            dataGridView1.Rows.Add("9교시(17시~18시)");
            dataGridView1.ReadOnly = true;
            LoadTimetableFromDatabase();  // MySQL에서 시간표 데이터 로드
            dataGridView1.ReadOnly = true;
        }

        private void LoadTimetableFromDatabase()
        {

            try
            {
                connection.Open();

                // class_info 테이블에 days, times1, time2, classname, professor 컬럼이 있다고 가정합니다.
                string query = "SELECT days, times1, time2, classname, professor FROM class_info WHERE id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userId", userId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string day = reader["days"].ToString();
                        int time1 = Convert.ToInt32(reader["times1"]);
                        int time2 = Convert.ToInt32(reader["times2"]);
                        string className = reader["classname"].ToString();
                        string professor = reader["professor"].ToString();

                        int rowIndex = GetRowIndex(time1); // 행을 시간으로 설정
                        int columnIndex = GetColumnIndex(day); // 열을 요일로 설정

                        // rowIndex가 음수가 아닌 경우에만 값을 설정
                        if (columnIndex >= 0)
                        {
                            SetCellValue(time1, columnIndex, className, professor);

                            // time2가 0보다 큰 경우에만 값을 설정
                            if (time2 > 0)
                            {
                                SetCellValue(time2, columnIndex, className, professor);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private int GetRowIndex(int time1)
        {
            // 시간을 행 인덱스로 매핑
            switch (time1)
            {
                case 1: return 1;
                case 2: return 2;
                case 3: return 3;
                case 4: return 4;
                case 5: return 5;
                case 6: return 6;
                case 7: return 7;
                case 8: return 8;
                case 9: return 9;
                default: return 0;
            }
            int dayValue = Convert.ToInt32(time1);
            return dayValue - 1;
        }

        private int GetColumnIndex(string day)
        {
            // 요일을 행 인덱스로 매핑
            switch (day)
            {
                case "1": return 1;
                case "2": return 2;
                case "3": return 3;
                case "4": return 4;
                case "5": return 5;
                case "6": return 6;
                case "7": return 7;
                default: return 0;
            }
        }
        private void SetCellValue(int rowIndex, int columnIndex, string className, string professor)
        {
            // rowIndex와 columnIndex가 유효한 범위 내에 있는지 확인
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count &&
                columnIndex >= 0 && columnIndex < dataGridView1.Columns.Count)
            {
                dataGridView1[columnIndex, rowIndex].Value = className + "\n" + professor;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            if (textBox1 != null && comboBox1 != null && comboBox2 != null)
            {
                dataGridView1[comboBox1.SelectedIndex, comboBox2.SelectedIndex].Value = textBox1.Text;
                dataGridView1[comboBox1.SelectedIndex, comboBox2.SelectedIndex].Style.BackColor = Color.FromArgb(rnd1.Next(0, 255), rnd1.Next(0, 256), rnd1.Next(0, 256));
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