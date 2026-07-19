using BookNest.Data.Models;
using BookNest.Services.DTOs;

namespace BookNest.Services.IService;

public interface ICategoryService
{
    void Add(CategoryDTO newCategoryDTO);
    void Edit(int id, CategoryDTO updatedCategoryDTO);
    void Delete(int id);
    Category? Search(string name);
    IEnumerable<Category> GetAllCategories();
}