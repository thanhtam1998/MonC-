/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 11/1/2019
 * Time: 11:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Thi_GK
{
	class Program
	{
		public static void Main(string[] args)
			
		{  
			//NhapXuatMangN() ;
			const int  Max = 100;
                double[] a = new double[Max]; // khai bao mang
                double n;//so luong phan tu cua mang 
                NhapMang(a,out n);
                XuatMang(a,n);
                int tam=0, dem=0;
                for (int i = 0; i < a.Length; i++){
                	if(i+1 < a.Length){
                		tam= i+1;
                	}
                	if((a[i] >0 && a[tam]>0)||(a[i] <0 && a[tam]<0)){
                		dem++;
                	}
                }
				
			Console.Write("so cap phan tu lientiep cung dau {0} ",dem);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void NhapMang(double []a,out double n)
        {
            // nhap so luong phan tu cua mang 
            do{
                Console.Write("Nhap so thuc: ");
                n = double.Parse(Console.ReadLine());
                if(n < 2|| n>20)
                {
                    Console.WriteLine("so luong phan tu cua mang khong hop le xin kiem tra lai !");
                }
            }while(n<2||n>20);
            //Duyet vong lap de nhap gia tri cho mang
            for (int i = 0; i < n; i++)
            {
            	do{
            		Console.WriteLine("NHAP A{0}",i);
            		a[i] =double.Parse(Console.ReadLine());
            		if(a[i]<-1000 ||a[i]>1000 )
            		{
            			Console.WriteLine("NHAP LAI");
            		}
            	}while(a[i]<-1000 ||a[i]>1000 );
               
            }
        }
 
        // ham xuat mang
        public static void XuatMang(double []a,double n)
        {
            for (int i = 0; i < n;i++)
            {
                Console.Write(a[i] + ", ");
            }
        }
   
		
	
      static void NhapXuatMangN()
		{
			int iN;	
			int [] A;
			int i;
			string sMessage = "";
			iN = InputInt("Nhap N so nguyen : ", 2, 20);
			A = new int[iN];
			for (i = 0; i < iN; i++) 
			{
				sMessage = String.Format("Nhap phan tu thu {0}",i+1);
				A[i] = InputInt(sMessage,-1000,1000);
			}
			WriteArray(A, iN);
			Console.WriteLine("Gia tri am lon nhat trong mang la: {0} tai vi tri {1}."
			                  ,KiemtraGiaTriAmLonNhat(A,iN),TimViTriGiaTriAmLonNhat(A,iN) + 1);
		}
      		
		static int KiemtraGiaTriAmLonNhat(int [] pA, int piN)
		{
			int i, iResult;
			iResult = pA[0];
			for (i = 0; i < piN; i++)
			{
				if(pA[i] > iResult )
				{
					iResult = pA[i];
				}
			}
			return iResult;
		}
		static int TimViTriGiaTriAmLonNhat(int [] pA, int piN)
		{
			int i, iResult;
			iResult = 0;
			for (i = 0; i < piN; i++)
			{
				if(pA[i]< pA[iResult])
				{
					iResult = i;
				}
			}
			return iResult;
		}
      static void WriteArray(int [] pA, int piN)
		{
			Console.Write("[");
			for (int i = 0; i < piN; i++) 
			{
				if(i<piN-1)
				{
					Console.Write("{0},", pA[i]);
				}
				else
				{
					Console.Write("{0}", pA[i]);
				}
			}
			Console.WriteLine("]");
		}
		static int InputInt(string psMessage, int piMin, int piMax)
		{
			int iResult = 0;
			do{
				Console.Write("{0} [{1},{2}]: ",psMessage,piMin,piMax);
				iResult = int.Parse(Console.ReadLine());
			}while (iResult < piMin || iResult > piMax) ;
			return iResult;
		}
		//---------------------------
	}
}