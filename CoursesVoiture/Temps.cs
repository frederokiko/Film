using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace CoursesVoiture
{
    public class Temps 
    {
        public double Dist { get; set; }
        public double Vits { get; set; }
        public double Tempsvoiture { get; set; }
        public Temps(int Dist, int Vits)
        {
            this.Dist = Dist;
            this.Vits = Vits;
        }
        public double Calcultemp()
        {
            Tempsvoiture = Dist / Vits;
            var timeSpan = TimeSpan.FromHours(Tempsvoiture);
            int hh = timeSpan.Hours;
            int mm = timeSpan.Minutes;
            int ss = timeSpan.Seconds;
            Console.SetCursorPosition(50 , Console.CursorTop);
            Console.Write("{0} : h  {1} :Min {2} :Sec     ", hh, mm, ss);
            double l = Vits/3;
            for (int m = 0; m < l; m++)
            {
                //Thread.Sleep(50);
                Console.Write( "-" );
            }
            Console.WriteLine("[:=:->");
            return Tempsvoiture;
        }
    }
   
}
