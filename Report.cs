using MySql.Data.MySqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Drawing.Chart;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Act4EDP
{
    public partial class Report : Form
    {
        private MySqlConnection connection;
        private string PlayerID;
        public Report(string PlayerID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComboBox();
            this.PlayerID = PlayerID;
        }

        private void InitializeComboBox()
        {
            // Add items to the combo box
            datacb.Items.Add("Player Statistics");
            datacb.Items.Add("Players' Rank");
            datacb.Items.Add("Match Details");
        }


        private void Report_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=valorantplayersdb;password=rachelle040403;";
            connection = new MySqlConnection(connectionString);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DshbrdLbel_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard(PlayerID);
            dashboardForm.Show();

            this.Hide();
        }

        private void matcheslbl_Click(object sender, EventArgs e)
        {
            Match matchForm = new Match();
            matchForm.Show();

            this.Hide();
        }

        private void weaponlbl_Click(object sender, EventArgs e)
        {
            Weapon weaponForm = new Weapon();
            weaponForm.Show();

            this.Hide();
        }

        private void agentslbl_Click(object sender, EventArgs e)
        {
            Agents agentsForm = new Agents();
            agentsForm.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maplbl_Click(object sender, EventArgs e)
        {
            Map mapForm = new Map();
            mapForm.Show();

            this.Hide();
        }

        private void reportlbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerList_Click(object sender, EventArgs e)
        {
            User userForm = new User();
            userForm.Show();

            this.Hide();
        }

        private void SgnBTN_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Show the login form
            this.Close(); // Close the dashboard form
        }

        private void datacb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            // Get selected item from ComboBox
            string selectedItem = datacb.SelectedItem.ToString();

            // Populate DataGridView based on selected item
            switch (selectedItem)
            {
                case "Player Statistics":
                    LoadPlayerStatistics();
                    break;
                case "Players' Rank":
                    LoadPlayersRank(); 
                    break;
                case "Match Details":
                    LoadMatchDetails(); 
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exportbtn_Click(object sender, EventArgs e)
        {
            DataTable currentData = (DataTable)dataGridView1.DataSource;
            ExportToExcel(currentData, datacb.SelectedItem.ToString());
        }


        private void ExportToExcel(DataTable currentData, string selectedItem)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (.xlsx)|.xlsx|All files (.)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Set the license context
                        using (OfficeOpenXml.ExcelPackage excelPackage = new OfficeOpenXml.ExcelPackage())
                        {
                            // Create Sheet1 with data
                            var sheet1 = excelPackage.Workbook.Worksheets.Add("Sheet1");
                            CreateDataWorksheet(sheet1);

                            // Create Sheet2 with graph
                            var sheet2 = excelPackage.Workbook.Worksheets.Add("Sheet2");
                            CreateGraphWorksheet(excelPackage, sheet2, selectedItem); // Pass the excelPackage variable

                            excelPackage.SaveAs(new System.IO.FileInfo(filePath));
                            MessageBox.Show("Data exported successfully!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message);
            }
        }



        private void CreateDataWorksheet(OfficeOpenXml.ExcelWorksheet worksheet)
        {
            // Add company logo if available
            if (logo.BackgroundImage != null)
            {
                using (var logoStream = new MemoryStream())
                {
                    Bitmap logoImage = (Bitmap)logo.BackgroundImage;
                    logoImage.Save(logoStream, System.Drawing.Imaging.ImageFormat.Png);
                    ExcelPicture logoPicture = worksheet.Drawings.AddPicture("Logo", logoStream);
                    logoPicture.SetPosition(1, 0, 0, 0); // Position at cell A1
                    logoPicture.SetSize(100, 100); // Adjust the size of the logo
                }
            }

            // Add company name
            worksheet.Cells["C3"].Value = "Valorant Information Management System";
            worksheet.Cells["C3"].Style.Font.Bold = true;
            worksheet.Cells["C3"].Style.Font.Size = 16; // Increase font size for better visibility

            // Add data from DataGridView
            int startRow = 9;
            int startCol = 1;
            int labelRow = startRow - 2;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    // Add headers
                    if (i == 0)
                    {
                        worksheet.Cells[labelRow, j + startCol].Value = dataGridView1.Columns[j].HeaderText;
                        worksheet.Cells[labelRow, j + startCol].Style.Font.Bold = true;
                    }

                    // Add data
                    var cellValue = dataGridView1.Rows[i].Cells[j].Value;
                    var cell = worksheet.Cells[i + startRow, j + startCol];

                    if (cellValue != null)
                    {
                        if (dataGridView1.Columns[j].DefaultCellStyle.FormatProvider is System.IFormatProvider provider)
                        {
                            // If there is a format provider, try to parse the value as a number
                            if (double.TryParse(cellValue.ToString(), System.Globalization.NumberStyles.Any, provider, out double number))
                            {
                                // If successful, set the cell value as a number
                                cell.Value = number;
                            }
                            else
                            {
                                // If parsing fails, set the cell value as text
                                cell.Value = cellValue.ToString();
                            }
                        }
                        else
                        {
                            // If there is no format provider, set the cell value as text
                            cell.Value = cellValue.ToString();
                        }
                    }
                    else
                    {
                        // If the cell value is null, set an empty string
                        cell.Value = "";
                    }
                }
            }

            // Add signature placeholder
            worksheet.Cells["C5"].Value = "Signature:";
            worksheet.Cells["C5"].Style.Font.Bold = true;
            worksheet.Cells["D5"].Value = "____________________";
            worksheet.Cells["D5"].Style.Font.Bold = true;
        }


        private void CreateGraphWorksheet(ExcelPackage excelPackage, ExcelWorksheet worksheet, string selectedItem)
        {
            // Get the data from Sheet1
            ExcelWorksheet dataWorksheet = excelPackage.Workbook.Worksheets["Sheet1"];

            // Determine the range of data for the chart
            ExcelRangeBase dataRangeBase;

            switch (selectedItem)
            {
                case "Player Statistics":
                    dataRangeBase = dataWorksheet.Cells[dataWorksheet.Dimension.Address];
                    break;
                case "Players' Rank":
                    dataRangeBase = dataWorksheet.Cells[dataWorksheet.Dimension.Address];
                    break;
                case "Match Details":
                    dataRangeBase = dataWorksheet.Cells[dataWorksheet.Dimension.Address];
                    break;
                default:
                    throw new ArgumentException("Invalid selected item: " + selectedItem);
            }

            ExcelRange dataRange = (ExcelRange)dataRangeBase;

            // Create a new chart
            ExcelChart chart = worksheet.Drawings.AddChart("Chart", eChartType.ColumnClustered);

            // Configure the chart
            chart.SetSize(800, 400);
            chart.SetPosition(1, 0, 0, 0);
            chart.Title.Text = selectedItem + " Chart";

            // Add series to the chart
            var series = chart.Series.Add(dataRange.Offset(1, 1, dataRange.Rows - 1, 1), dataRange.Offset(1, 0, dataRange.Rows - 1, 1));
            series.Header = selectedItem + " Data";

            // Remove the legend
            chart.Legend.Remove();
        }

        private void LoadPlayerStatistics()
        {
            // Open database connection
            connection.Open();

            // Create SQL command to retrieve player statistics
            string query = "SELECT * FROM PlayerStatistics";

            // Create data adapter
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

            // Create dataset to hold data from database
            DataSet ds = new DataSet();

            // Fill dataset with data from database
            adapter.Fill(ds, "PlayerStatistics");

            // Set DataGridView data source to the dataset
            dataGridView1.DataSource = ds.Tables["PlayerStatistics"];

            // Close database connection
            connection.Close();
        }

        private void LoadPlayersRank() 
        {
            // Open database connection
            connection.Open();

            // Create SQL command to retrieve players' rank
            string query = "SELECT * FROM player_ranks"; 

            // Create data adapter
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

            // Create dataset to hold data from database
            DataSet ds = new DataSet();

            // Fill dataset with data from database
            adapter.Fill(ds, "player_ranks"); 

            // Set DataGridView data source to the dataset
            dataGridView1.DataSource = ds.Tables["player_ranks"]; 

            // Close database connection
            connection.Close();
        }

        private void LoadMatchDetails() // 
        {
            // Open database connection
            connection.Open();

            // Create SQL command to retrieve matches
            string query = "SELECT * FROM match_details"; 

            // Create data adapter
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

            // Create dataset to hold data from database
            DataSet ds = new DataSet();

            // Fill dataset with data from database
            adapter.Fill(ds, "match_details"); 
            // Set DataGridView data source to the dataset
            dataGridView1.DataSource = ds.Tables["match_details"]; 

            // Close database connection
            connection.Close();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }
}
