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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuPodrOtv_Click(object sender, EventArgs e)
        {
            FormPodrOtv form_COMP = new FormPodrOtv();
            form_COMP.Owner = this;
            form_COMP.Show();
        }

        private void menuOtv_Click(object sender, EventArgs e)
        {
            FormOtv form_COMP = new FormOtv();
            form_COMP.Owner = this;
            form_COMP.Show();
        }

        private void menuSrSv_Click(object sender, EventArgs e)
        {
            FormSrSv form_COMP = new FormSrSv();
            form_COMP.Owner = this;
            form_COMP.Show();
        }

        private void menuPostNalZakr_Click(object sender, EventArgs e)
        {
            FormPostNalZakr form_COMP = new FormPostNalZakr();
            form_COMP.Owner = this;
            form_COMP.Show();
        }

        private void menuNal_Click(object sender, EventArgs e)
        {
            FormNal form_COMP = new FormNal();
            form_COMP.Owner = this;
            form_COMP.Show();
        }

        private void menuZakrep_Click(object sender, EventArgs e)
        {
            FormZakrep form_COMP = new FormZakrep();
            form_COMP.Owner = this;
            form_COMP.Show();
        }

        private void menuPered_Click(object sender, EventArgs e)
        {
            FormPered form_COMP = new FormPered();
            form_COMP.Owner = this;
            form_COMP.Show();
        }

        private void menuRemSpis_Click(object sender, EventArgs e)
        {
            FormRemSpis form_COMP = new FormRemSpis();
            form_COMP.Owner = this;
            form_COMP.Show();
        }

        private void menuRep1_Click(object sender, EventArgs e)
        {
            FormRep1 form_COMP = new FormRep1();
            form_COMP.Owner = this;
            form_COMP.Show();
        }

        private void menuRep2_Click(object sender, EventArgs e)
        {
            FormRep2 form_COMP = new FormRep2();
            form_COMP.Owner = this;
            form_COMP.Show();
        }

        private void nenuRep3_Click(object sender, EventArgs e)
        {
            FormRep3 form_COMP = new FormRep3();
            form_COMP.Owner = this;
            form_COMP.Show();
        }

    }
}
