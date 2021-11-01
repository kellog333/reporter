namespace Reporter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VersionLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.TabManager = new MetroSet_UI.Controls.MetroSetTabControl();
            this.SystemTab = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.CoreCountData = new MetroSet_UI.Controls.MetroSetLabel();
            this.CoreCountLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.ArchitectureData = new MetroSet_UI.Controls.MetroSetLabel();
            this.ProcessorData = new MetroSet_UI.Controls.MetroSetLabel();
            this.ProcessorLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.ArchitectureLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.ModelData = new MetroSet_UI.Controls.MetroSetLabel();
            this.ModelLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.ManufacturerData = new MetroSet_UI.Controls.MetroSetLabel();
            this.ManufacturerLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.SerialNumberData = new MetroSet_UI.Controls.MetroSetLabel();
            this.SerialNumberLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.SystemInformationLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.WindowsTab = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.ProductIdData = new MetroSet_UI.Controls.MetroSetLabel();
            this.ProductIdLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.WinVerData = new MetroSet_UI.Controls.MetroSetLabel();
            this.WinVerLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.WindowsInformationLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.DrivesTab = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.CDDriveList = new System.Windows.Forms.ListView();
            this.StorageDeviceList = new System.Windows.Forms.ListView();
            this.DriveColumnLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.AvailableSpaceLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.TotalSpaceLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.PercentAvailable = new MetroSet_UI.Controls.MetroSetLabel();
            this.CDDriveLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.StorageDriveLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.MemoryTab = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.LocationLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.ManufactLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.PartNumberLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.CapacityLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.MemoryList = new System.Windows.Forms.ListView();
            this.TotalMemoryData = new MetroSet_UI.Controls.MetroSetLabel();
            this.TotalMemoryLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.NetworkTab = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.VideoTab = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.ResolutionData = new MetroSet_UI.Controls.MetroSetLabel();
            this.ResolutionLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.RefreshRateData = new MetroSet_UI.Controls.MetroSetLabel();
            this.RefreshRateLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.GraphicsRAMData = new MetroSet_UI.Controls.MetroSetLabel();
            this.GraphicsRamLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.GraphicsCardData = new MetroSet_UI.Controls.MetroSetLabel();
            this.GraphicsCardLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.GraphicsInfoLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.ReportTab = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.GeneratePDFButton = new MetroSet_UI.Controls.MetroSetButton();
            this.OpenFileDialogButton = new MetroSet_UI.Controls.MetroSetButton();
            this.PriceData = new MetroSet_UI.Controls.MetroSetTextBox();
            this.PriceLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.ReportLocation = new MetroSet_UI.Controls.MetroSetTextBox();
            this.ReportGenLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.MachineName = new MetroSet_UI.Controls.MetroSetLabel();
            this.CloseButton = new MetroSet_UI.Controls.MetroSetButton();
            this.ReportButton = new MetroSet_UI.Controls.MetroSetButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.NetworkAdapterLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.AdapterLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.NetworkList = new System.Windows.Forms.ListView();
            this.MacAddressData = new MetroSet_UI.Controls.MetroSetLabel();
            this.InterfaceTypeData = new MetroSet_UI.Controls.MetroSetLabel();
            this.TabManager.SuspendLayout();
            this.SystemTab.SuspendLayout();
            this.WindowsTab.SuspendLayout();
            this.DrivesTab.SuspendLayout();
            this.MemoryTab.SuspendLayout();
            this.NetworkTab.SuspendLayout();
            this.VideoTab.SuspendLayout();
            this.ReportTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // VersionLabel
            // 
            this.VersionLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.IsDerivedStyle = true;
            this.VersionLabel.Location = new System.Drawing.Point(88, 51);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(100, 16);
            this.VersionLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.VersionLabel.StyleManager = this.styleManager1;
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.Text = "VersionLabel";
            this.VersionLabel.ThemeAuthor = "Narwin";
            this.VersionLabel.ThemeName = "MetroDark";
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\kevin\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Dark;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroDark";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(698, 2);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 1;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // TabManager
            // 
            this.TabManager.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.TabManager.AnimateTime = 200;
            this.TabManager.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TabManager.Controls.Add(this.SystemTab);
            this.TabManager.Controls.Add(this.WindowsTab);
            this.TabManager.Controls.Add(this.DrivesTab);
            this.TabManager.Controls.Add(this.MemoryTab);
            this.TabManager.Controls.Add(this.VideoTab);
            this.TabManager.Controls.Add(this.NetworkTab);
            this.TabManager.Controls.Add(this.ReportTab);
            this.TabManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabManager.IsDerivedStyle = true;
            this.TabManager.ItemSize = new System.Drawing.Size(100, 38);
            this.TabManager.Location = new System.Drawing.Point(15, 98);
            this.TabManager.Name = "TabManager";
            this.TabManager.SelectedIndex = 4;
            this.TabManager.SelectedTextColor = System.Drawing.Color.White;
            this.TabManager.Size = new System.Drawing.Size(763, 309);
            this.TabManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabManager.Speed = 100;
            this.TabManager.Style = MetroSet_UI.Enums.Style.Dark;
            this.TabManager.StyleManager = this.styleManager1;
            this.TabManager.TabIndex = 2;
            this.TabManager.ThemeAuthor = "Narwin";
            this.TabManager.ThemeName = "MetroDark";
            this.TabManager.UnselectedTextColor = System.Drawing.Color.Gray;
            this.TabManager.UseAnimation = false;
            // 
            // SystemTab
            // 
            this.SystemTab.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SystemTab.Controls.Add(this.CoreCountData);
            this.SystemTab.Controls.Add(this.CoreCountLabel);
            this.SystemTab.Controls.Add(this.ArchitectureData);
            this.SystemTab.Controls.Add(this.ProcessorData);
            this.SystemTab.Controls.Add(this.ProcessorLabel);
            this.SystemTab.Controls.Add(this.ArchitectureLabel);
            this.SystemTab.Controls.Add(this.ModelData);
            this.SystemTab.Controls.Add(this.ModelLabel);
            this.SystemTab.Controls.Add(this.ManufacturerData);
            this.SystemTab.Controls.Add(this.ManufacturerLabel);
            this.SystemTab.Controls.Add(this.SerialNumberData);
            this.SystemTab.Controls.Add(this.SerialNumberLabel);
            this.SystemTab.Controls.Add(this.SystemInformationLabel);
            this.SystemTab.Font = null;
            this.SystemTab.ImageIndex = 0;
            this.SystemTab.ImageKey = null;
            this.SystemTab.IsDerivedStyle = true;
            this.SystemTab.Location = new System.Drawing.Point(4, 42);
            this.SystemTab.Name = "SystemTab";
            this.SystemTab.Size = new System.Drawing.Size(755, 263);
            this.SystemTab.Style = MetroSet_UI.Enums.Style.Dark;
            this.SystemTab.StyleManager = this.styleManager1;
            this.SystemTab.TabIndex = 0;
            this.SystemTab.Text = "System";
            this.SystemTab.ThemeAuthor = "Narwin";
            this.SystemTab.ThemeName = "MetroDark";
            this.SystemTab.ToolTipText = null;
            this.SystemTab.Click += new System.EventHandler(this.metroSetSetTabPage1_Click);
            // 
            // CoreCountData
            // 
            this.CoreCountData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoreCountData.IsDerivedStyle = true;
            this.CoreCountData.Location = new System.Drawing.Point(122, 166);
            this.CoreCountData.Name = "CoreCountData";
            this.CoreCountData.Size = new System.Drawing.Size(387, 23);
            this.CoreCountData.Style = MetroSet_UI.Enums.Style.Dark;
            this.CoreCountData.StyleManager = null;
            this.CoreCountData.TabIndex = 12;
            this.CoreCountData.Text = "CoreCount";
            this.CoreCountData.ThemeAuthor = "Narwin";
            this.CoreCountData.ThemeName = "MetroDark";
            // 
            // CoreCountLabel
            // 
            this.CoreCountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoreCountLabel.IsDerivedStyle = true;
            this.CoreCountLabel.Location = new System.Drawing.Point(3, 166);
            this.CoreCountLabel.Name = "CoreCountLabel";
            this.CoreCountLabel.Size = new System.Drawing.Size(113, 23);
            this.CoreCountLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.CoreCountLabel.StyleManager = null;
            this.CoreCountLabel.TabIndex = 11;
            this.CoreCountLabel.Text = "Core Count";
            this.CoreCountLabel.ThemeAuthor = "Narwin";
            this.CoreCountLabel.ThemeName = "MetroDark";
            // 
            // ArchitectureData
            // 
            this.ArchitectureData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchitectureData.IsDerivedStyle = true;
            this.ArchitectureData.Location = new System.Drawing.Point(122, 120);
            this.ArchitectureData.Name = "ArchitectureData";
            this.ArchitectureData.Size = new System.Drawing.Size(387, 23);
            this.ArchitectureData.Style = MetroSet_UI.Enums.Style.Dark;
            this.ArchitectureData.StyleManager = null;
            this.ArchitectureData.TabIndex = 10;
            this.ArchitectureData.Text = "Architecture";
            this.ArchitectureData.ThemeAuthor = "Narwin";
            this.ArchitectureData.ThemeName = "MetroDark";
            // 
            // ProcessorData
            // 
            this.ProcessorData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessorData.IsDerivedStyle = true;
            this.ProcessorData.Location = new System.Drawing.Point(122, 143);
            this.ProcessorData.Name = "ProcessorData";
            this.ProcessorData.Size = new System.Drawing.Size(387, 23);
            this.ProcessorData.Style = MetroSet_UI.Enums.Style.Dark;
            this.ProcessorData.StyleManager = null;
            this.ProcessorData.TabIndex = 9;
            this.ProcessorData.Text = "Processor";
            this.ProcessorData.ThemeAuthor = "Narwin";
            this.ProcessorData.ThemeName = "MetroDark";
            // 
            // ProcessorLabel
            // 
            this.ProcessorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessorLabel.IsDerivedStyle = true;
            this.ProcessorLabel.Location = new System.Drawing.Point(3, 143);
            this.ProcessorLabel.Name = "ProcessorLabel";
            this.ProcessorLabel.Size = new System.Drawing.Size(113, 23);
            this.ProcessorLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.ProcessorLabel.StyleManager = null;
            this.ProcessorLabel.TabIndex = 8;
            this.ProcessorLabel.Text = "Processor";
            this.ProcessorLabel.ThemeAuthor = "Narwin";
            this.ProcessorLabel.ThemeName = "MetroDark";
            // 
            // ArchitectureLabel
            // 
            this.ArchitectureLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchitectureLabel.IsDerivedStyle = true;
            this.ArchitectureLabel.Location = new System.Drawing.Point(3, 118);
            this.ArchitectureLabel.Name = "ArchitectureLabel";
            this.ArchitectureLabel.Size = new System.Drawing.Size(113, 23);
            this.ArchitectureLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.ArchitectureLabel.StyleManager = null;
            this.ArchitectureLabel.TabIndex = 7;
            this.ArchitectureLabel.Text = "Architecture";
            this.ArchitectureLabel.ThemeAuthor = "Narwin";
            this.ArchitectureLabel.ThemeName = "MetroDark";
            // 
            // ModelData
            // 
            this.ModelData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelData.IsDerivedStyle = true;
            this.ModelData.Location = new System.Drawing.Point(122, 95);
            this.ModelData.Name = "ModelData";
            this.ModelData.Size = new System.Drawing.Size(387, 23);
            this.ModelData.Style = MetroSet_UI.Enums.Style.Dark;
            this.ModelData.StyleManager = null;
            this.ModelData.TabIndex = 6;
            this.ModelData.Text = "ModelData";
            this.ModelData.ThemeAuthor = "Narwin";
            this.ModelData.ThemeName = "MetroDark";
            // 
            // ModelLabel
            // 
            this.ModelLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.IsDerivedStyle = true;
            this.ModelLabel.Location = new System.Drawing.Point(3, 95);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(113, 23);
            this.ModelLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.ModelLabel.StyleManager = null;
            this.ModelLabel.TabIndex = 5;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.ThemeAuthor = "Narwin";
            this.ModelLabel.ThemeName = "MetroDark";
            // 
            // ManufacturerData
            // 
            this.ManufacturerData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerData.IsDerivedStyle = true;
            this.ManufacturerData.Location = new System.Drawing.Point(122, 49);
            this.ManufacturerData.Name = "ManufacturerData";
            this.ManufacturerData.Size = new System.Drawing.Size(387, 23);
            this.ManufacturerData.Style = MetroSet_UI.Enums.Style.Dark;
            this.ManufacturerData.StyleManager = null;
            this.ManufacturerData.TabIndex = 4;
            this.ManufacturerData.Text = "Manufacturer";
            this.ManufacturerData.ThemeAuthor = "Narwin";
            this.ManufacturerData.ThemeName = "MetroDark";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.IsDerivedStyle = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(3, 49);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(113, 23);
            this.ManufacturerLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.ManufacturerLabel.StyleManager = null;
            this.ManufacturerLabel.TabIndex = 3;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.ThemeAuthor = "Narwin";
            this.ManufacturerLabel.ThemeName = "MetroDark";
            // 
            // SerialNumberData
            // 
            this.SerialNumberData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberData.IsDerivedStyle = true;
            this.SerialNumberData.Location = new System.Drawing.Point(122, 72);
            this.SerialNumberData.Name = "SerialNumberData";
            this.SerialNumberData.Size = new System.Drawing.Size(387, 23);
            this.SerialNumberData.Style = MetroSet_UI.Enums.Style.Dark;
            this.SerialNumberData.StyleManager = null;
            this.SerialNumberData.TabIndex = 2;
            this.SerialNumberData.Text = "Serial Number";
            this.SerialNumberData.ThemeAuthor = "Narwin";
            this.SerialNumberData.ThemeName = "MetroDark";
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberLabel.IsDerivedStyle = true;
            this.SerialNumberLabel.Location = new System.Drawing.Point(3, 72);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(113, 23);
            this.SerialNumberLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.SerialNumberLabel.StyleManager = null;
            this.SerialNumberLabel.TabIndex = 1;
            this.SerialNumberLabel.Text = "Serial Number";
            this.SerialNumberLabel.ThemeAuthor = "Narwin";
            this.SerialNumberLabel.ThemeName = "MetroDark";
            // 
            // SystemInformationLabel
            // 
            this.SystemInformationLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemInformationLabel.IsDerivedStyle = true;
            this.SystemInformationLabel.Location = new System.Drawing.Point(3, 13);
            this.SystemInformationLabel.Name = "SystemInformationLabel";
            this.SystemInformationLabel.Size = new System.Drawing.Size(263, 29);
            this.SystemInformationLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.SystemInformationLabel.StyleManager = this.styleManager1;
            this.SystemInformationLabel.TabIndex = 0;
            this.SystemInformationLabel.Text = "System Information";
            this.SystemInformationLabel.ThemeAuthor = "Narwin";
            this.SystemInformationLabel.ThemeName = "MetroDark";
            // 
            // WindowsTab
            // 
            this.WindowsTab.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.WindowsTab.Controls.Add(this.ProductIdData);
            this.WindowsTab.Controls.Add(this.ProductIdLabel);
            this.WindowsTab.Controls.Add(this.WinVerData);
            this.WindowsTab.Controls.Add(this.WinVerLabel);
            this.WindowsTab.Controls.Add(this.WindowsInformationLabel);
            this.WindowsTab.Font = null;
            this.WindowsTab.ImageIndex = 0;
            this.WindowsTab.ImageKey = null;
            this.WindowsTab.IsDerivedStyle = true;
            this.WindowsTab.Location = new System.Drawing.Point(4, 42);
            this.WindowsTab.Name = "WindowsTab";
            this.WindowsTab.Size = new System.Drawing.Size(755, 263);
            this.WindowsTab.Style = MetroSet_UI.Enums.Style.Dark;
            this.WindowsTab.StyleManager = this.styleManager1;
            this.WindowsTab.TabIndex = 1;
            this.WindowsTab.Text = "Windows";
            this.WindowsTab.ThemeAuthor = "Narwin";
            this.WindowsTab.ThemeName = "MetroDark";
            this.WindowsTab.ToolTipText = null;
            this.WindowsTab.Click += new System.EventHandler(this.metroSetSetTabPage2_Click);
            // 
            // ProductIdData
            // 
            this.ProductIdData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdData.IsDerivedStyle = true;
            this.ProductIdData.Location = new System.Drawing.Point(122, 76);
            this.ProductIdData.Name = "ProductIdData";
            this.ProductIdData.Size = new System.Drawing.Size(387, 23);
            this.ProductIdData.Style = MetroSet_UI.Enums.Style.Dark;
            this.ProductIdData.StyleManager = null;
            this.ProductIdData.TabIndex = 11;
            this.ProductIdData.Text = "ProductId";
            this.ProductIdData.ThemeAuthor = "Narwin";
            this.ProductIdData.ThemeName = "MetroDark";
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdLabel.IsDerivedStyle = true;
            this.ProductIdLabel.Location = new System.Drawing.Point(3, 76);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(113, 23);
            this.ProductIdLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.ProductIdLabel.StyleManager = null;
            this.ProductIdLabel.TabIndex = 10;
            this.ProductIdLabel.Text = "Product Id";
            this.ProductIdLabel.ThemeAuthor = "Narwin";
            this.ProductIdLabel.ThemeName = "MetroDark";
            // 
            // WinVerData
            // 
            this.WinVerData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinVerData.IsDerivedStyle = true;
            this.WinVerData.Location = new System.Drawing.Point(122, 53);
            this.WinVerData.Name = "WinVerData";
            this.WinVerData.Size = new System.Drawing.Size(387, 23);
            this.WinVerData.Style = MetroSet_UI.Enums.Style.Dark;
            this.WinVerData.StyleManager = null;
            this.WinVerData.TabIndex = 9;
            this.WinVerData.Text = "Version";
            this.WinVerData.ThemeAuthor = "Narwin";
            this.WinVerData.ThemeName = "MetroDark";
            this.WinVerData.Click += new System.EventHandler(this.metroSetLabel1_Click);
            // 
            // WinVerLabel
            // 
            this.WinVerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinVerLabel.IsDerivedStyle = true;
            this.WinVerLabel.Location = new System.Drawing.Point(3, 53);
            this.WinVerLabel.Name = "WinVerLabel";
            this.WinVerLabel.Size = new System.Drawing.Size(113, 23);
            this.WinVerLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.WinVerLabel.StyleManager = null;
            this.WinVerLabel.TabIndex = 8;
            this.WinVerLabel.Text = "Verison";
            this.WinVerLabel.ThemeAuthor = "Narwin";
            this.WinVerLabel.ThemeName = "MetroDark";
            // 
            // WindowsInformationLabel
            // 
            this.WindowsInformationLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowsInformationLabel.IsDerivedStyle = true;
            this.WindowsInformationLabel.Location = new System.Drawing.Point(3, 14);
            this.WindowsInformationLabel.Name = "WindowsInformationLabel";
            this.WindowsInformationLabel.Size = new System.Drawing.Size(263, 29);
            this.WindowsInformationLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.WindowsInformationLabel.StyleManager = this.styleManager1;
            this.WindowsInformationLabel.TabIndex = 5;
            this.WindowsInformationLabel.Text = "Windows Information";
            this.WindowsInformationLabel.ThemeAuthor = "Narwin";
            this.WindowsInformationLabel.ThemeName = "MetroDark";
            // 
            // DrivesTab
            // 
            this.DrivesTab.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DrivesTab.Controls.Add(this.metroSetLabel2);
            this.DrivesTab.Controls.Add(this.metroSetLabel1);
            this.DrivesTab.Controls.Add(this.CDDriveList);
            this.DrivesTab.Controls.Add(this.StorageDeviceList);
            this.DrivesTab.Controls.Add(this.DriveColumnLabel);
            this.DrivesTab.Controls.Add(this.AvailableSpaceLabel);
            this.DrivesTab.Controls.Add(this.TotalSpaceLabel);
            this.DrivesTab.Controls.Add(this.PercentAvailable);
            this.DrivesTab.Controls.Add(this.CDDriveLabel);
            this.DrivesTab.Controls.Add(this.StorageDriveLabel);
            this.DrivesTab.Font = null;
            this.DrivesTab.ImageIndex = 0;
            this.DrivesTab.ImageKey = null;
            this.DrivesTab.IsDerivedStyle = true;
            this.DrivesTab.Location = new System.Drawing.Point(4, 42);
            this.DrivesTab.Name = "DrivesTab";
            this.DrivesTab.Size = new System.Drawing.Size(755, 263);
            this.DrivesTab.Style = MetroSet_UI.Enums.Style.Dark;
            this.DrivesTab.StyleManager = null;
            this.DrivesTab.TabIndex = 2;
            this.DrivesTab.Text = "Drives";
            this.DrivesTab.ThemeAuthor = "Narwin";
            this.DrivesTab.ThemeName = "MetroDark";
            this.DrivesTab.ToolTipText = null;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(490, 60);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(74, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 16;
            this.metroSetLabel2.Text = "Available Space";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(404, 60);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(47, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 15;
            this.metroSetLabel1.Text = "Drive";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // CDDriveList
            // 
            this.CDDriveList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CDDriveList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CDDriveList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDDriveList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CDDriveList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.CDDriveList.HideSelection = false;
            this.CDDriveList.Location = new System.Drawing.Point(404, 87);
            this.CDDriveList.Name = "CDDriveList";
            this.CDDriveList.Size = new System.Drawing.Size(375, 135);
            this.CDDriveList.TabIndex = 14;
            this.CDDriveList.UseCompatibleStateImageBehavior = false;
            // 
            // StorageDeviceList
            // 
            this.StorageDeviceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.StorageDeviceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StorageDeviceList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageDeviceList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.StorageDeviceList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.StorageDeviceList.HideSelection = false;
            this.StorageDeviceList.Location = new System.Drawing.Point(4, 87);
            this.StorageDeviceList.Name = "StorageDeviceList";
            this.StorageDeviceList.Size = new System.Drawing.Size(373, 135);
            this.StorageDeviceList.TabIndex = 13;
            this.StorageDeviceList.UseCompatibleStateImageBehavior = false;
            // 
            // DriveColumnLabel
            // 
            this.DriveColumnLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveColumnLabel.IsDerivedStyle = true;
            this.DriveColumnLabel.Location = new System.Drawing.Point(0, 60);
            this.DriveColumnLabel.Name = "DriveColumnLabel";
            this.DriveColumnLabel.Size = new System.Drawing.Size(47, 23);
            this.DriveColumnLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.DriveColumnLabel.StyleManager = null;
            this.DriveColumnLabel.TabIndex = 12;
            this.DriveColumnLabel.Text = "Drive";
            this.DriveColumnLabel.ThemeAuthor = "Narwin";
            this.DriveColumnLabel.ThemeName = "MetroDark";
            // 
            // AvailableSpaceLabel
            // 
            this.AvailableSpaceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableSpaceLabel.IsDerivedStyle = true;
            this.AvailableSpaceLabel.Location = new System.Drawing.Point(84, 60);
            this.AvailableSpaceLabel.Name = "AvailableSpaceLabel";
            this.AvailableSpaceLabel.Size = new System.Drawing.Size(74, 23);
            this.AvailableSpaceLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.AvailableSpaceLabel.StyleManager = null;
            this.AvailableSpaceLabel.TabIndex = 11;
            this.AvailableSpaceLabel.Text = "Available Space";
            this.AvailableSpaceLabel.ThemeAuthor = "Narwin";
            this.AvailableSpaceLabel.ThemeName = "MetroDark";
            // 
            // TotalSpaceLabel
            // 
            this.TotalSpaceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSpaceLabel.IsDerivedStyle = true;
            this.TotalSpaceLabel.Location = new System.Drawing.Point(200, 60);
            this.TotalSpaceLabel.Name = "TotalSpaceLabel";
            this.TotalSpaceLabel.Size = new System.Drawing.Size(66, 23);
            this.TotalSpaceLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.TotalSpaceLabel.StyleManager = null;
            this.TotalSpaceLabel.TabIndex = 10;
            this.TotalSpaceLabel.Text = "Total Space";
            this.TotalSpaceLabel.ThemeAuthor = "Narwin";
            this.TotalSpaceLabel.ThemeName = "MetroDark";
            // 
            // PercentAvailable
            // 
            this.PercentAvailable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentAvailable.IsDerivedStyle = true;
            this.PercentAvailable.Location = new System.Drawing.Point(283, 60);
            this.PercentAvailable.Name = "PercentAvailable";
            this.PercentAvailable.Size = new System.Drawing.Size(78, 23);
            this.PercentAvailable.Style = MetroSet_UI.Enums.Style.Dark;
            this.PercentAvailable.StyleManager = null;
            this.PercentAvailable.TabIndex = 9;
            this.PercentAvailable.Text = "% Free";
            this.PercentAvailable.ThemeAuthor = "Narwin";
            this.PercentAvailable.ThemeName = "MetroDark";
            // 
            // CDDriveLabel
            // 
            this.CDDriveLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDDriveLabel.IsDerivedStyle = true;
            this.CDDriveLabel.Location = new System.Drawing.Point(404, 19);
            this.CDDriveLabel.Name = "CDDriveLabel";
            this.CDDriveLabel.Size = new System.Drawing.Size(290, 29);
            this.CDDriveLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.CDDriveLabel.StyleManager = this.styleManager1;
            this.CDDriveLabel.TabIndex = 7;
            this.CDDriveLabel.Text = "CD/DVD Drive Information";
            this.CDDriveLabel.ThemeAuthor = "Narwin";
            this.CDDriveLabel.ThemeName = "MetroDark";
            // 
            // StorageDriveLabel
            // 
            this.StorageDriveLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageDriveLabel.IsDerivedStyle = true;
            this.StorageDriveLabel.Location = new System.Drawing.Point(3, 19);
            this.StorageDriveLabel.Name = "StorageDriveLabel";
            this.StorageDriveLabel.Size = new System.Drawing.Size(263, 29);
            this.StorageDriveLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.StorageDriveLabel.StyleManager = this.styleManager1;
            this.StorageDriveLabel.TabIndex = 6;
            this.StorageDriveLabel.Text = "Storage Drives";
            this.StorageDriveLabel.ThemeAuthor = "Narwin";
            this.StorageDriveLabel.ThemeName = "MetroDark";
            // 
            // MemoryTab
            // 
            this.MemoryTab.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MemoryTab.Controls.Add(this.LocationLabel);
            this.MemoryTab.Controls.Add(this.ManufactLabel);
            this.MemoryTab.Controls.Add(this.PartNumberLabel);
            this.MemoryTab.Controls.Add(this.CapacityLabel);
            this.MemoryTab.Controls.Add(this.MemoryList);
            this.MemoryTab.Controls.Add(this.TotalMemoryData);
            this.MemoryTab.Controls.Add(this.TotalMemoryLabel);
            this.MemoryTab.Font = null;
            this.MemoryTab.ImageIndex = 0;
            this.MemoryTab.ImageKey = null;
            this.MemoryTab.IsDerivedStyle = true;
            this.MemoryTab.Location = new System.Drawing.Point(4, 42);
            this.MemoryTab.Name = "MemoryTab";
            this.MemoryTab.Size = new System.Drawing.Size(755, 263);
            this.MemoryTab.Style = MetroSet_UI.Enums.Style.Dark;
            this.MemoryTab.StyleManager = null;
            this.MemoryTab.TabIndex = 3;
            this.MemoryTab.Text = "Memory";
            this.MemoryTab.ThemeAuthor = "Narwin";
            this.MemoryTab.ThemeName = "MetroDark";
            this.MemoryTab.ToolTipText = null;
            // 
            // LocationLabel
            // 
            this.LocationLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.IsDerivedStyle = true;
            this.LocationLabel.Location = new System.Drawing.Point(13, 53);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(88, 23);
            this.LocationLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.LocationLabel.StyleManager = null;
            this.LocationLabel.TabIndex = 16;
            this.LocationLabel.Text = "Location";
            this.LocationLabel.ThemeAuthor = "Narwin";
            this.LocationLabel.ThemeName = "MetroDark";
            // 
            // ManufactLabel
            // 
            this.ManufactLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufactLabel.IsDerivedStyle = true;
            this.ManufactLabel.Location = new System.Drawing.Point(208, 53);
            this.ManufactLabel.Name = "ManufactLabel";
            this.ManufactLabel.Size = new System.Drawing.Size(117, 23);
            this.ManufactLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.ManufactLabel.StyleManager = null;
            this.ManufactLabel.TabIndex = 15;
            this.ManufactLabel.Text = "Manufacturer";
            this.ManufactLabel.ThemeAuthor = "Narwin";
            this.ManufactLabel.ThemeName = "MetroDark";
            // 
            // PartNumberLabel
            // 
            this.PartNumberLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumberLabel.IsDerivedStyle = true;
            this.PartNumberLabel.Location = new System.Drawing.Point(419, 53);
            this.PartNumberLabel.Name = "PartNumberLabel";
            this.PartNumberLabel.Size = new System.Drawing.Size(120, 23);
            this.PartNumberLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.PartNumberLabel.StyleManager = null;
            this.PartNumberLabel.TabIndex = 14;
            this.PartNumberLabel.Text = "Part Number";
            this.PartNumberLabel.ThemeAuthor = "Narwin";
            this.PartNumberLabel.ThemeName = "MetroDark";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityLabel.IsDerivedStyle = true;
            this.CapacityLabel.Location = new System.Drawing.Point(606, 53);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(72, 23);
            this.CapacityLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.CapacityLabel.StyleManager = null;
            this.CapacityLabel.TabIndex = 13;
            this.CapacityLabel.Text = "Capacity";
            this.CapacityLabel.ThemeAuthor = "Narwin";
            this.CapacityLabel.ThemeName = "MetroDark";
            // 
            // MemoryList
            // 
            this.MemoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MemoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MemoryList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.MemoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.MemoryList.HideSelection = false;
            this.MemoryList.Location = new System.Drawing.Point(13, 79);
            this.MemoryList.Name = "MemoryList";
            this.MemoryList.Size = new System.Drawing.Size(726, 188);
            this.MemoryList.TabIndex = 9;
            this.MemoryList.UseCompatibleStateImageBehavior = false;
            // 
            // TotalMemoryData
            // 
            this.TotalMemoryData.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMemoryData.IsDerivedStyle = true;
            this.TotalMemoryData.Location = new System.Drawing.Point(195, 17);
            this.TotalMemoryData.Name = "TotalMemoryData";
            this.TotalMemoryData.Size = new System.Drawing.Size(176, 29);
            this.TotalMemoryData.Style = MetroSet_UI.Enums.Style.Dark;
            this.TotalMemoryData.StyleManager = this.styleManager1;
            this.TotalMemoryData.TabIndex = 8;
            this.TotalMemoryData.Text = "Total Memory";
            this.TotalMemoryData.ThemeAuthor = "Narwin";
            this.TotalMemoryData.ThemeName = "MetroDark";
            // 
            // TotalMemoryLabel
            // 
            this.TotalMemoryLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMemoryLabel.IsDerivedStyle = true;
            this.TotalMemoryLabel.Location = new System.Drawing.Point(13, 17);
            this.TotalMemoryLabel.Name = "TotalMemoryLabel";
            this.TotalMemoryLabel.Size = new System.Drawing.Size(176, 29);
            this.TotalMemoryLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.TotalMemoryLabel.StyleManager = this.styleManager1;
            this.TotalMemoryLabel.TabIndex = 7;
            this.TotalMemoryLabel.Text = "Total Memory";
            this.TotalMemoryLabel.ThemeAuthor = "Narwin";
            this.TotalMemoryLabel.ThemeName = "MetroDark";
            // 
            // NetworkTab
            // 
            this.NetworkTab.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NetworkTab.Controls.Add(this.AdapterLabel);
            this.NetworkTab.Controls.Add(this.InterfaceTypeData);
            this.NetworkTab.Controls.Add(this.MacAddressData);
            this.NetworkTab.Controls.Add(this.NetworkList);
            this.NetworkTab.Controls.Add(this.NetworkAdapterLabel);
            this.NetworkTab.Font = null;
            this.NetworkTab.ImageIndex = 0;
            this.NetworkTab.ImageKey = null;
            this.NetworkTab.IsDerivedStyle = true;
            this.NetworkTab.Location = new System.Drawing.Point(4, 42);
            this.NetworkTab.Name = "NetworkTab";
            this.NetworkTab.Size = new System.Drawing.Size(755, 263);
            this.NetworkTab.Style = MetroSet_UI.Enums.Style.Dark;
            this.NetworkTab.StyleManager = null;
            this.NetworkTab.TabIndex = 6;
            this.NetworkTab.Text = "Network";
            this.NetworkTab.ThemeAuthor = "Narwin";
            this.NetworkTab.ThemeName = "MetroDark";
            this.NetworkTab.ToolTipText = null;
            // 
            // VideoTab
            // 
            this.VideoTab.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.VideoTab.Controls.Add(this.ResolutionData);
            this.VideoTab.Controls.Add(this.ResolutionLabel);
            this.VideoTab.Controls.Add(this.RefreshRateData);
            this.VideoTab.Controls.Add(this.RefreshRateLabel);
            this.VideoTab.Controls.Add(this.GraphicsRAMData);
            this.VideoTab.Controls.Add(this.GraphicsRamLabel);
            this.VideoTab.Controls.Add(this.GraphicsCardData);
            this.VideoTab.Controls.Add(this.GraphicsCardLabel);
            this.VideoTab.Controls.Add(this.GraphicsInfoLabel);
            this.VideoTab.Font = null;
            this.VideoTab.ImageIndex = 0;
            this.VideoTab.ImageKey = null;
            this.VideoTab.IsDerivedStyle = true;
            this.VideoTab.Location = new System.Drawing.Point(4, 42);
            this.VideoTab.Name = "VideoTab";
            this.VideoTab.Size = new System.Drawing.Size(755, 263);
            this.VideoTab.Style = MetroSet_UI.Enums.Style.Dark;
            this.VideoTab.StyleManager = null;
            this.VideoTab.TabIndex = 5;
            this.VideoTab.Text = "Video";
            this.VideoTab.ThemeAuthor = "Narwin";
            this.VideoTab.ThemeName = "MetroDark";
            this.VideoTab.ToolTipText = null;
            // 
            // ResolutionData
            // 
            this.ResolutionData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionData.IsDerivedStyle = true;
            this.ResolutionData.Location = new System.Drawing.Point(122, 127);
            this.ResolutionData.Name = "ResolutionData";
            this.ResolutionData.Size = new System.Drawing.Size(387, 23);
            this.ResolutionData.Style = MetroSet_UI.Enums.Style.Dark;
            this.ResolutionData.StyleManager = null;
            this.ResolutionData.TabIndex = 20;
            this.ResolutionData.Text = "Resolution";
            this.ResolutionData.ThemeAuthor = "Narwin";
            this.ResolutionData.ThemeName = "MetroDark";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionLabel.IsDerivedStyle = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(3, 127);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(113, 23);
            this.ResolutionLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.ResolutionLabel.StyleManager = null;
            this.ResolutionLabel.TabIndex = 19;
            this.ResolutionLabel.Text = "Resolution";
            this.ResolutionLabel.ThemeAuthor = "Narwin";
            this.ResolutionLabel.ThemeName = "MetroDark";
            // 
            // RefreshRateData
            // 
            this.RefreshRateData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshRateData.IsDerivedStyle = true;
            this.RefreshRateData.Location = new System.Drawing.Point(122, 104);
            this.RefreshRateData.Name = "RefreshRateData";
            this.RefreshRateData.Size = new System.Drawing.Size(387, 23);
            this.RefreshRateData.Style = MetroSet_UI.Enums.Style.Dark;
            this.RefreshRateData.StyleManager = null;
            this.RefreshRateData.TabIndex = 18;
            this.RefreshRateData.Text = "RefreshRate";
            this.RefreshRateData.ThemeAuthor = "Narwin";
            this.RefreshRateData.ThemeName = "MetroDark";
            // 
            // RefreshRateLabel
            // 
            this.RefreshRateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshRateLabel.IsDerivedStyle = true;
            this.RefreshRateLabel.Location = new System.Drawing.Point(3, 104);
            this.RefreshRateLabel.Name = "RefreshRateLabel";
            this.RefreshRateLabel.Size = new System.Drawing.Size(113, 23);
            this.RefreshRateLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.RefreshRateLabel.StyleManager = null;
            this.RefreshRateLabel.TabIndex = 17;
            this.RefreshRateLabel.Text = "Refresh Rate";
            this.RefreshRateLabel.ThemeAuthor = "Narwin";
            this.RefreshRateLabel.ThemeName = "MetroDark";
            // 
            // GraphicsRAMData
            // 
            this.GraphicsRAMData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphicsRAMData.IsDerivedStyle = true;
            this.GraphicsRAMData.Location = new System.Drawing.Point(122, 81);
            this.GraphicsRAMData.Name = "GraphicsRAMData";
            this.GraphicsRAMData.Size = new System.Drawing.Size(387, 23);
            this.GraphicsRAMData.Style = MetroSet_UI.Enums.Style.Dark;
            this.GraphicsRAMData.StyleManager = null;
            this.GraphicsRAMData.TabIndex = 16;
            this.GraphicsRAMData.Text = "VideoRAM";
            this.GraphicsRAMData.ThemeAuthor = "Narwin";
            this.GraphicsRAMData.ThemeName = "MetroDark";
            // 
            // GraphicsRamLabel
            // 
            this.GraphicsRamLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphicsRamLabel.IsDerivedStyle = true;
            this.GraphicsRamLabel.Location = new System.Drawing.Point(3, 81);
            this.GraphicsRamLabel.Name = "GraphicsRamLabel";
            this.GraphicsRamLabel.Size = new System.Drawing.Size(113, 23);
            this.GraphicsRamLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.GraphicsRamLabel.StyleManager = null;
            this.GraphicsRamLabel.TabIndex = 15;
            this.GraphicsRamLabel.Text = "Video RAM";
            this.GraphicsRamLabel.ThemeAuthor = "Narwin";
            this.GraphicsRamLabel.ThemeName = "MetroDark";
            // 
            // GraphicsCardData
            // 
            this.GraphicsCardData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphicsCardData.IsDerivedStyle = true;
            this.GraphicsCardData.Location = new System.Drawing.Point(122, 58);
            this.GraphicsCardData.Name = "GraphicsCardData";
            this.GraphicsCardData.Size = new System.Drawing.Size(387, 23);
            this.GraphicsCardData.Style = MetroSet_UI.Enums.Style.Dark;
            this.GraphicsCardData.StyleManager = null;
            this.GraphicsCardData.TabIndex = 14;
            this.GraphicsCardData.Text = "GraphicsCard";
            this.GraphicsCardData.ThemeAuthor = "Narwin";
            this.GraphicsCardData.ThemeName = "MetroDark";
            // 
            // GraphicsCardLabel
            // 
            this.GraphicsCardLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphicsCardLabel.IsDerivedStyle = true;
            this.GraphicsCardLabel.Location = new System.Drawing.Point(3, 58);
            this.GraphicsCardLabel.Name = "GraphicsCardLabel";
            this.GraphicsCardLabel.Size = new System.Drawing.Size(113, 23);
            this.GraphicsCardLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.GraphicsCardLabel.StyleManager = null;
            this.GraphicsCardLabel.TabIndex = 13;
            this.GraphicsCardLabel.Text = "Graphics Card";
            this.GraphicsCardLabel.ThemeAuthor = "Narwin";
            this.GraphicsCardLabel.ThemeName = "MetroDark";
            // 
            // GraphicsInfoLabel
            // 
            this.GraphicsInfoLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphicsInfoLabel.IsDerivedStyle = true;
            this.GraphicsInfoLabel.Location = new System.Drawing.Point(3, 19);
            this.GraphicsInfoLabel.Name = "GraphicsInfoLabel";
            this.GraphicsInfoLabel.Size = new System.Drawing.Size(263, 29);
            this.GraphicsInfoLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.GraphicsInfoLabel.StyleManager = this.styleManager1;
            this.GraphicsInfoLabel.TabIndex = 12;
            this.GraphicsInfoLabel.Text = "Graphics Information";
            this.GraphicsInfoLabel.ThemeAuthor = "Narwin";
            this.GraphicsInfoLabel.ThemeName = "MetroDark";
            // 
            // ReportTab
            // 
            this.ReportTab.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ReportTab.Controls.Add(this.GeneratePDFButton);
            this.ReportTab.Controls.Add(this.OpenFileDialogButton);
            this.ReportTab.Controls.Add(this.PriceData);
            this.ReportTab.Controls.Add(this.PriceLabel);
            this.ReportTab.Controls.Add(this.ReportLocation);
            this.ReportTab.Controls.Add(this.ReportGenLabel);
            this.ReportTab.Controls.Add(this.metroSetLabel3);
            this.ReportTab.Font = null;
            this.ReportTab.ImageIndex = 0;
            this.ReportTab.ImageKey = null;
            this.ReportTab.IsDerivedStyle = true;
            this.ReportTab.Location = new System.Drawing.Point(4, 42);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.Size = new System.Drawing.Size(755, 263);
            this.ReportTab.Style = MetroSet_UI.Enums.Style.Dark;
            this.ReportTab.StyleManager = null;
            this.ReportTab.TabIndex = 4;
            this.ReportTab.Text = "Report";
            this.ReportTab.ThemeAuthor = "Narwin";
            this.ReportTab.ThemeName = "MetroDark";
            this.ReportTab.ToolTipText = null;
            // 
            // GeneratePDFButton
            // 
            this.GeneratePDFButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GeneratePDFButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GeneratePDFButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.GeneratePDFButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePDFButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.GeneratePDFButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.GeneratePDFButton.HoverTextColor = System.Drawing.Color.White;
            this.GeneratePDFButton.IsDerivedStyle = true;
            this.GeneratePDFButton.Location = new System.Drawing.Point(573, 209);
            this.GeneratePDFButton.Name = "GeneratePDFButton";
            this.GeneratePDFButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GeneratePDFButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GeneratePDFButton.NormalTextColor = System.Drawing.Color.White;
            this.GeneratePDFButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.GeneratePDFButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.GeneratePDFButton.PressTextColor = System.Drawing.Color.White;
            this.GeneratePDFButton.Size = new System.Drawing.Size(138, 30);
            this.GeneratePDFButton.Style = MetroSet_UI.Enums.Style.Light;
            this.GeneratePDFButton.StyleManager = null;
            this.GeneratePDFButton.TabIndex = 23;
            this.GeneratePDFButton.Text = "Generate";
            this.GeneratePDFButton.ThemeAuthor = "Narwin";
            this.GeneratePDFButton.ThemeName = "MetroLite";
            this.GeneratePDFButton.Click += new System.EventHandler(this.GeneratePDFButton_Click);
            // 
            // OpenFileDialogButton
            // 
            this.OpenFileDialogButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.OpenFileDialogButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.OpenFileDialogButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.OpenFileDialogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OpenFileDialogButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.OpenFileDialogButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.OpenFileDialogButton.HoverTextColor = System.Drawing.Color.White;
            this.OpenFileDialogButton.IsDerivedStyle = true;
            this.OpenFileDialogButton.Location = new System.Drawing.Point(660, 161);
            this.OpenFileDialogButton.Name = "OpenFileDialogButton";
            this.OpenFileDialogButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.OpenFileDialogButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.OpenFileDialogButton.NormalTextColor = System.Drawing.Color.White;
            this.OpenFileDialogButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.OpenFileDialogButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.OpenFileDialogButton.PressTextColor = System.Drawing.Color.White;
            this.OpenFileDialogButton.Size = new System.Drawing.Size(51, 31);
            this.OpenFileDialogButton.Style = MetroSet_UI.Enums.Style.Dark;
            this.OpenFileDialogButton.StyleManager = this.styleManager1;
            this.OpenFileDialogButton.TabIndex = 22;
            this.OpenFileDialogButton.Text = "...";
            this.OpenFileDialogButton.ThemeAuthor = "Narwin";
            this.OpenFileDialogButton.ThemeName = "MetroLite";
            this.OpenFileDialogButton.Click += new System.EventHandler(this.OpenFileDialogButton_Click);
            // 
            // PriceData
            // 
            this.PriceData.AutoCompleteCustomSource = null;
            this.PriceData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PriceData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PriceData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.PriceData.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PriceData.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PriceData.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PriceData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceData.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.PriceData.Image = null;
            this.PriceData.IsDerivedStyle = true;
            this.PriceData.Lines = null;
            this.PriceData.Location = new System.Drawing.Point(13, 85);
            this.PriceData.MaxLength = 32767;
            this.PriceData.Multiline = false;
            this.PriceData.Name = "PriceData";
            this.PriceData.ReadOnly = false;
            this.PriceData.Size = new System.Drawing.Size(698, 31);
            this.PriceData.Style = MetroSet_UI.Enums.Style.Dark;
            this.PriceData.StyleManager = this.styleManager1;
            this.PriceData.TabIndex = 21;
            this.PriceData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PriceData.ThemeAuthor = "Narwin";
            this.PriceData.ThemeName = "MetroLite";
            this.PriceData.UseSystemPasswordChar = false;
            this.PriceData.WatermarkText = "";
            // 
            // PriceLabel
            // 
            this.PriceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.IsDerivedStyle = true;
            this.PriceLabel.Location = new System.Drawing.Point(3, 59);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(88, 23);
            this.PriceLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.PriceLabel.StyleManager = null;
            this.PriceLabel.TabIndex = 20;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.ThemeAuthor = "Narwin";
            this.PriceLabel.ThemeName = "MetroDark";
            // 
            // ReportLocation
            // 
            this.ReportLocation.AutoCompleteCustomSource = null;
            this.ReportLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ReportLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ReportLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ReportLocation.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ReportLocation.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ReportLocation.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ReportLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLocation.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ReportLocation.Image = null;
            this.ReportLocation.IsDerivedStyle = true;
            this.ReportLocation.Lines = null;
            this.ReportLocation.Location = new System.Drawing.Point(13, 161);
            this.ReportLocation.MaxLength = 32767;
            this.ReportLocation.Multiline = false;
            this.ReportLocation.Name = "ReportLocation";
            this.ReportLocation.ReadOnly = false;
            this.ReportLocation.Size = new System.Drawing.Size(698, 31);
            this.ReportLocation.Style = MetroSet_UI.Enums.Style.Dark;
            this.ReportLocation.StyleManager = this.styleManager1;
            this.ReportLocation.TabIndex = 19;
            this.ReportLocation.Text = "FileLocation";
            this.ReportLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportLocation.ThemeAuthor = "Narwin";
            this.ReportLocation.ThemeName = "MetroLite";
            this.ReportLocation.UseSystemPasswordChar = false;
            this.ReportLocation.WatermarkText = "";
            this.ReportLocation.Click += new System.EventHandler(this.metroSetTextBox1_Click);
            // 
            // ReportGenLabel
            // 
            this.ReportGenLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportGenLabel.IsDerivedStyle = true;
            this.ReportGenLabel.Location = new System.Drawing.Point(3, 16);
            this.ReportGenLabel.Name = "ReportGenLabel";
            this.ReportGenLabel.Size = new System.Drawing.Size(207, 29);
            this.ReportGenLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.ReportGenLabel.StyleManager = this.styleManager1;
            this.ReportGenLabel.TabIndex = 18;
            this.ReportGenLabel.Text = "Report Generator";
            this.ReportGenLabel.ThemeAuthor = "Narwin";
            this.ReportGenLabel.ThemeName = "MetroDark";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(3, 135);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(88, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 17;
            this.metroSetLabel3.Text = "Location";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroDark";
            // 
            // MachineName
            // 
            this.MachineName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineName.IsDerivedStyle = true;
            this.MachineName.Location = new System.Drawing.Point(423, 43);
            this.MachineName.Name = "MachineName";
            this.MachineName.Size = new System.Drawing.Size(222, 24);
            this.MachineName.Style = MetroSet_UI.Enums.Style.Dark;
            this.MachineName.StyleManager = this.styleManager1;
            this.MachineName.TabIndex = 3;
            this.MachineName.Text = "MachineName";
            this.MachineName.ThemeAuthor = "Narwin";
            this.MachineName.ThemeName = "MetroDark";
            // 
            // CloseButton
            // 
            this.CloseButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CloseButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CloseButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.CloseButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.CloseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.CloseButton.HoverTextColor = System.Drawing.Color.White;
            this.CloseButton.IsDerivedStyle = true;
            this.CloseButton.Location = new System.Drawing.Point(679, 413);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CloseButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CloseButton.NormalTextColor = System.Drawing.Color.White;
            this.CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.CloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.CloseButton.PressTextColor = System.Drawing.Color.White;
            this.CloseButton.Size = new System.Drawing.Size(99, 23);
            this.CloseButton.Style = MetroSet_UI.Enums.Style.Dark;
            this.CloseButton.StyleManager = this.styleManager1;
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.ThemeAuthor = "Narwin";
            this.CloseButton.ThemeName = "MetroDark";
            // 
            // ReportButton
            // 
            this.ReportButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ReportButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ReportButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.ReportButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ReportButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ReportButton.HoverTextColor = System.Drawing.Color.White;
            this.ReportButton.IsDerivedStyle = true;
            this.ReportButton.Location = new System.Drawing.Point(554, 413);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ReportButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ReportButton.NormalTextColor = System.Drawing.Color.White;
            this.ReportButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.ReportButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.ReportButton.PressTextColor = System.Drawing.Color.White;
            this.ReportButton.Size = new System.Drawing.Size(108, 23);
            this.ReportButton.Style = MetroSet_UI.Enums.Style.Dark;
            this.ReportButton.StyleManager = this.styleManager1;
            this.ReportButton.TabIndex = 5;
            this.ReportButton.Text = "Generate Report";
            this.ReportButton.ThemeAuthor = "Narwin";
            this.ReportButton.ThemeName = "MetroDark";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NetworkAdapterLabel
            // 
            this.NetworkAdapterLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkAdapterLabel.IsDerivedStyle = true;
            this.NetworkAdapterLabel.Location = new System.Drawing.Point(14, 6);
            this.NetworkAdapterLabel.Name = "NetworkAdapterLabel";
            this.NetworkAdapterLabel.Size = new System.Drawing.Size(210, 29);
            this.NetworkAdapterLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.NetworkAdapterLabel.StyleManager = this.styleManager1;
            this.NetworkAdapterLabel.TabIndex = 17;
            this.NetworkAdapterLabel.Text = "Network Adapters";
            this.NetworkAdapterLabel.ThemeAuthor = "Narwin";
            this.NetworkAdapterLabel.ThemeName = "MetroDark";
            // 
            // AdapterLabel
            // 
            this.AdapterLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdapterLabel.IsDerivedStyle = true;
            this.AdapterLabel.Location = new System.Drawing.Point(14, 42);
            this.AdapterLabel.Name = "AdapterLabel";
            this.AdapterLabel.Size = new System.Drawing.Size(88, 23);
            this.AdapterLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.AdapterLabel.StyleManager = null;
            this.AdapterLabel.TabIndex = 23;
            this.AdapterLabel.Text = "Adapter";
            this.AdapterLabel.ThemeAuthor = "Narwin";
            this.AdapterLabel.ThemeName = "MetroDark";
            // 
            // NetworkList
            // 
            this.NetworkList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NetworkList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetworkList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.NetworkList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.NetworkList.HideSelection = false;
            this.NetworkList.Location = new System.Drawing.Point(14, 68);
            this.NetworkList.Name = "NetworkList";
            this.NetworkList.Size = new System.Drawing.Size(726, 188);
            this.NetworkList.TabIndex = 19;
            this.NetworkList.UseCompatibleStateImageBehavior = false;
            // 
            // MacAddressData
            // 
            this.MacAddressData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MacAddressData.IsDerivedStyle = true;
            this.MacAddressData.Location = new System.Drawing.Point(568, 42);
            this.MacAddressData.Name = "MacAddressData";
            this.MacAddressData.Size = new System.Drawing.Size(120, 23);
            this.MacAddressData.Style = MetroSet_UI.Enums.Style.Dark;
            this.MacAddressData.StyleManager = null;
            this.MacAddressData.TabIndex = 21;
            this.MacAddressData.Text = "MAC Address";
            this.MacAddressData.ThemeAuthor = "Narwin";
            this.MacAddressData.ThemeName = "MetroDark";
            // 
            // InterfaceTypeData
            // 
            this.InterfaceTypeData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterfaceTypeData.IsDerivedStyle = true;
            this.InterfaceTypeData.Location = new System.Drawing.Point(418, 42);
            this.InterfaceTypeData.Name = "InterfaceTypeData";
            this.InterfaceTypeData.Size = new System.Drawing.Size(117, 23);
            this.InterfaceTypeData.Style = MetroSet_UI.Enums.Style.Dark;
            this.InterfaceTypeData.StyleManager = null;
            this.InterfaceTypeData.TabIndex = 22;
            this.InterfaceTypeData.Text = "Type";
            this.InterfaceTypeData.ThemeAuthor = "Narwin";
            this.InterfaceTypeData.ThemeName = "MetroDark";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MachineName);
            this.Controls.Add(this.TabManager);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.VersionLabel);
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager1;
            this.Text = "Reporter";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabManager.ResumeLayout(false);
            this.SystemTab.ResumeLayout(false);
            this.WindowsTab.ResumeLayout(false);
            this.DrivesTab.ResumeLayout(false);
            this.MemoryTab.ResumeLayout(false);
            this.NetworkTab.ResumeLayout(false);
            this.VideoTab.ResumeLayout(false);
            this.ReportTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel VersionLabel;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl TabManager;
        private MetroSet_UI.Child.MetroSetSetTabPage SystemTab;
        private MetroSet_UI.Child.MetroSetSetTabPage WindowsTab;
        private MetroSet_UI.Controls.MetroSetLabel SystemInformationLabel;
        private MetroSet_UI.Controls.MetroSetLabel MachineName;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetLabel SerialNumberLabel;
        private MetroSet_UI.Controls.MetroSetLabel SerialNumberData;
        private MetroSet_UI.Controls.MetroSetLabel ManufacturerData;
        private MetroSet_UI.Controls.MetroSetLabel ManufacturerLabel;
        private MetroSet_UI.Controls.MetroSetLabel ModelData;
        private MetroSet_UI.Controls.MetroSetLabel ModelLabel;
        private MetroSet_UI.Controls.MetroSetLabel ArchitectureData;
        private MetroSet_UI.Controls.MetroSetLabel ProcessorData;
        private MetroSet_UI.Controls.MetroSetLabel ProcessorLabel;
        private MetroSet_UI.Controls.MetroSetLabel ArchitectureLabel;
        private MetroSet_UI.Controls.MetroSetLabel CoreCountData;
        private MetroSet_UI.Controls.MetroSetLabel CoreCountLabel;
        private MetroSet_UI.Controls.MetroSetLabel WinVerData;
        private MetroSet_UI.Controls.MetroSetLabel WinVerLabel;
        private MetroSet_UI.Controls.MetroSetLabel WindowsInformationLabel;
        private MetroSet_UI.Controls.MetroSetLabel ProductIdData;
        private MetroSet_UI.Controls.MetroSetLabel ProductIdLabel;
        private MetroSet_UI.Child.MetroSetSetTabPage DrivesTab;
        private MetroSet_UI.Controls.MetroSetLabel DriveColumnLabel;
        private MetroSet_UI.Controls.MetroSetLabel AvailableSpaceLabel;
        private MetroSet_UI.Controls.MetroSetLabel TotalSpaceLabel;
        private MetroSet_UI.Controls.MetroSetLabel PercentAvailable;
        private MetroSet_UI.Controls.MetroSetLabel CDDriveLabel;
        private MetroSet_UI.Controls.MetroSetLabel StorageDriveLabel;
        private System.Windows.Forms.ListView StorageDeviceList;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.ListView CDDriveList;
        private MetroSet_UI.Child.MetroSetSetTabPage MemoryTab;
        private MetroSet_UI.Controls.MetroSetLabel TotalMemoryData;
        private MetroSet_UI.Controls.MetroSetLabel TotalMemoryLabel;
        private System.Windows.Forms.ListView MemoryList;
        private MetroSet_UI.Controls.MetroSetLabel LocationLabel;
        private MetroSet_UI.Controls.MetroSetLabel ManufactLabel;
        private MetroSet_UI.Controls.MetroSetLabel PartNumberLabel;
        private MetroSet_UI.Controls.MetroSetLabel CapacityLabel;
        private MetroSet_UI.Controls.MetroSetButton ReportButton;
        private MetroSet_UI.Controls.MetroSetButton CloseButton;
        private MetroSet_UI.Child.MetroSetSetTabPage ReportTab;
        private MetroSet_UI.Controls.MetroSetTextBox ReportLocation;
        private MetroSet_UI.Controls.MetroSetLabel ReportGenLabel;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox PriceData;
        private MetroSet_UI.Controls.MetroSetLabel PriceLabel;
        private MetroSet_UI.Controls.MetroSetButton OpenFileDialogButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroSet_UI.Controls.MetroSetButton GeneratePDFButton;
        private MetroSet_UI.Child.MetroSetSetTabPage VideoTab;
        private MetroSet_UI.Controls.MetroSetLabel GraphicsRAMData;
        private MetroSet_UI.Controls.MetroSetLabel GraphicsRamLabel;
        private MetroSet_UI.Controls.MetroSetLabel GraphicsCardData;
        private MetroSet_UI.Controls.MetroSetLabel GraphicsCardLabel;
        private MetroSet_UI.Controls.MetroSetLabel GraphicsInfoLabel;
        private MetroSet_UI.Controls.MetroSetLabel RefreshRateData;
        private MetroSet_UI.Controls.MetroSetLabel RefreshRateLabel;
        private MetroSet_UI.Controls.MetroSetLabel ResolutionData;
        private MetroSet_UI.Controls.MetroSetLabel ResolutionLabel;
        private MetroSet_UI.Child.MetroSetSetTabPage NetworkTab;
        private MetroSet_UI.Controls.MetroSetLabel AdapterLabel;
        private MetroSet_UI.Controls.MetroSetLabel InterfaceTypeData;
        private MetroSet_UI.Controls.MetroSetLabel MacAddressData;
        private System.Windows.Forms.ListView NetworkList;
        private MetroSet_UI.Controls.MetroSetLabel NetworkAdapterLabel;
    }
}

