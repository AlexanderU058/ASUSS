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
    public partial class FormRep1 : Form
    {
        public FormRep1()
        {
            InitializeComponent();
        }

        private void FormRep1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.OTV". При необходимости она может быть перемещена или удалена.
            this.oTVTableAdapter.Fill(this.database1DataSet.OTV);

        }

        private void oTVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oTVBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
