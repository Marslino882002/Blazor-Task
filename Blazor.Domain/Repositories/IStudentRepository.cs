using Blazor.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Domain.Repositories
{
    public interface IStudentRepository
    {

        Task<IEnumerable<StudentDto>> GetAllAsync(string? search);
        Task<StudentDto> CreateAsync(StudentCreateDto dto);


    }
}
