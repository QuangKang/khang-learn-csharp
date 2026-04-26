using System.ComponentModel.DataAnnotations;

namespace WebApi.Models;

public record Person(int ID, [Required] string Name, [Required] string Role);