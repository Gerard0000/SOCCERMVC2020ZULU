using SOCCERMVC2020ZULU.Web.Data.Entities;
using SOCCERMVC2020ZULU.Web.Models;

namespace SOCCERMVC2020ZULU.Web.Helpers;

public interface IConverterHelper
{
    Team ToTeamEntity(TeamViewModel model, string path, bool isNew);

    TeamViewModel ToTeamViewModel(Team teamEntity);

    Tournament ToTournamentEntity(TournamentViewModel model, string path, bool isNew);

    TournamentViewModel ToTournamentViewModel(Tournament tournamentEntity);

    //es group es asincrono porque tenemos que buscar el registro en la base de datos
    Task<Group> ToGroupEntityAsync(GroupViewModel model, bool isNew);

    GroupViewModel ToGroupViewModel(Group groupEntity);

    Task<GroupDetail> ToGroupDetailEntityAsync(GroupDetailViewModel model, bool isNew);

    GroupDetailViewModel ToGroupDetailViewModel(GroupDetail groupDetailEntity);

    Task<Match> ToMatchEntityAsync(MatchViewModel model, bool isNew);

    MatchViewModel ToMatchViewModel(Match matchEntity);
}