using System;
using System.Collections.Generic;
using UTANI.Models;
using UTANI.Repositories;

namespace UTANI.Controllers
{
    public class UserController : BaseController
    {
        private readonly Pengguna penggunaRepo = new Pengguna();

        public User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Username dan password wajib diisi.");

            User user = penggunaRepo.GetByUsernameAndPassword(username, password);
            if (user != null)
            {
                CurrentUser = user;
            }
            return user;
        }

        public void Logout()
        {
            CurrentUser = null;
        }

        public List<User> AmbilSemuaBuruhTani()
        {
            return penggunaRepo.GetAllByRole("buruh_tani");
        }

        public void TambahAkunBuruh(string nama, string email, string password, string nomorTelepon)
        {
            ValidasiAksesPetani();

            User buruhBaru = new User(0, nama, email, password, nomorTelepon, "buruh_tani");
            penggunaRepo.Insert(buruhBaru);
        }

        public void UbahAkunBuruh(int idPengguna, string nama, string email, string password, string nomorTelepon)
        {
            ValidasiAksesPetani();

            User buruhUpdate = new User(idPengguna, nama, email, password, nomorTelepon, "buruh_tani");
            penggunaRepo.Update(buruhUpdate);
        }

        public void HapusAkunBuruh(int idPengguna)
        {
            ValidasiAksesPetani();

            penggunaRepo.Delete(idPengguna);
        }
    }
}