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
        int selectedId = 0;
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
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            selectedId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            NAMEtextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            GENDERtextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            AGEtextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            CLASStextBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void UPDATEbutton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                db = new StudentDbDataContext();
                db.spUpdateStudent(selectedId, NAMEtextBox.Text, GENDERtextBox.Text, int.Parse(AGEtextBox.Text), int.Parse(CLASStextBox3.Text));
                MessageBox.Show("Data has been Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                GridView();

            }
            else
            {
                MessageBox.Show("Please Select A Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CLEARbutton_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void DELETEbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult com = MessageBox.Show("Are You Sure Delete This", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (com == DialogResult.Yes)
                {

                    db = new StudentDbDataContext();
                    db.spDeleteStudent(selectedId);
                    MessageBox.Show("Data has been Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                    GridView();

                }
            }
            else
            {
                MessageBox.Show("Please Select A Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
