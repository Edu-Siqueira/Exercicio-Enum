using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnum.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birth)
        {
            Name = name;
            Email = email;
            BirthDate = birth;
        }

        public override string ToString()
        {
            return $"{Name} ({BirthDate.ToString("dd/MM/yyyy")}) - {Email}";
        }
    }
}
