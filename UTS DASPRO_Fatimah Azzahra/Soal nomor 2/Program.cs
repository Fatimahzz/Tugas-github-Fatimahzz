using System;

namespace UTSnodua
{
    class Program
    {
        static void Main(string[] args)
        {
            int jawaban = 0;
            Random rng = new Random();
            int cek = rng.Next(1,101);
            while (jawaban != cek)
            {
                Console.Write("Tebak angka antara 1-100 : ");
                jawaban = Convert.ToInt32(Console.ReadLine());
                if ( jawaban < cek )
                {
                    Console.WriteLine("Salah. Nilai terlalu rendah."); 
                }else if ( jawaban > cek ){
                    Console.WriteLine("Salah. Nilai terlalu tinggi.");
                }else{
                    Console.WriteLine("Anda benar!");
                    Console.WriteLine("Bye...");
                    Console.ReadLine();
                }
            }
        }
    }
}

