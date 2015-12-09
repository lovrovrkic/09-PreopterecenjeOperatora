﻿using System;

namespace Vsite.CSharp
{
    struct StrukturaDatum
    {
        public StrukturaDatum(int godina, int mjesec, int dan) : this()
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

        public static StrukturaDatum operator ++(StrukturaDatum datum)
        {
            datum.Dan++;
            // TODO: dodati korekcije ako je prekoračen zadnji dan u mjesecu i godini

            return datum;
        }
    }
}
