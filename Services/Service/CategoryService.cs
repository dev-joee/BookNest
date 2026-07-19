using BookNest.Data.IRepository;
using BookNest.Data.Models;
using BookNest.Services.DTOs;
using BookNest.Services.IService;

namespace BookNest.Services.Service;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryService(ICategoryRepository ctegoryRepository)
    {
        _categoryRepository = ctegoryRepository;
    }

    private Category AssembleCategory(CategoryDTO categoryDTO, int id = 0)
    {
        return new Category
        {
            Id = id,
            Name = categoryDTO.CategoryName,
            Description = categoryDTO.CategoryDescription
        };
    }

    public void Add(CategoryDTO newCategoryDTO)
    {
        var category = AssembleCategory(newCategoryDTO);

        try
        {
            _categoryRepository.Create(category);
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }


    public void Edit(int id, CategoryDTO updatedCategoryDTO)
    {
        var category = AssembleCategory(updatedCategoryDTO, id);

        try
        {
            _categoryRepository.Update(category);
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _categoryRepository.DeleteById(id);
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }

    public Category? Search(string name)
    {
        return _categoryRepository.SearchByName(name);
    }    

    public IEnumerable<Category> GetAllCategories()
    {
        return _categoryRepository.GetAll();
    }
}
