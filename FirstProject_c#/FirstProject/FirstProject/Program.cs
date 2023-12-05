using System;


namespace FirstProject
{
      class Program
    {
        static void Main()
        {
           
            while (true)
            {
               
                
                Console.WriteLine("'P' for procenti/ 'R' for ricxvi/ 'S' for shemosavali/ 'E' for Exit");
                string A = Console.ReadLine();
                
                
                //procentis gamotvla
                if (A == "P" || A == "p")
                {
                    Console.WriteLine("ricxvi");
                    float x = float.Parse(Console.ReadLine());
                    Console.WriteLine("Procenti");
                    float y = float.Parse(Console.ReadLine());

                    float z = x * y / 100;
                    Console.WriteLine($"{x} * {y}% = {z}");
                }
                
                
                //100% gamotvla
                if (A == "R" || A == "r")
                {
                    Console.WriteLine("Procenti");
                    float x = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ricxvi");
                    float y = float.Parse(Console.ReadLine());

                    float z = y / (x / 100);
                    Console.WriteLine($"{x}%, {y}, 100% = {z}");
                }
                
               
                

                //Shemosavlis gamotvla (tu 25% ewereba)
                if (A == "S" || A == "s")
                {
                    Console.WriteLine("chadebuli tanxa: ");
                    float x = float.Parse(Console.ReadLine());

                    Console.WriteLine("Momatebuli procenti: ");
                    float y = float.Parse(Console.ReadLine());


                    float z = (x * y / 100) - (x * y / 100) * 25 / 100;
                    float k = x + z;
                    Console.WriteLine($"momatebulia {z}$");
                    Console.WriteLine($"Sul - {k}$");


                }
                

                //exit
                if (A == "E" || A == "e")
                {
                    break;
                }


                    Console.ReadLine();

            }
            
           
        }
    
    }
            
        }
