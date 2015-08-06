using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgres_EF.EF.Entities
{
    [Table("pets", Schema = "public")]
    public class Pet
    {
        [Key]
        public int IdPet { get; set; }
        [Column("name")]
        public string Name { get; set; }
    }

}
