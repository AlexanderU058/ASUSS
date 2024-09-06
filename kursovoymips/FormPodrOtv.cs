using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kursovoymips
{
    public partial class FormPodrOtv : Form
    {
        public FormPodrOtv()
        {
            InitializeComponent();
        }

        private void mnClose_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPodrOtv_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.PODR". При необходимости она может быть перемещена или удалена.
            this.pODRTableAdapter.Fill(this.database1DataSet.PODR);

        }

        private void pODRBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pODRBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
