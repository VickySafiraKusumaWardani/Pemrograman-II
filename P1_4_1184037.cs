using System;
using System.Collections.Generic;
using System.Linq;
namespace safira
{
    public class P1_4_1184037
    {
        static void Main(string[] args)
        {
		// deklarasi
			float luaspersegipanjang,panjang,lebar;
			float keliling,panjang2,lebar2;
			float diagonal,panjang3,lebar3;
			int pilih;

		Console.WriteLine("MENU PERSEGI PANJANG KURNIA");
		Console.WriteLine("1.Hitung Luas");
		Console.WriteLine ("2.Hitung Keliling");
		Console.WriteLine ("3.Hitung Panjang Diagonal");
		Console.WriteLine ("================");

		Console.Write (" Menu Pilihan :");
		pilih = Convert.ToInt16(Console.ReadLine());
		switch(pilih)
		{
			case 1 :
			Console.Write ("masukan sisi panjang :");
			panjang = Convert.ToSingle(Console.ReadLine());
			Console.Write ("masukan sisi lebar :");
			lebar = Convert.ToSingle(Console.ReadLine());
			luaspersegipanjang= panjang*lebar;
			Console.Write("luas persegi panjang = "+ luaspersegipanjang);
			Console.ReadKey();
			break ;
			
			case 2 :
			Console.Write ("masukan sisi panjang :");
			panjang2 = Convert.ToSingle(Console.ReadLine());
			Console.Write ("masukan sisi lebar :");
			lebar2 = Convert.ToSingle(Console.ReadLine());
			keliling = 2*panjang2+2*lebar2;
			Console.Write("luas keliling persegi panjang = "+ keliling);
			Console.ReadKey();
			break;
			
			case 3 :
			Console.Write ("masukan sisi panjang :");
			panjang3 = Convert.ToSingle(Console.ReadLine());
			Console.Write ("masukan sisi lebar :");
			lebar3 = Convert.ToSingle(Console.ReadLine());
			diagonal= (panjang3*panjang3)+(lebar3*lebar3);
			Console.Write("luas diagonal persegi panjang = "+ diagonal);
			Console.ReadKey();
			break;

			case 4:
			Console.WriteLine("good");
			Console.ReadKey();
			break;

			default:
				Console.WriteLine("inputan anda salah silahkan ulangi !!");
				Console.ReadKey();
				//main();
				break;
			}
		}
	}
}