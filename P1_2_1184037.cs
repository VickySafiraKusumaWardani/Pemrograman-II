using System;
using System.Collections.Generic;
using System.Linq;
namespace isam
{
    public class P1_2_1184037
    {
        static void Main(string[] args)
        {
            do
            {
             Console.Clear();

             Console.Write("\n MENETUKAN INDEKS PRESTASI MAHASISWA \n");
             Console.Write("\n Masukkan Nama Mahasiswa: ");

             String nama = Console.ReadLine();

             Console.WriteLine("Masukan Nilai : ");

             int nilai = Convert.ToInt16(Console.ReadLine());

             String[] grade = {"A","B","C","D","E"};

             if(nilai >= 85)
			 {
                Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[0]);
			 }
				else if(nilai >= 70 && nilai < 85 )
             {
                Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[1]);
             }
             else if(nilai >= 60 && nilai < 70 )
             {
                Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[2]);
             }
             else
             {
                Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[3]);
             }

             Console.Write("\n Masukkan index yang akan ditampilkan : ");
             char indeks = Convert.ToChar(Console.ReadLine());
             Console.Write("Indeks prestasi {0} adalah", nama );

             prestasi(indeks);

             Console.Write("Ingin mangulang kembali (Y/T)?");
            }
			
			while (Console.ReadLine() == "Y");
        }
		
        private static void prestasi(char indeks)
        {
            switch (indeks)
            {
                case 'A':
					Console.WriteLine("Sangat Baik");
					break;
                case 'B':
					Console.WriteLine("Baik");
					break;
                case 'C':
					Console.WriteLine("Sedang");
					break;
                case 'D':
					Console.WriteLine("Buruk");
					break;
                case 'E':
					Console.WriteLine("Sangat Buruk");
					break;
                default:
					Console.WriteLine("invalid indeks prestasi");
					break;
            }
        }
    }
}