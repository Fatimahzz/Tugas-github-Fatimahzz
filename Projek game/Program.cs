using System;

    class program
    {
        static void Main(string[] args)
        {
           Intro();
           GamePlay();
           Outro();    
        }
        static void Intro()
        {
            Console.WriteLine("ADU DADU\n");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Halo, Selamat datang dalam permainan Adu Dadu");
            Console.WriteLine("Pada permainan ini kita akan berlawanan Dadu antara player dan komputer");
            Console.WriteLine("Permainan ini terdiri dari 10 Ronde");
            Console.WriteLine("Setiap ronde player dan komputer akan melempar satu buah dadu");
            Console.WriteLine("Pemain yang berpoint paling banyak dinyatakan pemenang dalam permainan ini");
            Console.WriteLine("-------------------------------------------------------------\n");
            
        }
        static void GamePlay()
        {
            int daduKomputer;
            int daduPlayer;

            int jumlahRonde = 0;
            int pointKomputer = 0;
            int pointPlayer = 0;
            Random dadu = new Random ();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nTekan tombol untuk memulai...\n");
                Console.ReadKey();

                jumlahRonde++;
                Console.WriteLine("Ronde" + jumlahRonde);
                daduKomputer = dadu.Next(1,7);
                Console.WriteLine("Komputer melempar dadu,lalu keluar angka yang di dapatkan" + daduKomputer);
                Console.ReadKey();
                Console.Write("...");
                System.Threading.Thread.Sleep(1500);
                Console.Write("\b\b\b\b");    
                daduPlayer = dadu.Next(1,7);
                Console.WriteLine("Player melempar dadu, lalu keluar angka yang di dapatkan" + daduPlayer);

                if (daduKomputer > daduPlayer)
                {
                    pointKomputer++;
                    Console.WriteLine(" Komputer memenangkan ronde ini !");
                }else if (daduPlayer > daduKomputer) {
                    pointPlayer++;
                    Console.WriteLine("Player memenangkan ronde ini ! "); 
                }else {
                    Console.WriteLine("Ronde ini seri !");
                }

                Console.WriteLine("Skor Komputer saat ini:" + pointKomputer + " || skor Player saat ini:" + pointPlayer);
                Console.WriteLine("-------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();       
            }

            if (pointKomputer > pointPlayer )
            {
                Console.WriteLine("\n-----------------------------------------------------------");  
                Console.WriteLine("Selamat, Komputer memenangkan permainan ini !");
                Console.WriteLine("-------------------------------------------------------------");    
            } else if (pointPlayer > pointKomputer) {
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine(" Selamat Player memenangkan permainan !");
                Console.WriteLine("-------------------------------------------------------------");      
            } else {
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("Permainan ini berakhir seri antara Komputer dan Player !");
                Console.WriteLine("-------------------------------------------------------------");      
            }
            Console.ReadKey();  
        }
        static void Outro()
        {
            Console.WriteLine("\nTerima kasih anda telah mengikuti alur permaiann ini !");
            Console.WriteLine("Dibuat oleh :"); 
            Console.WriteLine("Nama  : Fatimah Azzahra");
            Console.WriteLine("NIM   : 2207125072");
            Console.WriteLine("Kelas : Teknik Informatika A");  
            Console.ReadKey();    
        }
        
    }
