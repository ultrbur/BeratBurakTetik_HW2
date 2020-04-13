using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(100,MinimumLength =3)]
        public string Name { get; set; } // nvarchar(100) 2GB

        public virtual List<Book> Books { get; set; }
    }
}
