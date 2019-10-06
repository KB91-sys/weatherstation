using System;
using System.Collections.Generic;
using System.Linq;

namespace Gitrepo_Whetherstation
{
    class MenuMethods
    {

    
        public static List<string> cityList = new List<string>(); 
        public static List<double> temperaturList = new List<double>();
            
        //Låter användaren lägga till en stad och dess temperatur
        public static void AddCity()
        {
            Console.Clear();   
            Console.Write("Skriv in stad: ");
            string city = Console.ReadLine();
            cityList.Add(city);

            Console.Write("Skriv in temperatur: ");
            double temperatur = Convert.ToDouble(Console.ReadLine());
            temperaturList.Add(temperatur);                


        }
        
        //Visar inskrivna temperaturer och städer
        public static void SavedTemperatures()
        {
            Console.Clear();
            
            //Kollar om listan är tom
            bool listEmpty = !temperaturList.Any();
            
            if(listEmpty){
                //Om listan är tom skrivs detta ut
                Console.Write("Du har inte några sparade städer och temperaturer!");
            }
                //Om det finns sparade temp och städer i listan skrivs dessa ut
                else{
                Console.Write("\nInskrivna temperaturer och städer:\n");

                for(int i = 0; i < temperaturList.Count; i++ ){
                    Console.Write("\n" + cityList[i] + " " + temperaturList[i] + " grader");
                

                }
                
                //Räknar ut medeltemperaturen för alla städer
                double medeltemp = (temperaturList.Sum()/temperaturList.Count);
            
                Console.Write("\n\nGenomsnittlig temperatur: " + medeltemp);
            }
            Console.ReadKey();
        
        }
        //Användaren får välja vilken inmatning av stad och temp denne vill ta bort
        public static void RemoveFromList()
        {
            Console.Clear();

            int index = 1;
            int listNumber;


            try{
                for(int i = 0; i < temperaturList.Count; i++ ){
                
                
                    Console.Write("\n" + index++ + ". " + cityList[i] + " " + temperaturList[i] + " grader");
                }
            
                Console.WriteLine("\n\nSkriv in numret på den stad du vill ta bort.\n\nTryck på valfri knapp för att gå tillbaka till menyn.");
                listNumber = Convert.ToInt32(Console.ReadLine());

                
                cityList.RemoveAt(listNumber - 1);
                temperaturList.RemoveAt(listNumber - 1);
            
            }catch{

            }

        }



   }    
}
