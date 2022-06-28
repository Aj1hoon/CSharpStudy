using MySql.Data.MySqlClient;

namespace Project_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<User> users = DBAccess.Instance.SelectUsers();
            // 데이터그리드뷰 데이터 공급
            dataGridView1.DataSource = users;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            string age = NumericUpDown.Text.ToString();

            DBAccess.Instance.InsertUser(uid, name, hp, age);

            List<User> users = DBAccess.Instance.SelectUsers();
            dataGridView1.DataSource = users;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            NumericUpDown.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            DBAccess.Instance.DeleteUser(uid);

            List<User> users = DBAccess.Instance.SelectUsers();
            dataGridView1.DataSource = users;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show("click!");
            int selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            string name = row.Cells[1].Value.ToString();
            txtName.Text = name;

            string uid = row.Cells[0].Value.ToString();
            txtUid.Text = uid;

            string hp = row.Cells[2].Value.ToString();
            txtHp.Text = hp;

            string age = row.Cells[3].Value.ToString();
            //int age = (int)row.Cells[3].Value;
            NumericUpDown.Text = age;

            Console.Write(uid + name + hp + age);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            string age = NumericUpDown.Text.ToString();

            DBAccess.Instance.UpdateUser(uid, name, hp, age);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<User> users = DBAccess.Instance.SelectUsers();
            dataGridView1.DataSource = users;
        }
    }
    }
