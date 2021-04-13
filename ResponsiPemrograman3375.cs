using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;


class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajibulanan { get; set; }
        public int kenaikan { get; set; }

        public Karyawan(int nik, string nama, int gajibulanan)
        {
            this.nik = nik;
            this.nama = nama;
            if(gajibulanan < 0)
            {
                this.gajibulanan = 0;
            }
            else
            {
                this.gajibulanan = gajibulanan;
            }
            double tmp = 0;
            tmp = 0.1 * gajibulanan;
            kenaikan += Convert.ToInt32(tmp) + gajibulanan;
        }    
    }