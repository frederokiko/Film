// See https://aka.ms/new-console-template for more information
using CoursesVoiture;
using System.Security.Cryptography;

Console.ForegroundColor = ConsoleColor.Blue;

Console.ForegroundColor = ConsoleColor.White;
double[] score = new double[] {500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500};
string[] GP = new string[] { "Belgique", "Angleterre", "Allemagne", "Brésil", "Japon", "Emirats Arabe" };
int[] KM = new int[] {15,12,8,9,8,12 };
double[] ResultGp = new double[] { 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500 };
Voiture v1 = new Voiture("Cooper", "Mini", 90, 270,"Infantino","Mirco");
Voiture v2 = new Voiture("Corsa", "Opel", 90, 250,"Renaux","Ophanie");
Voiture v3 = new Voiture("Starlet", "Toyota", 90, 250,"Castiaux","Isabelle");
Voiture v4  = new Voiture("Serie 3", "BMW", 90, 250,"Sorée","Nathan");
Voiture v5 = new Voiture("F40", "Ferrari", 90, 260,"Lesire","Pol");
Voiture v6 = new Voiture("Accord", "Honda", 90, 260,"Wastijn","Willyam");
Voiture v7 = new Voiture("Crz", "Honda", 90, 250,"Kinet","Christounet");
Voiture v8 = new Voiture("Alpine", "Renault", 90, 250,"Verminen","Michaël");
Voiture v9 = new Voiture("Espace", "Renault", 90, 250,"Renaux","Frederic");
Voiture v10 = new Voiture("500", "Fiat", 90, 250,"Bolko","Kaja");
Voiture v11 = new Voiture("Epsilon", "fiat", 90, 250, "Ledoux", "Quentin");
Voiture v12 = new Voiture("RS8", "Audi", 90, 300, "Dhim", "Imen");
Voiture v13 = new Voiture("Aguilera", "Konigseig", 90, 310, "Papoutsakis", "Alexandre");
Voiture v14 = new Voiture("Elctro", "Testla", 90, 310, "Bral-Dupont", "Aurore");
Voiture v15 = new Voiture("Chiron", "Bugatti", 90, 310, "D'addabbo", "Nicolas");



// affichage de toute les voitures
Console.WriteLine(v1.Affichage()); 
Console.WriteLine(v2.Affichage());
Console.WriteLine(v3.Affichage());
Console.WriteLine(v4.Affichage());
Console.WriteLine(v5.Affichage());
Console.WriteLine(v6.Affichage());
Console.WriteLine(v7.Affichage());
Console.WriteLine(v8.Affichage());
Console.WriteLine(v9.Affichage());
Console.WriteLine(v10.Affichage());
Console.WriteLine(v11.Affichage());
Console.WriteLine(v12.Affichage());
Console.WriteLine(v13.Affichage());
Console.WriteLine(v14.Affichage());
Console.WriteLine(v15.Affichage());
// l'utilisateur entre le nombre de voiture
Console.WriteLine("Veuillez entrer le nombre de voiture qui seront en course : ");
int Nbrvoiture;
bool b_Nbrvoiture = int.TryParse(Console.ReadLine(), out Nbrvoiture);

