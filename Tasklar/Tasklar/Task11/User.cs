using System;
using System.Collections.Generic;
using System.Text;

namespace Tasklar.Task11
{
    class User
    {
        public User(string username)
        {
            Username = username;

        }

        private string _UserName;
        private string _PassWord;
        public string Username
        {
            get
            {
                return _UserName;
            }

            set
            {
                while (value.Length < 8)
                {
                    Console.WriteLine("Username must have 8 symbol:");
                    value = Console.ReadLine();
                }
                _UserName = value;
                return;
            }

        }
        public string Password
        {
            get
            {
                return _PassWord;
            }
            set
            {

                bool check = false;

                while (true)
                {
                tryagain:
                    if (value.Length > 8)
                    {
                        bool isDigit = false;
                        bool isUpper = false;
                        bool isLower = false;

                        foreach (char item in value)
                        {
                            if (char.IsDigit(item))
                            {
                                isDigit = true;
                            }
                            else if (char.IsLower(item))
                            {
                                isLower = true;

                            }
                            else if (char.IsUpper(item))
                            {
                                isUpper = true;

                            }

                        }
                        if (isUpper && isLower && isDigit)
                        {
                            check = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Password is not quiet right:");
                            value = Console.ReadLine();
                            goto tryagain;
                        }


                    }
                    else
                    {

                        Console.WriteLine("Password must have 8 symbol:");
                        value = Console.ReadLine();
                    }




                }

                _PassWord = value;


            }
        }





    }
}
