using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGD_RENTAL_CD_7923.Entity
{
    class Menu
    {
        int id,stok,id_kat;
        string judul,tgl;
        double harga;

        public Menu(int stok,int id_kat,string judul,string tgl,double harga)
        {
           
            this.stok=stok;
            this.id_kat=id_kat;
            this.judul=judul;
            this.tgl=tgl;
            this.harga = harga;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Stok
        {
            get { return stok; }
            set { stok = value; }
        }

        public int Id_kat
        {
            get { return id_kat; }
            set { id_kat = value; }
        }

        public string Judul
        {
            get { return judul; }
            set { judul = value; }
        }

        public string Tgl
        {
            get { return tgl; }
            set { tgl = value; }
        }

        public double Harga
        {
            get { return harga ; }
            set { harga = value; }
        }
         
    }
}
