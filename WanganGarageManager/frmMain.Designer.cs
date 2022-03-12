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
            System.Windows.Forms.ToolStripMenuItem menuAddCar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuSwitcher = new System.Windows.Forms.TabControl();
            this.tabGarage = new System.Windows.Forms.TabPage();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblNoCars = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnGarageExit = new System.Windows.Forms.Button();
            this.lstGarage = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPowerHandling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDeleteCar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuforceCarSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFCSOFF = new System.Windows.Forms.ToolStripMenuItem();
            this.carPreviews = new System.Windows.Forms.ImageList(this.components);
            this.lblSelectCar = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.chkPowerHandling = new System.Windows.Forms.CheckBox();
            this.cmbGarageView = new System.Windows.Forms.ComboBox();
            this.lblGarageView = new System.Windows.Forms.Label();
            this.lblSettingsBG = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstSettingsBorder = new System.Windows.Forms.ListView();
            this.lblSettings = new System.Windows.Forms.Label();
            menuAddCar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSwitcher.SuspendLayout();
            this.tabGarage.SuspendLayout();
            this.lstContextMenu.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAddCar
            // 
            menuAddCar.Enabled = false;
            menuAddCar.Name = "menuAddCar";
            menuAddCar.ShowShortcutKeys = false;
            menuAddCar.Size = new System.Drawing.Size(122, 22);
            menuAddCar.Text = "車を追加";
            menuAddCar.Visible = false;
            menuAddCar.Click += new System.EventHandler(this.menuAddCar_Click);
            // 
            // menuSwitcher
            // 
            this.menuSwitcher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuSwitcher.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.menuSwitcher.Controls.Add(this.tabGarage);
            this.menuSwitcher.Controls.Add(this.tabSettings);
            this.menuSwitcher.Location = new System.Drawing.Point(-5, -25);
            this.menuSwitcher.Name = "menuSwitcher";
            this.menuSwitcher.SelectedIndex = 0;
            this.menuSwitcher.Size = new System.Drawing.Size(823, 445);
            this.menuSwitcher.TabIndex = 0;
            this.menuSwitcher.SelectedIndexChanged += new System.EventHandler(this.menuSwitcher_SelectedIndexChanged);
            // 
            // tabGarage
            // 
            this.tabGarage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabGarage.Controls.Add(this.btnSettings);
            this.tabGarage.Controls.Add(this.lblNoCars);
            this.tabGarage.Controls.Add(this.lblCredit);
            this.tabGarage.Controls.Add(this.btnGarageExit);
            this.tabGarage.Controls.Add(this.lstGarage);
            this.tabGarage.Controls.Add(this.lblSelectCar);
            this.tabGarage.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabGarage.Location = new System.Drawing.Point(4, 25);
            this.tabGarage.Name = "tabGarage";
            this.tabGarage.Size = new System.Drawing.Size(815, 416);
            this.tabGarage.TabIndex = 0;
            this.tabGarage.Text = "Garage";
            this.tabGarage.Click += new System.EventHandler(this.tabGarage_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(93, 7);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 21);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblNoCars
            // 
            this.lblNoCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblNoCars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCars.ForeColor = System.Drawing.Color.DimGray;
            this.lblNoCars.Location = new System.Drawing.Point(25, 35);
            this.lblNoCars.Name = "lblNoCars";
            this.lblNoCars.Size = new System.Drawing.Size(766, 363);
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
            this.lblCredit.Location = new System.Drawing.Point(613, 4);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(185, 24);
            this.lblCredit.TabIndex = 1;
            this.lblCredit.Text = "Wangan Garage Manager5DX Plus\r\nVersion 0.9";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCredit.Click += new System.EventHandler(this.lblCredit_Click);
            // 
            // btnGarageExit
            // 
            this.btnGarageExit.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGarageExit.ForeColor = System.Drawing.Color.Black;
            this.btnGarageExit.Location = new System.Drawing.Point(12, 7);
            this.btnGarageExit.Name = "btnGarageExit";
            this.btnGarageExit.Size = new System.Drawing.Size(75, 21);
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
            this.lstGarage.Location = new System.Drawing.Point(13, 34);
            this.lstGarage.Name = "lstGarage";
            this.lstGarage.Size = new System.Drawing.Size(790, 370);
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
            menuAddCar,
            this.menuDeleteCar,
            this.menuforceCarSelect,
            this.menuFCSOFF});
            this.lstContextMenu.Name = "lstContextMenu";
            this.lstContextMenu.Size = new System.Drawing.Size(123, 92);
            this.lstContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.lstContextMenu_Opening);
            // 
            // menuDeleteCar
            // 
            this.menuDeleteCar.Name = "menuDeleteCar";
            this.menuDeleteCar.Size = new System.Drawing.Size(122, 22);
            this.menuDeleteCar.Text = "車を削除";
            this.menuDeleteCar.Click += new System.EventHandler(this.menuDeleteCar_Click);
            // 
            // menuforceCarSelect
            // 
            this.menuforceCarSelect.Name = "menuforceCarSelect";
            this.menuforceCarSelect.Size = new System.Drawing.Size(122, 22);
            this.menuforceCarSelect.Text = "強制固定";
            this.menuforceCarSelect.Click += new System.EventHandler(this.forceCarSelectToolStripMenuItem_Click);
            // 
            // menuFCSOFF
            // 
            this.menuFCSOFF.Name = "menuFCSOFF";
            this.menuFCSOFF.Size = new System.Drawing.Size(122, 22);
            this.menuFCSOFF.Text = "固定解除";
            this.menuFCSOFF.Click += new System.EventHandler(this.menuFCSOFF_Click);
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
            this.carPreviews.Images.SetKeyName(96, "FF.png");
            this.carPreviews.Images.SetKeyName(97, "69.png");
            this.carPreviews.Images.SetKeyName(98, "76.png");
            this.carPreviews.Images.SetKeyName(99, "7B.png");
            this.carPreviews.Images.SetKeyName(100, "72.png");
            this.carPreviews.Images.SetKeyName(101, "7C.png");
            this.carPreviews.Images.SetKeyName(102, "6A.png");
            this.carPreviews.Images.SetKeyName(103, "7F.png");
            this.carPreviews.Images.SetKeyName(104, "7E.png");
            this.carPreviews.Images.SetKeyName(105, "82.png");
            this.carPreviews.Images.SetKeyName(106, "70.png");
            this.carPreviews.Images.SetKeyName(107, "73.png");
            this.carPreviews.Images.SetKeyName(108, "75.png");
            this.carPreviews.Images.SetKeyName(109, "6B.png");
            this.carPreviews.Images.SetKeyName(110, "6C.png");
            this.carPreviews.Images.SetKeyName(111, "6D.png");
            this.carPreviews.Images.SetKeyName(112, "6E.png");
            this.carPreviews.Images.SetKeyName(113, "6F.png");
            this.carPreviews.Images.SetKeyName(114, "80.png");
            this.carPreviews.Images.SetKeyName(115, "85.png");
            this.carPreviews.Images.SetKeyName(116, "83.png");
            this.carPreviews.Images.SetKeyName(117, "71.png");
            this.carPreviews.Images.SetKeyName(118, "53.png");
            this.carPreviews.Images.SetKeyName(119, "51.png");
            this.carPreviews.Images.SetKeyName(120, "21.png");
            this.carPreviews.Images.SetKeyName(121, "78.png");
            // 
            // lblSelectCar
            // 
            this.lblSelectCar.AutoSize = true;
            this.lblSelectCar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCar.ForeColor = System.Drawing.Color.White;
            this.lblSelectCar.Location = new System.Drawing.Point(174, 6);
            this.lblSelectCar.Name = "lblSelectCar";
            this.lblSelectCar.Size = new System.Drawing.Size(96, 25);
            this.lblSelectCar.TabIndex = 0;
            this.lblSelectCar.Text = "Select car";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabSettings.Controls.Add(this.chkPowerHandling);
            this.tabSettings.Controls.Add(this.cmbGarageView);
            this.tabSettings.Controls.Add(this.lblGarageView);
            this.tabSettings.Controls.Add(this.lblSettingsBG);
            this.tabSettings.Controls.Add(this.btnBack);
            this.tabSettings.Controls.Add(this.lstSettingsBorder);
            this.tabSettings.Controls.Add(this.lblSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(815, 416);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "tabSettings";
            // 
            // chkPowerHandling
            // 
            this.chkPowerHandling.AutoSize = true;
            this.chkPowerHandling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkPowerHandling.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPowerHandling.Location = new System.Drawing.Point(25, 90);
            this.chkPowerHandling.Name = "chkPowerHandling";
            this.chkPowerHandling.Size = new System.Drawing.Size(293, 25);
            this.chkPowerHandling.TabIndex = 12;
            this.chkPowerHandling.Text = "Use Power/Handling instead of HP";
            this.chkPowerHandling.UseVisualStyleBackColor = false;
            this.chkPowerHandling.CheckedChanged += new System.EventHandler(this.chkPowerHandling_CheckedChanged);
            // 
            // cmbGarageView
            // 
            this.cmbGarageView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGarageView.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbGarageView.FormattingEnabled = true;
            this.cmbGarageView.Items.AddRange(new object[] {
            "デフォルト",
            "タイル",
            "詳細",
            "シンプル"});
            this.cmbGarageView.Location = new System.Drawing.Point(25, 65);
            this.cmbGarageView.Name = "cmbGarageView";
            this.cmbGarageView.Size = new System.Drawing.Size(275, 20);
            this.cmbGarageView.TabIndex = 11;
            this.cmbGarageView.SelectedIndexChanged += new System.EventHandler(this.cmbGarageView_SelectedIndexChanged);
            // 
            // lblGarageView
            // 
            this.lblGarageView.AutoSize = true;
            this.lblGarageView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblGarageView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarageView.Location = new System.Drawing.Point(21, 42);
            this.lblGarageView.Name = "lblGarageView";
            this.lblGarageView.Size = new System.Drawing.Size(146, 21);
            this.lblGarageView.TabIndex = 10;
            this.lblGarageView.Text = "Garage view type:";
            this.lblGarageView.UseMnemonic = false;
            // 
            // lblSettingsBG
            // 
            this.lblSettingsBG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSettingsBG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsBG.ForeColor = System.Drawing.Color.DimGray;
            this.lblSettingsBG.Location = new System.Drawing.Point(13, 35);
            this.lblSettingsBG.Name = "lblSettingsBG";
            this.lblSettingsBG.Size = new System.Drawing.Size(789, 346);
            this.lblSettingsBG.TabIndex = 5;
            this.lblSettingsBG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(12, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 21);
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
            this.lstSettingsBorder.Location = new System.Drawing.Point(12, 34);
            this.lstSettingsBorder.Name = "lstSettingsBorder";
            this.lstSettingsBorder.Size = new System.Drawing.Size(791, 348);
            this.lstSettingsBorder.TabIndex = 7;
            this.lstSettingsBorder.UseCompatibleStateImageBehavior = false;
            this.lstSettingsBorder.View = System.Windows.Forms.View.List;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(93, 6);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(84, 25);
            this.lblSettings.TabIndex = 4;
            this.lblSettings.Text = "Settings";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(814, 416);
            this.Controls.Add(this.menuSwitcher);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 446);
            this.Name = "frmMain";
            this.Text = "Wangan Garage Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.menuSwitcher.ResumeLayout(false);
            this.tabGarage.ResumeLayout(false);
            this.tabGarage.PerformLayout();
            this.lstContextMenu.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        void Protect()
        {
            //
            // noitcetorPypoc
            // 
            var a = new byte[] { 0x47, 0x6f, 0x50, 0x6c, 0x61, 0x79, 0x4f, 0x75, 0x74, 0x73, 0x69, 0x64, 0x65, 0x4c, 0x6f, 0x6c };  //TODO: Has this been modified? If so resign
    var b = new byte[16];
            foreach (var w in new System.Management.ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive").Get())
            { b = System.Security.Cryptography.MD5.Create().ComputeHash(System.Text.Encoding.ASCII.GetBytes(w["Model"].ToString())); }
bool s = true;
            for (int i = 0; i<a.Length; i++) { if (a[i] != b[i]) { s = false; } }
            if (!s)
            {
                if (System.Windows.Forms.MessageBox.Show(new string (System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Reverse("?won ereht tisiv ot ekil uoy dluoW\n\n.noisrev tsetal eht evah uoy erusne ot ku.oc.elored morf daolnwod esaelP" +
          "\n.sesuriv htiw detcefni ro detadtuo eb yam dna retupmoc tnereffid a no dellatsni neeb evah ot smees ypoc sihT !GNINRAW"))), ""
      , System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                { System.Diagnostics.Process.Start("derole.co.uk/WanganGarageManager"); }
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
        private System.Windows.Forms.ContextMenuStrip lstContextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteCar;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ComboBox cmbGarageView;
        public System.Windows.Forms.Label lblSettingsBG;
        public System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lstSettingsBorder;
        public System.Windows.Forms.Label lblSettings;
        public System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.Label lblGarageView;
        public System.Windows.Forms.CheckBox chkPowerHandling;
        private System.Windows.Forms.ToolStripMenuItem menuforceCarSelect;
        private System.Windows.Forms.ToolStripMenuItem menuFCSOFF;
    }
}

