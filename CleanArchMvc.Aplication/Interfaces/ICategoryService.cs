using CleanArchMvc.Aplication.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Aplication.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();
        Task<CategoryDTO> GetById(int? id);
        Task Add(CategoryDTO categoryDto);
        Task Update(CategoryDTO categoryDto);
        Task Remove(int? id);
    }
}