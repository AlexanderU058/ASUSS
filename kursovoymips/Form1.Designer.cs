namespace kursovoymips
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPodrOtv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOtv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSrSv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPostNalZakr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZakrep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPered = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemSpis = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRep1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRep2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nenuRep3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPodrOtv,
            this.menuOtv,
            this.menuSrSv,
            this.menuPostNalZakr,
            this.menuNal,
            this.menuZakrep,
            this.menuPered,
            this.menuRemSpis});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // menuPodrOtv
            // 
            this.menuPodrOtv.Name = "menuPodrOtv";
            this.menuPodrOtv.Size = new System.Drawing.Size(258, 22);
            this.menuPodrOtv.Text = "Подразделения воинской части";
            this.menuPodrOtv.Click += new System.EventHandler(this.menuPodrOtv_Click);
            // 
            // menuOtv
            // 
            this.menuOtv.Name = "menuOtv";
            this.menuOtv.Size = new System.Drawing.Size(258, 22);
            this.menuOtv.Text = "Ответственные лица";
            this.menuOtv.Click += new System.EventHandler(this.menuOtv_Click);
            // 
            // menuSrSv
            // 
            this.menuSrSv.Name = "menuSrSv";
            this.menuSrSv.Size = new System.Drawing.Size(258, 22);
            this.menuSrSv.Text = "Средства связи";
            this.menuSrSv.Click += new System.EventHandler(this.menuSrSv_Click);
            // 
            // menuPostNalZakr
            // 
            this.menuPostNalZakr.Name = "menuPostNalZakr";
            this.menuPostNalZakr.Size = new System.Drawing.Size(258, 22);
            this.menuPostNalZakr.Text = "Поступление средств связи";
            this.menuPostNalZakr.Click += new System.EventHandler(this.menuPostNalZakr_Click);
            // 
            // menuNal
            // 
            this.menuNal.Name = "menuNal";
            this.menuNal.Size = new System.Drawing.Size(258, 22);
            this.menuNal.Text = "Наличие средств связи";
            this.menuNal.Click += new System.EventHandler(this.menuNal_Click);
            // 
            // menuZakrep
            // 
            this.menuZakrep.Name = "menuZakrep";
            this.menuZakrep.Size = new System.Drawing.Size(258, 22);
            this.menuZakrep.Text = "Закрепление средств связи";
            this.menuZakrep.Click += new System.EventHandler(this.menuZakrep_Click);
            // 
            // menuPered
            // 
            this.menuPered.Name = "menuPered";
            this.menuPered.Size = new System.Drawing.Size(258, 22);
            this.menuPered.Text = "Передача средств связи";
            this.menuPered.Click += new System.EventHandler(this.menuPered_Click);
            // 
            // menuRemSpis
            // 
            this.menuRemSpis.Name = "menuRemSpis";
            this.menuRemSpis.Size = new System.Drawing.Size(258, 22);
            this.menuRemSpis.Text = "Ремонт и списание средств связи";
            this.menuRemSpis.Click += new System.EventHandler(this.menuRemSpis_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRep1,
            this.menuRep2,
            this.nenuRep3});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // menuRep1
            // 
            this.menuRep1.Name = "menuRep1";
            this.menuRep1.Size = new System.Drawing.Size(544, 22);
            this.menuRep1.Text = "Отчет о подразделениях и ответственных лицах";
            this.menuRep1.Click += new System.EventHandler(this.menuRep1_Click);
            // 
            // menuRep2
            // 
            this.menuRep2.Name = "menuRep2";
            this.menuRep2.Size = new System.Drawing.Size(544, 22);
            this.menuRep2.Text = "Отчет о видах средств связи и закреплении средств связи за ответственными лицами";
            this.menuRep2.Click += new System.EventHandler(this.menuRep2_Click);
            // 
            // nenuRep3
            // 
            this.nenuRep3.Name = "nenuRep3";
            this.nenuRep3.Size = new System.Drawing.Size(544, 22);
            this.nenuRep3.Text = "Отчет о поступлении ремонте и списании средств связи за определенный период";
            this.nenuRep3.Click += new System.EventHandler(this.nenuRep3_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(54, 20);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kursovoymips.Properties.Resources.TA_57_016;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 457);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Учет средств связи в воинской части";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPodrOtv;
        private System.Windows.Forms.ToolStripMenuItem menuSrSv;
        private System.Windows.Forms.ToolStripMenuItem menuPostNalZakr;
        private System.Windows.Forms.ToolStripMenuItem menuPered;
        private System.Windows.Forms.ToolStripMenuItem menuRemSpis;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRep1;
        private System.Windows.Forms.ToolStripMenuItem menuRep2;
        private System.Windows.Forms.ToolStripMenuItem nenuRep3;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuOtv;
        private System.Windows.Forms.ToolStripMenuItem menuNal;
        private System.Windows.Forms.ToolStripMenuItem menuZakrep;
    }
}

