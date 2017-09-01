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

            "Win32_OperatingSystem",        // OS version
            "Win32_Product",                // installed software
            "Win32_ComputerSystem",         // overall info, like: comp. name, model, manufacturer
            "Win32_BIOS",                   // BIOS: for motherboard serial number
            "Win32_Processor",              // CPU model
            "Win32_PhysicalMemory",         // RAM
            "Win32_PhysicalMemoryArray",    // RAM Max
            "Win32_DiskDrive",              // HDD capacity
            "Win32_DesktopMonitor"          // monitors/displays

        };

        // chassis type enumeration
        public enum ChassisTypes
        {
            Other = 1,
            Unknown,
            Desktop,
            LowProfileDesktop,
            PizzaBox,
            MiniTower,
            Tower,
            Portable,
            Laptop,
            Notebook,
            Handheld,
            DockingStation,
            AllInOne,
            SubNotebook,
            SpaceSaving,
            LunchBox,
            MainSystemChassis,
            ExpansionChassis,
            SubChassis,
            BusExpansionChassis,
            PeripheralChassis,
            StorageChassis,
            RackMountChassis,
            SealedCasePC
        }


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


        // chassis type >> from Win32_SystemEnclosure
        private void btn_Chassis_Click(object sender, EventArgs e)
        {
            textBox_Chassis.Text = GetChassisType().ToString();
        }

        public static ChassisTypes GetChassisType()
        {
            ManagementClass systemEnclosures = new ManagementClass("Win32_SystemEnclosure");
            foreach (ManagementObject obj in systemEnclosures.GetInstances())
            {
                foreach (int i in (UInt16[])(obj["ChassisTypes"]))
                {
                    if (i > 0 && i < 25)
                    {
                        return (ChassisTypes)i;
                    }
                }
            }
            return ChassisTypes.Unknown;
        }

    }
}
