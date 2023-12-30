using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Doan
{
    class QLCauhoi
    {
        public struct Cauhoi
        {
            public string Cauhoi1;
            public string Dapandung;
            public string TraloiB;
            public string TraloiC;
            public string TraloiD;
            public string LuuDapAn;
        }
        public int tong;
        public int dem;
        public int dapanhientai = 0;
        public StreamReader reader = new StreamReader("datadoan.txt");
        public Cauhoi[] CH = new Cauhoi[100];

        public void LoadCHvaomang()
        {
            tong = int.Parse(reader.ReadLine());
            while (reader.Peek() > 0)
            {
                CH[dem].Cauhoi1 = reader.ReadLine();
                CH[dem].Dapandung = reader.ReadLine();
                CH[dem].TraloiB = reader.ReadLine();
                CH[dem].TraloiC = reader.ReadLine();
                CH[dem].TraloiD = reader.ReadLine();
                dem++;
            }
        }
        public void LuuDapAn(Cauhoi[] Mon, CheckBox checkbox1, CheckBox checkbox2, CheckBox checkbox3, CheckBox checkbox4)
        {
            string LuuDapAn = "";
            if (checkbox1.Checked == true)
                LuuDapAn += "a";
            if (checkbox2.Checked == true)
                LuuDapAn += "b";
            if (checkbox3.Checked == true)
                LuuDapAn += "c";
            if (checkbox4.Checked == true)
                LuuDapAn += "d";
            Mon[dapanhientai].LuuDapAn = LuuDapAn;
        }
    }
}
