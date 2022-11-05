using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoursesVoiture
{
    public class Voiture 
    {
        public string Modele { get; set; }
        public string Marque { get; set; }
        public int VitesseMinimale { get; set; }
        public int VitesseMaximale { get; set; }
        public int vitesse { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        
        public double TempsTour { get; set; }
        public double TempsTotal { get; set; }
        public string affichage { get; set; }
        public string affichage1 { get; set; }
       
        public double TempsVoiture { get; set; }
        public int Penalite { get; set; }
        public Voiture(string Modele, string Marque, int VitesseMinimale, int VitesseMaximale,string Nom,string Prenom)
        {
            this.Modele = Modele;
            this.Marque = Marque;
            this.VitesseMinimale = VitesseMinimale;
            this.VitesseMaximale = VitesseMaximale;           
            this. Nom = Nom;
            this. Prenom = Prenom;
        }

        

        public double Vitesse(int NbrKm, int i, int NbrTour)
        {
            Random aleatoire = new Random();
            int vitesse = aleatoire.Next(VitesseMinimale, VitesseMaximale);
            Console.Write(Affichage1() );
            Console.SetCursorPosition(20, Console.CursorTop);
            Console.Write(" Roule à : " + vitesse + " Km/h   ");
            if (i == 1)
            {
                TempsTotal = 0;
            }
            Temps t1 = new Temps(NbrKm, vitesse);
            TempsTour = (double)t1.Calcultemp();
            TempsTotal += TempsTour;
            TempsVoiture = TempsTotal;
            return TempsVoiture;         
        }
        public string Affichage()
        {
            affichage = "Modele : " + Modele + " Marque : " + Marque + " vitesse min : " + VitesseMinimale + " vitesse max : " + VitesseMaximale;
            return affichage;
        }

        public string Affichage1()
        {
            affichage1 = Marque + " " + Modele + " ";
            return affichage1;
        }

        public void  Gagnant(int hh,int mm ,int ss)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Le gagnant est : "+Nom+" "+Prenom+" avec la voiture : "  );
            Console.SetCursorPosition(55, Console.CursorTop);
            Console.Write(Affichage1() );
            Console.SetCursorPosition(80, Console.CursorTop);
            Console.WriteLine(" temps : " + "{0} h  {1} Min {2} Sec", hh, mm, ss);

            Console.ForegroundColor = ConsoleColor.White;
            return;
        }
        public int Crevaison(int NbrKm)
        {
            Random aleatoire = new Random();
            int Creve = aleatoire.Next(0, 25);
            if (Creve == 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Le pilote : "+Nom+" "+Prenom+" est victime d'une crevaison et prend du retard !");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Penalite = NbrKm + 5;
                return Penalite;
            }if (Creve == 19)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Le pilote : " + Nom + " " + Prenom + " à pris l'aspiration et gagne du temps !");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Penalite = NbrKm -3;
            }
            return NbrKm;
        }
        public void GrandChampion(int hhh, int mmm, int sss)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Le grand champion de cette saison est : " + Nom + " " + Prenom + " avec un temps total de : " + hhh + " h " + mmm + " min " + sss + " sec");
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
