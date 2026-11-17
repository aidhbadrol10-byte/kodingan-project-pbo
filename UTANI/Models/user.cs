using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTANI.Models
{
    public class User
    {
        public int id_pengguna { get; set; }
        public string nama { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string nomor_telepon { get; set; }
        public string role { get; set; }
    }
}
