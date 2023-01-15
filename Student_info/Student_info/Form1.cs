namespace Student_info
{
    public partial class Form1 : Form
    {
        private int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = txtID.Text;
            dataGridView1.Rows[n].Cells[1].Value = txtName.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtSurname.Text;
            dataGridView1.Rows[n].Cells[3].Value = txtBirth.Text;
            dataGridView1.Rows[n].Cells[4].Value = txtStature.Text;
            dataGridView1.Rows[n].Cells[5].Value = txtGrade.Text;
            dataGridView1.Rows[n].Cells[6].Value = txtBranch.Text;

            txtID.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtBirth.Text = "";
            txtStature.Text = "";
            txtGrade.Text = "";
            txtBranch.Text = "";
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if(n!= -1)
            {
                dataGridView1.Rows.RemoveAt(n);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if(n!= -1)
            {
                label8.Text = (string)dataGridView1.Rows[n].Cells[1].Value;
            }
        }
    }
}