using SOCCERMVC2020ZULU.Web.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace SOCCERMVC2020ZULU.Web.Models;

public class TeamViewModel : Team
{
    [Display(Name = "Logo")]
    public IFormFile? LogoFile { get; set; }
}