using Blazor.Domain.DTOs;
using Microsoft.AspNetCore.Components.Forms;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Blazor.Client.Services
{
    public class StudentService(HttpClient _http)
    {
       

        public async Task<IEnumerable<StudentDto>> GetAllAsync(string? search = null)
        {
            var url = "api/students";
            if (!string.IsNullOrWhiteSpace(search))
                url += $"?search={search}";

            return await _http.GetFromJsonAsync<IEnumerable<StudentDto>>(url)
                   ?? new List<StudentDto>();
        }

        public async Task<StudentDto?> CreateAsync(StudentCreateDto dto)
        {
            var response = await _http.PostAsJsonAsync("api/students", dto);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<StudentDto>();
            return null;
        }
    }
}
