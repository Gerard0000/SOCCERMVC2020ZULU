using SOCCERMVC2020ZULU.Web.Data;
using SOCCERMVC2020ZULU.Web.Data.Entities;
using SOCCERMVC2020ZULU.Web.Models;

namespace SOCCERMVC2020ZULU.Web.Helpers;

public class ConverterHelper : IConverterHelper
{
    private readonly DataContext _context;
    private readonly ICombosHelper _combosHelper;

    public ConverterHelper(DataContext context, ICombosHelper combosHelper)
    {
        _context = context;
        _combosHelper = combosHelper;
    }

    public Team ToTeamEntity(TeamViewModel model, string path, bool isNew)
    {
        return new Team
        {
            Id = isNew ? 0 : model.Id,
            LogoPath = path,
            Name = model.Name
        };
    }

    public TeamViewModel ToTeamViewModel(Team teamEntity)
    {
        return new TeamViewModel
        {
            Id = teamEntity.Id,
            LogoPath = teamEntity.LogoPath,
            Name = teamEntity.Name
        };
    }

    public Tournament ToTournamentEntity(TournamentViewModel model, string path, bool isNew)
    {
        return new Tournament
        {
            EndDate = model.EndDate.ToUniversalTime(),
            Groups = model.Groups,
            Id = isNew ? 0 : model.Id,
            IsActive = model.IsActive,
            LogoPath = path,
            Name = model.Name,
            StartDate = model.StartDate.ToUniversalTime(),
        };
    }

    public TournamentViewModel ToTournamentViewModel(Tournament tournamentEntity)
    {
        return new TournamentViewModel
        {
            EndDate = tournamentEntity.EndDate,
            Groups = tournamentEntity.Groups,
            Id = tournamentEntity.Id,
            IsActive = tournamentEntity.IsActive,
            LogoPath = tournamentEntity.LogoPath,
            Name = tournamentEntity.Name,
            StartDate = tournamentEntity.StartDate
        };
    }

    public async Task<Group> ToGroupEntityAsync(GroupViewModel model, bool isNew)
    {
        return new Group
        {
            GroupDetails = model.GroupDetails,
            Id = isNew ? 0 : model.Id,
            Matches = model.Matches,
            Name = model.Name,
            Tournament = await _context.Tournaments!.FindAsync(model.TournamentId)
        };
    }

    public GroupViewModel ToGroupViewModel(Group groupEntity)
    {
        return new GroupViewModel
        {
            GroupDetails = groupEntity.GroupDetails,
            Id = groupEntity.Id,
            Matches = groupEntity.Matches,
            Name = groupEntity.Name,
            Tournament = groupEntity.Tournament,
            TournamentId = groupEntity.Tournament!.Id
        };
    }

    public async Task<GroupDetail> ToGroupDetailEntityAsync(GroupDetailViewModel model, bool isNew)
    {
        return new GroupDetail
        {
            GoalsAgainst = model.GoalsAgainst,
            GoalsFor = model.GoalsFor,
            Group = await _context.Groups!.FindAsync(model.GroupId),
            Id = isNew ? 0 : model.Id,
            MatchesLost = model.MatchesLost,
            MatchesPlayed = model.MatchesPlayed,
            MatchesTied = model.MatchesTied,
            MatchesWon = model.MatchesWon,
            Team = await _context.Teams!.FindAsync(model.TeamId)
        };
    }

    public GroupDetailViewModel ToGroupDetailViewModel(GroupDetail groupDetail)
    {
        return new GroupDetailViewModel
        {
            GoalsAgainst = groupDetail.GoalsAgainst,
            GoalsFor = groupDetail.GoalsFor,
            Group = groupDetail.Group,
            GroupId = groupDetail.Group!.Id,
            Id = groupDetail.Id,
            MatchesLost = groupDetail.MatchesLost,
            MatchesPlayed = groupDetail.MatchesPlayed,
            MatchesTied = groupDetail.MatchesTied,
            MatchesWon = groupDetail.MatchesWon,
            Team = groupDetail.Team,
            TeamId = groupDetail.Team!.Id,
            Teams = _combosHelper.GetComboTeams()
        };
    }

    public async Task<Match> ToMatchEntityAsync(MatchViewModel model, bool isNew)
    {
        return new Match
        {
            Date = model.Date.ToUniversalTime(),
            GoalsLocal = model.GoalsLocal,
            GoalsVisitor = model.GoalsVisitor,
            Group = await _context.Groups!.FindAsync(model.GroupId),
            Id = isNew ? 0 : model.Id,
            IsClosed = model.IsClosed,
            Local = await _context.Teams!.FindAsync(model.LocalId),
            Visitor = await _context.Teams!.FindAsync(model.VisitorId)
        };
    }

    public MatchViewModel ToMatchViewModel(Match matchEntity)
    {
        return new MatchViewModel
        {
            Date = matchEntity.Date.ToLocalTime(),
            GoalsLocal = matchEntity.GoalsLocal,
            GoalsVisitor = matchEntity.GoalsVisitor,
            Group = matchEntity.Group,
            GroupId = matchEntity.Group!.Id,
            Id = matchEntity.Id,
            IsClosed = matchEntity.IsClosed,
            Local = matchEntity.Local,
            LocalId = matchEntity.Local!.Id,
            Teams = _combosHelper.GetComboTeams(matchEntity.Group!.Id),
            Visitor = matchEntity.Visitor,
            VisitorId = matchEntity.Visitor!.Id
        };
    }
}