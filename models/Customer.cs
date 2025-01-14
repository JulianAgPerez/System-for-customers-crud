using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.models
{
    internal class Customer
    {
        /*
         Al utilizar get; set; crea automaticamente las variables

        private string name;
        private string lastName;
        private string celphone;
        private string creditCard;

        */
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Celphone { get; set; }
        public string CreditCard { get; set; }
        public string FullName
        {
            get { return Name + " " + LastName; }
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