// l'utilisateur entre le nombre de tour
Console.WriteLine("Veuillez entrer le nombre tour à parcourir : ");
int NbrTour;
bool b_NbrTour = int.TryParse(Console.ReadLine(), out NbrTour);
for (int i = 0; i < Nbrvoiture; i++)
{
    ResultGp[i] = 0;
    
}
for (int k = 0; k < GP.Length; k++)
{
    Console.Clear();
    
    Console.SetCursorPosition((Console.WindowWidth - 20) / 2, Console.CursorTop);
    Console.WriteLine("!! Grand prix : " + GP[k]+" !!" );
    Console.WriteLine(KM[k]+" Km au tour");
    int NbrKm = KM[k];
    //Console.WriteLine(NbrKm.calcul1());
    #region
    for (int i = 0; i <= NbrTour; i++)
{
    if (i >= 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Tour N° :" + i);
        Console.ForegroundColor = ConsoleColor.Yellow;


        if (Nbrvoiture > 14)
        {
            // Voiture 15;
            NbrKm = v15.Crevaison(NbrKm);
            score[14] = v15.Vitesse(NbrKm, i, NbrTour);
            ResultGp[14] += score[14];
        }
        if (Nbrvoiture > 13)
        {
            // Voiture 14
            NbrKm = v14.Crevaison(NbrKm);
            score[13] = v14.Vitesse(NbrKm, i, NbrTour);
            ResultGp[13] += score[13];
        }
        if (Nbrvoiture > 12)
        {
            // Voiture 13            
            NbrKm = v13.Crevaison(NbrKm);
            score[12] = v13.Vitesse(NbrKm, i, NbrTour); 
            ResultGp[12] += score[12];
        }
        if (Nbrvoiture > 11)
        {
            // Voiture 12            
            NbrKm = v12.Crevaison(NbrKm);
            score[11] = v12.Vitesse(NbrKm, i, NbrTour);
            ResultGp[11] += score[11];
        }
        if (Nbrvoiture > 10)
        {
            // Voiture 11                      
            NbrKm = v11.Crevaison(NbrKm);
            score[10] = v11.Vitesse(NbrKm, i, NbrTour);
            ResultGp[10] += score[10];
        }
        if (Nbrvoiture > 9)
        {
            // Voiture 10                        
            NbrKm = v10.Crevaison(NbrKm);
            score[9] = v10.Vitesse(NbrKm, i, NbrTour);
            ResultGp[9] += score[9];
        }
        if (Nbrvoiture > 8)
        {
            // voiture 9                        
            NbrKm = v9.Crevaison(NbrKm);
            score[8] = v9.Vitesse(NbrKm, i, NbrTour);
            ResultGp[8] += score[8];
        }
        if (Nbrvoiture > 7)
        {
            // voiture 8                       
            NbrKm = v8.Crevaison(NbrKm);
            score[7] = v8.Vitesse(NbrKm, i, NbrTour);
            ResultGp[7] += score[7];
        }
        if (Nbrvoiture > 6)
        {
            // voiture 7          
            NbrKm = v7.Crevaison(NbrKm);
            score[6] = v7.Vitesse(NbrKm, i, NbrTour);
            ResultGp[6] += score[6];
        }
        if (Nbrvoiture > 5)
        {
            // voiture 6                        
            NbrKm = v6.Crevaison(NbrKm);
            score[5] = v6.Vitesse(NbrKm, i, NbrTour);
            ResultGp[5] += score[5];
        }
        if (Nbrvoiture > 4)
        {
            // voiture 5                     
            NbrKm = v5.Crevaison(NbrKm);
            score[4] = v5.Vitesse(NbrKm, i, NbrTour);
            ResultGp[4] += score[4];
        }
        if (Nbrvoiture > 3)
        {
            // voiture 4                   
            NbrKm = v4.Crevaison(NbrKm);
            score[3] = v4.Vitesse(NbrKm, i, NbrTour);
            ResultGp[3] += score[3];
        }
        if (Nbrvoiture > 2)
        {
            // voiture 3
                      
            NbrKm = v3.Crevaison(NbrKm);
            score[2] = v3.Vitesse(NbrKm, i, NbrTour);
            ResultGp[2] += score[2];
        }
        if (Nbrvoiture > 1)
        {
            // voiture 2                     
            NbrKm = v2.Crevaison(NbrKm);
            score[1] = v2.Vitesse(NbrKm, i, NbrTour);
            ResultGp[1] += score[1];
        }
        if (Nbrvoiture >=1 )
        {
            // voiture 1            
            NbrKm= v1.Crevaison(NbrKm);
            score[0] = v1.Vitesse(NbrKm, i, NbrTour);
            ResultGp[0] += score[0];
        }
      

    }
}
int indice = 0;
for (int j = 0; j < Nbrvoiture; j++)
{
    if (score[j] == score.Min()) { indice = j; break; }
}
var timeSpan = TimeSpan.FromHours(score.Min());
int hh = timeSpan.Hours;
int mm = timeSpan.Minutes;
int ss = timeSpan.Seconds;
        //Console.WriteLine(ResultGp[0]);
        var timeSpan1 = TimeSpan.FromHours(ResultGp. Min()); 
        int hhh = timeSpan1.Hours;
        int mmm = timeSpan1.Minutes;
        int sss = timeSpan1.Seconds;
        switch (indice)
{
    case 0:
            v1.Gagnant(hh, mm, ss);
            if (k == GP.Length-1) { v1.GrandChampion(hhh, mmm, sss); }          
        break;
    case 1:
        v2.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v2.GrandChampion(hhh, mmm, sss); }
            break;
    case 2:
        v3.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v3.GrandChampion(hhh, mmm, sss); }
            break;
    case 3:
        v4.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v4.GrandChampion(hhh, mmm, sss); }
            break;
    case 4:
        v5.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v5.GrandChampion(hhh, mmm, sss); }
            break;
    case 5:
        v6.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v6.GrandChampion(hhh, mmm, sss); }
            break;
    case 6:
        v7.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v7.GrandChampion(hhh, mmm, sss); }
            break;
    case 7:
        v8.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v8.GrandChampion(hhh, mmm, sss); }
            break;
    case 8:
        v9.Gagnant(hh, mm, ss);
        if (k == GP.Length - 1) { v9.GrandChampion(hhh, mmm, sss); }
                break;
    case 9:
        v10.Gagnant(hh, mm, ss);
        if (k == GP.Length - 1) { v10.GrandChampion(hhh, mmm, sss); }
        break;
        case 10:
            v11.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v11.GrandChampion(hhh, mmm, sss); }
            break;
        case 11:
            v12.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v12.GrandChampion(hhh, mmm, sss); }
            break;
        case 12:
            v13.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v13.GrandChampion(hhh, mmm, sss); }
            break;
        case 13:
            v14.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v14.GrandChampion(hhh, mmm, sss); }
            break;
        case 14:
            v15.Gagnant(hh, mm, ss);
            if (k == GP.Length - 1) { v15.GrandChampion(hhh, mmm, sss); }
            break;
        }

Thread.Sleep(5000);


}
#endregion
