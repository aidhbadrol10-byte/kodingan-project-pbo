using System;
using UTANI.Models;

namespace UTANI.Controllers
{
    public class BaseController
    {
       
        public static User CurrentUser { get; set; }

        
        protected void ValidasiAksesPetani()
        {
            if (CurrentUser == null)
            {
                throw new UnauthorizedAccessException("Sesi login tidak ditemukan. Silakan login kembali.");
            }

            if (CurrentUser.role != "petani")
            {
                throw new UnauthorizedAccessException(
                    "Akses ditolak! Role Anda adalah '" + CurrentUser.role + "'. " +
                    "Tindakan ini hanya dapat dilakukan oleh Petani."
                );
            }
        }
    }
}