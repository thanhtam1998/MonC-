/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 10/26/2019
 * Time: 10:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Atm
{
	class Program
	{
		public static void Main(string[] args)
		{
			int amount = 1000, deposite ,withdraw ;
			int choice,pin = 0  ;
			Console.WriteLine("Nhập số tiền ");
			pin = int.Parse(Console.ReadLine());
			while(true){
				Console.WriteLine("***********Welcome to Atm service ***********");
				Console.WriteLine("1.Kiem tra so du \n");
			    Console.WriteLine("2.Rut  tien cash \n");
			    Console.WriteLine("3.tien mat\n");
			    Console.WriteLine("4.Quit\n");
			    Console.WriteLine("********************************************\n)");
			    Console.WriteLine("Enter your choice ");
			    choice=int.Parse(Console.ReadLine());
			    switch(choice)
			    {
			    		case 1 : Console.WriteLine("\n Balance in Rs :{0}",amount );
			    		break;
			   
			    		case 2 : Console.WriteLine("\n Enter  the Amoubt to Withdraw:");
			    		withdraw=int.Parse(Console.ReadLine());
			    		if (withdraw%100!=0 )
			    		{
			    			Console.WriteLine("\n Please enter the amunt in Multiples of 100 ");
			    			
			    		}else if(withdraw>(amount-500))
			    		{
			    			Console.WriteLine("\n Insufficient balance ");
			    			
			    		}else
			    		{
			    			amount =amount -withdraw;
			    			Console.WriteLine("\n please collect cash ");
			    			Console.WriteLine("\n your current balan is {0}  ",amount);
			    			
			    		}
			    		break;
			    	case 3 :  Console.WriteLine("\n Enter  the Amoubt to depocite:");
			    	deposite = int.Parse(Console.ReadLine());
			    	amount= amount+deposite;
			    		Console.WriteLine("\n your current balan is {0}  ",amount);
			    		break ;
			    		case 4 : Console.WriteLine("Thanks your , see yor atm " ); 
			    		break;
			    
			} Console.WriteLine("Thanks your , see yor atm " ); 
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}