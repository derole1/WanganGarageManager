namespace WanganGarageManager
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuSwitcher = new System.Windows.Forms.TabControl();
            this.tabGarage = new System.Windows.Forms.TabPage();
            this.lblWip = new System.Windows.Forms.Label();
            this.lblNoCars = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnGarageExit = new System.Windows.Forms.Button();
            this.lstGarage = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPowerHandling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDeleteCar = new System.Windows.Forms.ToolStripMenuItem();
            this.carPreviews = new System.Windows.Forms.ImageList(this.components);
            this.lblSelectCar = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lblSettingsWip = new System.Windows.Forms.Label();
            this.lblSettingsBG = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstSettingsBorder = new System.Windows.Forms.ListView();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblGarageView = new System.Windows.Forms.Label();
            this.cmbGarageView = new System.Windows.Forms.ComboBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.chkPowerHandling = new System.Windows.Forms.CheckBox();
            this.tabCopying = new System.Windows.Forms.TabPage();
            this.lblReupload = new System.Windows.Forms.Label();
            this.lblCopyInfo = new System.Windows.Forms.Label();
            this.lblCopyMoreInfo = new System.Windows.Forms.Label();
            this.menuSwitcher.SuspendLayout();
            this.tabGarage.SuspendLayout();
            this.lstContextMenu.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabCopying.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSwitcher
            // 
            this.menuSwitcher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuSwitcher.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.menuSwitcher.Controls.Add(this.tabGarage);
            this.menuSwitcher.Controls.Add(this.tabSettings);
            this.menuSwitcher.Controls.Add(this.tabCopying);
            this.menuSwitcher.Location = new System.Drawing.Point(-4, -25);
            this.menuSwitcher.Name = "menuSwitcher";
            this.menuSwitcher.SelectedIndex = 0;
            this.menuSwitcher.Size = new System.Drawing.Size(822, 480);
            this.menuSwitcher.TabIndex = 0;
            this.menuSwitcher.SelectedIndexChanged += new System.EventHandler(this.menuSwitcher_SelectedIndexChanged);
            // 
            // tabGarage
            // 
            this.tabGarage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabGarage.Controls.Add(this.btnSettings);
            this.tabGarage.Controls.Add(this.lblWip);
            this.tabGarage.Controls.Add(this.lblNoCars);
            this.tabGarage.Controls.Add(this.lblCredit);
            this.tabGarage.Controls.Add(this.btnGarageExit);
            this.tabGarage.Controls.Add(this.lstGarage);
            this.tabGarage.Controls.Add(this.lblSelectCar);
            this.tabGarage.Location = new System.Drawing.Point(4, 25);
            this.tabGarage.Name = "tabGarage";
            this.tabGarage.Size = new System.Drawing.Size(814, 451);
            this.tabGarage.TabIndex = 0;
            this.tabGarage.Text = "Garage";
            // 
            // lblWip
            // 
            this.lblWip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWip.ForeColor = System.Drawing.Color.DimGray;
            this.lblWip.Location = new System.Drawing.Point(211, 439);
            this.lblWip.Name = "lblWip";
            this.lblWip.Size = new System.Drawing.Size(606, 14);
            this.lblWip.TabIndex = 3;
            this.lblWip.Text = "Work in progress build, do not distribute!";
            this.lblWip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNoCars
            // 
            this.lblNoCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblNoCars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCars.ForeColor = System.Drawing.Color.DimGray;
            this.lblNoCars.Location = new System.Drawing.Point(13, 38);
            this.lblNoCars.Name = "lblNoCars";
            this.lblNoCars.Size = new System.Drawing.Size(788, 400);
            this.lblNoCars.TabIndex = 1;
            this.lblNoCars.Text = "No cars have been created.\r\nPerform a race in a car of your choice for it to show" +
    " up here.";
            this.lblNoCars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCredit
            // 
            this.lblCredit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCredit.ForeColor = System.Drawing.Color.DimGray;
            this.lblCredit.Location = new System.Drawing.Point(271, 7);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(531, 26);
            this.lblCredit.TabIndex = 1;
            this.lblCredit.Text = "Wangan Garage Manager\r\nVersion -";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnGarageExit
            // 
            this.btnGarageExit.ForeColor = System.Drawing.Color.Black;
            this.btnGarageExit.Location = new System.Drawing.Point(12, 8);
            this.btnGarageExit.Name = "btnGarageExit";
            this.btnGarageExit.Size = new System.Drawing.Size(75, 23);
            this.btnGarageExit.TabIndex = 2;
            this.btnGarageExit.Text = "Exit";
            this.btnGarageExit.UseVisualStyleBackColor = true;
            this.btnGarageExit.Click += new System.EventHandler(this.btnGarageExit_Click);
            // 
            // lstGarage
            // 
            this.lstGarage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGarage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lstGarage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmPowerHandling,
            this.clmFileName});
            this.lstGarage.ContextMenuStrip = this.lstContextMenu;
            this.lstGarage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGarage.ForeColor = System.Drawing.Color.White;
            this.lstGarage.FullRowSelect = true;
            this.lstGarage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstGarage.HideSelection = false;
            this.lstGarage.LargeImageList = this.carPreviews;
            this.lstGarage.Location = new System.Drawing.Point(12, 37);
            this.lstGarage.Name = "lstGarage";
            this.lstGarage.Size = new System.Drawing.Size(790, 402);
            this.lstGarage.SmallImageList = this.carPreviews;
            this.lstGarage.TabIndex = 1;
            this.lstGarage.UseCompatibleStateImageBehavior = false;
            this.lstGarage.View = System.Windows.Forms.View.Tile;
            this.lstGarage.ItemActivate += new System.EventHandler(this.lstGarage_ItemActivate);
            this.lstGarage.SelectedIndexChanged += new System.EventHandler(this.lstGarage_SelectedIndexChanged);
            // 
            // clmName
            // 
            this.clmName.Text = "Car model";
            this.clmName.Width = 360;
            // 
            // clmPowerHandling
            // 
            this.clmPowerHandling.Text = "Power/Handling";
            this.clmPowerHandling.Width = 160;
            // 
            // clmFileName
            // 
            this.clmFileName.Text = "File name";
            this.clmFileName.Width = 200;
            // 
            // lstContextMenu
            // 
            this.lstContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeleteCar});
            this.lstContextMenu.Name = "lstContextMenu";
            this.lstContextMenu.Size = new System.Drawing.Size(140, 26);
            this.lstContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.lstContextMenu_Opening);
            // 
            // menuDeleteCar
            // 
            this.menuDeleteCar.Name = "menuDeleteCar";
            this.menuDeleteCar.Size = new System.Drawing.Size(139, 22);
            this.menuDeleteCar.Text = "Delete car(s)";
            this.menuDeleteCar.Click += new System.EventHandler(this.menuDeleteCar_Click);
            // 
            // carPreviews
            // 
            this.carPreviews.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("carPreviews.ImageStream")));
            this.carPreviews.TransparentColor = System.Drawing.Color.Transparent;
            this.carPreviews.Images.SetKeyName(0, "00.png");
            this.carPreviews.Images.SetKeyName(1, "0A.png");
            this.carPreviews.Images.SetKeyName(2, "0B.png");
            this.carPreviews.Images.SetKeyName(3, "0C.png");
            this.carPreviews.Images.SetKeyName(4, "0D.png");
            this.carPreviews.Images.SetKeyName(5, "0E.png");
            this.carPreviews.Images.SetKeyName(6, "0F.png");
            this.carPreviews.Images.SetKeyName(7, "01.png");
            this.carPreviews.Images.SetKeyName(8, "1A.png");
            this.carPreviews.Images.SetKeyName(9, "1B.png");
            this.carPreviews.Images.SetKeyName(10, "1C.png");
            this.carPreviews.Images.SetKeyName(11, "1D.png");
            this.carPreviews.Images.SetKeyName(12, "1E.png");
            this.carPreviews.Images.SetKeyName(13, "1F.png");
            this.carPreviews.Images.SetKeyName(14, "02.png");
            this.carPreviews.Images.SetKeyName(15, "2A.png");
            this.carPreviews.Images.SetKeyName(16, "2B.png");
            this.carPreviews.Images.SetKeyName(17, "2C.png");
            this.carPreviews.Images.SetKeyName(18, "2D.png");
            this.carPreviews.Images.SetKeyName(19, "2E.png");
            this.carPreviews.Images.SetKeyName(20, "2F.png");
            this.carPreviews.Images.SetKeyName(21, "03.png");
            this.carPreviews.Images.SetKeyName(22, "3A.png");
            this.carPreviews.Images.SetKeyName(23, "3B.png");
            this.carPreviews.Images.SetKeyName(24, "3C.png");
            this.carPreviews.Images.SetKeyName(25, "3D.png");
            this.carPreviews.Images.SetKeyName(26, "04.png");
            this.carPreviews.Images.SetKeyName(27, "4A.png");
            this.carPreviews.Images.SetKeyName(28, "4B.png");
            this.carPreviews.Images.SetKeyName(29, "4C.png");
            this.carPreviews.Images.SetKeyName(30, "4D.png");
            this.carPreviews.Images.SetKeyName(31, "4E.png");
            this.carPreviews.Images.SetKeyName(32, "4F.png");
            this.carPreviews.Images.SetKeyName(33, "05.png");
            this.carPreviews.Images.SetKeyName(34, "5A.png");
            this.carPreviews.Images.SetKeyName(35, "5B.png");
            this.carPreviews.Images.SetKeyName(36, "5C.png");
            this.carPreviews.Images.SetKeyName(37, "5D.png");
            this.carPreviews.Images.SetKeyName(38, "5E.png");
            this.carPreviews.Images.SetKeyName(39, "5F.png");
            this.carPreviews.Images.SetKeyName(40, "06.png");
            this.carPreviews.Images.SetKeyName(41, "6A.png");
            this.carPreviews.Images.SetKeyName(42, "6B.png");
            this.carPreviews.Images.SetKeyName(43, "6C.png");
            this.carPreviews.Images.SetKeyName(44, "6D.png");
            this.carPreviews.Images.SetKeyName(45, "6E.png");
            this.carPreviews.Images.SetKeyName(46, "6F.png");
            this.carPreviews.Images.SetKeyName(47, "07.png");
            this.carPreviews.Images.SetKeyName(48, "08.png");
            this.carPreviews.Images.SetKeyName(49, "09.png");
            this.carPreviews.Images.SetKeyName(50, "10.png");
            this.carPreviews.Images.SetKeyName(51, "11.png");
            this.carPreviews.Images.SetKeyName(52, "12.png");
            this.carPreviews.Images.SetKeyName(53, "13.png");
            this.carPreviews.Images.SetKeyName(54, "14.png");
            this.carPreviews.Images.SetKeyName(55, "15.png");
            this.carPreviews.Images.SetKeyName(56, "16.png");
            this.carPreviews.Images.SetKeyName(57, "17.png");
            this.carPreviews.Images.SetKeyName(58, "18.png");
            this.carPreviews.Images.SetKeyName(59, "19.png");
            this.carPreviews.Images.SetKeyName(60, "20.png");
            this.carPreviews.Images.SetKeyName(61, "22.png");
            this.carPreviews.Images.SetKeyName(62, "23.png");
            this.carPreviews.Images.SetKeyName(63, "24.png");
            this.carPreviews.Images.SetKeyName(64, "25.png");
            this.carPreviews.Images.SetKeyName(65, "27.png");
            this.carPreviews.Images.SetKeyName(66, "28.png");
            this.carPreviews.Images.SetKeyName(67, "29.png");
            this.carPreviews.Images.SetKeyName(68, "30.png");
            this.carPreviews.Images.SetKeyName(69, "31.png");
            this.carPreviews.Images.SetKeyName(70, "32.png");
            this.carPreviews.Images.SetKeyName(71, "33.png");
            this.carPreviews.Images.SetKeyName(72, "34.png");
            this.carPreviews.Images.SetKeyName(73, "35.png");
            this.carPreviews.Images.SetKeyName(74, "36.png");
            this.carPreviews.Images.SetKeyName(75, "37.png");
            this.carPreviews.Images.SetKeyName(76, "38.png");
            this.carPreviews.Images.SetKeyName(77, "39.png");
            this.carPreviews.Images.SetKeyName(78, "42.png");
            this.carPreviews.Images.SetKeyName(79, "47.png");
            this.carPreviews.Images.SetKeyName(80, "48.png");
            this.carPreviews.Images.SetKeyName(81, "49.png");
            this.carPreviews.Images.SetKeyName(82, "50.png");
            this.carPreviews.Images.SetKeyName(83, "52.png");
            this.carPreviews.Images.SetKeyName(84, "54.png");
            this.carPreviews.Images.SetKeyName(85, "55.png");
            this.carPreviews.Images.SetKeyName(86, "56.png");
            this.carPreviews.Images.SetKeyName(87, "57.png");
            this.carPreviews.Images.SetKeyName(88, "58.png");
            this.carPreviews.Images.SetKeyName(89, "59.png");
            this.carPreviews.Images.SetKeyName(90, "60.png");
            this.carPreviews.Images.SetKeyName(91, "61.png");
            this.carPreviews.Images.SetKeyName(92, "62.png");
            this.carPreviews.Images.SetKeyName(93, "69.png");
            this.carPreviews.Images.SetKeyName(94, "70.png");
            this.carPreviews.Images.SetKeyName(95, "72.png");
            this.carPreviews.Images.SetKeyName(96, "DAMMY.png");
            this.carPreviews.Images.SetKeyName(97, "FF.png");
            // 
            // lblSelectCar
            // 
            this.lblSelectCar.AutoSize = true;
            this.lblSelectCar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCar.ForeColor = System.Drawing.Color.White;
            this.lblSelectCar.Location = new System.Drawing.Point(174, 6);
            this.lblSelectCar.Name = "lblSelectCar";
            this.lblSelectCar.Size = new System.Drawing.Size(93, 25);
            this.lblSelectCar.TabIndex = 0;
            this.lblSelectCar.Text = "Select car";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabSettings.Controls.Add(this.chkPowerHandling);
            this.tabSettings.Controls.Add(this.cmbGarageView);
            this.tabSettings.Controls.Add(this.lblGarageView);
            this.tabSettings.Controls.Add(this.lblSettingsWip);
            this.tabSettings.Controls.Add(this.lblSettingsBG);
            this.tabSettings.Controls.Add(this.btnBack);
            this.tabSettings.Controls.Add(this.lstSettingsBorder);
            this.tabSettings.Controls.Add(this.lblSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(814, 451);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "tabSettings";
            // 
            // lblSettingsWip
            // 
            this.lblSettingsWip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsWip.ForeColor = System.Drawing.Color.DimGray;
            this.lblSettingsWip.Location = new System.Drawing.Point(211, 439);
            this.lblSettingsWip.Name = "lblSettingsWip";
            this.lblSettingsWip.Size = new System.Drawing.Size(606, 14);
            this.lblSettingsWip.TabIndex = 9;
            this.lblSettingsWip.Text = "Work in progress build, do not distribute!";
            this.lblSettingsWip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSettingsBG
            // 
            this.lblSettingsBG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSettingsBG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsBG.ForeColor = System.Drawing.Color.DimGray;
            this.lblSettingsBG.Location = new System.Drawing.Point(13, 38);
            this.lblSettingsBG.Name = "lblSettingsBG";
            this.lblSettingsBG.Size = new System.Drawing.Size(788, 400);
            this.lblSettingsBG.TabIndex = 5;
            this.lblSettingsBG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(12, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstSettingsBorder
            // 
            this.lstSettingsBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSettingsBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lstSettingsBorder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSettingsBorder.ForeColor = System.Drawing.Color.White;
            this.lstSettingsBorder.FullRowSelect = true;
            this.lstSettingsBorder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstSettingsBorder.HideSelection = false;
            this.lstSettingsBorder.Location = new System.Drawing.Point(12, 37);
            this.lstSettingsBorder.Name = "lstSettingsBorder";
            this.lstSettingsBorder.Size = new System.Drawing.Size(790, 402);
            this.lstSettingsBorder.TabIndex = 7;
            this.lstSettingsBorder.UseCompatibleStateImageBehavior = false;
            this.lstSettingsBorder.View = System.Windows.Forms.View.List;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(93, 6);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(79, 25);
            this.lblSettings.TabIndex = 4;
            this.lblSettings.Text = "Settings";
            // 
            // lblGarageView
            // 
            this.lblGarageView.AutoSize = true;
            this.lblGarageView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblGarageView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarageView.Location = new System.Drawing.Point(21, 46);
            this.lblGarageView.Name = "lblGarageView";
            this.lblGarageView.Size = new System.Drawing.Size(133, 21);
            this.lblGarageView.TabIndex = 10;
            this.lblGarageView.Text = "Garage view type:";
            this.lblGarageView.UseMnemonic = false;
            // 
            // cmbGarageView
            // 
            this.cmbGarageView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGarageView.FormattingEnabled = true;
            this.cmbGarageView.Items.AddRange(new object[] {
            "Standard",
            "Tiled",
            "Detailed",
            "Compact"});
            this.cmbGarageView.Location = new System.Drawing.Point(25, 70);
            this.cmbGarageView.Name = "cmbGarageView";
            this.cmbGarageView.Size = new System.Drawing.Size(275, 21);
            this.cmbGarageView.TabIndex = 11;
            this.cmbGarageView.SelectedIndexChanged += new System.EventHandler(this.cmbGarageView_SelectedIndexChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(93, 8);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // chkPowerHandling
            // 
            this.chkPowerHandling.AutoSize = true;
            this.chkPowerHandling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkPowerHandling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkPowerHandling.Location = new System.Drawing.Point(25, 97);
            this.chkPowerHandling.Name = "chkPowerHandling";
            this.chkPowerHandling.Size = new System.Drawing.Size(267, 25);
            this.chkPowerHandling.TabIndex = 12;
            this.chkPowerHandling.Text = "Use Power/Handling instead of HP";
            this.chkPowerHandling.UseVisualStyleBackColor = false;
            this.chkPowerHandling.CheckedChanged += new System.EventHandler(this.chkPowerHandling_CheckedChanged);
            // 
            // tabCopying
            // 
            this.tabCopying.BackColor = System.Drawing.Color.Black;
            this.tabCopying.Controls.Add(this.lblCopyMoreInfo);
            this.tabCopying.Controls.Add(this.lblCopyInfo);
            this.tabCopying.Controls.Add(this.lblReupload);
            this.tabCopying.Location = new System.Drawing.Point(4, 25);
            this.tabCopying.Name = "tabCopying";
            this.tabCopying.Size = new System.Drawing.Size(814, 451);
            this.tabCopying.TabIndex = 2;
            this.tabCopying.Text = "Copying";
            // 
            // lblReupload
            // 
            this.lblReupload.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReupload.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReupload.ForeColor = System.Drawing.Color.Red;
            this.lblReupload.Location = new System.Drawing.Point(0, 0);
            this.lblReupload.Name = "lblReupload";
            this.lblReupload.Size = new System.Drawing.Size(814, 67);
            this.lblReupload.TabIndex = 0;
            this.lblReupload.Text = "This is a reupload!";
            this.lblReupload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCopyInfo
            // 
            this.lblCopyInfo.BackColor = System.Drawing.Color.Red;
            this.lblCopyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyInfo.ForeColor = System.Drawing.Color.White;
            this.lblCopyInfo.Location = new System.Drawing.Point(0, 67);
            this.lblCopyInfo.Name = "lblCopyInfo";
            this.lblCopyInfo.Size = new System.Drawing.Size(814, 384);
            this.lblCopyInfo.TabIndex = 1;
            this.lblCopyInfo.Text = "This application has not been downloaded from derole.co.uk!\r\nIt may have been tam" +
    "pered with and/or be out of date!";
            this.lblCopyInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCopyMoreInfo
            // 
            this.lblCopyMoreInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCopyMoreInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyMoreInfo.ForeColor = System.Drawing.Color.Red;
            this.lblCopyMoreInfo.Location = new System.Drawing.Point(0, 196);
            this.lblCopyMoreInfo.Name = "lblCopyMoreInfo";
            this.lblCopyMoreInfo.Size = new System.Drawing.Size(814, 255);
            this.lblCopyMoreInfo.TabIndex = 2;
            this.lblCopyMoreInfo.Text = "If you bought this from a seller, request a refund IMMEDIATELY. This is not paid " +
    "software and you should not be paying money to use it.";
            this.lblCopyMoreInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(814, 451);
            this.Controls.Add(this.menuSwitcher);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmMain";
            this.Text = "Wangan Garage Manager";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.menuSwitcher.ResumeLayout(false);
            this.tabGarage.ResumeLayout(false);
            this.tabGarage.PerformLayout();
            this.lstContextMenu.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabCopying.ResumeLayout(false);
            this.ResumeLayout(false);

            CopyProtect();
        }

        void CopyProtect()
        {
            string fileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            if (mac == "000000000000")
            {
                System.IO.File.Move(fileName, System.IO.Path.GetDirectoryName(fileName) + "\\original.exe");
                System.IO.File.Copy(System.IO.Path.GetDirectoryName(fileName) + "\\original.exe", fileName);
                byte[] data = System.IO.File.ReadAllBytes(fileName);
                System.IO.File.WriteAllBytes(fileName, data);
            }
            else
            {
                if (System.IO.File.Exists(System.IO.Path.GetDirectoryName(fileName) + "\\original.exe"))
                {
                    System.IO.File.Delete(System.IO.Path.GetDirectoryName(fileName) + "\\original.exe");
                    //if (mac == )
                }
            }
        }

        #endregion

        private System.Windows.Forms.TabControl menuSwitcher;
        private System.Windows.Forms.TabPage tabGarage;
        public System.Windows.Forms.Button btnGarageExit;
        private System.Windows.Forms.ListView lstGarage;
        public System.Windows.Forms.Label lblSelectCar;
        public System.Windows.Forms.ColumnHeader clmName;
        public System.Windows.Forms.ColumnHeader clmPowerHandling;
        public System.Windows.Forms.ColumnHeader clmFileName;
        private System.Windows.Forms.ImageList carPreviews;
        private System.Windows.Forms.Label lblCredit;
        public System.Windows.Forms.Label lblNoCars;
        private System.Windows.Forms.Label lblWip;
        private System.Windows.Forms.ContextMenuStrip lstContextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteCar;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ComboBox cmbGarageView;
        private System.Windows.Forms.Label lblSettingsWip;
        public System.Windows.Forms.Label lblSettingsBG;
        public System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lstSettingsBorder;
        public System.Windows.Forms.Label lblSettings;
        public System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.Label lblGarageView;
        public System.Windows.Forms.CheckBox chkPowerHandling;
        private System.Windows.Forms.TabPage tabCopying;
        private System.Windows.Forms.Label lblCopyMoreInfo;
        private System.Windows.Forms.Label lblCopyInfo;
        private System.Windows.Forms.Label lblReupload;
    }
}

