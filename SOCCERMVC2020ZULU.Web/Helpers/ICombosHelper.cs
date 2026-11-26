using Microsoft.AspNetCore.Mvc.Rendering;

namespace SOCCERMVC2020ZULU.Web.Helpers;

public interface ICombosHelper
{
    IEnumerable<SelectListItem> GetComboTeams();

    IEnumerable<SelectListItem> GetComboTeams(int id);
}