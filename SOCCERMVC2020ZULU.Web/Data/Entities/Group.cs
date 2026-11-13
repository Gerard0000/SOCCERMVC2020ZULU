using System.ComponentModel.DataAnnotations;

namespace SOCCERMVC2020ZULU.Web.Data.Entities;

public class Group
{
    public int Id { get; set; }

    [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
    [Required(ErrorMessage = "The field {0} is mandatory.")]
    public string? Name { get; set; }

    public Tournament? Tournament { get; set; }

    public ICollection<Group>? Groups { get; set; }
}