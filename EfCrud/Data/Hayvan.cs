using System.ComponentModel.DataAnnotations;

namespace EfCrud.Data
{
    public class Hayvan
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Ad { get; set; }
    }
}
