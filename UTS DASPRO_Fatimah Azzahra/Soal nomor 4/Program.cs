using System;

namespace UTSnoempat
{
    class Program
    {
        static void Main(string[] args){
            int skorMenang = 0;
            int skorKalah = 0;
            int skorSeri = 0;
            char userInput = ' ';
            Random rng = new Random();

            while ( userInput != 'e')
            {
                Console.WriteLine("Batu, Gunting, Kertas\n");
                Console.Write("Choose [b]atu, [g]unting, [k]ertas, or [e]xit :");
                userInput = Convert.ToChar(Console.ReadLine());

                if (userInput == 'e')
                {
                    Console.WriteLine("Goodbye...");
                    break;
                }
                int computer = rng.Next(1,4);
                if (userInput == 'b')
                {
                    if (computer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Seri.");
                        skorSeri++;
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Anda Menang.");
                        skorMenang++; 
                    }
                    else if (computer == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Anda Kalah.");
                        skorKalah++;
                    }
                }
                else if (userInput == 'g')
                {
                    if (computer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Anda Kalah.");
                        skorKalah++;
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Seri.");
                        skorSeri++;
                    }
                    else if (computer == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Anda Menang.");
                        skorMenang++;
                    }
                } 
                else if (userInput == 'k')
                {
                   if (computer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Anda Menang.");
                        skorMenang++;
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Anda Kalah.");
                        skorKalah++;
                    }
                    else if (computer == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Seri.");
                        skorSeri++;
                    }
                }   
                Console.WriteLine("Skor kamu : {0} menang, {1} kalah, {2} seri", skorMenang, skorKalah, skorSeri);
                Console.WriteLine("Tekan Enter untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
                
            }
            
        }
    }
} 