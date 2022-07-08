using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace exerciciosVeiculos_EF
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key()]
        public int Id { get; set; }

        [ForeignKey("Modelo")]
        public int ModeloId { get; set; }
        public virtual Modelo Modelo { get; set; }

        public string Nome { get; set; }
        public int Ano { get; set; }

        public void Salvar()
        {
            var db = new BaseContext();
            db.Veiculos.Add(this);
            db.SaveChanges();
        }
        public static void Remover(int id)
        {
            var db = new BaseContext();
            Veiculo veiculo = db.Veiculos.Single(v => v.Id == id);
            db.Veiculos.Remove(veiculo);
            db.SaveChanges();
        }
        public static List<Veiculo> Todos()
        {
            var db = new BaseContext();
            return db.Veiculos.ToList();
        }
    }
}
