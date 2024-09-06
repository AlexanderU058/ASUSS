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
    public partial class FormSrSv : Form
    {
        public FormSrSv()
        {
            InitializeComponent();
        }

        private void FormSrSv_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.SRSV". При необходимости она может быть перемещена или удалена.
            this.sRSVTableAdapter.Fill(this.database1DataSet.SRSV);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.SRSV". При необходимости она может быть перемещена или удалена.
            this.sRSVTableAdapter.Fill(this.database1DataSet.SRSV);

        }

        private void sRSVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sRSVBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
