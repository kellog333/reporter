using System;
using System.IO;
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
using System.Management.Instrumentation;
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
            long memoryTotal = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory").Get().Cast<ManagementObject>().Sum(x => Convert.ToInt64(x.Properties["Capacity"].Value));

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

            // Load Product Id
            ProductIdData.Text = GetProductId();

            // Load Storage Table
            StorageDeviceList.View = View.Details;
            StorageDeviceList.Columns.Add("", 0, HorizontalAlignment.Left);
            StorageDeviceList.Columns.Add("Drive", 70, HorizontalAlignment.Left);
            StorageDeviceList.Columns.Add("Available", 100, HorizontalAlignment.Left);
            StorageDeviceList.Columns.Add("Total", 120, HorizontalAlignment.Left);
            StorageDeviceList.Columns.Add("%Used", 50, HorizontalAlignment.Left);
            LoadStorageData();

            // Load CD Drives
            CDDriveList.View = View.Details;
            CDDriveList.Columns.Add("", 0, HorizontalAlignment.Left);
            CDDriveList.Columns.Add("Drive", 70, HorizontalAlignment.Left);
            CDDriveList.Columns.Add("Name", 200, HorizontalAlignment.Left);
            LoadCDData();

            // Load Memory
            TotalMemoryData.Text = (memoryTotal / 1024 / 1024 / 1024).ToString() + " GB";
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

        private string GetProductId()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_OperatingSystem");
            ManagementObjectCollection moc = mos.Get();
            foreach(ManagementObject mo in moc)
            {
                foreach(PropertyData data in mo.Properties)
                {
                    if(data.Name == "SerialNumber")
                    {
                        return data.Value.ToString();
                    }
                }
            }
            return "";
        }

        private void metroSetSetTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void LoadStorageData()
        {
            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            foreach(DriveInfo d in driveInfo)
            {
                if(d.IsReady == true && d.DriveType.ToString() == "Fixed")
                {
                    var availableSpace = d.AvailableFreeSpace / 1024 / 1024 / 1024;
                    var totalSpace = d.TotalSize / 1024 / 1024 / 1024;
                    var percentAvail = Math.Round((double)(100 * availableSpace) / totalSpace);
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(d.RootDirectory.ToString());
                    item.SubItems.Add(availableSpace.ToString() + " GB");
                    item.SubItems.Add(totalSpace.ToString() + " GB");
                    item.SubItems.Add(percentAvail.ToString() +"%");
                    StorageDeviceList.Items.Add(item);
                }
            }
        }

        private void LoadCDData()
        {
            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            foreach(DriveInfo d in driveInfo)
            {
                if(d.DriveType.ToString() == "CDRom")
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(d.RootDirectory.ToString());
                    item.SubItems.Add("CD / DVD Drive");
                    CDDriveList.Items.Add(item);
                }
            }
        }
    }
}
