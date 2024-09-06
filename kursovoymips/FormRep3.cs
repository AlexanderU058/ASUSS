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
    public partial class FormRep3 : Form
    {
        public FormRep3()
        {
            InitializeComponent();
        }

        

        private void FormRep3_Load(object sender, EventArgs e)
        {     
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.REM". При необходимости она может быть перемещена или удалена.
            this.rEMTableAdapter.Fill(this.database1DataSet.REM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.POST". При необходимости она может быть перемещена или удалена.
            this.pOSTTableAdapter.Fill(this.database1DataSet.POST);

        }

        private void pOSTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pOSTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            CurrencyManager manager1 = (CurrencyManager)BindingContext[pOSTDataGridView.DataSource];
            manager1.SuspendBinding();
            

            
            for (int i = 0; i < pOSTDataGridView.Rows.Count; i++)
            {

                if ((pOSTDataGridView.Rows[i].Cells[2].Value !=null) && (DateTime.Compare(Convert.ToDateTime(pOSTDataGridView.Rows[i].Cells[2].Value), dateTimePicker2.Value) <= 0) && (DateTime.Compare(Convert.ToDateTime(pOSTDataGridView.Rows[i].Cells[2].Value), dateTimePicker1.Value)>=0))
                {
                    
                    pOSTDataGridView.Rows[i].Visible = true;
                }
                else 
                {                    
                    pOSTDataGridView.Rows[i].Visible = false;
                }
            }
            manager1.ResumeBinding();
            CurrencyManager manager2 = (CurrencyManager)BindingContext[rEMDataGridView.DataSource];
            manager2.SuspendBinding();
            for (int i = 0; i < rEMDataGridView.Rows.Count; i++)
            {
                if ((pOSTDataGridView.Rows[i].Cells[2].Value != null) && (DateTime.Compare(Convert.ToDateTime(rEMDataGridView.Rows[i].Cells[4].Value), dateTimePicker2.Value) <= 0) && (DateTime.Compare(Convert.ToDateTime(rEMDataGridView.Rows[i].Cells[4].Value), dateTimePicker1.Value) >= 0))
                {
                    rEMDataGridView.Rows[i].Visible = true;
                }
                else
                {
                    pOSTDataGridView.Rows[i].Visible = false;
                }
            }            
            manager2.ResumeBinding();

        }
    }
}
