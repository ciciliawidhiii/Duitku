using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duitku
{
    class rekomendasipengeluaran
    {
        private int _duitRec;

        public int duitRec
        {
            get { return _duitRec;}
        }

        public int reccomendation(int duitRec)
        {
            pemasukan n = new pemasukan();
            tabungan m = new tabungan();
            jangkawaktu k = new jangkawaktu();
            duitRec = ((n.duitAwal - m.duitTabung) / k.waktuDuit);
            return duitRec;
        }
    }
}
