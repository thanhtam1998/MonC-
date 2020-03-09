/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 12/14/2019
 * Time: 9:41 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Thi_CKbai2
{
	class Program
	{
	
	struct HocSinh
        {
            public string Ten;
            public float Toan;
            public float Van;
        }
        static HocSinh Nhap()
        {
            HocSinh hs;
            Console.Write(" Nhap ten Hoc Sinh : \n");
            hs.Ten = Console.ReadLine();
            Console.Write(" Nhap Diem Toan   : \n");
            hs.Toan = int.Parse(Console.ReadLine());
            Console.Write(" Nhap Diem Van  : \n");
            hs.Van = int.Parse(Console.ReadLine());
            return hs;
        }
         static float TinhDiemTrungBinh(HocSinh hs)
        {
            float dtb = (hs.Toan + hs.Van) / 2;
            return dtb;
        }
         static void Xuat(HocSinh hs)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("***Ten hoc sinh:  {0,8} *********", hs.Ten);
            Console.WriteLine("***Diem Toan    :{0,8}   ********", hs.Toan);
            Console.WriteLine("***Diem Van :     {0,8} ********", hs.Van);
            Console.WriteLine("***Diem trung binh:{0,8} ********", TinhDiemTrungBinh(hs));
            
            Console.WriteLine("************************************");
            
        }
         // hoc sinh gioi toan --------------------------//
         static void hocsinhgioitoan(HocSinh hs)
         {  float dtb = TinhDiemTrungBinh(hs);
         		if (hs.Toan>8 && dtb>7)
         		    {
         		         Console.WriteLine("diem trung binh",hs.Ten);
         		    }
         }
         static void dshctoan (HocSinh hs){
         	Console.WriteLine("************************************");
         	Console.WriteLine("**hoc sinh gioi toan la {0}**",hs.Ten);
            Console.WriteLine("************************************");
            
         	
         }
      
        static void Main(string[] args)
        {
            int spt, i, tam = 0;
            HocSinh[] hs;
            do
            {
                Console.Write("Nhap so luong phan tu cua mang:  ");
                spt = int.Parse(Console.ReadLine());
                if (spt < 0 || spt > 10)
                {
                    Console.WriteLine("so luong phan tu cua mang khong hop le xin kiem tra lai !");
                }
            } while (spt < 0 || spt > 10);
            hs = new HocSinh[spt];

            //			Nhap hoc sinh
            for (i = 0; i < hs.Length; i++)
            {
                hs[i] = Nhap();
            }
            //			Xuat danh sach hoc sinh	
            for (i = 0; i < hs.Length; i++)
            {
                Xuat(hs[i]);
                
            }
            // danh sach gioi toan
             for (i = 0; i < hs.Length; i++)
            {
                dshctoan(hs[i]);
                
            }
            Console.ReadKey();
        }


	}
}