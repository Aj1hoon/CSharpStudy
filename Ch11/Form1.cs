namespace Ch11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��ư1 Ŭ��!");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� ������ �ִ� �޽����ڽ�", "��ư2 Ŭ��!");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�ΰ��� ��ư�� ���� �޽����ڽ�", "�޽����ڽ�3", MessageBoxButtons.YesNo);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ��ư�� ���� �޽����ڽ�",
                            "�޽����ڽ�4",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Exclamation);
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text = "��� : " + uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lbName.Text = "��� : " + name;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            lbHp.Text = "��� : " + txtHp.Text;
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chbFruits = { chbFruit1, chbFruit2, chbFruit3, chbFruit4, chbFruit5 };

            List<string> fruits = new List<string>();

            foreach (CheckBox chb in chbFruits)
            {
                if (chb.Checked)
                {
                    fruits.Add(chb.Text);
                }
            }
            lbResultFruit.Text = "������ ���� : " + String.Join(", ", fruits);
        }

        private void btnSex_Click_1(object sender, EventArgs e)
        {
            RadioButton[] btnSexer = { rbMale, rbFemale};

            List<string> sexer = new List<string>();

            foreach (RadioButton chb in btnSexer)
            {
                if (chb.Checked)
                {
                    sexer.Add(chb.Text);
                }
            }
            lbResultSex.Text = "��� : " + String.Join(", ", sexer);
        }
        /*
         * if (rdMale.Checked)
         * {
         * lbResultSex.Text = "��� : ����";
         * }
         * else
         * {
         * lbResultSex.Text = "��� : ����";
         * }
         */
        private void btnYear_Click(object sender, EventArgs e)
        {
            if (rbYear1.Checked)
            {
                lbResultYear.Text = "��� : 1�г�";
            }
            else if (rbYear2.Checked)
            {
                lbResultYear.Text = "��� : 2�г�";
            }
            else if (rbYear3.Checked)
            {
                lbResultYear.Text = "��� : 3�г�";
            }
            else if (rbYear4.Checked)
            {
                lbResultYear.Text = "��� : 4�г�";
            }

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}