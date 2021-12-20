using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace WanganGarageManager
{
    public class GarageCar
    {
        string filename;
        byte[] data;

        public bool inEditor = false;
        public bool hasSaved = true;
        public bool isLoaded = false;
        public bool confirmedDiscard = false;

        public byte rearWing;
        public byte sideMirrors;
        public byte bodySticker;
        public byte japanSticker;
        public byte stickerColour;
        public byte carbonTrunk;
        public byte numberPlateFrame;
        public byte specialPlateFrame;
        public byte unk1;
        public byte unk2;
        public byte plateFrameColour;
        public ushort numberPlateNumber;
        public byte bodyKit;
        public byte hood;
        public byte carColour;
        public byte customColour;
        public byte wheels;
        public byte wheelColour;
        public byte neons;
        public byte numberPlatePrefecture;
        public byte car;

        public byte power;
        public byte handling;
        public byte level;

        public GarageCar(string filename)
        {
            this.filename = filename;
        }

        public void LoadCar()
        {
            data = File.ReadAllBytes(filename);

            numberPlatePrefecture = data[0x28];
            car = data[0x34];

            carColour = data[0x38];
            customColour = data[0x3C];
            wheels = data[0x40];
            wheelColour = data[0x44];
            neons = data[0x90];

            bodyKit = data[0x48];
            hood = data[0x4C];

            rearWing = data[0x58];
            sideMirrors = data[0x5C];
            bodySticker = data[0x60];
            japanSticker = data[0x60];
            stickerColour = data[0x64];

            carbonTrunk = data[0x94];
            numberPlateFrame = data[0x98];
            specialPlateFrame = data[0x85];
            unk1 = data[0x86];
            unk2 = data[0x87];
            plateFrameColour = 0x00;
            numberPlateNumber = BitConverter.ToUInt16(data, 0x8C);

            power = data[0xAC];
            handling = data[0xB8];

            level = data[0xBC];

            Console.WriteLine("State of save: rearWing={0}, sideMirrors={1}, bodySticker={2}, japanSticker={3}, stickerColour={4}, carbonTrunk={5}, numberPlateFrame={6}" +
                ", specialPlateFrame={7}, unk1={8}, unk2={9}, plateFrameColour={10}, numberPlateNumber={11}, bodyKit={12}, hood={13}" +
                ", carColour={14}, wheels={15}, wheelColour={16}, numberPlatePrefecture={17}, car={18}"
                , rearWing, sideMirrors, bodySticker, japanSticker, stickerColour, carbonTrunk, numberPlateFrame, specialPlateFrame, unk1, unk2, plateFrameColour
                , numberPlateNumber, bodyKit, hood, carColour, wheels, wheelColour, numberPlatePrefecture, car);
            isLoaded = true;
        }

        public void SaveCar()
        {
            data[0x28] = numberPlatePrefecture;
            data[0x34] = car;

            data[0x38] = carColour;
            data[0x3C] = customColour;
            data[0x40] = wheels;
            data[0x44] = wheelColour;
            data[0x90] = neons;

            data[0x48] = bodyKit;
            data[0x4C] = hood;

            data[0x58] = rearWing;
            data[0x5C] = sideMirrors;
            data[0x60] = bodySticker;
            data[0x60] = japanSticker;
            data[0x64] = stickerColour;

            data[0x94] = carbonTrunk;
            data[0x98] = numberPlateFrame;
            data[0x85] = specialPlateFrame;
            data[0x86] = unk1;
            data[0x87] = unk2;
            data[0x00] = plateFrameColour;
            InsertBytesIntoBuffer(data, BitConverter.GetBytes(numberPlateNumber), 0x8C);

            data[0xAC] = power;
            data[0xB8] = handling;

            data[0xBC] = level;

            File.WriteAllBytes(filename, data);
            hasSaved = true;
        }

        public void DeleteCar()
        {
            File.Delete(filename);
            Console.WriteLine("Deleted {0}", filename);
        }

        public void UpdateAeroKit(int value)
        {
            if (bodyKit != value)
            {
                bodyKit = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdateWing(int value)
        {
            if (rearWing != CarDB.wing[value])
            {
                rearWing = CarDB.wing[(byte)value];
                hasSaved = false;
            }
        }

        public void UpdateRims(int value)
        {
            if (wheels != CarDB.rims[value])
            {
                wheels = CarDB.rims[(byte)value];
                hasSaved = false;
            }
        }

        public void UpdateRimsColour(int value)
        {
            if (wheelColour != value)
            {
                wheelColour = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdateStickers(int value)
        {
            if (bodySticker != CarDB.stickers[value])
            {
                bodySticker = CarDB.stickers[(byte)value];
                hasSaved = false;
            }
        }

        public void UpdateStickerColour(int value)
        {
            if (stickerColour != value)
            {
                stickerColour = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdateTrunk(int value)
        {
            if (carbonTrunk != value)
            {
                carbonTrunk = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdateMirrors(int value)
        {
            if (sideMirrors != value)
            {
                sideMirrors = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdateHood(int value)
        {
            if (hood != value)
            {
                hood = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdatePlateFrame(int value)
        {
            if (numberPlateFrame != value)
            {
                numberPlateFrame = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdatePlateFrameColour(int value)
        {
            if (plateFrameColour != value)
            {
                plateFrameColour = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdateNeons(int value)
        {
            if (neons != value)
            {
                neons = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdateCarColour(int value)
        {
            if (carColour != value)
            {
                carColour = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdateCustomColour(int value)
        {
            if (customColour != value)
            {
                customColour = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdatePlate(ushort value)
        {
            if (numberPlateNumber != value)
            {
                numberPlateNumber = value;
                hasSaved = false;
            }
        }

        public void UpdatePlatePrefecture(int value)
        {
            if (numberPlatePrefecture != value)
            {
                numberPlatePrefecture = (byte)value;
                hasSaved = false;
            }
        }

        public void UpdatePowerHandling(int value1, int value2)
        {
            if (power != value1 || handling != value2)
            {
                power = (byte)value1;
                handling = (byte)value2;
                hasSaved = false;
            }
        }

        public ListViewItem GetListViewItem(ImageList imgLst)
        {
            ListViewItem item = new ListViewItem();
            item.Name = Path.GetFileNameWithoutExtension(filename);
            item.Text = CarDB.GetCarName(car);
            if (Properties.Settings.Default.usePowerHandling)
            {
                item.SubItems.Add("P:" + power.ToString() + "/H:" + handling.ToString());
            }
            else
            {
                item.SubItems.Add(CarDB.power[power]);
            }
            item.SubItems.Add(Path.GetFileName(filename));
            item.ImageIndex = imgLst.Images.IndexOfKey(GetPreviewImageName(car));
            return item;
        }

        public void UpdateListViews(frmEditor editor)
        {
            editor.lstAero.SelectedIndices.Add(bodyKit);
            editor.lstWing.SelectedIndices.Add(Array.IndexOf(CarDB.wing, rearWing));
            editor.lstRims.SelectedIndices.Add(Array.IndexOf(CarDB.rims, wheels));
            editor.lstStickers.SelectedIndices.Add(Array.IndexOf(CarDB.stickers, bodySticker));
            editor.lstCustomColour.SelectedIndices.Add(customColour);
            editor.lstTrunk.SelectedIndices.Add(carbonTrunk);
            editor.lstMirror.SelectedIndices.Add(sideMirrors);
            editor.lstHood.SelectedIndices.Add(hood);
            editor.lstPlateFrame.SelectedIndices.Add(numberPlateFrame);
            editor.lstNeons.SelectedIndices.Add(neons);

            editor.trkPower.Value = power;
            editor.trkHandling.Value = handling;

            string number = numberPlateNumber.ToString().PadLeft(4, '0');


            Application.DoEvents();
            hasSaved = true;
        }

        public void UpdateColourPanelRims(Button[] btns)
        {
            int count = 0;
            for (int i = 0; i < CarDB.rimColours[wheels].Length; i++)
            {
                btns[i].Visible = true;
                btns[i].BackColor = CarDB.rimColours[wheels][i];
                btns[i].Text = "";
                count++;
            }
            for (int i = count; i < btns.Length; i++)
            {
                btns[i].Visible = false;
            }
            btns[wheelColour].Focus();
        }

        public void UpdateColourPanelPlateFrame(Button[] btns)
        {
            int count = 0;
            for (int i = 0; i < CarDB.plateFrameColours[numberPlateFrame].Length; i++)
            {
                btns[i].Visible = true;
                btns[i].BackColor = CarDB.plateFrameColours[numberPlateFrame][i];
                if (numberPlateFrame == 3)
                {
                    btns[i].Text = CarDB.ymSpecialNames[i];
                    if (btns[i].BackColor == Color.Black) { btns[i].ForeColor = Color.White; }
                    else { btns[i].ForeColor = Color.Black; }
                } else { btns[i].Text = ""; }
                count++;
            }
            for (int i = count; i < btns.Length; i++)
            {
                btns[i].Visible = false;
            }
            btns[plateFrameColour].Focus();
        }

        public void UpdateColourPanelStickers(Button[] btns)
        {
            int count = 0;
            for (int i = 0; i < CarDB.stickerColours[bodySticker].Length; i++)
            {
                btns[i].Visible = true;
                btns[i].BackColor = CarDB.stickerColours[bodySticker][i];
                btns[i].Text = "";
                count++;
            }
            for (int i = count; i < btns.Length; i++)
            {
                btns[i].Visible = false;
            }
            btns[stickerColour].Focus();
        }

        public void UpdateColourPanelColour(Button[] btns)
        {
            int count = 0;
            for (int i = 0; i < CarDB.carColours[car].Length; i++)
            {
                btns[i].Visible = true;
                btns[i].BackColor = CarDB.carColours[car][i];
                btns[i].Text = "";
                count++;
            }
            for (int i = count; i < btns.Length; i++)
            {
                btns[i].Visible = false;
            }
            btns[plateFrameColour].Focus();
        }

        public string GetPreviewImageName(byte id)
        {
            if (CarDB.ContainsCar(id))
            {
                return id.ToString("X2") + ".png";
            }
            else
            {
                return "FF.png";
            }
        }

        public void InsertBytesIntoBuffer(byte[] buf, byte[] bufToInsert, int startIndex)
        {
            for (int i = startIndex; i < startIndex + bufToInsert.Length; i++)
            {
                buf[i] = bufToInsert[i - startIndex];
            }
        }
    }
}
