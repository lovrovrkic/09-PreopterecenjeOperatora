
namespace Vsite.CSharp
{
    class KlasaDatum
    {
        public KlasaDatum(int godina, int mjesec, int dan)
        {
            Godina = godina;
            Mjesec = mjesec;
            Dan = dan;
        }

        public int Godina
        {
            get;
            private set;
        }

        public int Mjesec
        {
            get;
            private set;
        }

        public int Dan
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}", Dan, Mjesec, Godina);
        }

        private void UvecajMjesec()
        {
            Mjesec++;
            if (Mjesec <= 12)
                return;
            Mjesec = 1;
            Godina++;
        }

        public static KlasaDatum operator ++(KlasaDatum datum)
        {
            datum.Dan++;
            // dodati korekcije ako je prekoračen zadnji dan u mjesecu i godini
            if (datum.Dan > Datum.BrojDanaUMjesecu(datum.Mjesec, datum.Godina))
            {
                datum.Mjesec++;
                datum.Dan = 1;
                if (datum.Mjesec > 12)
                {
                    datum.Godina++;
                    datum.Mjesec = 1;
                }
            }
            return datum;
        }
    }
}
