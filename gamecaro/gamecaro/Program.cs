/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 3/2/2020
 * Time: 11:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace gamecaro
{
	class Program
	{
		public static void Main(string[] args)
		{
			int sopt,i,j,t;
			do{
                Console.Write("Nhap so luong phan tu cua mang so:  ");
                sopt = int.Parse(Console.ReadLine());
                if(sopt < 3 || sopt>10)
                {
                    Console.WriteLine("so luong phan tu cua mang khong hop le xin kiem tra lai !");
                }
            }while(sopt<3||sopt>10);
			
			int[,] A;
			int tong = 0;
			A = new int[sopt, sopt];
			Random rd = new Random();
			for (i = 0; i < sopt; i++)
                {
                    for (j = 0; j < sopt; j++)
                    {
                    	A[i,j] = rd.Next(-1000,1000);
                    }
                }
			WriteArray(A,sopt,sopt);
			
			Console.WriteLine("Xuat ma tran tren");
			//ma tran tren
			for (i = 0; i < sopt; i++)
                {
                    for (j = 0; j < sopt; j++)
                    {
                    	if(i + j < sopt-1) //khong bao gom duong cheo (neu bao gom thi <=)
                    	{
                    	   	Console.Write("{0,8}", A[i,j]);
                    	   	tong = tong + A[i,j];
                    	   	
                    	}else{
                    		Console.Write("        ");
                    	}
                    }
                    Console.WriteLine();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}