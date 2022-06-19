using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Dtos
{
    public class BookSaveDto
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public short Count { get; set; }
    }
}
