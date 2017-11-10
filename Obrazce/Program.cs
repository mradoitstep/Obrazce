using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obrazec kruh = new Kruh(3);
            //Console.WriteLine("Obsah kruhu : {0}", kruh.VypocitajObsah());
            //Stvorec stvorec = new Stvorec(5);
            //Console.WriteLine("Obsah kruhu : {0}", stvorec.VypocitajObsah());

            //Stvorec stvorec2 = new Stvorec(4.5);

            //Console.WriteLine("Porovnaj {0}", Stvorec.Porovnaj(stvorec, stvorec2));

            //IKreslenie k = stvorec2;
            //IKreslenie k1 = new Kruh(10.2);
            //k.Vykresli();
            //k1.Vykresli();

            Kruh kruh1 = new Kruh(5);
            IZmenRozmer zmenaKruhu = kruh1;
            zmenaKruhu.ZmenRozmer(3);
            Console.WriteLine(kruh1.VypocitajObsah());


            Stvorec stvorec = new Stvorec(5);
            IZmenRozmer zmenaStvorca = stvorec;
            zmenaStvorca.ZmenRozmer(4);
            Console.WriteLine(stvorec.VypocitajObsah());


            Console.ReadLine();
        }
    }
}
