
/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 10/10/2019
 * Time: 8:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace xuatmag
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			baixuatmang ();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static  void  baixuatmang()
		{
			int iN ;
			int [] A;
			int i ; 
			string smes="";
			iN = 	InputInt("Nhap N", 3, 20);
			A = new int[iN] ;
			for (i=0 ;i<iN;i++)
			{
				smes=string.Format("Nhap phan  tu {0}",i+1);
				A[i] = InputInt(smes,1,100);
			}WriteArray(A,iN);
			Console.WriteLine("");
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
		static int  InputInt(string psMessage, int piMin, int piMax)
		{
			
			int iResult = 0;
			do{
				Console.Write("{0} [{1},{2}]: ",psMessage,piMin,piMax);
				iResult = int.Parse(Console.ReadLine());
			}while (iResult < piMin || iResult > piMax) ;
			return iResult  ;
			
		}
	}
}