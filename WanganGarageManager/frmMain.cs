using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using System.IO;

namespace WanganGarageManager
{
    public partial class frmMain : Form
    {
        enum tabs
        {
            garage = 0,
            settings = 1
        }

        int[] listViewTypes = new int[] { 4, 0, 1, 3 };

        public frmMain()
        {
            if (!File.Exists("wmn5r.exe"))
            {
                MessageBox.Show("The garage manager has not been placed in the correct directory, please place it with your game files, where wmn5r.exe is.", "Wangan garage manager is in the wrong folder!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            InitializeComponent();
            Localisation.InitMain();
            Localisation.InitEditor();
            CarDB.InitDB();
            lblCredit.Text = "Wangan Garage Manager\nVersion " + Application.ProductVersion.Split('.')[0];
            Localisation.UpdateMain(this, CultureInfo.InstalledUICulture.Name);
            menuSwitcher_SelectedIndexChanged(null, null);
        }

        List<GarageCar> cars = new List<GarageCar>();

        private void menuSwitcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (menuSwitcher.SelectedIndex)
            {
                case (int)tabs.garage:
                    lstGarage.Items.Clear();
                    cars.Clear();
                    lblNoCars.Visible = true;
                    lstGarage.View = (View)Properties.Settings.Default.garageViewType;
                    if (Properties.Settings.Default.usePowerHandling) {
                        lstGarage.Columns[1].Text = "Power/Handling";
                    } else {
                        lstGarage.Columns[1].Text = "HP";
                    }
                    if (Directory.Exists("OpenParrot_Cars"))
                    {
                        foreach (string file in Directory.GetFiles("OpenParrot_Cars", "*.car"))
                        {
                            GarageCar car = new GarageCar(file);
                            car.LoadCar();
                            lstGarage.Items.Add(car.GetListViewItem(carPreviews));
                            cars.Add(car);
                            lblNoCars.Visible = false;
                        }
                    }
                    if (Directory.Exists("Teknoparrot_Cars"))
                    {
                        foreach (string file in Directory.GetFiles("Teknoparrot_Cars", "*.car"))
                        {
                            GarageCar car = new GarageCar(file);
                            car.LoadCar();
                            lstGarage.Items.Add(car.GetListViewItem(carPreviews));
                            cars.Add(car);
                            lblNoCars.Visible = false;
                        }
                    }
                    if (Directory.Exists("sv"))
                    {
                        foreach (string file in Directory.GetFiles("sv", "*.car", SearchOption.AllDirectories))
                        {
                            GarageCar car = new GarageCar(file);
                            car.LoadCar();
                            lstGarage.Items.Add(car.GetListViewItem(carPreviews));
                            cars.Add(car);
                            lblNoCars.Visible = false;
                        }
                    }
                    break;
                case (int)tabs.settings:
                    cmbGarageView.SelectedIndex = Array.IndexOf(listViewTypes, Properties.Settings.Default.garageViewType);
                    chkPowerHandling.Checked = Properties.Settings.Default.usePowerHandling;
                    break;
            }
        }

        private void btnGarageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstGarage_ItemActivate(object sender, EventArgs e)
        {
            for (int i=0; i<lstGarage.SelectedItems.Count; i++)
            {
                int index = lstGarage.SelectedIndices[i];
                if (!cars[index].inEditor)
                {
                    frmEditor frm = new frmEditor(cars[index]);
                    frm.Show();
                }
            }
        }

        string[] dragDropFiles = new string[0];

        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                dragDropFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in dragDropFiles)
                {
                    if (Path.GetExtension(file) != ".car")
                    {
                        e.Effect = DragDropEffects.None;
                        return;
                    }
                }
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string file in dragDropFiles)
            {
                GarageCar car = new GarageCar(file);
                car.inEditor = true;
                frmEditor frm = new frmEditor(car);
                frm.Show();
            }
        }

        private void menuDeleteCar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to permanently delete these car(s)? You will not be able to recover them.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                for (int i=0; i < lstGarage.SelectedIndices.Count; i++)
                {
                    cars[lstGarage.SelectedIndices[i]].DeleteCar();
                }
                menuSwitcher_SelectedIndexChanged(null, null);
            }
        }

        private void lstContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (lstGarage.SelectedIndices.Count < 1)
            {
                menuDeleteCar.Visible = false;
            }
            else
            {
                menuDeleteCar.Visible = true;
            }
        }

        private void lstGarage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGarage.SelectedIndices.Count > 0)
            {
                Console.WriteLine("Selected {0}", CarDB.GetCarName(cars[lstGarage.SelectedIndices[0]].car));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            menuSwitcher.SelectedTab = tabGarage;
        }

        private void cmbGarageView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.garageViewType = listViewTypes[cmbGarageView.SelectedIndex];
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            menuSwitcher.SelectedTab = tabSettings;
        }

        private void chkPowerHandling_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.usePowerHandling = chkPowerHandling.Checked;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tabGarage_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://forms.gle/gfvfYvTHxcEUyruj8");
        }
    }
}
