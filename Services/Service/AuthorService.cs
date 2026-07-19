using BookNest.Data.IRepository;
using BookNest.Data.Models;
using BookNest.Services.DTOs;
using BookNest.Services.IService;

namespace BookNest.Services.Service;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;
    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
    public Author AssembleAuthor(AuthorDTO authorDTO, int id = 0)
    {
        return new Author
        {
            Id = id,
            Name = authorDTO.AuthorName,
            Biography = authorDTO.Bio
        };
    }
    public void Add(AuthorDTO newAuthorDTO)
    {
        var author = this.AssembleAuthor(newAuthorDTO);

        try
        {
            _authorRepository.Create(author);
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }

    public void Update(int id, AuthorDTO updatedAuthorDTO)
    {
        var author = AssembleAuthor(updatedAuthorDTO, id);

        try
        {
            _authorRepository.Update(author);
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
            _authorRepository.DeleteById(id);
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }

    public Author? Search(string name)
    {
        return _authorRepository.SearchByName(name);
    }
}
