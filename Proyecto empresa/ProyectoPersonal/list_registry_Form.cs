using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPersonal
{
    public partial class list_registry_Form : Form
    {
        public list_registry_Form()
        {
            InitializeComponent();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_registry_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bBDDmaestraDataSet1.personal' table. You can move, or remove it, as needed.
            this.personalTableAdapter1.Fill(this.bBDDmaestraDataSet1.personal);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personalTableAdapter.FillBy(this.bBDDmaestraDataSet.personal);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
