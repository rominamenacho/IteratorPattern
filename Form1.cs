using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IteratorPattern
{
    public partial class Form1 : Form
    {

        private Collection _colection = new ConcreteCollection();
        private Iterator iterator;


        public Form1()
        {
            iterator = _colection.CreateIterator();
            InitializeComponent();
        }

        private void Listar()
        {
            listBox1.Items.Clear();
            iterator.First();
            Item i = iterator.Current();
            if (i != null) listBox1.Items.Add(i);
            while (!iterator.IsDone())
            {
                iterator.Next();
                listBox1.Items.Add(iterator.Current());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _item = new Item(textBox1.Text);
            _colection.Agregar(_item);
            Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btn primero
            iterator.First();
            textBox2.Text = iterator.Current().Nombre;
            textBox3.Text = iterator.Current().Nombre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if( !iterator.IsDone())
            {
                iterator.Next();
                textBox3.Text = iterator.Current().Nombre;
            }
        }
    }
}
