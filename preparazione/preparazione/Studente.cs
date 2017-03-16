using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preparazione
{
    class Studente : Persona
    {
        public string section { get; set; }

        public Studente(string name, string surname, int year, string section) : base(name, surname, year)
        {
            this.section = section;
        }

        public override string describe()
        {
            return base.describe()+ " " + section;
        }

        public override string ToString()
        {
            return base.ToString()+ " " + section;
        }
    }
}
