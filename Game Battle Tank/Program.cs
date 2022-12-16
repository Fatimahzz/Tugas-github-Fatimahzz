using System;

namespace BattleTank
{
    class program
    {
        static void Main(string[] args)
        {
            //Inisialisasi variabel yang dibutuhkan 
            int panjangArea = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'X';
            char miss = 'O';
            int jumlahTank = 3;
            
            char[,] playArea = buatRuang(panjangArea,rumput,tank,jumlahTank); 

            printArea(playArea,rumput,tank);

            int jumlahTankTersembunyi = jumlahTank;

            //Gameplay
            while(jumlahTankTersembunyi > 0){
                int[] tebakanKoordinat = getKoordinatTebakan(panjangArea);
                char updateTampilanArea = verifikasiTebakan(tebakanKoordinat, playArea, tank, rumput, hit, miss);
                if(updateTampilanArea == hit){
                    jumlahTankTersembunyi--;
                }
                playArea = updateArea(playArea,tebakanKoordinat, updateTampilanArea);
                printArea(playArea,rumput,tank);
            } 

            Console.WriteLine("Game over, byebye...");
            Console.Read();  

        }
        // Membuat arena permainanan 
        static char [,] buatRuang(int panjangArea, char rumput,char tank, int jumlahTank){
            char[,] ruangan = new char[panjangArea,panjangArea];

            for(int baris = 0; baris < panjangArea; baris ++){
                for(int kolom = 0; kolom < panjangArea; kolom++){
                    ruangan[baris,kolom] = rumput;  
                }
            }
            return letakkanTank(ruangan,jumlahTank,rumput,tank);
        
        }
        //membuat tank dalam Area
        static char[,] letakkanTank(char[,] ruangan, int jumlahTank, char rumput, char tank){
            int letakTank = 0;
            int panjangArea = 5;

            while(letakTank<jumlahTank){
                int [] lokasiTank = tentukanKoordinatTank(panjangArea);
                char posisi = ruangan[lokasiTank[0], lokasiTank[1]];

                if(posisi==rumput){
                    ruangan[lokasiTank[0], lokasiTank[1]] = tank;
                    letakTank++;
                }  
            }
            return ruangan; 
        } 
        //menentukan posisi koordinat tank (x,y) secara acak
        static int[] tentukanKoordinatTank(int panjangArea){
            Random rnd = new Random();
            int[] koordinat = new int[2];
            for(int i = 0; i < koordinat.Length;i++)
            {
                koordinat[i] = rnd.Next(panjangArea);// x = random(0,4) ; y = random(0,4)
            }

            return koordinat;
        }
        //menampilkan area permainan ke console
        static void printArea(char[,] playArea, char rumput, char tank){
           
            Console.Write(" ");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 +" "); 
            }
            Console.WriteLine(); 

            for(int baris = 0; baris < 5; baris++){
                Console.Write(baris + 1 +" ");
                for(int kolom = 0; kolom < 5; kolom++){
                    char posisi = playArea[baris,kolom];
                    if(posisi == tank){
                        Console.Write(rumput + " ");  
                    }else{
                        Console.Write(posisi + " ");  
                    } 
                } 
                Console.WriteLine();   
            }
        }
        //Tebakkan koordinat pemain
        static int[] getKoordinatTebakan(int panjangArea){
            int baris;
            int kolom;

            do{
                Console.Write("Pilih baris : ");
                baris = Convert.ToInt32(Console.ReadLine());  
            }while(baris < 0 || baris > panjangArea + 1);

            do{
                Console.Write("Pilih kolom : ");
                kolom = Convert.ToInt32(Console.ReadLine());  
            }while(kolom < 0 || kolom > panjangArea + 1);

            return new[]{baris-1, kolom-1};
        }

        //Verifikasi tebakan pemain
        static char verifikasiTebakan(int[] tebakan, char[,] playArea, char tank, char rumput, char hit,char miss){
            string pesan;
            int baris = tebakan[0];
            int kolom = tebakan[1];
            char target = playArea[baris,kolom];

            if(target == tank){
                pesan ="HIT!!";
                target = hit; 
            }else if(target == rumput){
                pesan ="MISS!!";
                target = miss; 
            }else{
                pesan="CLEAR!!"; 
            }

            Console.WriteLine(pesan);
            Console.WriteLine("----");
            return target;  
        } 

        //update tampilan area
        static char[,] updateArea(char[,] playArea, int[] tebakan, char Update){

            int baris = tebakan[0];  
            int kolom = tebakan[1];
            playArea[baris, kolom] = Update;
            return playArea;   
        }
        
        
    }
}
