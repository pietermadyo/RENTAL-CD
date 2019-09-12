using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//memanggil methot di tabeladaptor pada dataset
using UGD_RENTAL_CD_7923.DS_RentalTableAdapters;

namespace UGD_RENTAL_CD_7923.Control_7923
{
    class LoginControl
    {
        //membuat fungsi cek login dan role dari user
        TBL_PENGGUNATableAdapter TP = new TBL_PENGGUNATableAdapter();

        public bool cekLogin(string user,string pass)  
        {
            bool cek = false;
            try
            {
                if(TP.GetUser(user,pass).ToString()!="")
                    cek=true;
            }
            catch(Exception)
            {
                cek = false;
            }
            return cek;
        }

        public int GetRoleUser(string user, string pass)
        {
            int role = 0;
            try
            {
                role = int.Parse(TP.GetRole(user,pass).ToString());
            }
            catch(Exception)
            {
                role = 0;
            }
            return role;
        }
        //======================================================
    }
}
