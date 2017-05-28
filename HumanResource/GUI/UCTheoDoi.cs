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
          
        }

        public void setIsAction(bool v)
        {
          
        }

        private void UCTheoDoi_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadComboboxData(ComboBox cbb, List<DataItem> list)
        {
          
        }
        private void LoadNameFromID(ComboBox cbb, string id, List<DataItem> list)
        {
           
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
