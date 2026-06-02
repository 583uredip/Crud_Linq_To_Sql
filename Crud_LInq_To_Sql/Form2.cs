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
            ISingleResult<spShowAtudentResult> obj = db.spShowAtudent();
            dataGridView2.DataSource = obj;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
