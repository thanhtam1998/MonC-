/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 12/7/2019
 * Time: 8:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Matranvuongandtamgiac
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
                }
			Console.WriteLine("Tong cac phan tu ma tran tren la: {0}", tong);
			//sap xep
			for (i = 0; i < sopt-1; i++)
                {
                    for (j = i+1; j < sopt; j++)
                    {
                    	if(A[i,i]>A[j,j])
                    	{
                    		t= A[i,i];
                    		A[i,i] = A[j,j];
                    		A[j,j] = t;
                    	}
                    	
                    	//sap xep duong cheo phu
                    	if(A[i,sopt-i -1]>A[j,sopt-j-1])
                    	{
                    		t= A[i,sopt-i -1];
                    		A[i,sopt-i -1] = A[j,sopt-j-1];
                    		A[j,sopt-j-1] = t;
                    	}
                    }
                    Console.WriteLine();
                }
			
			//duong cheo chinh tang dan
			Console.WriteLine("duong cheo chinh tang dan");
			for (i = 0; i < sopt; i++)
                {
                    for (j = 0; j < sopt; j++)
                    {
                    	if(i == j) //khong bao gom duong cheo (neu bao gom thi <=)
                    	{
                    	   	Console.Write("{0,8}", A[i,j]);
                    	   	
                    	}else{
                    		Console.Write("        ");
                    	}
                    }
                    Console.WriteLine();
                }
			
			//duong cheo phu tang dan
			Console.WriteLine("duong cheo phu tang dan");
for (i = 0; i < sopt; i++)
                {
                    for (j = 0; j < sopt; j++)
                    {
                    	if(i+j == sopt-1)
                    	{
                    	   	Console.Write("{0,8}", A[i,j]);
                    	   	
                    	}else{
                    		Console.Write("        ");
                    	}
                    }
                    Console.WriteLine();
                }
			
			
			Console.ReadKey(true);
		}
		static void WriteArray(int [,] pA, int pN, int pM)
		{
			for (int i = 0; i < pN; i++) 
			{
				for (int j = 0; j < pM; j++) {
					
					if(j<pM-1)
					{
						Console.Write("{0,8}", pA[i,j]);
					}
					else
					{
						Console.Write("{0,8}", pA[i,j]);
						
					}
				}
				Console.WriteLine();

			}
		}
	}
}