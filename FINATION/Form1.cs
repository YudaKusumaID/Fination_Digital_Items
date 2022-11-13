using System.Diagnostics;
using System.Security.Policy;
using static System.Net.WebRequestMethods;

namespace FINATION
{
    public partial class Form1 : Form
    {
        //VARIABLE PROSES
        int harga_barang;
        int jumlah_barang;
        int total;

        //VARIABLE HARGA
        //PUBG MOBILE
        int uc_25 = 5000;
        int uc_35 = 7000;
        int uc_50 = 10000;
        int uc_70 = 14000;
        int uc_125 = 25000;
        int uc_250 = 50000;
        int uc_500 = 100000;
        int uc_1250 = 250000;
        int uc_2500 = 500000;
        int uc_5000 = 1000000;

        //LOL WILD DRIFT
        int wildcores_125 = 15000;
        int wildcores_417 = 50000;
        int wildcores_667 = 80000;
        int wildcores_1250 = 150000;
        int wildcores_2083 = 250000;
        int wildcores_3333 = 400000;
        int wildcores_6667 = 800000;

        //POINT BLANK
        int cash_1200 = 11000;
        int cash_2400 = 22000;
        int cash_6000 = 55000;
        int cash_12000 = 110000;
        int cash_24000 = 220000;
        int cash_36000 = 330000;
        int cash_60000 = 550000;

        //GENSHIN IMPACT
        int genesis_60 = 16000;
        int genesis_300 = 79000;
        int genesis_980 = 249000;
        int genesis_1980 = 479000;
        int genesis_3280 = 799000;
        int genesis_6480 = 1599000;

        //VALORANT
        int points_125 = 15000;
        int points_420 = 50000;
        int points_700 = 80000;
        int points_1375 = 150000;
        int points_2400 = 250000;
        int points_4000 = 400000;
        int points_8150 = 800000;

        //GOOGLE PLAY
        int gplay_5000 = 5000;
        int gplay_10000 = 10000;
        int gplay_20000 = 20000;
        int gplay_50000 = 50000;
        int gplay_100000 = 100000;
        int gplay_150000 = 150000;
        int gplay_300000 = 300000;
        int gplay_500000 = 500000;

        //ITUNES
        int itunes_5 = 82000;
        int itunes_10 = 165000;
        int itunes_15 = 247000;
        int itunes_25 = 412000;
        int itunes_50 = 825000;
        int itunes_100 = 1650000;

        //STEAM WALLET
        int steam_12000 = 12000;
        int steam_45000 = 45000;
        int steam_60000 = 60000;
        int steam_90000 = 90000;
        int steam_120000 = 120000;
        int steam_250000 = 250000;
        int steam_400000 = 400000;
        int steam_600000 = 600000;

        //PLAY STATION
        int ps_100000 = 105000;
        int ps_200000 = 210000;
        int ps_400000 = 420000;

        //XBOX LIVE
        int xbox_5 = 80000;
        int xbox_10 = 160000;
        int xbox_15 = 240000;
        int xbox_25 = 400000;
        int xbox_50 = 800000;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbjenisitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbproduk.Text == "Top Up")
            {
                cmblist.Items.Clear();
                cmblist.Text = "";
                cmblist.Items.Add("PUBG Mobile");
                cmblist.Items.Add("LOL Wild Drift");
                cmblist.Items.Add("Point Blank");
                cmblist.Items.Add("Genshin Impact");
                cmblist.Items.Add("Valorant");
            }

