using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLTC3
{
    class Phanso
    {
        int tuso, mauso;
        public Phanso()
        {
            tuso = 0;
            mauso = 1;
        }
        public Phanso(int ts, int ms)
        {
            tuso = ts;
            mauso = ms;
        }
        public int Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int Mauso
        {
            get { return mauso; }
            set { mauso = (value == 0 ? 1:value); }
        }
        private void Toigian()
        {
            int us = Lopdungchung.USCLN(tuso, mauso);
            if (us > 0)
            {
                tuso /= us;
                mauso /= us;
            }
        }
        public Phanso Cong(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso + mauso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            kq.Toigian();
            return kq;
        }
        public Phanso Tru(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso - mauso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            kq.Toigian();
            return kq;
        }
        public Phanso Nhan(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso *  ps.tuso;
            kq.mauso = mauso * ps.mauso;
            kq.Toigian();
            return kq;
        }
        public Phanso Chia(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso;
            kq.mauso = mauso * ps.tuso;
            kq.Toigian();
            return kq;
        }
    }
}
