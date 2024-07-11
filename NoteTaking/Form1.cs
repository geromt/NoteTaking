using System.Data;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        private DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Title"].Width = 115;
            dataGridView1.Columns["Messages"].Width = 115;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textTitle.Clear();
            textMessage.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textTitle.Text, textMessage.Text);
            textTitle.Clear();
            textMessage.Clear();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                textTitle.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                textMessage.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}
