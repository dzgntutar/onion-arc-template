using Library.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public Guid Author { get; set; }
        public short Count { get; set; }

    }
}
