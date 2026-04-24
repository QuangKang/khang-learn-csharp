using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class PersonController : ControllerBase
{
    private static readonly List<Person> _people = new()
    {
        new Person(1, "A", "CEO"),
        new Person(2, "B", "HR"),
        new Person(3, "D", "PM"),
        new Person(4, "K", "Intern")
    };

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_people);
    }

    [HttpGet("{id}")]
    public IActionResult GetByID(int id)
    {
        var person = _people.FirstOrDefault(p => p.ID == id);
        if (person is null)
        {
            return NotFound(new { Message = $"No user match ID {id}"});
        }
        return Ok(person);
    }

    [HttpPost]
    public IActionResult Create(Person newPerson)
    {
        _people.Add(newPerson);
        return CreatedAtAction(nameof(GetByID), new { id = newPerson.ID }, newPerson);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Person updatedData)
    {
        var index = _people.FindIndex(p => p.ID == id);
        if (index == -1)
        {
            return NotFound();
        }
        _people[index] = updatedData with { ID = id };
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var person = _people.FirstOrDefault(p => p.ID == id);
        if (person is null)
        {
            return NotFound();
        }
        _people.Remove(person);
        return NoContent();
    }
}