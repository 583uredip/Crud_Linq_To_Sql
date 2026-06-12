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
    public partial class Form4 : Form
    {
        ProductDbDataContext pd;
        public Form4()
        {
            InitializeComponent();
        }

        private void GrideView()
        {
            pd = new ProductDbDataContext();
            dataGridView1.DataSource = pd.Products.ToList();
            
        }
        private void ClearTex()
        {
           foreach(Control crt in this.Controls)
            {
                if(crt is TextBox)
                {
                    TextBox txt = crt as TextBox;
                    txt.Clear();
                }
            }
            NAMEtextBox.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            GrideView();
        }

        private void CLEARbutton_Click(object sender, EventArgs e)
        {
            ClearTex();
        }

        private void INSERTbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NAMEtextBox.Text) ||
                string.IsNullOrWhiteSpace(PRICEtextBox.Text) ||
                string.IsNullOrWhiteSpace(MODELtextBox.Text) ||
                string.IsNullOrWhiteSpace(QUANTITYtextBox.Text))
            {
                MessageBox.Show("Please fill up all fields.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            decimal price;
            int quantity;

            if (!decimal.TryParse(PRICEtextBox.Text, out price))
            {
                MessageBox.Show("Price must be a valid number!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(QUANTITYtextBox.Text, out quantity))
            {
                MessageBox.Show("Quantity must be a valid number!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pd = new ProductDbDataContext();
            Product pro = new Product();
            pro.Name = NAMEtextBox.Text;
            pro.Price = price;
            pro.Model = MODELtextBox.Text;
            pro.Quantity = quantity;
            pd.Products.InsertOnSubmit(pro);
            pd.SubmitChanges();
            MessageBox.Show("Data Inserted Successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTex();
            GrideView();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            NAMEtextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PRICEtextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            MODELtextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            QUANTITYtextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


        }

        private void UPDATEbutton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Product pro = pd.Products.FirstOrDefault(s => s.Id == id);
                pro.Name = NAMEtextBox.Text;
                pro.Price = decimal.Parse(PRICEtextBox.Text);
                pro.Model = MODELtextBox.Text;
                pro.Quantity = int.Parse(QUANTITYtextBox.Text);
                //pd.Products.InsertOnSubmit(pro);
                pd.SubmitChanges();
                MessageBox.Show("Data has been Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTex();
                GrideView();

            }
            else
            {
                MessageBox.Show("Please Select A Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DELETEbutton_Click(object sender, EventArgs e)
        {
            DialogResult com = MessageBox.Show("Are You Sure Delete This", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(com==DialogResult.Yes)
            {
                pd = new ProductDbDataContext();
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Product pro = pd.Products.FirstOrDefault(s => s.Id == id);
                pd.Products.DeleteOnSubmit(pro);
                pd.SubmitChanges();
                MessageBox.Show("Data has been Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTex();
                GrideView();
            }
            else
            {
                MessageBox.Show("Please Select A Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
