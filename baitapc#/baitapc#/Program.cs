/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 10/17/2019
 * Time: 8:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace baitapc_
{
	class Program
	{
		public static void Main(string[] args)
		{
			//hello
			Console.WriteLine ("What is your name ?");
			string name ;
			name = Console.ReadLine();
			   
			Console.WriteLine (" I'm {0} ",name );
			Console.WriteLine ("Welcome {0} ban can gi ?" ,name );
			
			// nhap so  kiem tra biet so chan hay le 
			Console.WriteLine ("NHAP SO N ");
			int N ;
			N=int.Parse(Console.ReadLine());
			if ( N%2 ==0 )
			{
				Console.WriteLine("{0}La so chan ");
			}
			else{
				Console.WriteLine("{0}La so chan ");
			}
			
			
			// VE  HINH CHU NHAT RONG RUOT 
			int n , m;
			Console.WriteLine("nhap chieu dai");
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("nhap chieu rong ");
			m = int.Parse(Console.ReadLine());
			for  (int i = 1 ; i<=m;i++ )
			{
				for ( int  j=1 ;j<=n ;j++)
				{
					if (i== 1 || i ==m ||j== n||j==1)
					{
						Console.Write ("*") ;
					}else 
					{
					Console.Write (" ") ;
					}
				}
				Console.WriteLine("") ;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}		 
	}
}