using System;

namespace KaotikusAllatklinika
{
    public class HipnoMacska : Kisallat
    {
        private int hipnoEro;
        public HipnoMacska(string nev, int kor, int egeszsegSzint, int hipnoEro) : base(nev, kor, egeszsegSzint)
        {
            HipnoEro = hipnoEro;
        }
        public int HipnoEro
        {
            get
            {
                return HipnoEro;
            }
            set
            {
                if (value < 1)
                {
                    HipnoEro = 1;
                }
                else if (value > 10)
                {
                    HipnoEro = 10;
                }
                else
                {
                    HipnoEro = value;
                }
            }
        }
        public override void HangotAd()
        {
            Console.WriteLine($"{Nev} mélyen a szemedbe néz... (A táljába akarod önteni az összes jutalomfalatot).");
        }
    }
}