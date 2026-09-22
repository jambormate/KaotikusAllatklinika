using Newtonsoft.Json;
using System;

namespace KaotikusAllatklinika
{
    public class Kisallat
    {
        private string nev;
        private int kor;
        private int egeszsegSzint;
        private int aggodalomSzint;

        public Kisallat(string nev, int kor, int egeszsegSzint)
        {
            Nev = nev;
            Kor = kor;
            EgeszsegSzint = egeszsegSzint;
            AggodalomSzint = 20;
        }

        public string Nev
        {
            get
            {
                return nev;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    nev = "Névtelen Páciens";
                }
                else
                {
                    nev = value;
                }
            }
        }
        public int Kor
        {
            get
            {
                return kor;
            }
            set
            {
                if (value < 0)
                {
                   kor =0;
                }
                else if(kor > 30)
                {
                    kor = 30;
                }
                else
                {
                    kor = value;
                }
            }
        }
        public int EgeszsegSzint
        {
            get
            {
                return egeszsegSzint;
            }
            set
            {
                if (value < 0)
                {
                    egeszsegSzint = 0;
                }
                else if (egeszsegSzint > 100)
                {
                    egeszsegSzint = 100;
                }
                else
                {
                    egeszsegSzint = value;
                }
            }
        }
        public int AggodalomSzint
        {
            get
            {
                return aggodalomSzint;
            }
            set
            {
                if (value < 0)
                {
                    aggodalomSzint = 0;
                }
                else if (aggodalomSzint > 100)
                {
                    aggodalomSzint = 100;
                }
                else
                {
                    aggodalomSzint = value;
                }
            }
        }
        public bool Veszelyes
        {
            get
            {
                return aggodalomSzint >= 80;
            }
        }
        public virtual void HangotAd()
        {
            Console.WriteLine($"{nev} érthetetlen állati hangokat ad ki.");
        }
        public virtual void KezelesKapot(int gyógyításMértéke)
        {
            EgeszsegSzint += gyógyításMértéke;
            AggodalomSzint -= 10;
            Console.WriteLine($"{nev} megkapta a gyógyszerét.");
        }
    }
}