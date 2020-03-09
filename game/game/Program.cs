﻿/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 2/27/2020
 * Time: 5:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace game
{
	class Program
	{
		public static void Main(string[] args)
		{
			#include<iostream>
#include<windows.h>
#include<conio.h>

using namespace std;

#define UP   119  // w
#define DOW  115  // s
#define LE   97   // a
#define RI   100  // d
#define OK   13   // enter

int a[100][100];
int luot = 0;
int x = 12;
int y = 6;
int p1 = 0;
int p2 = 0; // p1,p2 la ti so cua 2 player
int thaydoiluot = 0;

struct ToaDo{
 int x;
 int y;
};
ToaDo mang[4];

void txtColor(int color);
void gotoxy(int x,int y);
void khung();
void play();
int thang();
void tiso();
void khungtiso();
void huongdan();

int main(){
 SetConsoleTitle("Game : Ca-ro . Developer : Nguyen Dinh Tuan");
 khung();
 khungtiso();
 gotoxy(x,y);
 play();
 getch();
 return 0;
}

void txtColor(int color)
{
 SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), color);
}

void gotoxy(int x, int y)
{
 COORD coord;
 coord.X = x;
 coord.Y = y;
 SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

void start(){
 for(int i=0 ;i<100 ;i++){
  for(int j=0 ;j<100 ;j++){
   a[i][j] = 0;
  }
 }
}

void khung(){
 int d=1;
 txtColor(6);
 for(int i=0 ;i < 40;i++){
  gotoxy(10+i,3);
  cout << char(220);
  gotoxy(10+i,20);
  cout << char(223);
 }
 for(int i=4 ;i<=19 ;i++){
  gotoxy(10,i);
  cout << char(219);
  gotoxy(49,i);
  cout << char(219);
 }
 int k=1;
 for(int i=11; i<=48 ;i++){
  for(int j=4 ;j<=19 ;j++){
   if(i%2==0){
    if(j%2==0){
     gotoxy(i,j);
     txtColor(0);
     cout << char(219);
    }
    else{
     gotoxy(i,j);
     txtColor(7);
     cout << char(219);
    }
   }
   else{
    if(j%2==0){
     gotoxy(i,j);
     txtColor(7);
     cout << char(219);
    }
    else{
     gotoxy(i,j);
     txtColor(0);
     cout << char(219);
    }
   }
  }
 }
 txtColor(14);
 gotoxy(10,21);
 cout << "Developer : Nguyen Dinh Tuan . ";
 gotoxy(10,22);
 cout << "Mail      : theiron1997@gmail.com";
 huongdan();
}

void play(){
 tiso();
 gotoxy(x,y);
 //int (*fthang)() = thang;
 if(thang()){
  gotoxy(10,1);
  cout << "                                                              ";
  gotoxy(10,1);
  cout << "Nguoi choi " << thang() << " da thang.";
  if(thang()==1) p1++; else p2++;
  for(int k = 0;k<4 ;k++){
   gotoxy(mang[k].x,mang[k].y);
   txtColor(13);
   if(thang()==1){
    cout << "o";
   }
   else{
    cout << "x";
   }
  }
  getch();
  gotoxy(10,1);
  cout << "                                                  ";
  gotoxy(10,1);
  cout << "Co muon tiep tuc danh (c/k)";
  char ch = getch();
  if((ch=='c')||(ch=='C')){
   gotoxy(10,1);
   thaydoiluot++;
       if(thaydoiluot%2==0) luot = 0;
       else luot = 1;
      cout << "                                  ";
   start();
   khung();
   khungtiso();
   gotoxy(x,y);
   play();
  }
  else{
   exit(0);
  }
  
 }
 char ch = getch();
 // Nen su dung switch();
 if(ch==104){
  
  txtColor(10);
  if(luot%2==0){ // nguoi 2 cau hoa
   gotoxy(15,1);
   cout << "Nguoi choi 2 co dong y khong ? c/k";
   char CHAR = getch();
   if((CHAR=='c')||(CHAR=='C')){
    gotoxy(10,1);
       thaydoiluot++;
       if(thaydoiluot%2==0) luot = 0;
       else luot = 1;
          cout << "                                                 ";
       start();
       khung();
       khungtiso();
       gotoxy(x,y);
       play();
   }
   else{
   gotoxy(15,1);
   cout << "                                              ";
   gotoxy(15,1);
   cout << "Nguoi choi 2 khong dong y ";
   gotoxy(15,1);
   getch();
   cout << "                                        ";
   //gotoxy(15,1);
   //system("pause");
   
   cout << "                                                                     ";
      }
  }
  else{
   gotoxy(15,1);
   cout << "Nguoi choi 1 co dong y khong ? c/k";
   char CHAR = getch();
   if((CHAR=='c')||(CHAR=='C')){
    gotoxy(10,1);
       thaydoiluot++;
       if(thaydoiluot%2==0) luot = 0;
       else luot = 1;
          cout << "                                                  ";
       start();
       khung();
       khungtiso();
       gotoxy(x,y);
       play();
   }
   else{
   gotoxy(15,1);
   cout << "                                              ";
   gotoxy(15,1);
   cout << "Nguoi choi 1 khong dong y . ";
   getch();
   gotoxy(15,1);
   cout << "                                        ";
   gotoxy(15,1);
   //system("pause");
   //getch();
   //gotoxy(15,1);
   cout << "                                                                     ";
      }
  
         }
    }
 if(ch==116){
  if(luot%2==0){
   gotoxy(15,1);
   txtColor(10);
   cout << "Nguoi choi 1 da thua ";
   getch();
   p2++;
   gotoxy(10,1);
   //luot = 0; // <- nen nang cap cho nay
   thaydoiluot++;
       if(thaydoiluot%2==0) luot = 0;
       else luot = 1;
      cout << "                                  ";
   start();
   khung();
   khungtiso();
   gotoxy(x,y);
   play();
  }
  else{
   gotoxy(15,1);
   txtColor(10);
   cout << "Nguoi choi 2 da thua ";
   getch();
    p1++;
   gotoxy(10,1);
   //luot = 0; // <- nen nang cap cho nay
   thaydoiluot++;
       if(thaydoiluot%2==0) luot = 0;
       else luot = 1;
      cout << "                                  ";
   start();
   khung();
   khungtiso();
   gotoxy(x,y);
   play();
  }
 }
 if(ch==UP){
  if(y<=4){
   y = 19;
   gotoxy(x,y);
   play();
  }
  else{
   y--;
   gotoxy(x,y);
   play();
  }
 }
 if(ch==27){
  gotoxy(15,0);
  cout << "Ban co muon thoat c/k";
  char C = getch();
  if((C=='c')||(C=='C')){
   exit(0);
  }
  else{
   gotoxy(15,0);
      cout << "                                ";
  }
 }
 if(ch==DOW){
  if(y>=19){
   y = 4;
   gotoxy(x,y);
   play();
  }
  else{
   y++;
   gotoxy(x,y);
   play();
  }
 }
 if(ch==RI){
  if(x>=48){
   x = 11;
   gotoxy(x,y);
   play();
  }
  else{
   x++;
   gotoxy(x,y);
   play();
  }
 }
 if(ch==LE){
  if(x<=11){
   x = 48;
   gotoxy(x,y);
   play();
  }
  else{
   x--;
   gotoxy(x,y);
   play();
  }
 }
 if(ch==OK){
  // Neu ma da co gia tri
  if(a[x][y]!=0){
   gotoxy(15,1);
   txtColor(10);
   cout << "O nay khong trong. Ban hay chon o khac ...";
   getch();
   gotoxy(15,1);
   cout << "                                            ";
   gotoxy(x,y);
   play();
  }
  // luc nay da chon o khong co gia tri
  luot++;
  if(luot%2==0){  // luot nguoi 2
       a[x][y] = 2;
       gotoxy(x,y);
       txtColor(10);
       cout << "x";
       gotoxy(15,1);
       txtColor(11);
       cout << "Den luot nguoi 1 - " ;
       txtColor(12);
       cout << "o";
       play();
  }
  else{ // luot nguoi 1
   a[x][y] = 1 ;
   gotoxy(x,y);
   txtColor(12);
   cout << "o";
   gotoxy(15,1);
   txtColor(11);
      cout << "Den luot nguoi 2 - " ;
      txtColor(10);
      cout << "x";
   play();
  }
 }
 play(); // luc an phim khac
}
int thang(){
 int Thang = 1; // thang . 0 la chua thang
 for(int i=1 ;i<=50 ;i++){
  for(int j=1 ;j<=50 ;j++){
   
   if((a[i][j]==a[i+1][j])&&(a[i][j]==a[i+2][j])&&(a[i][j]==a[i+3][j])/*&&(a[i+4][j]==a[i][j])*/&&(a[i][j]!=0)){
    Thang = 1;
    for(int h=0;h<=50 ;h++){
     if(i-h <= 1){
      break;
     }
     else{
      if ((a[i - h][j] != a[i][j]) && (a[i - h][j] != 0)){
       Thang = 0;
       break;
      }
     }
    }
    for(int h=0;h<=50 ;h++){
     if(i+h >= 50){
      break;
     }
     else{
      if ((a[i + h + 3][j] != a[i][j]) && (a[i + h + 3][j] != 0)){
       Thang = 0;
       break;
      }
     }
    }
    if(Thang==1){
     for(int k=0 ;k<4 ;k++){
      mang[k].y = j;
      mang[k].x = i+k; 
     }
     return a[i][j];
    } 
   }
   if((a[i][j]==a[i][j+1])&&(a[i][j]==a[i][j+2])&&(a[i][j]==a[i][j+3])/*&&(a[i][j]==a[i][j+4])*/&&(a[i][j]!=0)){
    Thang = 1;
    for(int h=0 ;h<=50 ;h++){
     if(j+h>=50){
      break;
     }
     else{
      if((a[i][j+3+h]!=0)&&(a[i][j+3+h]!=a[i][j])) Thang = 0;
     }
    }
    for(int h=0 ;h<=50 ;h++){
     if(j-h<=1){
      break;
     }
     else{
      if((a[i][j-h]!=0)&&(a[i][j-h]!=a[i][j])) Thang = 0;
     }
    }
    if(Thang==1){
     for(int k=0 ;k<4 ;k++){
      mang[k].x = i;
      mang[k].y = j+k; 
     }
     return a[i][j];
    } 
   }
   if((a[i][j]==a[i+1][j+1])&&(a[i][j]==a[i+2][j+2])&&(a[i][j]==a[i+3][j+3])/*&&(a[i][j]==a[i+4][j+4])*/&&(a[i][j]!=0)){
    Thang = 1;
    for(int h=0; h<=50 ;h++){
     if((i+h>=50)||(j+h)>=30) break;
     else{
      if((a[i+h+3][j+h+3]!=a[i][j])&&(a[i+h+3][j+h+3]!=0)) Thang = 0;
     }
    }
    for(int h=0; h<=50 ;h++){
     if((i-h<=1)||(j-h)<=1) break;
     else{
      if((a[i-h][j-h]!=a[i][j])&&(a[i-h][j-h]!=0)) Thang = 0;
     }
    }
    if(Thang==1){
     for(int k=0 ;k<4 ;k++){
      mang[k].x = i+k;
      mang[k].y = j+k; 
     }
     return a[i][j];
    } 
   } 
   if((a[i][j]==a[i-1][j+1])&&(a[i][j]==a[i-2][j+2])&&(a[i][j]==a[i-3][j+3])/*&&(a[i][j]==a[i-4][j-4])*/&&(a[i][j]!=0)){
    Thang = 1;
    for(int h=1; h<=50 ;h++){
     if((i+h>=50)||(j-h)<=1) break;
     else{
      if((a[i+h][j-h]!=a[i][j])&&(a[i+h][j-h]!=0)) Thang = 0;
     }
    }
    for(int h=0; h<=50 ;h++){
     if((i-h<=1)||(j+h)>=50) break;
     else{
      if((a[i-4-h][j+h+4]!=a[i][j])&&(a[i-h-4][j+h+4]!=0)) Thang = 0;
     }
    }
    if(Thang==1){
     for(int k=0 ;k<4 ;k++){
      mang[k].x = i-k;
      mang[k].y = j+k; 
     }
     return a[i][j];
    } 
   } ;
  }
 }
 
 return 0;
}

void khungtiso(){
 gotoxy(52,3);
 txtColor(10);
 cout << char(220) << char(220) << char(220) << char(220) << char(220) << char(220) << char(220) << char(220) ;
 txtColor(13); 
 cout << " Ti so ";
 txtColor(10);
 cout  << char(220)  << char(220) << char(220) << char(220) << char(220) << char(220) << char(220);
 gotoxy(54,4);
 txtColor(14);
 cout << "player1    player2";
 
 for(int i=0; i<=21 ;i++){
  gotoxy(52+i,4+18);
  txtColor(10);
  cout << char(223);
 }
 for(int i=4 ; i<= 21 ;i++){
  gotoxy(52,i);
  cout << char(219);
  gotoxy(52+16+5,i);
  cout << char(219);
  gotoxy(52+8+2,i);
  cout << char(219);
 } 
 tiso();
}
void tiso(){
 for(int i=0 ;i < p1 ;i++){
  gotoxy(52+2,6+i);
  txtColor(12);
  cout << "o";
 }
 for(int i=0 ;i < p2 ;i++){
  gotoxy(52+13,6+i);
  txtColor(11);
  cout << "x";
 }
}
void huongdan(){
 txtColor(10);
 gotoxy(1,0);
 txtColor(9);
 cout << "Esc - Thoat";
 txtColor(10);
 gotoxy(1,3);
 cout << "a : " << char(283);
 gotoxy(1,4);
 cout << "d : " << char(282);
 gotoxy(1,5);
 cout << "w : " << char(280);
 gotoxy(1,6);
 cout << "s : " << char(281);
 gotoxy(1,8);
 txtColor(13);
 cout << "t : xin ";
 gotoxy(1,9);
 txtColor(13);
 cout << "    thua";
 gotoxy(1,10);
 txtColor(10);
 txtColor(13);
 cout << "h : cau ";
 gotoxy(1,11);
 
 cout << "    hoa";
 
}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}