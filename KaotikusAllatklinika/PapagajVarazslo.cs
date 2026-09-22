using System;

namespace KaotikusAllatklinika
{
    public class PapagajVarazslo : Kisallat
    {
        private int manaSzint;

        public PapagajVarazslo(string nev, int kor, int egeszsegSzint, int mana) : base(nev, kor, egeszsegSzint)
        {
            ManaSzint = mana;
        }

        public int ManaSzint { get => manaSzint; set => manaSzint = Math.Clamp(value, 0, 50); }

        public override void HangotAd()
        {
            if(manaSzint >= 10)
            {
                Console.WriteLine($"{Nev}: KÁÁÁ-AVADA KEDAVRA!");
                manaSzint -= 10;
            }
            else
            {
                Console.WriteLine($"{Nev}: Kár... több manát!");
            }
        }
        public void VarázsolGyogyitast()
        {
            if(manaSzint >= 15)
            {
                manaSzint -= 15;
                EgeszsegSzint += 20;
            }
        }
    }
}