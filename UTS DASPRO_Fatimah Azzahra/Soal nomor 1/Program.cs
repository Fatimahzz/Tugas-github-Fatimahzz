using System;
using System.Collections.Generic;
using System.Text;
using System.IO;   

namespace UTSnosatu
{
    class Program 
    {
        public static void Main(string[] args){
            Console.Clear();
            Console.WriteLine("Nama            : ");
            string Nama = Console.ReadLine();
            Console.WriteLine("Nim             : ");
            string Nim = Console.ReadLine();
            Console.WriteLine("Konsentrasi     : ");
            string Konsentrasi = Console.ReadLine().ToUpper();
            teknikinformatika mhst = new teknikinformatika(Nama, Nim, Konsentrasi);
            mhst.printNameTag();
        }  
    }
    class teknikinformatika
    {
        string Nama;
        string Nim;
        string Konsentrasi;

        public teknikinformatika(string nama, string nim , string konsentrasi)
        {
            Nama = nama;
            Nim = nim;
            Konsentrasi = konsentrasi;
        }
        public void printNameTag()
        {
            Console.WriteLine();
            Console.WriteLine("|*********************************|");
            Console.WriteLine("{0,-16} {1,18}","|Nama :",Nama+"|");
            Console.WriteLine("{0,-16} {1,18}","|",Nim+"|");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine("{0, -16}{1,19}","|",Konsentrasi+"|"); 
            Console.WriteLine("|*********************************|");
        }
    }
}
