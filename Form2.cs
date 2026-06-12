using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_LInq_To_Sql
{
    public partial class Form2 : Form
    {
        StudentDbDataContext db;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new StudentDbDataContext();
            ISingleResult<spShowStudentResult> obj = db.spShowStudent(null);
            dataGridView2.DataSource = obj;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(SearchtextBox.Text)==true)
            {
                MessageBox.Show("Please fill up The fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                db = new StudentDbDataContext();
                ISingleResult<spShowStudentResult> obj = db.spShowStudent(int.Parse(SearchtextBox.Text));
                dataGridView2.DataSource = obj;
            }
            if(dataGridView2.Rows.Count==1)
            {
                MessageBox.Show("No Rows Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            db = new StudentDbDataContext();
            ISingleResult<spShowStudentResult> obj = db.spShowStudent(null);
            dataGridView2.DataSource = obj;
        }
    }
}
