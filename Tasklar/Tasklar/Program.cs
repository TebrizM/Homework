using System;
using Tasklar.Task11;
using Tasklar.Task12;
using Tasklar.Task13;
using Tasklar.Task14;


namespace Tasklar
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = { 25, 8, 10, 55, 36 };
            //int[] arr2 = { 2, 3, 4, 56, 34, 54, 5, 6, 7, 6, 894 };
            //string str = "Musa, Resad, Nazim, Eltur";
            //int b = 5;
            #region Task - 11:
            //string Username = Console.ReadLine();
            //string Password = Console.ReadLine();
            //User user = new User(Username);
            //user.Password = Password;
            //Console.WriteLine(user.Username+ " " + user.Password);
            //Console.ReadLine();
            #endregion

            #region Task - 12:
            //Milk milk = new Milk("Resad", 5.5, 5, 5, 2.5);
            //Console.WriteLine(milk.count);

            //milk.Sell();
            //milk.Sell(); 
            //milk.Sell(); 
            //milk.Sell();
            //milk.Sell();
            //milk.Sell();
            //Console.WriteLine(milk.count);
            //Console.WriteLine(milk.totalincome);
            #endregion

            #region Task - 13:
            //Book[] books = new Book[10];

            //int Check = 0;
            //while (books[books.Length - 1] == null)
            //{
            //    Console.WriteLine("Kitabin adini Daxil Edin :");

            //    string name = Console.ReadLine();
            //    Console.WriteLine("Kitabin Sayini Daxil Edin :");
            //    string count = Console.ReadLine();
            //    int icount;

            //    while (!int.TryParse(count, out icount))
            //    {
            //        Console.WriteLine("Kitabin sayi tam olmalidi");
            //        count = Console.ReadLine();
            //    }
            //    Book book = new Book(name, icount);

            //    Console.WriteLine("Kitabin Sehifelerinin Sayini Daxil Edin :");
            //    string pagecount = Console.ReadLine();
            //    int iPagecount;

            //    while (!int.TryParse(pagecount, out iPagecount))
            //    {
            //        Console.WriteLine("Kitabin Sehifelerinin sayi tam olmalidi");
            //        pagecount = Console.ReadLine();
            //    }
            //    book.PageCount = iPagecount;
            //    books[Check] = book;

            //    Check++;

            //}
            //foreach (Book item in books)
            //{
            //    Console.WriteLine($"{item.Name} {item.PageCount}");
            //}
            #endregion

            #region Task - 14:

            //Console.WriteLine("Group limiti teyin edin:");
            //int limit = int.Parse(Console.ReadLine());
            //int choose;
            //Group group = new Group(limit);
            //do
            //{

            //    AddStudent( group);
            //    GetStudents( group);


            //    static void AddStudent( Group group)
            //    {
            //        Console.WriteLine("Add Group: ");
            //        if (group.students.Length < group.groupLimit)
            //        {
            //            group.AddStudent();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Group is Full: ");
            //        }
            //    }

            //    static void GetStudents(Group group)
            //    {
            //        Console.WriteLine("Students");
            //        group.GetStudents();
            //    }

            //    choose = int.Parse(Console.ReadLine());
            //} while (choose != 0);

            #endregion

            #region Task - 15:

            #endregion





        }
        #region  Task - 1:
        //Ədədin istənilən qüvvətini tapan alqoritmi qurmaq.
        //static void numpower()

        //{
        //    int a = 4;
        //    int p = 6;
        //    int res = 1;
        //    for(int i = 0; i<p; i++)
        //    {
        //        res = res * a;

        //    }
        //    Console.WriteLine(res);


        //}






        #endregion

        #region Task - 2:
        //Array-də(minimum 5 element olsun) cüt ədədlərlə tək ədədlərin fərqini tapan algorithmi qurun;
        //static void Oddeven(int[] arr1)
        //{
        //    int odd = 0;
        //    int even = 0;

        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        if (arr1[i] % 2 == 0)
        //        {
        //            even += arr1[i];
        //        }
        //    }
        //    if(even > odd)
        //    {
        //        Console.WriteLine("Aralarindaki Ferq :" + (even - odd));
        //    }
        //    else
        //    {
        //        Console.WriteLine("Aralarindaki Ferqi :" + (odd - even));
        //    }


        //}
        #endregion

        #region Task - 3:
        //Array-də(minimum 5 element olsun) 3 rəqəmli ədədlərlə digər ədədlər arasındakı fərqi tapan algorithmi qurun;
        //static void Ucreqemli(int[] arr1)

        //{
        //    int ucreqemli = 0;
        //    int othernumb = 0;

        //    foreach (int item in arr1)
        //    {
        //        if(100 < item && item < 999)
        //        {
        //            ucreqemli += item;

        //        }
        //        else
        //        {
        //            othernumb += item;
        //        }
        //    }
        //    if (ucreqemli > othernumb)
        //    {
        //        Console.WriteLine("Difference between 3-digit numbers and others is: " + (ucreqemli - othernumb));
        //    }
        //    else
        //    {
        //        Console.WriteLine("Difference between 3-digit numbers and others is: " + (othernumb - ucreqemli));
        //    }
        //}

        #endregion

        #region Task - 4:
        //Array-i(minimum 5 element olsun) tərsinə çevirən(reverse) algorithmi qurun;
        //static void Reversearr(int[] arr)
        //{
        //    int[] revarr = new int[arr.Length];

        //    for (int i = arr.Length - 1, j = 0; i >= 0; i--)
        //    {
        //        revarr[j] = arr[i];
        //        j++;
        //    }
        //    foreach (int item in revarr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        #endregion

        #region Task - 5:
        //static void Samenum(int[] arr1, int[] arr2)
        //{
        //    bool check = true;

        //    foreach (int item in arr1)
        //    {
        //        foreach (int item2 in arr2)
        //        {
        //            if (item == item2)
        //            {
        //                check = false;
        //                break;

        //            }
        //        }
        //        if (check == true)
        //        {
        //            Console.WriteLine(item);
        //        }
        //        check = true;

        //    }

        //}

        #endregion

        #region Task - 7:
        //Gonderilmis ededler siyahisini icinde yalnizca cut ededler qalan yeni bir array-e ceviren metod(gonderilen array variableninn ozunu - referance)

        //static int[] Evennumb(ref int[] arr)
        //{
        //    int[] evenarr = new int[0];

        //    foreach (int item in arr)
        //    {
        //        if(item % 2 == 0)
        //        {
        //            Array.Resize(ref evenarr, evenarr.Length + 1);
        //            evenarr[evenarr.Length -1] = item;
        //        }
        //    }
        //    return evenarr;
        //}
        #endregion

        #region Task - 8:
        //static int Find(string str)
        //{
        //    string[] arr = str.Split(" ");
        //    return arr.Length;
        //}
        #endregion

        #region Task - 9:

        //static bool Task9(string word)
        //{
        //    bool IsDigit = false;
        //    bool IsUpper = false;
        //    bool IsLower = false;
        //    foreach (char item in word)
        //    {
        //        if(char.IsDigit(item) == true)
        //        {
        //            IsDigit = true;
        //        }
        //        else if (char.IsUpper(item) == true)
        //        {
        //            IsUpper = true;
        //        }
        //        else if(char.IsLower(item) == true)
        //        {
        //            IsLower = true;
        //        }
        //    }
        //        if (IsDigit && IsLower && IsUpper)
        //        {
        //            return true;
        //        }
        //    return false;
        //}

        #endregion

        #region Task - 10:

        //static int[] Task10(int[] arr, int a)
        //{
        //    Array.Resize(ref arr, arr.Length + 1);
        //    arr[arr.Length - 1] = a;

        //    return arr;
        //}

        #endregion

        #region Task - 11:

        #endregion



    }

}
