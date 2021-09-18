using System;
using System.Collections.Generic;
using System.Text;

namespace Tasklar.Task13
{
    class Book
    {
        private string _name;
        public string Name 
        {
            get => _name;
            
               
            
            set
            {
                while(value.Length < 3)
                {
                    Console.WriteLine("Verilmish uzunluq yanlishdir :");
                    value = Console.ReadLine();
                }
                _name = value;
            }
        }
        private int _count;
        public int Count
        {
            get => _count;

            set
            {
                //Console.WriteLine("Kitabin Yoxdur");
                //string count = Console.ReadLine();
                //while (!int.TryParse(count, out value))
                //{
                //    Console.WriteLine("Kitabin sayi tam olmalidi");
                //    count = Console.ReadLine();
                //}
                _count = value;
                

                
            }

        }
        
        
        
        private int _pageCount;
        public int PageCount 
        {
            get => _pageCount;
            set
            {

                while(value <= 10)
                {
                    Console.WriteLine("Kitabda sehifelerin sayi 10 dan kicik ola bilmez :");
                    string pCount = Console.ReadLine();
                    while(!int.TryParse(pCount, out value))
                    {
                        Console.WriteLine("Kitabin Sehifeleri Tam Reqem Olmalidi :");
                        pCount = Console.ReadLine();
                    }
                }
                _pageCount = value;
            }
        }




        public Book(string name, int count)
        {
            Name = name;
            Count = count;

            //if(PageCount < 10)
            //{
            //    Console.WriteLine("Bele kitab yoxdur");
            //}
            //else if (name.Length < 3)
            //{
            //    Console.WriteLine("Bele kitab yoxdur");
            //}
        }

        
    }
}
