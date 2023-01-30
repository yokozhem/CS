// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 26. Программа проверяет пятизначное число на палиндромом. Например: 12321

int N=12321;
int d0,d1,d3,d4;
d0=N%10;
d1=N/10%10;
d3=N/1000%10;
d4=N/10000;

if(d0==d4 & d1==d3) System.Console.WriteLine("Число палиндром");
else System.Console.WriteLine("Увы, но ваше число не палиднром");


