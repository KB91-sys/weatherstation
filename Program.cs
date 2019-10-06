using System;
using System.Collections.Generic;

namespace Gitrepo_Whetherstation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cityList = new List<string>(); 
            List<double> cityTemperaturList = new List<double>();
            
            bool menu = true;


            
      

            //Menu
            try{
                
                while(menu == true){
                    
                    
                    Console.Clear();
                    Console.Write("\n\n***Väderstationen***\n\n");
                    Console.WriteLine("[L]ägg till temperatur\n[S]kriv ut alla temperaturer\n[T]a bort temperaturmätning\n[A]vsluta");
                    string menuChoice = Console.ReadLine();
                    

                    switch(menuChoice){
                    case "L":
                    MenuMethods.AddCity();
                    break;
                    case "l":
                    MenuMethods.AddCity();
                    break;
                    case "S":
                    MenuMethods.SavedTemperatures();
                    break;
                    case "s":
                    MenuMethods.SavedTemperatures();
                    break;
                    case "T":
                    MenuMethods.RemoveFromList();
                    break;
                    case "t":
                    MenuMethods.RemoveFromList();
                    break;
                    case "A":
                    menu = false;
                    break;
                    case "a":
                    menu = false;
                    break;


            
                }
                }

                

                


            }catch (Exception e){
                Console.Write("Du måste välja någon av alternativen i menyn!");
                Console.Write(e);
                
            }
            




        }
    }
}
