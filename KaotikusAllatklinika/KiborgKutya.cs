using System;

namespace KaotikusAllatklinika
{
    public class KiborgKutya : Kisallat
    {
        private int akkumulatorToltottseg;
        public KiborgKutya(string nev, int kor, int egeszsegSzint, int akku) : base(nev, kor, egeszsegSzint)
        {
            AkkumulatorToltottseg = akku;
        }
        public int AkkumulatorToltottseg
        {
            get
            {
                return akkumulatorToltottseg;
            }
            set
            {
                if (value < 0)
                {
                    akkumulatorToltottseg = 0;
                }
                else if (value > 100)
                {
                    akkumulatorToltottseg = 100;
                }
                else
                {
                    akkumulatorToltottseg = value;
                }
            }
        }
        public override void HangotAd()
        {
            if (AkkumulatorToltottseg > 10)
            {
                Console.WriteLine($"{Nev}: BARK! BARK! Robotic Beep");
                AkkumulatorToltottseg -= 5;
            }
            else
            {
                Console.WriteLine("Kattogó hangok(lemerült)");
            }
        }
        public override void KezelesKapot(int gyógyításMértéke)
        {
            base.KezelesKapot(gyógyításMértéke);
            AkkumulatorToltottseg += 20;
        }
    }
}