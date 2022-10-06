using l10_assignment.Models;
using l10_assignment.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace l10_assignment.Controllers;

[ApiController]
[Route("[controller]")]
public class petController : ControllerBase 
{
    private readonly ILogger<petController> _logger;
    private readonly IPetRepository _petRepository;

    public petController(ILogger<petController> logger, IPetRepository repository)
    {
        _logger = logger;
        _petRepository = repository;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Pet>> Get() 
    {
    return Ok(_petRepository.GetPets());
    }
    [HttpGet]
    [Route("{petId:int}")]
    public ActionResult<Pet> GetPetById(int petId) 
    {
        var pet = _petRepository.GetPetById(petId);
        if (pet == null) {
            return NotFound();
            }
            return Ok(pet);
    }
    [HttpPost]
public ActionResult<Pet> CreatePet(Pet pet) 
    {
    if (!ModelState.IsValid || pet == null) {
        return BadRequest();
    }
    var newPet = _petRepository.CreatePet(pet);
    return Created(nameof(GetPetById), newPet);
    }
    [HttpPut]
[Route("{petId:int}")]
public ActionResult<Pet> UpdatePet(Pet pet) 
    {
    if (!ModelState.IsValid || pet == null) {
        return BadRequest();
    }
    return Ok(_petRepository.UpdatePet(pet));
    }
    [HttpDelete]
[Route("{petId:int}")]
public ActionResult DeletePet(int petId) 
    {
    _petRepository.DeletePetById(petId); 
    return NoContent();
    }
}
