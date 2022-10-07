using l10_assignment.Migrations;
using l10_assignment.Models;

namespace l10_assignment.Repositories;

public class petsRepository : IPetRepository 
{
    private readonly PetsDbContext _context;

    public petsRepository(PetsDbContext context)
    {
        _context = context;
    }

    public Pet CreatePet(Pet newPet)
    {
        _context.Pet.Add(newPet);
        _context.SaveChanges();
        return newPet;
    }

    public void DeletePetById(int petId)
    {
        var pet = _context.Pet.Find(petId);
        if (pet != null) {
            _context.Pet.Remove(pet); 
            _context.SaveChanges(); 
        }
    }

    public IEnumerable<Pet> GetPets()
    {
        return _context.Pet.ToList();
    }

    public Pet? GetPetById(int petId)
    {
        return _context.Pet.SingleOrDefault(c => c.PetId == petId);
    }

    public Pet? UpdatePet(Pet newPet)
    {
        var originalPet = _context.Pet.Find(newPet.PetId);
        if (originalPet != null) {
            originalPet.PetName = newPet.PetName;
            originalPet.Type = newPet.Type;
            originalPet.Description = newPet.Description;
            _context.SaveChanges();
        }
        return originalPet;
    }
}