/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 11/20/2019
 * Time: 3:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cautruc
{
	class Program
	{
		public static void Main(string[] args)
		{
			NHAPDIEM();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static Diem NHAPDIEM()
	{
		Diem dResult ;
		Console.WriteLine("Nhap diem x");
		dResult.X= double.Parse(Console.ReadLine());
		Console.WriteLine("Nhap diem Y");
		dResult.Y= double.Parse(Console.ReadLine());
		return dResult ;
	}
		static void xuatdiem(){
			
		}
	}
	
	struct Diem
	{
		public double X;
		public double Y;
	}
	struct NHAPDIEM
	{
		
	}
	
}