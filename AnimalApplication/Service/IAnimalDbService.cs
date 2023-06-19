using AnimalApplication.Models;

namespace AnimalApplication.Service;

public interface IAnimalDbService
{
    Task<IList<Animal>> GetAnimalListAsync(string name);
       
    Task<bool> AddAnimalAsync(Animal animal);

    Task<bool>  DeleteAnimalAsync(int id);

    Task<bool> PutAnimalAsync(int id,Animal animal);


}