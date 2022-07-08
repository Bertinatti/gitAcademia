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
    [Table("Modelos")]
    public class Modelo
    {
        [Key()]
        public int Id { get; set; }
        public string Nome { get; set; }

        public void Salvar()
        {
            var db = new BaseContext();
            db.Modelos.Add(this);
            db.SaveChanges();
        }
        public static void Remover(int id)
        {
            var db = new BaseContext();
            Modelo modelo = db.Modelos.Single(m => m.Id == id);
            db.Modelos.Remove(modelo);
            db.SaveChanges();
        }
        public static List<Modelo> Todos()
        {
            var db = new BaseContext();
            return db.Modelos.ToList();
        }
    }
}
