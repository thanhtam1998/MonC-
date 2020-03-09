/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 10/24/2019
 * Time: 12:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Baitaptuan12
{
	class Program
	{
		public static void Main(string[] args)
		{
		   string pdMessage ="NHap so thuc" ;
	       double Min =-1000;
	      double Max =1000;
	       InputDouble(pdMessage,Min,Max);
//	     double n;
//	     Inputdoub(out n );
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void  InputDouble(string pdMessage ,double Min  ,double Max )
		{
			Console.WriteLine(pdMessage);
			double d = double.Parse(Console.ReadLine());
		if(d<=Min ||d>=Max )
				Console.WriteLine("KQ :{0}",d);
		}
		// Cách 2 ----------------------------------------------------------------------
//		public static void Inputdoub(out double n )
//		{
//			do{
//				Console.WriteLine("nhap so n ");
//				n=double.Parse(Console.ReadLine());
//				if(n<=-1000 || n>1000 ){
//					Console.WriteLine("so nhap qua gioi han");
//				}
//			}while(n<=-1000 || n>1000);
//				Console.WriteLine("KQ :{0} ",n);
//		}
		
	}
}