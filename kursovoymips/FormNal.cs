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
    public partial class FormNal : Form
    {
        public FormNal()
        {
            InitializeComponent();
        }

        private void nALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nALBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormNal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.NAL". При необходимости она может быть перемещена или удалена.
            this.nALTableAdapter.Fill(this.database1DataSet.NAL);

        }
    }
}
