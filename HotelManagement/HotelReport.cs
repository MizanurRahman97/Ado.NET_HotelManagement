using HotelManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class HotelReport : Form
    {
        List<HotelViewModel> lst;
        public HotelReport(List<HotelViewModel> list)
        {
            InitializeComponent();
            lst = list;
        }
        public HotelReport()
        {
            InitializeComponent();
        }

        private void HotelReport_Load(object sender, EventArgs e)
        {
            ReportHotel objRpt = new ReportHotel();
            objRpt.SetDataSource(lst);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();

        }
    }
}
