using System;
using System.Globalization;
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks; 

namespace SESI_4___Assesment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("selamat datang di assigment 1");
            Console.WriteLine("=============================");
            Console.WriteLine("nama lengkap saya : muhammad fauzaan irsyaadi");
            Console.WriteLine("nomor peserta : FSDO001ONL025");
            Console.WriteLine("alamat : banyumas");
            Console.WriteLine("=============================");
            Console.WriteLine("pilih menu soal :");
            Console.WriteLine("1. segitiga alfabet");
            Console.WriteLine("2. Segitiga angka");
            Console.WriteLine("3. program factorial");
            Console.WriteLine("4. balik angka");
            Console.WriteLine("5. convert angka ke string");
            Console.WriteLine("6. polindrome");

            string ulang;

            do
            {
                isValid = true;
                int input;
                Console.WriteLine("masukan nomor pilihan anda (1-6) :");
                input = Convert.ToInt(Console.ReadLine());
                Console.WriteLine("go to program");
                switch(input)    
                {
                    case 1:{
                        Console.WriteLine("test");
                        // number1;
                        break;
                    }
                    case 2:{
                        Console.WriteLine("test");
                        // number2;
                        break;
                    }
                    case 3:{
                        Console.WriteLine("test");
                        // number3;
                        break;
                    }
                    case 4:{
                        Console.WriteLine("test");
                        // number4;
                        break;
                    }
                    case 5:{
                        Console.WriteLine("test");
                        // number5;
                        break;
                    }
                    case 6:{
                        Console.WriteLine("test");
                        // number6;
                        break;
                    }
                    default: 
                        Console.WriteLine("masukan salah !");
                        isValid = false;
                }
                Console.Write("Apakah Anda Ingin Mengulang [Y/T]? ");
                ulang = Console.ReadLine();
            } while (ulang == "Y" || ulang == "y");
            
            
        }

        // public static void number1(){
        //     char ch='A';      
        //     int i, j, k, m;
        //     Console.WriteLine("masukan nilai : ");
        //     int max = Convert.ToInt(Console.ReadLine());      
        //     for(i=1; i<=max; i++)      
        //     {      
        //         for(j=max; j>=i; j--)      
        //         Console.Write(" ");      
        //         for(k=1;k<=i;k++)      
        //         Console.Write(ch++);      
        //         ch--;      
        //         for(m=1;m<i;m++)      
        //         Console.Write(--ch);      
        //         Console.Write("\n");      
        //         ch='A';      
                    
        //     }
        // }
        
        // public static void number2(){
        //     int  i,j,k,l,n;           
        //     Console.Write("Enter the Range=");    
        //     n= int.Parse(Console.ReadLine());     
        //     for(i=1; i<=n; i++)      
        //     {          
        //         for(j=1; j<=n-i; j++)      
        //         {      
        //         Console.Write(" ");      
        //         }      
        //         for(k=1;k<=i;k++)      
        //         {      
        //         Console.Write(k);      
        //         }      
        //         for(l=i-1;l>=1;l--)      
        //         {      
        //         Console.Write(l);      
        //         }      
        //         Console.Write("\n"); 
        //     }   
        // }

        // public static void number3(){
        //     int i,fact=1,number;      
        //     Console.Write("Enter any Number: ");      
        //     number= int.Parse(Console.ReadLine());     
        //     for(i=1;i<=number;i++){      
        //         fact=fact*i;      
        //     }      
        //     Console.Write("Factorial of " +number+" is: "+fact);   
        // }

        // public static void number4(){
        //     int  n, reverse=0, rem;           
        //     Console.Write("Enter a number: ");      
        //     n= int.Parse(Console.ReadLine());     
        //     while(n!=0)      
        //     {      
        //         rem=n%10;        
        //         reverse=reverse*10+rem;      
        //         n/=10;      
        //     }      
        //     Console.Write("Reversed Number: "+reverse);  
        // }

        // public static void number5(){
        //     int n,sum=0,r;     
        //     Console.Write("Enter the Number= ");    
        //     n= int.Parse(Console.ReadLine());     
        //     while(n>0)      
        //     {      
        //         r=n%10;      
        //         sum=sum*10+r;      
        //         n=n/10;      
        //     }      
        //     n=sum;      
        //     while(n>0)      
        //     {      
        //         r=n%10;      
        //         switch(r)      
        //         {      
        //         case 1:      
        //         Console.Write("one ");  
        //         break;      
        //         case 2:      
        //         Console.Write("two ");      
        //         break;      
        //         case 3:      
        //         Console.Write("three ");    
        //         break;      
        //         case 4:      
        //         Console.Write("four ");    
        //         break;      
        //         case 5:      
        //         Console.Write("five ");    
        //         break;      
        //         case 6:      
        //         Console.Write("six ");     
        //         break;      
        //         case 7:    
        //         Console.Write("seven ");    
        //         break;    
        //         case 8:      
        //         Console.Write("eight ");      
        //         break;      
        //         case 9:      
        //         Console.Write("nine ");    
        //         break;      
        //         case 0:      
        //         Console.Write("zero ");    
        //         break;      
        //         default:      
        //         Console.Write("tttt ");      
        //         break;      
        //         }//end of switch      
        //         n=n/10;      
        //     }
        // }
        
        // public static void number6(){
        //     string string1, rev;
        //     Console.Write("enter your text : ");
        //     string1 = Console.ReadLine();
        //     char[] ch = string1.ToCharArray();
        //     Array.Reverse(ch);
        //     rev = new string(ch);
        //     bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
        //     if (b == true) {
        //         Console.WriteLine("" + string1 + " is a Palindrome!");
        //     } else {
        //         Console.WriteLine(" " + string1 + " is not a Palindrome!");
        //     }
        //     Console.Read(); 
        // }
            

    }
}


