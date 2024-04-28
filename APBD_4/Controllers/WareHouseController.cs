using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using APBD_4.Models;

namespace APBD_4.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WareHouseController : ControllerBase
{
    private IOrdersService _ordersService;
    /// <summary>
    /// Endpoint used to return a single student.
    /// </summary>
    /// <param name="id">Id of a student</param>
    /// <returns>Student</returns>
    [HttpGet("{id:int}")]
    public IActionResult CheckIfProductExists(int id)
    {
        var animal = _animalService.GetAnimal(id);

        if (animal==null)
        {
            return NotFound("Animal not found");
        }
        
        return Ok(animal);
    }
}