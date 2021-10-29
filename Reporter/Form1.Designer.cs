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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.metroSetSetTabPage1 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetSetTabPage2 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.SystemInformationLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.MachineName = new MetroSet_UI.Controls.MetroSetLabel();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.SerialNumberLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.SerialNumberData = new MetroSet_UI.Controls.MetroSetLabel();
            this.ManufacturerLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.ManufacturerData = new MetroSet_UI.Controls.MetroSetLabel();
            this.ModelLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.ModelData = new MetroSet_UI.Controls.MetroSetLabel();
            this.ArchitectureLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.ProcessorLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.ProcessorData = new MetroSet_UI.Controls.MetroSetLabel();
            this.ArchitectureData = new MetroSet_UI.Controls.MetroSetLabel();
            this.CoreCountLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.CoreCountData = new MetroSet_UI.Controls.MetroSetLabel();
            this.WindowsInformationLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.WinVerLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.WinVerData = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTabControl1.SuspendLayout();
            this.metroSetSetTabPage1.SuspendLayout();
            this.metroSetSetTabPage2.SuspendLayout();
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
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl1.Controls.Add(this.metroSetSetTabPage1);
            this.metroSetTabControl1.Controls.Add(this.metroSetSetTabPage2);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(15, 98);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 1;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(763, 309);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl1.StyleManager = this.styleManager1;
            this.metroSetTabControl1.TabIndex = 2;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroDark";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // metroSetSetTabPage1
            // 
            this.metroSetSetTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.metroSetSetTabPage1.Controls.Add(this.CoreCountData);
            this.metroSetSetTabPage1.Controls.Add(this.CoreCountLabel);
            this.metroSetSetTabPage1.Controls.Add(this.ArchitectureData);
            this.metroSetSetTabPage1.Controls.Add(this.ProcessorData);
            this.metroSetSetTabPage1.Controls.Add(this.ProcessorLabel);
            this.metroSetSetTabPage1.Controls.Add(this.ArchitectureLabel);
            this.metroSetSetTabPage1.Controls.Add(this.ModelData);
            this.metroSetSetTabPage1.Controls.Add(this.ModelLabel);
            this.metroSetSetTabPage1.Controls.Add(this.ManufacturerData);
            this.metroSetSetTabPage1.Controls.Add(this.ManufacturerLabel);
            this.metroSetSetTabPage1.Controls.Add(this.SerialNumberData);
            this.metroSetSetTabPage1.Controls.Add(this.SerialNumberLabel);
            this.metroSetSetTabPage1.Controls.Add(this.SystemInformationLabel);
            this.metroSetSetTabPage1.Font = null;
            this.metroSetSetTabPage1.ImageIndex = 0;
            this.metroSetSetTabPage1.ImageKey = null;
            this.metroSetSetTabPage1.IsDerivedStyle = true;
            this.metroSetSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage1.Name = "metroSetSetTabPage1";
            this.metroSetSetTabPage1.Size = new System.Drawing.Size(755, 263);
            this.metroSetSetTabPage1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetSetTabPage1.StyleManager = this.styleManager1;
            this.metroSetSetTabPage1.TabIndex = 0;
            this.metroSetSetTabPage1.Text = "System";
            this.metroSetSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage1.ThemeName = "MetroDark";
            this.metroSetSetTabPage1.ToolTipText = null;
            this.metroSetSetTabPage1.Click += new System.EventHandler(this.metroSetSetTabPage1_Click);
            // 
            // metroSetSetTabPage2
            // 
            this.metroSetSetTabPage2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.metroSetSetTabPage2.Controls.Add(this.WinVerData);
            this.metroSetSetTabPage2.Controls.Add(this.WinVerLabel);
            this.metroSetSetTabPage2.Controls.Add(this.WindowsInformationLabel);
            this.metroSetSetTabPage2.Font = null;
            this.metroSetSetTabPage2.ImageIndex = 0;
            this.metroSetSetTabPage2.ImageKey = null;
            this.metroSetSetTabPage2.IsDerivedStyle = true;
            this.metroSetSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage2.Name = "metroSetSetTabPage2";
            this.metroSetSetTabPage2.Size = new System.Drawing.Size(755, 263);
            this.metroSetSetTabPage2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetSetTabPage2.StyleManager = this.styleManager1;
            this.metroSetSetTabPage2.TabIndex = 1;
            this.metroSetSetTabPage2.Text = "Windows";
            this.metroSetSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage2.ThemeName = "MetroDark";
            this.metroSetSetTabPage2.ToolTipText = null;
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
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\kevin\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Dark;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroDark";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MachineName);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.VersionLabel);
            this.Name = "Form1";
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager1;
            this.Text = "Reporter";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroSetTabControl1.ResumeLayout(false);
            this.metroSetSetTabPage1.ResumeLayout(false);
            this.metroSetSetTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel VersionLabel;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage2;
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
    }
}

