using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} - LastName: {LastName} - Score: {Score}";
        }
    }
}
