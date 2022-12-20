using Interface_Homework.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Homework.Service
{
    internal class AccountService : IAccountService
    {

       
            public string name;
            public string password;

            public AccountService(string name, string password)
            {
                this.name = name;
                this.password = password;

            }

            internal void Sign()
            {
                if (name == "Aqsin" && password == "7248254a")
                {
                    Console.WriteLine("Emeliyyat ugurluur");
                }
                else
                {
                    Console.WriteLine("username ve ya password yalnisdir");
                }
            }

        void IAccountService.Sign()
        {
            
        }
    }
}
