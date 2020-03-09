/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 11/6/2019
 * Time: 12:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace baitap
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
				const int  Max = 100;
                double[] a = new double[Max]; // khai bao mang
                double n;//so luong phan tu cua mang 
                nhapmang(a,out n);
                xuatmang(a,n);
                sapxieptangdan(a,n);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void  nhapmang(double []a,out double n)
        {
            do{
                Console.Write("Nhap so thuc cua mang A[2,20] : ");
                n = double.Parse(Console.ReadLine());
                if(n < 3|| n>20)
                {
                    Console.WriteLine("so luong phan tu cua mang khong hop le xin kiem tra lai !");
                }
            }while(n<3||n>20);
          for (int i = 0; i < n; i++)
            {
            	do{
            		Console.WriteLine("NHAP A {0}",i);
            		a[i] =double.Parse(Console.ReadLine());
            		if(a[i]<-1000 ||a[i]>1000 )
            		{
            			Console.WriteLine("NHAP LAI");
            		}
            	}while(a[i]<-1000 ||a[i]>1000 );
               
          }
		}
          
       
		public static void xuatmang(double []a,double n)
        {
            for (int i = 0; i < n;i++)
            {
                Console.Write(a[i] );
            }
        }
		public static  void sapxieptangdan(double []a, double n )
		{
			for(int i =0 ;i<n-2 ;i++)
			{
				for (int j = i ; j<=n-1; j++)
				{
					Console.WriteLine("Tim gia vi tri  {0} ",i+1,j+1);
					if ((i%2==0 ) && (j%2==0))
					{
						if(a[i]>a[j])
						{
							Console.WriteLine("Sap tang da vi tri thu {0} va vi tri thu{1}");
							double t = a[i];
							a[i] = a[j] ;
							a[j]=t ;
						}else 
						{
							Console.WriteLine("hoan vi tri thu {0} va vi tri {1}",i+1,j+1);
							
						}
					}
				
			} 
		 
		}
	}
	}
}