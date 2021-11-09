using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
class P_3_1184037
{
static void Main(string[] args)
{
Console.WriteLine("Program Menghitung Anak Ayam");
double A,i,key;
Console.Write("\n");
A = double.Parse(System.Console.ReadLine());
for(i=A;i>1;i--){
	System.Console.WriteLine("\nAnak Ayam Turunlah "+A.ToString());
	A=A-1;
	System.Console.WriteLine("\nMati Satu Tinggalah "+A.ToString());
}
Console.WriteLine("\nAnak Ayam turun 1, Mati Satu Tinggal Induknya");
key = System.Console.Read();
}
}
}