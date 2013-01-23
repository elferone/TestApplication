using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelCreation;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdTest_Click(object sender, EventArgs e)
        {
            List<int> TravelerIds = new List<int>();
            DateTime From = new DateTime(2012, 4, 25);
            DateTime To = new DateTime(2012, 9, 15);

            TravelerIds.Add(28737);
            TravelerIds.Add(30628);
            TravelerIds.Add(25582);
            TravelerIds.Add(24209);
            TravelerIds.Add(26784);
            
            //Modification test

            ExportExcel.FillExcelTemplate(From, To, TravelerIds, System.Configuration.ConfigurationManager.AppSettings["TemplateFIlePath"]);
        }
    }
}

