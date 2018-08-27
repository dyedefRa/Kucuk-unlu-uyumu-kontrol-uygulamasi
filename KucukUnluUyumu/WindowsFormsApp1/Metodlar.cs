using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Metodlar
    {
        public static List<string> cumleAlKelimeVer(string cumle)
        {
            return cumle.Split(' ').ToList();
        }

        public static List<char> kelimeAlDiziver(string kelime)
        {
            return kelime.ToCharArray().ToList();
        }
        public static string KucukUnluUyumuKONTROL(string cumle)
        {
            var sonuc = cumle + " =>  ";
            var kelimeListesi = cumleAlKelimeVer(cumle);
            foreach (var kelime in kelimeListesi)
            {
                if (KucukUnluUyumu(kelime))
                {
                    sonuc += "  '" + kelime + "'si Küçük ünlü uyumuna uyuyor  ,";
                }
                else
                {
                    sonuc += "  '" + kelime + "'si Küçük ünlü uyumuna uymuyor  ,";
                }
            }
            sonuc = sonuc.Remove(sonuc.Length - 1, 1);
            return sonuc;
        }

        public static bool KucukUnluUyumu(string kelime)
        {
            List<char> sadeceChar = new List<char>();
            var kelimeninCharListi = kelimeAlDiziver(kelime);
            for (int i = 0; i < kelimeninCharListi.Count; i++)
            {
                if (kelimeninCharListi[i] == 'a' || kelimeninCharListi[i] == 'e' || kelimeninCharListi[i] == 'ı' || kelimeninCharListi[i] == 'i' || kelimeninCharListi[i] == 'o' || kelimeninCharListi[i] == 'ö' || kelimeninCharListi[i] == 'u' || kelimeninCharListi[i] == 'ü')
                {
                    sadeceChar.Add(kelimeninCharListi[i]);
                }
            }

            for (int i = 0; i < sadeceChar.Count; i++)
            {
                if (i != sadeceChar.Count - 1)
                {
                    if (sadeceChar[i] == 'a' || sadeceChar[i] == 'e' || sadeceChar[i] == 'ı' || sadeceChar[i] == 'i')
                    {
                        char birsonrakiUnlu = sadeceChar[i + 1];
                        if (birsonrakiUnlu == 'o' || birsonrakiUnlu == 'ö' || birsonrakiUnlu == 'u' || birsonrakiUnlu == 'ü')
                        {
                            return false;
                        }
                    }


                    else if (sadeceChar[i] == 'o' || sadeceChar[i] == 'ö' || sadeceChar[i] == 'u' || sadeceChar[i] == 'ü')
                    {
                        char birsonrakiUnlu = sadeceChar[i + 1];
                        if (birsonrakiUnlu == 'o' || birsonrakiUnlu == 'ö' || birsonrakiUnlu == 'ı' || birsonrakiUnlu == 'i')
                        {
                            return false;
                        }
                    }


                }
            }

            return true;
        }


      
    }
}
