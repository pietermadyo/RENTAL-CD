using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGD_RENTAL_CD_7923.Entity_7923
{
    class Kategori
    {
        int id;
        string nama,deskripsi;

        public Kategori(int id, string nama, string deskripsi)
        {
            this.id = id;
            this.nama = nama;
            this.deskripsi = deskripsi;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public string Deskripsi
        {
            get { return deskripsi; }
            set { deskripsi = value; }
        }
    }
}
