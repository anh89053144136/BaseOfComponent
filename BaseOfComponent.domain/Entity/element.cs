using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseOfComponent
{
    public class Element
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public int Count { set; get; }
    }
}
