using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net.NetworkInformation;
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
using System.ServiceProcess;
using MetroSet_UI.Forms;
using Microsoft.Win32;
using GrapeCity.Documents.Html;

namespace Reporter
{
    public partial class Form1 : MetroSetForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable storageDrivesDT = new DataTable("StorageDrives");
        DataTable opticalDriveDT = new DataTable("OpticalDrives");
        DataTable networkDT = new DataTable("Network");
        DataTable memoryDT = new DataTable("Memory");
        DataSet storageDrivesDS = new DataSet();

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


            // Set tab default
            TabManager.SelectedTab = SystemTab;

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
            storageDrivesDT.Columns.Add("Drive");
            StorageDeviceList.Columns.Add("Available", 100, HorizontalAlignment.Left);
            storageDrivesDT.Columns.Add("Available");
            StorageDeviceList.Columns.Add("Total", 120, HorizontalAlignment.Left);
            storageDrivesDT.Columns.Add("Total");
            StorageDeviceList.Columns.Add("%Used", 50, HorizontalAlignment.Left);
            storageDrivesDT.Columns.Add("%Free");
            LoadStorageData();

            // Load CD Drives
            CDDriveList.View = View.Details;
            CDDriveList.Columns.Add("", 0, HorizontalAlignment.Left);
            CDDriveList.Columns.Add("Drive", 70, HorizontalAlignment.Left);
            opticalDriveDT.Columns.Add("Drive");
            CDDriveList.Columns.Add("Name", 200, HorizontalAlignment.Left);
            opticalDriveDT.Columns.Add("Name");
            LoadCDData();

            // Load Memory
            TotalMemoryData.Text = (memoryTotal / 1024 / 1024 / 1024).ToString() + " GB";

            // Load Memory List
            MemoryList.View = View.Details;
            MemoryList.Columns.Add("", 0, HorizontalAlignment.Left);
            MemoryList.Columns.Add("Location", 200, HorizontalAlignment.Left);
            memoryDT.Columns.Add("Location");
            MemoryList.Columns.Add("Manufacturer", 200, HorizontalAlignment.Left);
            memoryDT.Columns.Add("Manufacturer");
            MemoryList.Columns.Add("Part Number", 200, HorizontalAlignment.Left);
            memoryDT.Columns.Add("PartNumber");
            MemoryList.Columns.Add("Capacity", 100, HorizontalAlignment.Left);
            memoryDT.Columns.Add("Capacity");
            LoadMemoryData();

            // Load Network Data
            NetworkList.View = View.Details;
            NetworkList.Columns.Add("", 0, HorizontalAlignment.Left);
            NetworkList.Columns.Add("Adapter", 400, HorizontalAlignment.Left);
            networkDT.Columns.Add("Adapter");
            NetworkList.Columns.Add("Type", 150, HorizontalAlignment.Left);
            networkDT.Columns.Add("Type");
            NetworkList.Columns.Add("MACAddress", 175, HorizontalAlignment.Left);
            networkDT.Columns.Add("MACAddress");
            LoadNetworkData();

            // Load Video Data
            LoadVideoData();

            // Report Location
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Replace("/", "_");
            ReportLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + date.ToString() + "_" + ManufacturerData.Text.Replace(" ", "_") + "_" + ModelData.Text.Replace(" ", "_") + ".pdf"; 

            // Close Button
            CloseButton.Click += new EventHandler(CloseWindow);

