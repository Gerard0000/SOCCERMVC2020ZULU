using System.ComponentModel.DataAnnotations;

namespace SOCCERMVC2020ZULU.Web.Data.Entities;

public class Team
{
    public int Id { get; set; }

    [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
    [Required(ErrorMessage = "The field {0} is mandatory.")]
    public string? Name { get; set; }

    [Display(Name = "Logo")]
    public string? LogoPath { get; set; }
}