/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 11/12/2019
 * Time: 8:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Matran
{
	class Program
	{
		public static void Main(string[] args)
		{
			  int[,] mang=new int[100,100];
            int so;
            Console.Write("Ban muon nhap ma tran vuong cap may:");
            so = int.Parse(Console.ReadLine());
            //Nhap gia tri cho mang
            for (int i = 0; i < so; i++)//Phan tu dau tien bat dau =0
            {
                for (int j = 0; j < so; j++)
                {
                    Console.Write("Nhap phan tu dong {0} cot {1}:", i+1,j+1);
                    mang[i,j] = int.Parse(Console.ReadLine());
                }
             
            }
            //Xuat gia tri da nhap
            Console.WriteLine("Ma tran da nhap la:");
            for (int i = 0; i < so; i++)//Phan tu dau tien bat dau =0
            {
                for (int j = 0; j < so; j++)
                {
                    Console.Write("{0} ",mang[i, j]);
                }
                Console.WriteLine();
            }
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}