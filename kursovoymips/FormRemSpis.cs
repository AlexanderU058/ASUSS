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
    public partial class FormRemSpis : Form
    {
        public FormRemSpis()
        {
            InitializeComponent();
        }

        private void FormRemSpis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.REM". При необходимости она может быть перемещена или удалена.
            this.rEMTableAdapter.Fill(this.database1DataSet.REM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.REM". При необходимости она может быть перемещена или удалена.
            this.rEMTableAdapter.Fill(this.database1DataSet.REM);

        }

        private void rEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rEMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
