using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    internal class Livro
    {
        // atributos
        public string titulo;
        public string autor;
        public int paginas;
        public int ano;
        public int edicao;

        // método construtor
        public Livro(string titulo, string autor, int pagina, int ano, int edicao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = pagina;
            this.ano = ano;
            this.edicao = edicao;
        }

        // métodos
        public void apresentaInfoLivro()
        {
            Console.WriteLine("O livro {0}, do autor {1}, tem {2} páginas, foi publicado no ano de {3} e está na sua {4}º versão.", this.titulo, this.autor, this.paginas, this.ano, this.edicao);
        }
    }
}
