using System;
using System.Collections.Generic; 

namespace tebakanKata
{
    class Program
    {
        static string kataRahasia = "minions";
        static int kesempatan = 5;
        static List<string> tebakanPemain = new List<string>{};

        static void Main(string[] args) 
        {
            Intro();
            MulaiMain();
        }

        static void Intro(){
            Console.WriteLine("Selamat datang, hari ini kita akan bermain...");
            Console.WriteLine($"Kamu mempunyai {kesempatan} kesempatan untuk menebak kata rahasia hari ini.");
            Console.WriteLine("Petunjuknya adalah kata ini merupakan nama film animasi.");
            Console.WriteLine($"Kata ini terdiri dari {kataRahasia.Length}karakter.");
            Console.WriteLine("Film apakah yang dimaksud.");
            Console.ReadKey();
            Console.WriteLine();
        }

        static void MulaiMain(){
            while (kesempatan>0){
                Console.WriteLine("Apa karakter tebakanmu?(a-z) : ");
                string input = Console.ReadLine();
                tebakanPemain.Add(input);  

                if(CekJawaban(kataRahasia, tebakanPemain)){
                    Console.WriteLine("Selamat anda berhasil menebak katanya");
                    Console.WriteLine($"Kata rahasia hari ini adalah {kataRahasia}");
                    break;
                }else if(kataRahasia.Contains(input)){
                    Console.WriteLine("Ya benar! huruf itu ada dalam kata ini");
                    Console.WriteLine("Silahkan tebak huruf lainnya...");
                    //menampilkan huruf yang sudah di tebak
                    Console.WriteLine(Cekhuruf(kataRahasia, tebakanPemain));  
                }else{
                    Console.WriteLine("Huruf itu tidak ada dalam kata ini");
                    kesempatan--;//kesempatan = kesempatan - 1;
                    Console.WriteLine($"kesempatan anda tinggal {kesempatan}"); 
            }

                static bool CekJawaban(string kataRahasia, List<string> list){
                    bool status = false;

                    for (int i = 0; i < kataRahasia.Length; i++)
                    {
                        string c = Convert.ToString(kataRahasia[i]);
                        if(list.Contains(c)){
                            status = true;
                        }else{
                            return status = false; 
                        }  
                    } 
                    
                    return status; 
                }

                static string Cekhuruf (string kataRahasia, List<string> list){
                    string x = "";

                    for (int i = 0; i < kataRahasia.Length; i++)
                    {
                        string c = Convert.ToString (kataRahasia [i]); 
                        if(list.Contains(c)){
                            x = x + c;
                             
                        }else{
                            x = x + ".";
                        } 

                    }
                    return x;

                }

                if(kesempatan == 0){
                    Console.WriteLine("Mohon maaf kesempatan anda sudah habis.");
                    Console.WriteLine($"Kata misteri yang dimaksdud adalah {kataRahasia}.");
                    Console.WriteLine("Terima kasih sudah bermain...");
                    break;
                }
            }
        }
    }
}