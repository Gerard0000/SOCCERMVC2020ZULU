using SOCCERMVC2020ZULU.Web.Data.Entities;
using SOCCERMVC2020ZULU.Web.Models;

namespace SOCCERMVC2020ZULU.Web.Helpers;

public interface IConverterHelper
{
    Team ToTeamEntity(TeamViewModel model, string path, bool isNew);

    TeamViewModel ToTeamViewModel(Team teamEntity);
}