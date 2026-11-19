using System.Collections.Generic;

namespace UTANI.Models
{
    public class Dashboard
    {
        private List<PeriodeTanam> daftar_periode;

        public IReadOnlyList<PeriodeTanam> DaftarPeriode
        {
            get { return daftar_periode.AsReadOnly(); }
        }

        public Dashboard(List<PeriodeTanam> daftar_periode)
        {
            this.daftar_periode = daftar_periode ?? new List<PeriodeTanam>();
        }

        public void TambahPeriode(PeriodeTanam periode)
        {
            if (periode != null)
            {
                daftar_periode.Add(periode);
            }
        }

        public decimal HitungTotalPendapatanSemuaPeriode()
        {
            decimal total = 0;
            foreach (PeriodeTanam p in daftar_periode)
            {
                total += p.HitungTotalPendapatan();
            }
            return total;
        }

        public decimal HitungTotalBiayaSemuaPeriode()
        {
            decimal total = 0;
            foreach (PeriodeTanam p in daftar_periode)
            {
                total += p.HitungTotalBiaya();
            }
            return total;
        }

        public decimal HitungTotalLabaSemuaPeriode()
        {
            decimal total = 0;
            foreach (PeriodeTanam p in daftar_periode)
            {
                total += p.HitungLaba();
            }
            return total;
        }
    }
}