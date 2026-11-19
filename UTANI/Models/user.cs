using System;

namespace UTANI.Models
{
    public class User
    {
        private int _id_pengguna;
        private string _nama;
        private string _email;
        private string _password;
        private string _nomor_telepon;
        private string _role = "buruh_tani";

        public int id_pengguna
        {
            get { return _id_pengguna; }
            set { _id_pengguna = value; }
        }

        public string nama
        {
            get { return _nama; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama pengguna tidak boleh kosong.");
                _nama = value;
            }
        }

        public string email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Email tidak boleh kosong.");
                _email = value;
            }
        }

        public string password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Password tidak boleh kosong.");
                _password = value;
            }
        }

        public string nomor_telepon
        {
            get { return _nomor_telepon; }
            set { _nomor_telepon = value; }
        }

        public string role
        {
            get { return _role; }
            set
            {
                if (value != "petani" && value != "buruh_tani")
                    throw new ArgumentException("Peran hanya boleh 'petani' atau 'buruh_tani'.");
                _role = value;
            }
        }

        public User()
        {
        }

        public User(int id_pengguna, string nama, string email, string password, string nomor_telepon, string role)
        {
            this.id_pengguna = id_pengguna;
            this.nama = nama;
            this.email = email;
            this.password = password;
            this.nomor_telepon = nomor_telepon;
            this.role = role;
        }
    }
}