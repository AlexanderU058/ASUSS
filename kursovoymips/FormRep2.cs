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
    public partial class FormRep2 : Form
    {
        public FormRep2()
        {
            InitializeComponent();
        }

        private void zAKRBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zAKRBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormRep2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.SRSV". При необходимости она может быть перемещена или удалена.
            this.sRSVTableAdapter.Fill(this.database1DataSet.SRSV);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.OTV". При необходимости она может быть перемещена или удалена.
            this.oTVTableAdapter.Fill(this.database1DataSet.OTV);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.ZAKR". При необходимости она может быть перемещена или удалена.
            this.zAKRTableAdapter.Fill(this.database1DataSet.ZAKR);

           

            for (int i = 0; i < database1DataSet.Tables["ZAKR"].Rows.Count; i++)
            {
                dataGridView1.RowCount++;
                dataGridView1.Rows[i].Cells[0].Value = database1DataSet.Tables["ZAKR"].Rows[i].ItemArray[1];
                for (int k = 0; k < database1DataSet.Tables["OTV"].Rows.Count; k++)
                {
                    if ((int)database1DataSet.Tables["ZAKR"].Rows[i].ItemArray[2] == (int)database1DataSet.Tables["OTV"].Rows[k].ItemArray[0])
                    {
                        dataGridView1.Rows[i].Cells[3].Value = database1DataSet.Tables["ZAKR"].Rows[k].ItemArray[2];
                        dataGridView1.Rows[i].Cells[4].Value = database1DataSet.Tables["OTV"].Rows[k].ItemArray[1];
                    }
                }
                for (int k = 0; k < database1DataSet.Tables["SRSV"].Rows.Count; k++)
                {
                    if ((int)database1DataSet.Tables["ZAKR"].Rows[i].ItemArray[1] == (int)database1DataSet.Tables["SRSV"].Rows[k].ItemArray[0])
                    {
                        dataGridView1.Rows[i].Cells[1].Value = database1DataSet.Tables["SRSV"].Rows[k].ItemArray[1];
                        dataGridView1.Rows[i].Cells[2].Value = database1DataSet.Tables["SRSV"].Rows[k].ItemArray[2];
                    }
                }
                
            }
            

           // CurrencyManager manager1 = (CurrencyManager)BindingContext[zAKRDataGridView.DataSource];
            //manager1.SuspendBinding();
          //  CurrencyManager manager2 = (CurrencyManager)BindingContext[oTVDataGridView.DataSource];
          //  manager2.SuspendBinding();
           // CurrencyManager manager3 = (CurrencyManager)BindingContext[sRSVDataGridView.DataSource];
          //  manager3.SuspendBinding();

            //for (int i = 0; i < zAKRDataGridView.Rows.Count; i++)
           // {
              //  for (int k = 0; k < oTVDataGridView.Rows.Count; k++)
               // {
                //    if (zAKRDataGridView.Rows[i].Cells[3].Value == oTVDataGridView.Rows[k].Cells[0].Value)
                       // zAKRDataGridView.Rows[i].Cells[4].Value = oTVDataGridView.Rows[k].Cells[1].Value;
            //    }
             //   for (int k = 0; k < sRSVDataGridView.Rows.Count; k++)
              //  {
                //    if (zAKRDataGridView.Rows[i].Cells[1].Value == sRSVDataGridView.Rows[k].Cells[0].Value)
                //        zAKRDataGridView.Rows[i].Cells[2].Value = sRSVDataGridView.Rows[k].Cells[2].Value;
               // }

           // }
          //  manager1.ResumeBinding();
           // manager2.ResumeBinding();
           // manager3.ResumeBinding();
        }

        
    }
}
