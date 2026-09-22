using System;
using System.Collections.Generic;

namespace KaotikusAllatklinika
{
    public class Klinika
    {
        private List<Kisallat> paciensek = new List<Kisallat>();

        public List<Kisallat> Paciensek { get => paciensek;}

        public void BetegFelvétele(Kisallat allat)
        {
            Paciensek.Add(allat);
            Console.WriteLine($"{allat.Nev} megérkezett és fel lett véve.");
        }
        public void VaroTerHangzavar()
        {
            foreach(Kisallat allat in Paciensek)
            {
                allat.HangotAd();
            }
        }
        public void CsoportosKezeles(int alapGyogyszerDozis)
        {
            foreach (Kisallat allat in Paciensek)
            {
                if (allat.Veszelyes == true)
                {
                    Console.WriteLine($"{allat.Nev} túl veszélyes a megközelítéshez, emiatt kimarad a kezelésből");
                    continue;
                }
                allat.KezelesKapot(alapGyogyszerDozis);
                if(allat is PapagajVarazslo)
                {
                    ((PapagajVarazslo)allat).VarázsolGyogyitast();
                }
            }
        }
    }
}