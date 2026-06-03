using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_LInq_To_Sql
{
    public partial class Form3 : Form
    {
        StudentDbDataContext db;
        public Form3()
        {
            InitializeComponent();
        }
        private void ClearTextBox()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = ctr as TextBox;
                    txt.Clear();
                }
            }
            NAMEtextBox.Focus();
        }
        private void GridView()
        {
            db = new StudentDbDataContext();
            dataGridView1.DataSource = db.students;
        }

        private void INSERTbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NAMEtextBox.Text) || string.IsNullOrWhiteSpace(GENDERtextBox.Text) || string.IsNullOrWhiteSpace(AGEtextBox.Text) || string.IsNullOrWhiteSpace(CLASStextBox3.Text))
            {
                MessageBox.Show("Please fill up all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            db = new StudentDbDataContext();
            db.spInsertStudent(NAMEtextBox.Text, GENDERtextBox.Text, int.Parse(AGEtextBox.Text), int.Parse(CLASStextBox3.Text));
            MessageBox.Show("Data has been inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBox();
            GridView();



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GridView();
        }
    }
}