            else if (cmbproduk.Text == "Voucher")
            {
                cmblist.Items.Clear();
                cmblist.Text = "";
                cmblist.Items.Add("Google Play");
                cmblist.Items.Add("Steam Wallet");
                cmblist.Items.Add("iTunes");
                cmblist.Items.Add("Play Station");
                cmblist.Items.Add("Xbox Live");
            }
        }

        private void cmblist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //======================|| TOP UP ||======================
            if (cmblist.Text == "PUBG Mobile")
            {
                cmbitems.Items.Clear();
                cmbitems.Text = "";
                cmbitems.Items.Add("25 Uc");
                cmbitems.Items.Add("35 Uc");
                cmbitems.Items.Add("50 Uc");
                cmbitems.Items.Add("70 Uc");
                cmbitems.Items.Add("125 Uc");
                cmbitems.Items.Add("250 Uc");
                cmbitems.Items.Add("500 Uc");
                cmbitems.Items.Add("1250 Uc");
            }

            else if (cmblist.Text == "LOL Wild Drift")
            {
                cmbitems.Items.Clear();
                cmbitems.Text = "";
                cmbitems.Items.Add("125 Wild Cores");
                cmbitems.Items.Add("417 Wild Cores");
                cmbitems.Items.Add("667 Wild Cores");
                cmbitems.Items.Add("1250 Wild Cores");
                cmbitems.Items.Add("2083 Wild Cores");
                cmbitems.Items.Add("3333 Wild Cores");
                cmbitems.Items.Add("6667 Wild Cores");
            }

            else if (cmblist.Text == "Point Blank")
            {
                cmbitems.Items.Clear();
                cmbitems.Text = "";
                cmbitems.Items.Add("1200 CASH");
                cmbitems.Items.Add("2400 CASH");
                cmbitems.Items.Add("6000 CASH");
                cmbitems.Items.Add("12000 CASH");
                cmbitems.Items.Add("24000 CASH");
                cmbitems.Items.Add("36000 CASH");
                cmbitems.Items.Add("60000 CASH");
            }

            else if (cmblist.Text == "Genshin Impact")
            {
                cmbitems.Items.Clear();
                cmbitems.Text = "";
                cmbitems.Items.Add("60 Genesis");
                cmbitems.Items.Add("300 Genesis");
                cmbitems.Items.Add("980 Genesis");
                cmbitems.Items.Add("1980 Genesis");
                cmbitems.Items.Add("3280 Genesis");
                cmbitems.Items.Add("6480 Genesis");
            }

            else if (cmblist.Text == "Valorant")
            {
                cmbitems.Items.Clear();
                cmbitems.Text = "";
                cmbitems.Items.Add("125 Points");
                cmbitems.Items.Add("420 Points");
                cmbitems.Items.Add("700 Points");
                cmbitems.Items.Add("1375 Points");
                cmbitems.Items.Add("2400 Points");
                cmbitems.Items.Add("4000 Points");
                cmbitems.Items.Add("8150 Points");
            }

            //======================|| VOUCHER ||======================
            else if (cmblist.Text == "Google Play")
            {
                cmbitems.Items.Clear();
                cmbitems.Text = "";
                cmbitems.Items.Add("50000 IDR");
                cmbitems.Items.Add("10000 IDR");
                cmbitems.Items.Add("20000 IDR");
                cmbitems.Items.Add("50000 IDR");
                cmbitems.Items.Add("100000 IDR");
                cmbitems.Items.Add("150000 IDR");
                cmbitems.Items.Add("300000 IDR");
                cmbitems.Items.Add("500000 IDR");
            }

            else if (cmblist.Text == "Steam Wallet")
            {
                cmbitems.Items.Clear();
                cmbitems.Text = "";
                cmbitems.Items.Add("12000 Wallet");
                cmbitems.Items.Add("45000 Wallet ");
                cmbitems.Items.Add("60000 Wallet");
                cmbitems.Items.Add("90000 Wallet");
                cmbitems.Items.Add("120000 Wallet");
                cmbitems.Items.Add("250000 Wallet");
                cmbitems.Items.Add("400000 Wallet");
                cmbitems.Items.Add("600000 Wallet");
            }

            else if (cmblist.Text == "iTunes")
            {
                cmbitems.Items.Clear();
                cmbitems.Text = "";
                cmbitems.Items.Add("5 USD");
                cmbitems.Items.Add("10 USD");
                cmbitems.Items.Add("15 USD");
                cmbitems.Items.Add("25 USD");
                cmbitems.Items.Add("50 USD");
                cmbitems.Items.Add("100 USD");
            }

            else if (cmblist.Text == "Play Station")
            {
                cmbitems.Items.Clear();
                cmbitems.Text = "";
                cmbitems.Items.Add("IDR 100000");
                cmbitems.Items.Add("IDR 200000");
                cmbitems.Items.Add("IDR 400000");
            }

            else if (cmblist.Text == "Xbox Live")
            {
                cmbitems.Items.Clear();
                cmbitems.Text = "";
                cmbitems.Items.Add("5 USD Gift Card");
                cmbitems.Items.Add("10 USD Gift Card");
                cmbitems.Items.Add("15 USD Gift Card");
                cmbitems.Items.Add("25 USD Gift Card");
                cmbitems.Items.Add("50 USD Gift Card");
            }
        }

        private void cmbitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HARGA
            //======================||   TOP UP    ||======================
            //======================|| PUBG MOBILE ||======================
            if (cmbitems.Text == "25 Uc")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = uc_25.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "35 Uc")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = uc_35.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "50 Uc")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = uc_50.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "70 Uc")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = uc_70.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "125 Uc")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = uc_125.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "250 Uc")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = uc_250.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "500 Uc")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = uc_500.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "1250 Uc")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = uc_1250.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "2500 Uc")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = uc_2500.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "5000 Uc")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = uc_5000.ToString(textHarga.Text);
            }

            ////======================|| LOL WILD DRIFT ||======================
            else if (cmbitems.Text == "125 Wild Cores")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = wildcores_125.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "417 Wild Cores")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = wildcores_417.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "667 Wild Cores")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = wildcores_667.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "1250 Wild Cores")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = wildcores_1250.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "2083 Wild Cores")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = wildcores_2083.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "3333 Wild Cores")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = wildcores_3333.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "6667 Wild Cores")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = wildcores_6667.ToString(textHarga.Text);
            }

            //======================|| POINT BLANK ||======================
            else if (cmbitems.Text == "1200 CASH")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = cash_1200.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "2400 CASH")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = cash_2400.ToString(textHarga.Text);
            }
            
            else if (cmbitems.Text == "6000 CASH")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = cash_6000.ToString(textHarga.Text);
            }
            
            else if (cmbitems.Text == "12000 CASH")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = cash_12000.ToString(textHarga.Text);
            }
            
            else if (cmbitems.Text == "24000 CASH")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = cash_24000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "36000 CASH")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = cash_36000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "60000 CASH")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = cash_60000.ToString(textHarga.Text);
            }

            //======================|| GENSHIN IMPACT ||======================
            else if (cmbitems.Text == "60 Genesis")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = genesis_60.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "300 Genesis")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = genesis_300.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "980 Genesis")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = genesis_980.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "1980 Genesis")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = genesis_1980.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "3280 Genesis")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = genesis_3280.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "6480 Genesis")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = genesis_6480.ToString(textHarga.Text);
            }

            //======================|| VALORANT ||======================
            else if (cmbitems.Text == "125 Points")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = points_125.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "420 Points")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = points_420.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "700 Points")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = points_700.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "1375 Points")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = points_1375.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "2400 Points")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = points_2400.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "4000 Points")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = points_4000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "8150 Points")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = points_8150.ToString(textHarga.Text);
            }


            //======================|| GOOGLE PLAY ||======================
            else if (cmbitems.Text == "5000 IDR")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = gplay_5000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "10000 IDR")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = gplay_10000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "20000 IDR")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = gplay_20000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "50000 IDR")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = gplay_50000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "100000 IDR")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = gplay_100000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "150000 IDR")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = gplay_150000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "300000 IDR")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = gplay_300000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "500000 IDR")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = gplay_500000.ToString(textHarga.Text);
            }

            //======================|| ITUNES ||======================
            else if (cmbitems.Text == "5 USD")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = itunes_5.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "10 USD")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = itunes_10.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "15 USD")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = itunes_15.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "25 USD")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = itunes_25.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "50 USD")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = itunes_50.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "50 USD")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = itunes_50.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "100 USD")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = itunes_100.ToString(textHarga.Text);
            }

            //======================|| STEAM WALLET ||======================
            else if (cmbitems.Text == "12000 Wallet")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = steam_12000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "45000 Wallet")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = steam_45000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "60000 Wallet")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = steam_60000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "90000 Wallet")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = steam_90000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "120000 Wallet")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = steam_120000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "250000 Wallet")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = steam_250000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "400000 Wallet")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = steam_400000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "600000 Wallet")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = steam_600000.ToString(textHarga.Text);
            }

            //======================|| PLAY STATION ||======================
            else if (cmbitems.Text == "IDR 100000")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = ps_100000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "IDR 200000")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = ps_200000.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "IDR 400000")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = ps_400000.ToString(textHarga.Text);
            }

            //======================|| XBOX LIVE ||======================
            else if (cmbitems.Text == "5 USD Gift Card")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = xbox_5.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "10 USD Gift Card")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = xbox_10.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "15 USD Gift Card")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = xbox_15.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "25 USD Gift Card")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = xbox_25.ToString(textHarga.Text);
            }

            else if (cmbitems.Text == "50 USD Gift Card")
            {
                textHarga.Clear();
                textJumlah.Clear();
                textHarga.Text = xbox_50.ToString(textHarga.Text);
            }
        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            textTotal.Clear();
            harga_barang = Int32.Parse(textHarga.Text);
            jumlah_barang = Int32.Parse(textJumlah.Text);
            total = harga_barang * jumlah_barang;
            textTotal.Text = total.ToString(textTotal.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/YudaKusumaID") { UseShellExecute = true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textHarga.Clear();
            textJumlah.Clear();
            textTotal.Clear();
        }
    }
}