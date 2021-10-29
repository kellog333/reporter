using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using System.Diagnostics;
using System.Management;
using MetroSet_UI.Forms;
using Microsoft.Win32;

namespace Reporter
{
    public partial class Form1 : MetroSetForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Vars
            string MachineNameG = Environment.MachineName;
            string SerialNumberG = GetSerialNumber();
            string ManufacturerG = GetManModel("Manufacturer");
            string Model = GetManModel("Model");
            string Architecture = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432");
            string ProcessorName = GetProcessorData("name");
            string CoreCount = GetProcessorData("corecount");
            string WinVersion = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows NT\CurrentVersion", "ProductName", null).ToString() + " Build " + Environment.OSVersion.Version.Build.ToString();


            // Load Version Number
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            VersionLabel.Text = "v " + fileVersionInfo.ProductMajorPart + "." + fileVersionInfo.ProductMinorPart + "." + fileVersionInfo.ProductBuildPart;

            // Load Machine Name
            MachineName.Text = MachineNameG;

            // Load Serial Number
            SerialNumberData.Text = SerialNumberG;

            // Load Manufacturer
            ManufacturerData.Text = ManufacturerG;

            // Load Model
            ModelData.Text = Model;

            // Load Architecture
            ArchitectureData.Text = Architecture;

            // Load Processor
            ProcessorData.Text = ProcessorName;

            // Load Core Count
            CoreCountData.Text = CoreCount;

            // Load Windows Version
            WinVerData.Text = WinVersion;
        }

        private void SerialNumberData_Click(object sender, EventArgs e)
        {

        }

        private void metroSetSetTabPage1_Click(object sender, EventArgs e)
        {

        }

        private string GetSerialNumber()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_SystemEnclosure");
            foreach(ManagementObject obj in searcher.Get())
            {
                if(obj["SerialNumber"].ToString().Length > 5)
                {
                    return obj["SerialNumber"].ToString();
                } else
                {
                    return "Not Available";
                }
            }
            return "Not Available";
        }

        private string GetManModel(string type)
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            if(moc.Count != 0)
            {
                foreach(ManagementObject obj in moc)
                {
                    return obj[type].ToString();
                }
            }
            return "";
        }

        private string GetProcessorData(string type)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection procs = searcher.Get();
            foreach(ManagementObject mo in procs)
            {
                if(type == "name")
                {
                    return mo["name"].ToString();
                }
                if(type == "corecount")
                {
                    return mo["NumberOfCores"].ToString();
                }
            }
            return "";
        }

        private void metroSetLabel1_Click(object sender, EventArgs e)
        {

        }

    }
}
