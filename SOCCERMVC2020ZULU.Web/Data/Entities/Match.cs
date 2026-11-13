using System.ComponentModel.DataAnnotations;

namespace SOCCERMVC2020ZULU.Web.Data.Entities;

public class Match
{
    public int Id { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
    public DateTime Date { get; set; }

    public DateTime DateLocal => Date.ToLocalTime();

    public Team? Local { get; set; }

    public Team? Visitor { get; set; }

    [Display(Name = "Goals Local")]
    public int GoalsLocal { get; set; }

    [Display(Name = "Goals Visitor")]
    public int GoalsVisitor { get; set; }

    [Display(Name = "Is Closed?")]
    public bool IsClosed { get; set; }

    public Group? Group { get; set; }
}