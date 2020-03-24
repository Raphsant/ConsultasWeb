using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultasWeb.Models
{
    public class Pacient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Diagnostico { get; set; }
        public DateTime Fecha { get; set; }
        public Medic medico { get; set; }
        public ICollection<Medic> medics { get; set; }






    }
}
