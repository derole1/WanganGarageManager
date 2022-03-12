using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace WanganGarageManager
{
    static class CarDB
    {
        static Dictionary<byte, string> db = new Dictionary<byte, string>();

        public static byte[] rims = new byte[] {0, 34, 39, 36, 35, 37, 38, 42, 41, 43, 40, 44, 45, 48, 47, 46, 49, 17, 18, 19, 22, 25, 21, 20, 23, 24, 30, 29, 28, 31, 27, 32, 33, 50, 55, 52, 56, 51, 53, 54, 26, 1, 4, 5, 6, 3, 8, 7, 2, 10
            , 12, 9, 11, 57, 58, 60, 59, 13, 14, 15, 16, 61, 62, 63, 64, 67, 68, 65, 66, 69};
        public static byte[] stickers = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 35, 37, 38, 41, 33, 36, 39, 44, 40, 42, 50, 49, 45, 46, 47, 51 };
        public static byte[] wing = new byte[] { 0, 9, 1, 2, 3, 4, 5, 6 };

        public static string[] power = new string[] { "---馬力/B", "360馬力/B", "400馬力/B", "420馬力/B", "450馬力/B", "470馬力/B", "500馬力/B", "530馬力/B", "550馬力/B", "580馬力/B", "600馬力/HG", "620馬力/HG", "640馬力/HG", "660馬力/G", "680馬力/G", "700馬力/G", "720馬力/B", "740馬力/B", "760馬力/D", "780馬力/D", "800馬力/D", "815馬力/DG", "830馬力/DG" };

        public static string[] defaultPower = new string[] {
            "300",
            "300",
            "300",
            "300",
            "300",
            "170",
            "280",
            "205",
            "250",
            "280",
            "272",
            "272",
            "165",
            "128",
            "280",
            "280",
            "280",
            "280",
            "280",
            "280",
            "280",
            "280",
            "270",
            "270",
            "280",
            "175",
            "280"
            //Nissan next
        };

        public static Color[][] rimColours = new Color[][] { new Color[] {Color.Transparent},
new Color[] {Color.Silver, Color.Red},
new Color[] {Color.Transparent},
new Color[] {Color.Black, Color.Silver},
new Color[] {Color.Silver, Color.White, Color.Gold},
new Color[] {Color.Transparent},
new Color[] {Color.Silver, Color.Brown, Color.Gold, Color.Black, Color.White},
new Color[] {Color.Silver, Color.LightGray},
new Color[] {Color.Transparent},
new Color[] {Color.Silver, Color.Gray},
new Color[] {Color.Silver, Color.Blue},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Black, Color.Gold, Color.Silver, Color.Gray},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Brown, Color.White},
new Color[] {Color.Brown, Color.Gold, Color.Silver},
new Color[] {Color.White, Color.Silver, Color.Black},
new Color[] {Color.Red, Color.Silver, Color.Brown, Color.White},
new Color[] {Color.Silver, Color.Black},
new Color[] {Color.Silver, Color.Gold, Color.White},
new Color[] {Color.Silver, Color.Black, Color.White},
new Color[] {Color.Silver, Color.Silver},
new Color[] {Color.Silver, Color.Red, Color.Blue},
new Color[] {Color.Black, Color.Silver, Color.Silver, Color.Brown, Color.White},
new Color[] {Color.Silver, Color.White},
new Color[] {Color.Transparent},
new Color[] {Color.Silver, Color.White},
new Color[] {Color.Silver, Color.Black},
new Color[] {Color.Yellow, Color.Orange, Color.Silver, Color.White},
new Color[] {Color.Black, Color.Silver, Color.Red, Color.Gold, Color.Blue, Color.White},
new Color[] {Color.Silver, Color.Silver},
new Color[] {Color.Gray, Color.Silver},
new Color[] {Color.Gray, Color.Silver, Color.SaddleBrown},
new Color[] {Color.Transparent},
new Color[] {Color.Silver, Color.Black},
new Color[] {Color.Silver, Color.Black},
new Color[] {Color.Silver, Color.Silver},
new Color[] {Color.Gold, Color.Silver},
new Color[] {Color.WhiteSmoke, Color.Gold, Color.Silver, Color.Blue, Color.Red, Color.Silver},
new Color[] {Color.Silver, Color.Orange, Color.Silver, Color.Black},
new Color[] {Color.White, Color.Gold, Color.Silver, Color.Black},
new Color[] {Color.White, Color.Gold, Color.Silver, Color.Black},
new Color[] {Color.Gold, Color.Silver, Color.White},
new Color[] {Color.Silver, Color.Gold, Color.White, Color.Black},
new Color[] {Color.Silver, Color.Orange, Color.White, Color.Gold},
new Color[] {Color.Silver, Color.Gold, Color.Black, Color.White, Color.Brown},
new Color[] {Color.Black, Color.White, Color.Silver, Color.Black},
new Color[] {Color.White, Color.Brown},
new Color[] {Color.Brown, Color.Silver, Color.Black},
new Color[] {Color.Silver, Color.Brown, Color.Black},
new Color[] {Color.Silver, Color.Gray, Color.Gray},
new Color[] {Color.Silver, Color.Black, Color.White},
new Color[] {Color.Silver, Color.Black, Color.Silver, Color.Red, Color.White},
new Color[] {Color.White, Color.Brown, Color.Gold, Color.Red, Color.Black, Color.Black},
new Color[] {Color.White, Color.Brown, Color.Gold, Color.Red, Color.Black, Color.Black},
new Color[] {Color.Black, Color.Silver, Color.Brown, Color.White, Color.Black},
new Color[] {Color.Silver, Color.Brown, Color.Red, Color.Black},
new Color[] {Color.Black, Color.Silver, Color.Brown, Color.White, Color.Red},
new Color[] {Color.White, Color.White, Color.Black, Color.Black, Color.Gold, Color.Gold},
new Color[] {Color.Silver, Color.Gold},
new Color[] {Color.Silver, Color.Black},
new Color[] {Color.Black, Color.Silver},
new Color[] {Color.White, Color.Black},
new Color[] {Color.Silver, Color.Gold, Color.Gray, Color.Black},
new Color[] {Color.Silver, Color.Silver},
new Color[] {Color.Silver, Color.Gray, Color.Black},
new Color[] {Color.Silver, Color.Gray} };

        public static Color[][] plateFrameColours = new Color[][] { new Color[] {Color.Transparent},
new Color[] {Color.Green, Color.Blue, Color.MediumPurple, Color.Red, Color.Yellow, Color.Purple},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.White},
new Color[] {Color.Blue, Color.MediumPurple, Color.Purple, Color.White, Color.Red, Color.Silver, Color.Black, Color.Yellow, Color.Green, Color.LightBlue},
new Color[] {Color.Pink, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.White},
new Color[] {Color.Transparent},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.Black},
new Color[] {Color.Pink, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.White},
new Color[] {Color.Transparent},
new Color[] {Color.Green, Color.Blue, Color.MediumPurple, Color.Red, Color.Yellow, Color.Purple},
new Color[] {Color.Gold, Color.Gray},
new Color[] {Color.Pink, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.White},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.White},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.White},
new Color[] {Color.Pink, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.White},
new Color[] {Color.Green, Color.Blue, Color.MediumPurple, Color.Red, Color.Yellow, Color.White},
new Color[] {Color.Silver, Color.Gray, Color.Gold},
new Color[] {Color.Brown, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.LightBlue, Color.Blue, Color.Black},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.Silver},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.Black},
new Color[] {Color.Silver, Color.Silver, Color.Gold, Color.Gold},
new Color[] {Color.Silver, Color.Gold},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.Black},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.LightBlue, Color.Blue, Color.Black},
new Color[] {Color.Silver, Color.White, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.MediumPurple, Color.Blue, Color.LightBlue},
new Color[] {Color.Green, Color.Blue, Color.MediumPurple, Color.Red, Color.Yellow, Color.White} };

        public static string[] ymSpecialNames = new string[] {"YM SPEED", "MACH", "RGO", "ACE", "R200 CLUB", "FLAT", "BLACKBIRD", "ZERO", "GREEN AUTO", "GT CARS"};

        public static Color[][] carColours = new Color[][] { new Color[] {Color.Blue, Color.Red, Color.Yellow, Color.White, Color.Silver, Color.Black},
            new Color[] {Color.Transparent},
            new Color[] {Color.Yellow, Color.Silver, Color.Red, Color.White, Color.DarkBlue, Color.Black},
            new Color[] {Color.Yellow, Color.Silver, Color.Red, Color.White, Color.DarkBlue, Color.Black},
            new Color[] {Color.Silver, Color.Blue, Color.Red, Color.Black, Color.Yellow, Color.White},
            new Color[] {Color.DarkRed, Color.Gray, Color.Silver, Color.Black, Color.DarkBlue, Color.DarkGreen},
            new Color[] {Color.Yellow, Color.Blue, Color.Red, Color.White, Color.Silver, Color.Black},
            new Color[] {Color.Red, Color.White, Color.Black, Color.Silver, Color.DarkBlue},
            new Color[] {Color.Blue, Color.Gray, Color.White, Color.Yellow, Color.Red, Color.Black},
            new Color[] {Color.Gray, Color.Red, Color.Black, Color.DarkBlue, Color.LightBlue, Color.Yellow},
            new Color[] {Color.Silver, Color.Black, Color.DarkMagenta, Color.Red, Color.White, Color.Gray},
            new Color[] {Color.Transparent},    //MPS school
            new Color[] {Color.RosyBrown, Color.White, Color.Silver, Color.Red, Color.Black, Color.Gray},
            new Color[] {Color.White},
            new Color[] {Color.Red, Color.Silver, Color.Blue, Color.Black, Color.White},
            new Color[] {Color.White, Color.DarkMagenta, Color.Silver, Color.Red},
            new Color[] {Color.DarkMagenta, Color.White, Color.Red, Color.Silver},
            new Color[] {Color.DarkMagenta, Color.White, Color.Red, Color.Silver},
            new Color[] {Color.Blue, Color.White, Color.Silver, Color.DarkBlue, Color.Black},
            new Color[] {Color.Blue, Color.White, Color.Silver, Color.DarkBlue, Color.Black},
            new Color[] {Color.Silver, Color.Yellow, Color.White, Color.Red, Color.Black},
            new Color[] {Color.Silver, Color.Yellow, Color.White, Color.Red, Color.Black},
            new Color[] {Color.Yellow, Color.White, Color.Silver, Color.Red, Color.Black},
            new Color[] {Color.Yellow, Color.White, Color.Silver, Color.Red, Color.Black},
            new Color[] {Color.Red, Color.Black, Color.White, Color.Silver, Color.Blue},
            new Color[] {Color.Black, Color.White, Color.Gray, Color.Silver, Color.Red},
            new Color[] {Color.White, Color.Red, Color.Silver},
            new Color[] {Color.Silver, Color.Gray, Color.White, Color.Red, Color.DarkGray, Color.Black},
            new Color[] {Color.DarkMagenta, Color.White, Color.Red, Color.DarkGray, Color.Black},
            new Color[] {Color.Blue, Color.DarkSeaGreen, Color.White, Color.Silver, Color.Black},
            new Color[] {Color.Blue, Color.DarkSeaGreen, Color.White, Color.Silver, Color.Black},
            new Color[] {Color.DarkMagenta, Color.DarkBlue, Color.Silver, Color.White, Color.Black, Color.Red},
            new Color[] {Color.DarkGray, Color.White, Color.Black, Color.Red, Color.Silver, Color.DarkBlue},
            new Color[] {Color.Red, Color.Silver, Color.White, Color.Yellow},
            new Color[] {Color.Gray, Color.White, Color.Yellow, Color.Blue, Color.Red, Color.Black},
            new Color[] {Color.Gray, Color.Red, Color.Orange, Color.Blue, Color.Black, Color.White},
            new Color[] {Color.Red, Color.White, Color.Yellow, Color.Silver, Color.Black, Color.DarkBlue},
            new Color[] {Color.Gray, Color.Tomato, Color.Red, Color.Silver},    //Z31
            new Color[] {Color.Transparent},
            new Color[] {Color.Orange, Color.Silver, Color.Red, Color.Yellow, Color.White, Color.Blue},
            new Color[] {Color.Yellow, Color.Gray, Color.Blue, Color.Red, Color.White, Color.Black},
            new Color[] {Color.LightYellow, Color.DarkGreen, Color.Black, Color.DarkGray, Color.Red, Color.White},
            new Color[] {Color.Red, Color.DarkBlue, Color.White, Color.Silver, Color.Black, Color.Blue},
            new Color[] {Color.Maroon, Color.White, Color.DarkGray, Color.Black, Color.Silver, Color.Black},
            new Color[] {Color.Yellow, Color.Black, Color.Red, Color.Silver, Color.LimeGreen, Color.White},
            new Color[] {Color.Silver, Color.LimeGreen, Color.White, Color.Yellow, Color.Black, Color.Red},
            new Color[] {Color.Red, Color.Silver, Color.LimeGreen, Color.White, Color.Yellow, Color.Black},
            new Color[] {Color.DarkGray, Color.Blue, Color.Red, Color.DarkBlue, Color.White, Color.Silver},
            new Color[] {Color.White, Color.Blue, Color.Red, Color.Gray, Color.Black, Color.Silver},
            new Color[] {Color.Blue, Color.Red, Color.White, Color.Silver, Color.Black},
            new Color[] {Color.Blue, Color.Red, Color.White, Color.Silver, Color.Black},
            new Color[] {Color.Yellow, Color.White, Color.DarkBlue, Color.Silver, Color.Gray},
            new Color[] {Color.Yellow, Color.White, Color.DarkBlue, Color.Silver, Color.Gray},
            new Color[] {Color.White, Color.Silver, Color.Black, Color.DarkBlue, Color.DarkMagenta, Color.Red},  //TODO: Which legacy? (Assumed BM9)
            new Color[] {Color.Silver, Color.Red, Color.DarkGray, Color.Maroon, Color.Black, Color.White},
            new Color[] {Color.White, Color.PaleGreen, Color.Blue, Color.Red, Color.Silver, Color.Black},
            new Color[] {Color.Black, Color.White, Color.Silver, Color.Red, Color.DarkBlue},  //TODO: Which legacy? (Assumed BL5)
            new Color[] {Color.Silver, Color.White, Color.Black, Color.Red, Color.Yellow, Color.Blue},
            new Color[] {Color.Black, Color.White, Color.Red, Color.DarkGreen, Color.Blue},
            new Color[] {Color.Red, Color.Yellow, Color.Blue, Color.White, Color.Black},
            new Color[] {Color.White, Color.Silver, Color.DarkBlue, Color.Maroon, Color.DarkGreen},
            new Color[] {Color.DarkGreen, Color.Black, Color.White, Color.Silver, Color.DarkMagenta},
            new Color[] {Color.Transparent},
            new Color[] {Color.Transparent},
            new Color[] {Color.Transparent},
            new Color[] {Color.Transparent},
            new Color[] {Color.Transparent},
            new Color[] {Color.Transparent},
            new Color[] {Color.Transparent},
            new Color[] {Color.Transparent},
            new Color[] {Color.Transparent},
            new Color[] {Color.Silver, Color.White, Color.Black, Color.Maroon, Color.DarkGreen, Color.DarkBlue},
            new Color[] {Color.Transparent},
            new Color[] {Color.White, Color.Beige, Color.Silver, Color.Black, Color.Maroon, Color.DarkGreen},
            new Color[] {Color.White, Color.Beige, Color.Gray, Color.LightGreen, Color.DarkGreen, Color.DarkBlue},
            new Color[] {Color.White, Color.Beige, Color.Gray, Color.LightGreen, Color.DarkGreen, Color.DarkBlue},
            new Color[] {Color.DarkBlue, Color.Silver, Color.Maroon, Color.Black, Color.White, Color.Beige},
            new Color[] {Color.Red, Color.White, Color.Silver},
            new Color[] {Color.Red, Color.White, Color.DarkRed, Color.DarkBlue, Color.Beige},
            new Color[] {Color.White, Color.Red, Color.Silver},
            new Color[] {Color.White, Color.Red, Color.Silver},
            new Color[] {Color.Blue, Color.DarkSeaGreen, Color.White, Color.Silver, Color.Black},
            new Color[] {Color.Silver, Color.Black},
            new Color[] {Color.Transparent},
            new Color[] {Color.Silver, Color.Red, Color.Black, Color.DarkBlue, Color.Beige, Color.White},    //Sting Ray
            new Color[] {Color.Red, Color.Silver, Color.White, Color.Blue},
            new Color[] {Color.Red, Color.White, Color.Black, Color.Silver, Color.DarkBlue},
            new Color[] {Color.Black, Color.Gray, Color.Silver, Color.Maroon, Color.LightBlue, Color.DarkBlue},
            new Color[] {Color.Silver, Color.Red, Color.White, Color.DarkBlue, Color.Black, Color.DarkGray },
            new Color[] {Color.Silver, Color.White, Color.DarkBlue, Color.Maroon, Color.Black},
            new Color[] {Color.Black, Color.Silver, Color.White, Color.DarkBlue, Color.Beige, Color.DarkGreen},
            new Color[] {Color.Red, Color.Gray, Color.White, Color.Red},
            new Color[] {Color.White, Color.DarkBlue, Color.Silver},
            new Color[] {Color.Green, Color.Silver, Color.Yellow, Color.Black, Color.Red, Color.White},
            new Color[] {Color.Blue, Color.White, Color.Black, Color.Silver, Color.DarkBlue},
            new Color[] {Color.Blue, Color.Black, Color.White, Color.Red, Color.DarkBlue, Color.Silver},
            new Color[] {Color.DarkBlue, Color.White, Color.Red, Color.Silver, Color.DarkGreen, Color.Beige},
            new Color[] {Color.Red, Color.Black, Color.Silver, Color.White, Color.Orange, Color.Blue},
            new Color[] {Color.White, Color.Silver, Color.Black, Color.DarkBlue, Color.White, Color.Gray},
            new Color[] {Color.Transparent},    //Maxi G
            new Color[] {Color.Transparent},
            new Color[] {Color.Silver, Color.Black},
            new Color[] {Color.Transparent},
            new Color[] {Color.Transparent},
            new Color[] {Color.White, Color.Silver, Color.Black, Color.DarkBlue, Color.White, Color.Gray},
            new Color[] {Color.White, Color.DarkBlue, Color.Red, Color.Maroon, Color.Black, Color.Gray},
            new Color[] {Color.Silver, Color.Black},
            new Color[] {Color.Silver, Color.Black, Color.White, Color.Red, Color.Gray},
            new Color[] {Color.DarkBlue},
            new Color[] {Color.White, Color.Silver, Color.Black, Color.DarkBlue, Color.Red, Color.DarkOrange},
            new Color[] {Color.White, Color.Silver, Color.Black, Color.Red, Color.Silver, Color.Blue},
            new Color[] {Color.Red, Color.DarkBlue, Color.Black, Color.Lime, Color.Orange, Color.DarkMagenta},
            new Color[] {Color.Red, Color.Silver, Color.Black},
            new Color[] {Color.Transparent},
            new Color[] {Color.Red, Color.Silver, Color.White, Color.Blue},     //Big wheels miata
            new Color[] {Color.Transparent},
            new Color[] {Color.Transparent},

};

        public static Color[][] stickerColours = new Color[][] { new Color[] {Color.Transparent},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Yellow, Color.Red, Color.White, Color.LightBlue, Color.DarkMagenta, Color.Green, Color.Red, Color.Blue, Color.Silver, Color.Black},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Transparent},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},  //Tribal b4 galaga