            // Report Button
            ReportButton.Click += new EventHandler(OpenReportTab);

        }

        private void OpenReportTab(object sender, EventArgs e)
        {
            TabManager.SelectedTab = ReportTab;
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
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
                    storageDrivesDT.Rows.Add(d.RootDirectory.ToString(), availableSpace.ToString() + " GB", totalSpace.ToString() + " GB", percentAvail.ToString() + "%");
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
                    opticalDriveDT.Rows.Add(d.RootDirectory.ToString(), "CD / DVD Drive");
                    CDDriveList.Items.Add(item);
                }
            }
        }

        private void LoadMemoryData()
        {
            string locator = "";
            string manufacturer = "";
            string partnumber = "";
            string capacity = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectCollection moc = searcher.Get();
            foreach(ManagementObject mo in moc)
            {
                ListViewItem item = new ListViewItem();
                foreach(PropertyData data in mo.Properties)
                {
                    if(data.Name == "DeviceLocator")
                    {
                        if(data.Value != null)
                        {
                            locator = data.Value.ToString();
                        } else
                        {
                            locator = "Unknown";
                        }
                    }
                    if(data.Name == "Manufacturer")
                    {
                        if(data.Value != null)
                        {
                            manufacturer = data.Value.ToString();
                        }
                        else
                        {
                            manufacturer = "Unknown";
                        }
                    }
                    if(data.Name == "PartNumber")
                    {
                        if(data.Value != null)
                        {
                            partnumber = data.Value.ToString();
                        }
                        else
                        {
                            partnumber = "Unknown";
                        }
                    }
                    if(data.Name == "Capacity")
                    {
                       capacity = (Convert.ToInt64(data.Value) / 1024 / 1024 / 1024).ToString();
                    }
                }
                item.SubItems.Add(locator);
                item.SubItems.Add(manufacturer);
                item.SubItems.Add(partnumber);
                item.SubItems.Add(capacity + " GB");
                memoryDT.Rows.Add(locator, manufacturer, partnumber, capacity + " GB");
                MemoryList.Items.Add(item);
            }
        }

        private void LoadNetworkData()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach(NetworkInterface nic in networkInterfaces)
            {
                if(nic.NetworkInterfaceType.ToString() != "Loopback")
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(nic.Description.ToString());
                    item.SubItems.Add(nic.NetworkInterfaceType.ToString());
                    item.SubItems.Add(nic.GetPhysicalAddress().ToString());
                    networkDT.Rows.Add(nic.Description.ToString(), nic.NetworkInterfaceType.ToString(), nic.GetPhysicalAddress().ToString());
                    NetworkList.Items.Add(item);
                }
            }
        }

        private void LoadVideoData()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach(ManagementObject mo in searcher.Get())
            {
                GraphicsCardData.Text = mo["Name"].ToString();
                GraphicsRAMData.Text = mo["AdapterRAM"].ToString();
                ResolutionData.Text = mo["CurrentVerticalResolution"].ToString() + "x" + mo["CurrentHorizontalResolution"].ToString();
                RefreshRateData.Text = mo["CurrentRefreshRate"].ToString();
            }
        }

        private void metroSetTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileDialogButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Replace("/","-");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Report";
            saveFileDialog1.FileName = date.ToString() + "_" + ManufacturerData.Text.Replace(" ","_") + "_" + ModelData.Text.Replace(" ", "_");
            saveFileDialog1.DefaultExt = "pdf";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ReportLocation.Text = saveFileDialog1.FileName;
            }
        }

        private string GetImageData()
        {
            // Load Logo Image
            Assembly assembly = Assembly.GetExecutingAssembly();
            string appName = assembly.GetName().Name;
            Stream stream = assembly.GetManifestResourceStream(appName + ".logo.png");
            Image image = Image.FromStream(stream);
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void GeneratePDF()
        {
            string Template;
            var sysInfo = new
            {
                Manufacturer = ManufacturerData.Text,
                SerialNumber = SerialNumberData.Text,
                ModelNumber = ModelData.Text,
                Architecture = ArchitectureData.Text,
                Processor = ProcessorData.Text,
                CoreCount = CoreCountData.Text
            };
            var imageData = new
            {
                Image = GetImageData()
            };
            var osInfo = new
            {
                Version = WinVerData.Text,
                ProductId = ProductIdData.Text
            };
            var storageDrives = from item in storageDrivesDT.Select()
                                select new
                                {
                                    Drive = item["Drive"],
                                    Available = item["Available"],
                                    Total = item["Total"],
                                    Free = item["%Free"]
                                };
            var opticals = from item in opticalDriveDT.Select()
                           select new
                           {
                               Drive = item["Drive"],
                               Name = item["Name"]
                           };
            var memory = from item in memoryDT.Select()
                         select new
                         {
                             Location = item["Location"],
                             Manufacturer = item["Manufacturer"],
                             PartNumber = item["PartNumber"],
                             Capacity = item["Capacity"]
                         };
            var networking = from item in networkDT.Select()
                             select new
                             {
                                 Adapter = item["Adapter"],
                                 Type = item["Type"],
                                 MACAddress = item["MACAddress"]
                             };
            var TotalMemory = new
            {
                Total = TotalMemoryData.Text
            };
            var GraphicsData = new
            {
                Card = GraphicsCardData.Text,
                VideoRAM = GraphicsRAMData.Text,
                Refresh = RefreshRateData.Text,
                Resolution = ResolutionData.Text
            };
            var priceData = "";
            if(PriceData.Text.Length > 0)
            {
                priceData = "Total: $" + PriceData.Text;
            }
            var priceQ = new
            {
                Price = priceData
            };
            Assembly assembly = Assembly.GetExecutingAssembly();
            string appName = assembly.GetName().Name;
            var htmlTemplate = assembly.GetManifestResourceStream(appName + ".ReportTemplate.html");
            var builder = new Stubble.Core.Builders.StubbleBuilder();
            using (StreamReader reader = new StreamReader(htmlTemplate))
            {
                Template = reader.ReadToEnd();
            }
            var boundTemplate = builder.Build().Render(Template, new {
                ImageQuery = imageData,
                SysQuery = sysInfo,
                OsQuery = osInfo,
                StorageQuery = storageDrives,
                DVDQuery = opticals,
                MemoryQuery = memory,
                TotalMemoryQuery = TotalMemory,
                GraphicsQuery = GraphicsData,
                NetworkQuery = networking,
                PriceQuery = priceQ
            });

            using (var re = new GcHtmlRenderer(boundTemplate))
            {
                var pdfSettings = new PdfSettings();
                re.RenderToPdf(ReportLocation.Text, pdfSettings);
            }
            Process.Start(ReportLocation.Text);
        }

        private void GeneratePDFButton_Click(object sender, EventArgs e)
        {
            GeneratePDF();
        }


    }
}
