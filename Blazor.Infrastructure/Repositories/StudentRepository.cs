using Blazor.Domain.DTOs;
using Blazor.Domain.Entities;
using Blazor.Domain.Repositories;
using Blazor.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Blazor.Infrastructure.Repositories
{
    public class StudentRepository(
            BlazorSolutionDbContext _dbContext) : IStudentRepository
    {
        public async Task<StudentDto> CreateAsync(StudentCreateDto dto)
        {
            var entity = new Student
            {
                Name = dto.Name,
                Age = dto.Age,
                FatherName = dto.FatherName,
            };

            _dbContext.Students.Add(entity);
            await _dbContext.SaveChangesAsync();

            return new StudentDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Age = entity.Age,
                FatherName = entity.FatherName,
            };
        }

        public async Task<IEnumerable<StudentDto>> GetAllAsync(string? search)
        {
            var query = _dbContext.Students.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(s =>
                    s.Name.Contains(search) ||
                    s.FatherName.Contains(search));
            }

            return await query
                .Select(s => new StudentDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Age = s.Age,
                    FatherName = s.FatherName,
                })
                .ToListAsync();
        }
    }
}
