
namespace Crud_LInq_To_Sql
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NAMEtextBox = new System.Windows.Forms.TextBox();
            this.INSERTbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GENDERlabel = new System.Windows.Forms.Label();
            this.AGEtextBox = new System.Windows.Forms.TextBox();
            this.CLASStextBox3 = new System.Windows.Forms.TextBox();
            this.GENDERtextBox = new System.Windows.Forms.TextBox();
            this.CLEARbutton = new System.Windows.Forms.Button();
            this.DELETEbutton = new System.Windows.Forms.Button();
            this.UPDATEbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENTS DETAIL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NAMEtextBox
            // 
            this.NAMEtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAMEtextBox.Location = new System.Drawing.Point(212, 127);
            this.NAMEtextBox.Name = "NAMEtextBox";
            this.NAMEtextBox.Size = new System.Drawing.Size(233, 30);
            this.NAMEtextBox.TabIndex = 0;
            this.NAMEtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // INSERTbutton
            // 
            this.INSERTbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERTbutton.Location = new System.Drawing.Point(52, 341);
            this.INSERTbutton.Name = "INSERTbutton";
            this.INSERTbutton.Size = new System.Drawing.Size(121, 42);
            this.INSERTbutton.TabIndex = 4;
            this.INSERTbutton.Text = "INSERT";
            this.INSERTbutton.UseVisualStyleBackColor = true;
            this.INSERTbutton.Click += new System.EventHandler(this.INSERTbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "CLASS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "AGE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GENDERlabel
            // 
            this.GENDERlabel.AutoSize = true;
            this.GENDERlabel.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENDERlabel.Location = new System.Drawing.Point(87, 175);
            this.GENDERlabel.Name = "GENDERlabel";
            this.GENDERlabel.Size = new System.Drawing.Size(111, 29);
            this.GENDERlabel.TabIndex = 6;
            this.GENDERlabel.Text = "GENDER";
            this.GENDERlabel.Click += new System.EventHandler(this.GENDERlabel_Click);
            // 
            // AGEtextBox
            // 
            this.AGEtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGEtextBox.Location = new System.Drawing.Point(212, 225);
            this.AGEtextBox.Name = "AGEtextBox";
            this.AGEtextBox.Size = new System.Drawing.Size(233, 30);
            this.AGEtextBox.TabIndex = 2;
            this.AGEtextBox.TextChanged += new System.EventHandler(this.AGEtextBox_TextChanged);
            // 
            // CLASStextBox3
            // 
            this.CLASStextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLASStextBox3.Location = new System.Drawing.Point(212, 274);
            this.CLASStextBox3.Name = "CLASStextBox3";
            this.CLASStextBox3.Size = new System.Drawing.Size(233, 30);
            this.CLASStextBox3.TabIndex = 3;
            this.CLASStextBox3.TextChanged += new System.EventHandler(this.CLASStextBox3_TextChanged);
            // 
            // GENDERtextBox
            // 
            this.GENDERtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENDERtextBox.Location = new System.Drawing.Point(212, 175);
            this.GENDERtextBox.Name = "GENDERtextBox";
            this.GENDERtextBox.Size = new System.Drawing.Size(233, 30);
            this.GENDERtextBox.TabIndex = 1;
            this.GENDERtextBox.TextChanged += new System.EventHandler(this.GENDERtextBox_TextChanged);
            // 
            // CLEARbutton
            // 
            this.CLEARbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEARbutton.Location = new System.Drawing.Point(500, 341);
            this.CLEARbutton.Name = "CLEARbutton";
            this.CLEARbutton.Size = new System.Drawing.Size(121, 42);
            this.CLEARbutton.TabIndex = 7;
            this.CLEARbutton.Text = "CLEAR";
            this.CLEARbutton.UseVisualStyleBackColor = true;
            this.CLEARbutton.Click += new System.EventHandler(this.CLEARbutton_Click);
            // 
            // DELETEbutton
            // 
            this.DELETEbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEbutton.Location = new System.Drawing.Point(354, 341);
            this.DELETEbutton.Name = "DELETEbutton";
            this.DELETEbutton.Size = new System.Drawing.Size(121, 42);
            this.DELETEbutton.TabIndex = 6;
            this.DELETEbutton.Text = "DELETE";
            this.DELETEbutton.UseVisualStyleBackColor = true;
            this.DELETEbutton.Click += new System.EventHandler(this.DELETEbutton_Click);
            // 
            // UPDATEbutton
            // 
            this.UPDATEbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEbutton.Location = new System.Drawing.Point(212, 341);
            this.UPDATEbutton.Name = "UPDATEbutton";
            this.UPDATEbutton.Size = new System.Drawing.Size(126, 42);
            this.UPDATEbutton.TabIndex = 5;
            this.UPDATEbutton.Text = "UPDATE";
            this.UPDATEbutton.UseVisualStyleBackColor = true;
            this.UPDATEbutton.Click += new System.EventHandler(this.UPDATEbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(569, 290);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 714);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UPDATEbutton);
            this.Controls.Add(this.DELETEbutton);
            this.Controls.Add(this.CLEARbutton);
            this.Controls.Add(this.GENDERtextBox);
            this.Controls.Add(this.CLASStextBox3);
            this.Controls.Add(this.AGEtextBox);
            this.Controls.Add(this.GENDERlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.INSERTbutton);
            this.Controls.Add(this.NAMEtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NAMEtextBox;
        private System.Windows.Forms.Button INSERTbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GENDERlabel;
        private System.Windows.Forms.TextBox AGEtextBox;
        private System.Windows.Forms.TextBox CLASStextBox3;
        private System.Windows.Forms.TextBox GENDERtextBox;
        private System.Windows.Forms.Button CLEARbutton;
        private System.Windows.Forms.Button DELETEbutton;
        private System.Windows.Forms.Button UPDATEbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

