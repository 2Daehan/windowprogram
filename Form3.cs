

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using scheduler;

namespace winProExam
{
    public partial class Form3 : Form
    {
        private string userId;
        string connectionString = "Server=localhost;Database=dbtest;Uid=root;Pwd=1234;";
        DataTable selectedCoursesDataTable;

        public Form3(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        // MySQL에서 데이터를 로드하여 DataGridView1에 표시하는 메서드
        private void LoadDataFromMySQL()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // MySQL에서 데이터를 가져오는 쿼리 (id가 'master'에 해당하는 정보만 가져옴)
                    string selectQuery = "SELECT classname AS '과목명', professor AS '교수명', days AS '요일', class AS '분반', times1 AS '시작하는교시', time2 AS '끝나는교시' FROM class_info WHERE id = 'master'";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // 데이터그리드뷰에 데이터 바인딩
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"에러: {ex.Message}\n{ex.StackTrace}");
            }

            // 선택된 과목을 저장할 DataTable 초기화
            selectedCoursesDataTable = new DataTable();
            selectedCoursesDataTable.Columns.Add("과목명");
            selectedCoursesDataTable.Columns.Add("교수명");
            selectedCoursesDataTable.Columns.Add("요일");
            selectedCoursesDataTable.Columns.Add("분반");
            selectedCoursesDataTable.Columns.Add("시작하는교시");
            selectedCoursesDataTable.Columns.Add("끝나는교시");
        }

        private void WKUniversity_Click(object sender, EventArgs e) //오류로 클릭한 Label. 코드 삭제 시 오류 발생(수정할 예정)
        {

        } //오류 코드 끝

        private void upButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
                dataGridView2.Rows.RemoveAt(selectedRowIndex);
            }
            else
            {
                MessageBox.Show("삭제할 아이템을 선택해 주세요.");
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // 선택된 행을 DataTable에 추가
                selectedCoursesDataTable.Rows.Add(selectedRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());

                // dataGridView1에서 선택된 행 제거
                dataGridView1.Rows.RemoveAt(selectedRowIndex);
            }
        }

        private void courseRegistrationForm_Load(object sender, EventArgs e)
        {
            LoadDataFromMySQL();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void decisionButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // MySQL에 데이터를 저장하는 쿼리
                    string insertQuery = "INSERT INTO class_info(id, classname, professor, days, class, times1, time2) VALUES ";

                    foreach (DataRow row in selectedCoursesDataTable.Rows)
                    {
                        string userID = userId;
                        string classname = row["과목명"].ToString();
                        string professor = row["교수명"].ToString();
                        string days = row["요일"].ToString();
                        string classNumber = row["분반"].ToString();
                        string startTime = row["시작하는교시"].ToString();
                        string endTime = row["끝나는교시"].ToString();

                        // 각 행의 데이터를 MySQL 쿼리에 추가
                        insertQuery += $"('{userID}', '{classname}', '{professor}', '{days}', '{classNumber}', '{startTime}', '{endTime}'),";
                    }

                    // 마지막 쉼표(,) 제거
                    insertQuery = insertQuery.TrimEnd(',');

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("데이터가 성공적으로 저장되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"에러: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
           
            
        }

    }
}