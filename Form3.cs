

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

namespace winProExam
{
    public partial class Form3 : Form
    {
        string connectionString = "Server = localhost;Database=dbtest;Uid=root;Pwd=1234;";

        public Form3()
        {
            InitializeComponent();

        }

        private void WKUniversity_Click(object sender, EventArgs e) //오류로 클릭한 Label. 코드 삭제 시 오류 발생(수정할 예정)
        {

        } //오류 코드 끝

        private void upButton_Click(object sender, EventArgs e)
        {
            if (courseRegistrationListBox.SelectedIndex > -1)
            {
                openClassListBox.Items.Add(courseRegistrationListBox.SelectedItem);
                courseRegistrationListBox.Items.Remove(courseRegistrationListBox.SelectedItem);
                courseRegistrationListBox.Text = "";
            }
            else MessageBox.Show("수강신청을 취소할 아이템을 선택해 주세요.");
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (openClassListBox.SelectedIndex > -1)
            {
                courseRegistrationListBox.Items.Add(openClassListBox.SelectedItem);
                openClassListBox.Items.Remove(openClassListBox.SelectedItem);
            }
            else MessageBox.Show("수강신청 목록으로 보낼 아이템을 선택해 주세요.");
        }

        private void courseRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void decisionButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (var item in courseRegistrationListBox.Items)
                    {
                        string courseName = item.ToString(); // 강의 이름이 문자열인 것을 가정하고 필요에 따라 수정

                        // 여기서 MySQL INSERT 명령어를 실행합니다.
                        string insertQuery = $"INSERT INTO account_info (classname) VALUES ('{courseName}')";

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("MySQL에 데이터 저장 완료!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"에러: {ex.Message}");
            }
        }
    }
}
