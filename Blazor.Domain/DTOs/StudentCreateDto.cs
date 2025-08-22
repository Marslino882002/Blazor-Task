using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Domain.DTOs
{
    public class StudentCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string FatherName { get; set; } = string.Empty;


    }
}
