﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Dtos
{
    public class BookViewDto
    {
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public Guid Author { get; set; }
    }
}
