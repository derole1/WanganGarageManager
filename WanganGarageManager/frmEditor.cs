using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WanganGarageManager
{
    public partial class frmEditor : Form
    {
        enum Parts
        {
            Aero = 0,
            Wing = 1,
            Rims = 2,
            Stickers = 3,
            Colour = 4,
            Trunk = 5,
            Mirrors = 6,
            Hood = 7,
            PlateFrame = 8,
            Neons = 9,
            Tuning = 10,
        }

        GarageCar car;
        Button[] colourButtons;

        public frmEditor(GarageCar car)
        {
            InitializeComponent();
            if (!car.isLoaded) { car.LoadCar(); }
            this.car = car;
            car.inEditor = true;
            this.Text += CarDB.GetCarName(car.car);
            car.UpdateListViews(this);
            UpdateHPLbl();
            colourButtons = new Button[] { btnColour1, btnColour2, btnColour3, btnColour4, btnColour5, btnColour6, btnColour7, btnColour8, btnColour9, btnColour10 };
            Localisation.UpdateEditor(this, CultureInfo.InstalledUICulture.Name);
            partsSwitcher_SelectedIndexChanged(null, null);
        }

        private void frmEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!car.hasSaved && !car.confirmedDiscard)
            {
                if (MessageBox.Show("変更内容は保存されていません。本当に終了しますか？", "終了しますか？", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    car.inEditor = false;
                    car.LoadCar();
                } else { e.Cancel = true; }
            } else { car.LoadCar(); car.inEditor = false; }
        }

        private void btnEditorBack_Click(object sender, EventArgs e)
        {
            if (!car.hasSaved)
            {
                if (MessageBox.Show("変更内容は保存されていません。本当に終了しますか？", "終了しますか？", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    car.confirmedDiscard = true;
                    this.Close();
                }
            } else { this.Close(); }
        }

        private void lstAero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAero.SelectedIndices.Count > 0)
            {
                car.UpdateAeroKit(lstAero.SelectedIndices[0]);
            }
        }

        private void lstWing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWing.SelectedIndices.Count > 0)
            {
                car.UpdateWing(lstWing.SelectedIndices[0]);
            }
        }

        private void lstRims_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRims.SelectedIndices.Count > 0)
            {
                car.UpdateRims(lstRims.SelectedIndices[0]);
                car.UpdateColourPanelRims(colourButtons);
            }
        }

        private void lstStickers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStickers.SelectedIndices.Count > 0)
            {
                car.UpdateStickers(lstStickers.SelectedIndices[0]);
                car.UpdateColourPanelStickers(colourButtons);
            }
        }

        private void lstTrunk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTrunk.SelectedIndices.Count > 0)
            {
                car.UpdateTrunk(lstTrunk.SelectedIndices[0]);
            }
        }

        private void lstMirror_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMirror.SelectedIndices.Count > 0)
            {
                car.UpdateMirrors(lstMirror.SelectedIndices[0]);
            }
        }

        private void lstHood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHood.SelectedIndices.Count > 0)
            {
                car.UpdateHood(lstHood.SelectedIndices[0]);
            }
        }

        private void lstPlateFrame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlateFrame.SelectedIndices.Count > 0)
            {
                car.UpdatePlateFrame(lstPlateFrame.SelectedIndices[0]);
                car.UpdateColourPanelPlateFrame(colourButtons);
            }
        }

        private void lstNeons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNeons.SelectedIndices.Count > 0)
            {
                car.UpdateNeons(lstNeons.SelectedIndices[0]);
            }
        }

        private void btnEditorSave_Click(object sender, EventArgs e)
        {
            car.SaveCar();
        }

        private void cmbPrefecture_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
        }

        ushort ParseLicensePlate(string num1, string num2)
        {
            return ushort.Parse(num1.PadLeft(2, '0') + num2.PadLeft(2, '0'));
        }

        private void txtNum1_Leave(object sender, EventArgs e)
        {
        }

        private void txtNum2_Leave(object sender, EventArgs e)
        {
        }

        private void trkPower_Scroll(object sender, EventArgs e)
        {
            if (trkPower.Value > 9)
            {
                trkHandling.Value = trkHandling.Maximum - (trkPower.Value - 9) + 1;
            }
            else if (trkPower.Value < 10 && trkHandling.Value > 9)
            {
                trkHandling.Value = 9;
            }

            Console.WriteLine("New P:{0}/H:{1}", trkPower.Value, trkHandling.Value);
            car.UpdatePowerHandling(trkPower.Value, trkHandling.Value);
            UpdateHPLbl();
        }

        private void trkHandling_Scroll(object sender, EventArgs e)
        {
            if (trkHandling.Value > 9)
            {
                trkPower.Value = trkPower.Maximum - (trkHandling.Value - 9) + 1;
            }
            else if (trkHandling.Value < 10 && trkPower.Value > 9)
            {
                trkPower.Value = 9;
            }

            Console.WriteLine("New P:{0}/H:{1}", trkPower.Value, trkHandling.Value);
            car.UpdatePowerHandling(trkPower.Value, trkHandling.Value);
            UpdateHPLbl();
        }

        private void numTuningStage_ValueChanged(object sender, EventArgs e)
        {
            trkPower.Maximum = (int)numTuningStage.Value;
            trkHandling.Maximum = (int)numTuningStage.Value;
        }

        void UpdateHPLbl()
        {
            if (Properties.Settings.Default.usePowerHandling)
            {
                lblHP.Text = "P: " + trkPower.Value.ToString() + "/H:" + trkHandling.Value.ToString();
            }
            else
            {
                lblHP.Text = CarDB.power[trkPower.Value];
            }
        }

        private void partsSwitcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (partsSwitcher.SelectedIndex)
            {
                case (int)Parts.Rims:
                    car.UpdateColourPanelRims(colourButtons);
                    pnlColour.Visible = true;
                    colourButtons[car.wheelColour].Focus();
                    break;
                case (int)Parts.Stickers:
                    car.UpdateColourPanelStickers(colourButtons);
                    pnlColour.Visible = true;
                    colourButtons[car.stickerColour].Focus();
                    break;
                case (int)Parts.PlateFrame:
                    car.UpdateColourPanelPlateFrame(colourButtons);
                    pnlColour.Visible = true;
                    colourButtons[car.plateFrameColour].Focus();
                    break;
                case (int)Parts.Colour:
                    car.UpdateColourPanelColour(colourButtons);
                    pnlColour.Visible = true;
                    colourButtons[car.carColour].Focus();
                    break;
                default:
                    pnlColour.Visible = false;
                    break;
            }
        }

        private void lstRims_Enter(object sender, EventArgs e)
        {
            colourButtons[car.wheelColour].Focus();
        }

        private void btnColours_Click(object sender, EventArgs e)
        {
            switch (partsSwitcher.SelectedIndex)
            {
                case (int)Parts.Rims:
                    car.UpdateRimsColour(Array.IndexOf(colourButtons, sender));
                    break;
                case (int)Parts.Stickers:
                    car.UpdateStickerColour(Array.IndexOf(colourButtons, sender));
                    break;
                case (int)Parts.PlateFrame:
                    car.UpdatePlateFrameColour(Array.IndexOf(colourButtons, sender));
                    break;
                case (int)Parts.Colour:
                    car.UpdateCarColour(Array.IndexOf(colourButtons, sender));
                    break;
            }
        }

        private void lstCustomColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNeons.SelectedIndices.Count > 0)
            {
                car.UpdateCustomColour(lstCustomColour.SelectedIndices[0]);
            }
        }

        private void lstStickers_Enter(object sender, EventArgs e)
        {
            colourButtons[car.stickerColour].Focus();
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://forms.gle/gfvfYvTHxcEUyruj8");
        }

        private void lblHP_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
