using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseOfComponent
{
    public class Relation
    {

        [ForeignKey("ElementParentId")]
        public virtual Element ElementParent { get; set; }
        [ForeignKey("ElementChildId")]
        public virtual Element ElementChild { get; set; }

        [Key, Column(Order = 1)]
        public virtual int? ElementParentId { get; set; }
        [Key, Column(Order = 2)]
        public virtual int ElementChildId { get; set; }

    }
}
