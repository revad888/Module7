using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Customer
    {
        protected string email;
        public readonly string name;
        public readonly string lastName;    
        private string HasData(string data, string FieldName)
        {
            while (data == "" || data == string.Empty)
            {
                Console.WriteLine($"{FieldName} не может быть пустым! Введите {FieldName}");
                Console.ReadLine();
            }
             
            return data;
            
        }
        public Customer(string Name, string LastName, string Email) 
        { 
            this.name = HasData(Name, "Имя");
            this.lastName = HasData(LastName, "Фамилия");
            this.email = HasData(Email, "email");
        }


    }
}
