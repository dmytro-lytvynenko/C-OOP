using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using TableEditor;

namespace TableEditor
{
    public partial class Form1 : Form
    {
        Table table = new Table();
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView(table.rowCount, table.colCount);
            splitContainer1.IsSplitterFixed = true;
        }


        private void InitializeDataGridView(int rows, int columns)
        {
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.ColumnCount = columns;
            for (int i = 0; i < columns; i++)
            {
                string columnName = NumberConverter.To26System(i);
                dataGridView1.Columns[i].Name = columnName;
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < rows; i++)
            {
                dataGridView1.Rows.Add("");
                dataGridView1.Rows[i].HeaderCell.Value = (i).ToString();
            }
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            table.setTable(columns, rows);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int col = dataGridView1.SelectedCells[0].ColumnIndex;
            int row = dataGridView1.SelectedCells[0].RowIndex;
            string expression = textBox.Text;
            if (expression == "") return;
            table.ChangeCellWithAllPointers(row, col, expression, dataGridView1);
            dataGridView1[col, row].Value = Table.grid[row][col].value;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = dataGridView1.SelectedCells[0].ColumnIndex;
            int row = dataGridView1.SelectedCells[0].RowIndex;
            string expression = Table.grid[row][col].expression;
            string value = Table.grid[row][col].value;
            textBox.Text = expression;
            textBox.Focus();
        }

        private void buttonAR_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new System.Windows.Forms.DataGridViewRow();
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("There are no columns!");
                return;
            }
            dataGridView1.Rows.Add(row);
            dataGridView1.Rows[table.rowCount].HeaderCell.Value = (table.rowCount).ToString();
            table.AddRow(dataGridView1);
        }

        private void buttonDR_Click(object sender, EventArgs e)
        {
            if (!table.DeleteRow(dataGridView1))
                return;
            dataGridView1.Rows.RemoveAt(table.rowCount);
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            string name = NumberConverter.To26System(table.colCount);
            dataGridView1.Columns.Add(name, name);
            table.AddColumn(dataGridView1);
        }

        private void buttonDC_Click(object sender, EventArgs e)
        {
            if (!table.DeleteColumn(dataGridView1))
                return;
            dataGridView1.Columns.RemoveAt(table.colCount);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TableFile|*.txt";
            saveFileDialog.Title = "Save table file";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(fs);
                table.Save(sw);
                sw.Close();
                fs.Close();
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TableFile|*.txt";
            openFileDialog.Title = "Open Table File";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            StreamReader sr = new StreamReader(openFileDialog.FileName);
            table.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int row; int column;
            Int32.TryParse(sr.ReadLine(), out row);
            Int32.TryParse(sr.ReadLine(), out column);
            InitializeDataGridView(row, column);
            table.Open(row, column, sr, dataGridView1);
            sr.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult userAnswer = MessageBox.Show("Do you wanna close the table?", "Close table?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userAnswer == DialogResult.Yes)
                this.Dispose();
            else if (userAnswer == DialogResult.No)
                e.Cancel = true;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string message = "Програма підтримує операції +, -,"
                + " /, *, ^, XmodY, XdivY.\nУ полі для введеня необхідно ввести значення" +
                " або вираз з використанням = на початку виразу). Зайві спейси ставити не варто.\n" +
                "Скористайтеся кнопками Save та Open " +
                "\nдля відповідно збереження або відкриття існуючої таблиці.";
            MessageBox.Show(message);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
