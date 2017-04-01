using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanResource.BUS;

namespace HumanResource.GUI
{
    public partial class UCTheoDoi : UserControl
    {
        public UCTheoDoi()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dataGridViewTheoDoi.DataSource = Bus.GetListTheoDoi();
        }
    }
}
