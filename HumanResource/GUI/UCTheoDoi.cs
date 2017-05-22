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
using HumanResource.VO;
using HumanResource.Config;

namespace HumanResource.GUI
{
    public partial class UCTheoDoi : UserControl
    {
        string PROC_GET_LIST_NHAN_VIEN ="GetListNhanVien";
        string maTDCurrent;
        private bool isAction;
        public UCTheoDoi()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dataGridViewTheoDoi.DataSource = Bus.GetListTheoDoi();
            DataTable dtNV = Bus.GetListNhanVien();

            LoadComboboxData(cbbMaNV, Bus.GetList(PROC_GET_LIST_NHAN_VIEN));
            EnableDisableToolBox(false);
        }

        public void setIsAction(bool v)
        {
            isAction = v;
        }

        private void UCTheoDoi_Load(object sender, EventArgs e)
        {

        }
        private void LoadComboboxData(ComboBox cbb, List<DataItem> list)
        {
            cbb.DataSource = list;
            cbb.ValueMember = "Value";
            cbb.DisplayMember = "Name";
        }
        private void LoadNameFromID(ComboBox cbb, string id, List<DataItem> list)
        {
            LoadComboboxData(cbb, list);
            int i = 0;
            foreach (DataItem di in list)
            {
                if (di.Value.Contains(id))
                {
                    cbb.SelectedIndex = i;
                    return;
                }
                i++;
            }
        }

        public void EnableDisableToolBox(bool b)
        {
          
        }
        public void ClearTextBox()
        {
        }
        public bool getIsAction()
        {
          
        }
        public void AddTheoDoi()
        {
           
                
        }
        
        private TheoDoi GetDataFromFRM()
        {
          
        }
        private string GetMaTDNext()
        {
           
        }

        private void dataGridViewTheoDoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
           
        }
        public void UpdateTheoDoi()
        {
           
        }
        public void EditClick()
        {
           
        }
        public void DeleteTheoDoi()
        {
         
        }

        private void dataGridViewTheoDoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