new Color[] {Color.Transparent},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Transparent},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Transparent},
new Color[] {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Pink, Color.LightBlue, Color.Blue, Color.Black, Color.Silver, Color.White},
};

        public static void InitDB()
        {
            db.Add(0x00, "Corvette ZR1");
            db.Add(0x01, "Corvette ZR1 Taxi");
            db.Add(0x02, "Camero SS");
            db.Add(0x03, "Camero SS (Matte)");
            db.Add(0x04, "Corvette Stingray C3");
            db.Add(0x05, "Mazda MX5 NC");
            db.Add(0x06, "Mazda RX7 FD");
            db.Add(0x07, "Mazda RX7 FC");
            db.Add(0x08, "Mazda RX8");
            db.Add(0x09, "Mazda Eunos Cosmo");
            db.Add(0x0A, "Mazda 6MPS");
            db.Add(0x0B, "Mazda 6MPS Driving School");
            db.Add(0x0C, "Mazda RX7 Turbo SA");
            db.Add(0x0D, "Mazda 110S Cosmo");
            db.Add(0x0E, "Mitsubishi Lancer Evolution X");
            db.Add(0x0F, "Mitsubishi Lancer Evolution IX");
            db.Add(0x10, "Mitsubishi Lancer Evolution VIII");
            db.Add(0x11, "Mitsubishi Lancer Evolution VIII RS");
            db.Add(0x12, "Mitsubishi Lancer Evolution VI RS");
            db.Add(0x13, "Mitsubishi Lancer Evolution VI");
            db.Add(0x14, "Mitsubishi Lancer Evolution V");
            db.Add(0x15, "Mitsubishi Lancer Evolution V RS");
            db.Add(0x16, "Mitsubishi Lancer Evolution III");
            db.Add(0x17, "Mitsubishi Lancer Evolution III RS");
            db.Add(0x18, "Mitsubishi GTO");
            db.Add(0x19, "Mitsubishi Starion");
            db.Add(0x1A, "Mitsubishi Pajero Evolution");
            db.Add(0x1B, "Nissan GTR35");
            db.Add(0x1C, "Nissan GTR35 Spec V");
            db.Add(0x1D, "Nissan GTR34");
            db.Add(0x1E, "Nissan GTR34 VSpec2 NUR");
            db.Add(0x1F, "Nissan GTR33");
            db.Add(0x20, "Nissan GTR32");
            db.Add(0x21, "Nissan Skyline GT-R");
            db.Add(0x22, "Nissan 370Z");
            db.Add(0x23, "Nissan 350Z");
            db.Add(0x24, "Nissan 300ZX (Z32)");
            db.Add(0x25, "Nissan 300ZX (Z31)");
            db.Add(0x26, "DUMMY");
            db.Add(0x27, "Nissan Fairlady Z S30");
            db.Add(0x28, "Nissan Silvia S15");
            db.Add(0x29, "Nissan 180SX");
            db.Add(0x2A, "Nissan Skyline 370GT");
            db.Add(0x2B, "Nissan Fuga");
            db.Add(0x2C, "RUF CTR");
            db.Add(0x2D, "RUF RGT");
            db.Add(0x2E, "RUF RK");
            db.Add(0x2F, "Subaru WRX GRB");
            db.Add(0x30, "Subaru WRX GDB-F");
            db.Add(0x31, "Subaru WRX GDB-C");
            db.Add(0x32, "Subaru WRX GDB-C Spec C");
            db.Add(0x33, "Subaru WRX GC8 Type RA");
            db.Add(0x34, "Subaru WRX GC8");
            db.Add(0x35, "Subaru Legacy");
            db.Add(0x36, "Subaru SVX");
            db.Add(0x37, "Subaru R2");
            db.Add(0x38, "Subaru Legacy");
            db.Add(0x39, "Toyota Supra (JZA80)");
            db.Add(0x3A, "Toyota Supra (JZA70)");
            db.Add(0x3B, "Toyota MR2");
            db.Add(0x3C, "Toyota Chaser");
            db.Add(0x3D, "Toyota Celsior");
            db.Add(0x3E, "DUMMY");
            db.Add(0x3F, "DUMMY");
            db.Add(0x40, "DUMMY");
            db.Add(0x41, "DUMMY");
            db.Add(0x42, "Toyota Celsior Taxi");
            db.Add(0x43, "DUMMY");
            db.Add(0x44, "DUMMY");
            db.Add(0x45, "DUMMY");
            db.Add(0x46, "DUMMY");
            db.Add(0x47, "Toyota Aristo");
            db.Add(0x48, "Toyota Aristo Taxi");
            db.Add(0x49, "Toyota Corolla");
            db.Add(0x4A, "Toyota Hiace");
            db.Add(0x4B, "Toyota Hiace (High Lift)");
            db.Add(0x4C, "Toyota Crown");
            db.Add(0x4D, "Toyota AE86");
            db.Add(0x4E, "Toyota Celica");
            db.Add(0x4F, "Toyota 2000GT");
            db.Add(0x50, "Toyota 2000GT");
            db.Add(0x51, "BMW Z4 sDrive35is (E89)");
            db.Add(0x52, "BMW M3");
            db.Add(0x53, "Camaro Z28");
            db.Add(0x54, "Corvette Stingray C2");
            db.Add(0x55, "Mazda Miata NA");
            db.Add(0x56, "Mazda Savanna");
            db.Add(0x57, "Mercedes 500E");
            db.Add(0x58, "Mercedes SLK");
            db.Add(0x59, "Mitsubishi Galant");
            db.Add(0x5A, "Nissan Gloria");
            db.Add(0x5B, "Nissan Skyline");
            db.Add(0x5C, "Nissan Stagea");
            db.Add(0x5D, "RUF RT35");
            db.Add(0x5E, "Subaru GVB");
            db.Add(0x5F, "Subaru BRZ");
            db.Add(0x60, "Toyota Soarer");
            db.Add(0x61, "Toyota GT86");
            db.Add(0x62, "Toyota Hiace Super GL");
            db.Add(0x63, "Maxi G Truck");
            db.Add(0x64, "CRASH");
            db.Add(0x65, "BMW M3 (Matte)");
            db.Add(0x66, "CRASH");
            db.Add(0x67, "Mercedes SLK Taxi");
            db.Add(0x68, "Toyota Hiace Super GL (High Lift)");
            db.Add(0x69, "BMW M1");
            db.Add(0x6A, "BMW M3 CSL");
            db.Add(0x6B, "Mercedes SLS");
            db.Add(0x6C, "Mercedes 190E EVO");
            db.Add(0x6D, "Audi R8");
            db.Add(0x6E, "Audi RS4");
            db.Add(0x6F, "Dodge Viper");
            db.Add(0x70, "Dodge Charger");
            db.Add(0x71, "SUBARU  LEVORG 2.0GT-S EyeSight (VMG)");
            db.Add(0x73, "BMW 2002 TURBO");
            db.Add(0x72, "BMW M6 Gran Coupe");
            db.Add(0x74, "MAZDA ROADSTER ND");
            db.Add(0x75, "NISSAN LAUREL 25 CLUB－S");
            db.Add(0x79, "TOYOTA MARKII TOURER V");
            db.Add(0x7A, "BMW MINI Cooper S Crossover");
            db.Add(0x80, "HONDA NSX");
            db.Add(0x81, "HONDA NSX-R");
            db.Add(0x7F, "HONDA New NSX");
            db.Add(0x83, "HONDA S2000");
            db.Add(0x82, "HONDA S660");
            db.Add(0x7B, "Lamborghini Aventador LP700-4");
            db.Add(0x7C, "Lamborghini Countach LP400");
            db.Add(0x7E, "Lamborghini Diablo VT");
            db.Add(0x7D, "Lamborghini Miura P400S");
            db.Add(0x85, "NISSAN SILVIA K's");
            db.Add(0x76, "Nissan GTR35 NISMO");
            db.Add(0x78, "RUF RCT");
        }

        public static string GetCarName(byte id)
        {
            return db[id];
        }

        public static bool ContainsCar(byte id)
        {
            return db.ContainsKey(id);
        }
    }
}
