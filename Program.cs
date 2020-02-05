using System;

namespace Projekti
{
    class Program
    {
        static void Main(string[] args)


        {   //Kysytään käyttäjältä käyttäjätunnus
            Console.Write("Käyttäjätunnus: ");
            String syöte=Console.ReadLine();

            if (syöte == "pepo") //Tarkistetaan tunnuksen oikeellisuus
            {
                Console.Write("Salasana: ");
                String salasana = Console.ReadLine();
                if (salasana == "perunamaa")
                {
                    Console.WriteLine("Kirjautuminen onnistui");
                }

                else
                {
                    Console.WriteLine("Väärä salasana");
                }

            }
            else
            {
                Console.WriteLine("Väärä käyttäjätunnus");
            }


            
        
        
        }


         
            
        }
    }