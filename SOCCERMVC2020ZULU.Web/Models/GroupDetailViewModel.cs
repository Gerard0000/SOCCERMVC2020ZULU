using Microsoft.AspNetCore.Mvc.Rendering;
using SOCCERMVC2020ZULU.Web.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace SOCCERMVC2020ZULU.Web.Models;

public class GroupDetailViewModel : GroupDetail
{
    public int GroupId { get; set; }

    [Required(ErrorMessage = "The field {0} is mandatory.")]
    [Display(Name = "Team")]
    [Range(1, int.MaxValue, ErrorMessage = "You must select a team.")]
    public int TeamId { get; set; }

    public IEnumerable<SelectListItem>? Teams { get; set; }
}