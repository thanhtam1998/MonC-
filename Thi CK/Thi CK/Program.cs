		/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 12/12/2019
 * Time: 10:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Thi_CK
{
	class Program
	{
		public static void Main(string[] args)
		{
		
			bai1();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static  void  bai1()
	    {
				int spt,i,j,t;
			do{
                Console.Write("Nhap so luong phan tu cua mang so:  ");
                spt = int.Parse(Console.ReadLine());
                if(spt < 3 || spt>10)
                {
                    Console.WriteLine("so luong phan tu cua mang khong hop le xin kiem tra lai !");
                }
            }while(spt<3||spt>10);
			
			int[,] N;
			int tong = 0;
			N = new int[spt, spt];
			Random rd = new Random();
			for (i = 0; i < spt; i++)
                {
                    for (j = 0; j < spt; j++)
                    {
                    	N[i,j] = rd.Next(-1000,1000);
                    }
                }
		WriteArray(N,spt,spt);
			
			Console.WriteLine("tim so nho nhat cua  ma tran tam giac tren");
			//ma tran tren
			int min = N[0,0];
			for (i = 0; i < spt; i++)
                {
                    for (j = 0; j < spt; j++)
                    {
                    	if(i + j >= spt-1) //khong bao gom duong cheo (neu bao gom thi <=)
                    	{
                    		if(min > N[i,j]){
                    			min = N[i,j];
                    		}
                    	   	
                    	}else{
                    		Console.Write("        ");
                    	}
                    }
                    Console.WriteLine();
                }
			Console.WriteLine("so nho nhat cua  ma tran tam giac tren la : {0}",min);
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