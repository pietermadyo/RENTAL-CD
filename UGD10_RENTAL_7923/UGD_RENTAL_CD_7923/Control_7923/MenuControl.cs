using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//memanggil tabel dari dataset dan entity
using UGD_RENTAL_CD_7923.DS_RentalTableAdapters;
using System.Data;
using UGD_RENTAL_CD_7923.Entity;

namespace UGD_RENTAL_CD_7923.Control_7923
{
    class MenuControl
    {
        //menambahkan exception untuk menangkap error untuk semua fungsi pada data master dari dataset
        private TBL_CDTableAdapter TM = new TBL_CDTableAdapter();
        private TBL_KATEGORITableAdapter TK = new TBL_KATEGORITableAdapter();

        ShowException SE = new ShowException();

        public DataTable showMenu()
        {
            DataTable DT = null;
            try
            {
                DT = TM.GetData();
            }
            catch(Exception ex)
            {
                SE.ShowMessage(ex.ToString(),"Kesalahan");
            }
            return DT;
           
        }

        public DataTable searchMenu(string keyword)
        {
           
            DataTable DT = null;
            try
            {
                DT = TM.GetDataBy1(keyword);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public void addMenu(Menu M)
        {
            try
            {
                TM.InsertMenu(M.Judul, M.Stok, M.Harga, M.Tgl, M.Id_kat);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public DataTable getKategori()
        {
            
            DataTable DT = null;
            try
            {
                DT = TK.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public int GetIdKategori(String Kategori)
        {
            
            int temp = 0;
            try
            {
                temp = TK.GetIdKategori(Kategori).Value; 
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return temp;
        }

        public void editMenu(Menu M, int idmenu)
        {
            
            try
            {
                TM.UpdateMenu(M.Judul,M.Stok,M.Harga,M.Tgl,M.Id_kat,idmenu);
            }
            catch (Exception ex)
            {
                 SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void deleteMenu(int idmenu)
        {
            
            try
            {
                TM.DeleteMenu(idmenu);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }
    }
}
