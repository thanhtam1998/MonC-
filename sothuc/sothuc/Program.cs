/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 10/17/2019
 * Time: 10:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace sothuc
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a,b,c ;
			Console.WriteLine("nhap a ");
			a=int.Parse(Console.ReadLine());
			Console.WriteLine("nhap b ");
			b=int.Parse(Console.ReadLine());
			Console.WriteLine("nhap a ");
			c=int.Parse(Console.ReadLine());
			int  max =a  ;
			if (b>a) max =b;
			if (c>a) max=c ;	
			Console.WriteLine("So lon nhat la {0}",max);
			
			 //Khởi tạo biến x, y
			float  x = 0,y =0 ,A;
			 Console.WriteLine("nhap a ");
			x=float.Parse(Console.ReadLine());
			Console.WriteLine("nhap b ");
			y=float.Parse(Console.ReadLine());
			A = x*y ;
			if (A>0 )
			{
				Console.WriteLine("{0} va {1} cung dau", x, y);
			} else if(A>0)
			{
				Console.WriteLine("{0} va {1} trai dau", x, y);
			}
//			else
//       {
//        if (x == 0 && y == 0)
//        {
//            Console.WriteLine("khong xac dinh boi vi x = 0 va y = 0");
//        }
//        else if (x == 0)
//        {
//            Console.WriteLine("khong xac dinh boi vi x = 0");
//        }
//        else
//        {
    //        Console.WriteLine("khong xac dinh boi vi y = 0");
     //   }

  //  }//
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}