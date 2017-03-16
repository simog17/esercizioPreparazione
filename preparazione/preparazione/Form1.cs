using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preparazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Persona("monica", "Anceschi", 45));
            listBox1.Items.Add(new Studente("simone", "gaddi", 17, "3f"));
            
           /* Persona p1 = new Persona("giuseppe", "pino", 98);
            listBox1.Items.Add(p1);
            Studente s1 = new Studente("caio", "gracco", -1, "6j");
            listBox1.Items.Add(s1);
            Console.WriteLine(p1.describe());
            Console.WriteLine(s1.describe());*/
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
