

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

            // dataGridView2에서 선택된 셀이 있는지 확인
            if (dataGridView2.SelectedCells.Count > 0)
            {
                // 선택된 셀의 행 인덱스 가져오기
                int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;

                // DataGridView2의 선택된 행 데이터 가져오기
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];

                // 선택된 행의 데이터 배열
                object[] rowData = selectedRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray();

                // DataGridView2에서 선택된 행 제거
                dataGridView2.Rows.RemoveAt(selectedRowIndex);

                // selectedCoursesDataTable에서 해당 행 제거
                DataRow[] rowsToDelete = selectedCoursesDataTable.Select($"과목명 = '{rowData[0]}' AND 교수명 = '{rowData[1]}' AND 요일 = '{rowData[2]}' AND 분반 = '{rowData[3]}' AND 시작하는교시 = '{rowData[4]}' AND 끝나는교시 = '{rowData[5]}'");
                foreach (DataRow row in rowsToDelete)
                {
                    selectedCoursesDataTable.Rows.Remove(row);
                }
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            // dataGridView1에서 선택된 셀이 있는지 확인
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // 선택된 셀의 행 인덱스 가져오기
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                // DataGridView1의 선택된 행 데이터 가져오기
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // 선택된 행의 데이터 배열
                object[] rowData = selectedRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray();


                // 중복 여부 확인
                bool issame = dataGridView2.Rows.Cast<DataGridViewRow>().Any(row =>
                {
                    // 각 행의 데이터를 가져와서 비교
                    bool isSameRow = true;
                    for (int i = 0; i < rowData.Length; i++)
                    {
                        if (!rowData[i].Equals(row.Cells[i].Value))
                        {
                            isSameRow = false;
                            break;
                        }
                    }
                    return isSameRow;
                });

                // 중복이 아니면 추가
                if (!issame)
                {
                    // 선택된 행을 DataTable에 추가
                    selectedCoursesDataTable.Rows.Add(rowData);

                    // DataGridView2에 추가
                    dataGridView2.Rows.Add(rowData);
                }
                else
                {
                    MessageBox.Show("이미 선택된 항목입니다.");
                }
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
                    string insertQuery = "INSERT INTO class_info(id, classname, professor, days, class, times1, time2) VALUES";

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
                Form4 form4 = new Form4(userId);
                form4.Show();
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