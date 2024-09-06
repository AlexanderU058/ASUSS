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
    public partial class FormZakrep : Form
    {
        public FormZakrep()
        {
            InitializeComponent();
        }

        private void zAKRBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zAKRBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormZakrep_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.ZAKR". При необходимости она может быть перемещена или удалена.
            this.zAKRTableAdapter.Fill(this.database1DataSet.ZAKR);

        }
    }
}
