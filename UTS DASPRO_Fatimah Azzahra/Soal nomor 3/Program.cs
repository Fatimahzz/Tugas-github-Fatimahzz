using System;
using System.Text; 

namespace UTSnotiga
{
    class Program
    {
        static void Main(string[] args)
        {
            int hari = 0;
            int denda = 0;
            Console.Write("Input jumlah hari peminjaman buku : ");
            hari = Convert.ToInt32(Console.ReadLine());
            if ( hari > 30)
            {
                denda = ( hari - 30 ) * 30000 + 50000 + 400000;
                Console.WriteLine("Keanggotaan anda dibatalkan");
                Console.WriteLine("Total denda :Rp." +denda);
        
            }
            else if ( hari > 10 )
            {
                denda = ( hari - 10 ) * 20000 + 50000;
                Console.WriteLine("Total denda : Rp." +denda);
            }
            else if ( hari > 5 )
            {
                denda = ( hari -5 ) * 10000;
                Console.WriteLine("Total denda : Rp." +denda);
            }
            else 
            {
                Console.WriteLine("Total denda : Rp." +denda);
            }
            Console.ReadKey();
        }
    }
}
