using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio002
{
    // criação da classe animal
    internal class Animal
    {
        // atributos
        private string nome;
        private string tipo;

        // método construtor e sobrecarga 
        public Animal()
        {

        }

        public Animal(string n, string t)
        {
            this.nome = n;
            this.tipo = t;
        }      

        // métodos getter e setter 
        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
