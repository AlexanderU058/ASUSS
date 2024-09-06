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
    public partial class FormPered : Form
    {
        public FormPered()
        {
            InitializeComponent();
        }

        private void FormPered_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.PERED". При необходимости она может быть перемещена или удалена.
            this.pEREDTableAdapter.Fill(this.database1DataSet.PERED);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.PERED". При необходимости она может быть перемещена или удалена.
            this.pEREDTableAdapter.Fill(this.database1DataSet.PERED);

        }

        private void pEREDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pEREDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
