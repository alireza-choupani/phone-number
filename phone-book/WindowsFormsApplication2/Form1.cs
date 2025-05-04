using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Phones : Form
    {
        public Phones()
        {
            InitializeComponent();
        }

        private void Phones_Load(object sender, EventArgs e)
        {
            // TODO: این خط کد داده ها را در جدول 'database18DataSet1.phones' بارگیری می کند. در صورت نیاز می توانید آن را جابجا کرده یا حذف کنید.
            this.phonesTableAdapter.Fill(this.database18DataSet1.phones);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.phonesTableAdapter.InsertQuery(name.Text, phone.Text);
                MessageBox.Show("phone number seccessfully added!");
            }
            catch (Exception)
            {
                MessageBox.Show("error during add phone number!");
                throw;
            }
            this.phonesTableAdapter.Fill(this.database18DataSet1.phones);

            name.Text = "";
            phone.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string record = (this.phonesTableAdapter.GetDataBy1(search.Text)).ToString();
                MessageBox.Show(record);
            }
            catch (Exception)
            {
                MessageBox.Show("error during getting data!");
                throw;
            }
            this.phonesTableAdapter.Fill(this.database18DataSet1.phones);

            name.Text = "";
            phone.Text = "";
        }
    }
}
