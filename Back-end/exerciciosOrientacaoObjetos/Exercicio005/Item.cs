using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio005
{
    internal class Item
    {
        // atributo
        private string descricao;
        private DateTime dataCriacao;
        private float altura;

        // construtor com todos os atributos
        public Item(string descricao, DateTime dataCriacao, float altura)
        {
            this.descricao = descricao;
            this.dataCriacao = dataCriacao;
            this.altura = altura;
        }

        // métodos getters e setters
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime DataCriacao { get => dataCriacao; set => dataCriacao = value; }
        public float Altura { get => altura; set => altura = value; }

        // método para imprimir todos os dados na tela
        public void ImprimeDados()
        {
            Console.WriteLine("Dados do item: \n" +
                              "[1] - Descrição: {0}\n" +
                              "[2] - Data da criação: {1:dd/MM/yyyy}\n" +
                              "[3] - Altura: {2}\n.", this.Descricao, this.DataCriacao, this.Altura);
        }

        // método para calcular quantos dias da criação do item até o dia de hoje
        public int RetornaDias()
        {
            int dias = DateTime.Today.Subtract(this.DataCriacao).Days;
            return dias;
        }
    }
}
