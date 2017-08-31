using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemInfoScanner
{
    public partial class MainForm : Form
    {
        public List<string> queriesList = new List<string>
        {
            "Win32_DiskDrive",
            "Win32_OperatingSystem",
            "Win32_Processor",
            "Win32_ComputerSystem",
            "Win32_StartupCommand",
            "Win32_ProgramGroup",
            "Win32_SystemDevices"
        };
        
        public MainForm()
        {
            InitializeComponent();

            comboBox_Queries.DataSource = queriesList;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            dataGridViewQuery.DataSource = GetStuff(comboBox_Queries.Text);
        }

        //method to obtain all the info > depending on the query
        public ArrayList GetStuff(string queryObject)
        {
            ManagementObjectSearcher searcher;
            int i = 0;
            ArrayList arrDetails = new ArrayList();
            try
            {
                searcher = new ManagementObjectSearcher(
                  "SELECT * FROM " + queryObject);
                foreach (ManagementObject wmi_Info in searcher.Get())
                {
                    i++;
                    PropertyDataCollection searcherProperties =
                      wmi_Info.Properties;
                    foreach (PropertyData sp in searcherProperties)
                    {
                        arrDetails.Add(sp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return arrDetails;
        }
    }
}
