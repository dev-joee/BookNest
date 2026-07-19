using BookNest.Data.Models;
using BookNest.Services.DTOs;

namespace BookNest.Services.IService;

public interface IAuthorService
{
    Author AssembleAuthor(AuthorDTO authorDTO, int id = 0);
    void Add(AuthorDTO newAuthorDTO);
    void Update(int id, AuthorDTO updatedAuthorDTO);
    void Delete(int id);
    Author? Search(string name);
}