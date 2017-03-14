using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResource.Config;
using HumanResource.BUS;

namespace HumanResource
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        Configuration config = new Configuration();
        public void LoadData()
        {
            DataTable dataTable = new DataTable();
            dataTable = Bus.GetListNhanVien();
            this.gridControl1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
