using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : this("Bir hata meydana geldi..")   
        {

        }


        public ValidationException(string message) : base(message)
        {

        }


        public ValidationException(Exception e) : base(e.Message)
        {
                
        }
    }
}
