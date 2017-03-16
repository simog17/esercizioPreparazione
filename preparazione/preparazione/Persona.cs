using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preparazione
{
    class Persona
    {
        public string name { get; set; }

        public string surname { get; set; }

        private int _year;
        public int year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value <= 0) value = 1;
                _year = value;
            }
        }

        public Persona(string name, string surname, int year)
        {
            this.name = name;
            this.surname = surname;
            this.year = year;
        }

        public virtual string describe()
        {
            return "descrizione : "+ name + " " + surname + " " + year;
        }

        public override string ToString()
        {
            return name + " "+ surname + " " + year;
        }
    }
}
