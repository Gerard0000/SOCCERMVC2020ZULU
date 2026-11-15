using SOCCERMVC2020ZULU.Web.Data.Entities;

namespace SOCCERMVC2020ZULU.Web.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();
        await CheckTeamsAsync();
        await CheckTournamentsAsync();
    }

    private async Task CheckTeamsAsync()
    {
        if (!_context.Teams!.Any())
        {
            AddTeam("Afghanistan");
            AddTeam("Albania");
            AddTeam("Algeria");
            AddTeam("American Samoa");
            AddTeam("Andorra");
            AddTeam("Angola");
            AddTeam("Anguilla");
            AddTeam("Antigua and Barbuda");
            AddTeam("Argentina");
            AddTeam("Armenia");
            AddTeam("Aruba");
            AddTeam("Australia");
            AddTeam("Austria");
            AddTeam("Azerbaijan");
            AddTeam("Bahamas");
            AddTeam("Bahrain");
            AddTeam("Bangladesh");
            AddTeam("Barbados");
            AddTeam("Belarus");
            AddTeam("Belgium");
            AddTeam("Belize");
            AddTeam("Benin");
            AddTeam("Bermuda");
            AddTeam("Bhutan");
            AddTeam("Bolivia");
            AddTeam("Bonaire");
            AddTeam("Bosnia and Herzegovina");
            AddTeam("Botswana");
            AddTeam("Brazil");
            AddTeam("British Virgin Islands");
            AddTeam("Brunei");
            AddTeam("Bulgaria");
            AddTeam("Burkina Faso");
            AddTeam("Burundi");
            AddTeam("Cambodia");
            AddTeam("Cameroon");
            AddTeam("Canada");
            AddTeam("Cape Verde");
            AddTeam("Cayman Islands");
            AddTeam("Central African Republic");
            AddTeam("Chad");
            AddTeam("Chile");
            AddTeam("China PR");
            AddTeam("Chinese Taipei");
            AddTeam("Colombia");
            AddTeam("Comoros");
            AddTeam("Congo");
            AddTeam("Congo DR");
            AddTeam("Cook Islands");
            AddTeam("Costa Rica");
            AddTeam("Côte d Ivoire");
            AddTeam("Croatia");
            AddTeam("Cuba");
            AddTeam("Curaçao");
            AddTeam("Cyprus");
            AddTeam("Czechia");
            AddTeam("Denmark");
            AddTeam("Djibouti");
            AddTeam("Dominica");
            AddTeam("Dominican Republic");
            AddTeam("Ecuador");
            AddTeam("Egypt");
            AddTeam("El Salvador");
            AddTeam("England");
            AddTeam("Equatorial Guinea");
            AddTeam("Eritrea");
            AddTeam("Estonia");
            AddTeam("Eswatini");
            AddTeam("Ethiopia");
            AddTeam("Faroe Islands");
            AddTeam("Federated States of Micronesia");
            AddTeam("Fiji");
            AddTeam("Finland");
            AddTeam("France");
            AddTeam("French Guiana");
            AddTeam("Gabon");
            AddTeam("Gambia");
            AddTeam("Georgia");
            AddTeam("Germany");
            AddTeam("Ghana");
            AddTeam("Gibraltar");
            AddTeam("Greece");
            AddTeam("Grenada");
            AddTeam("Guadeloupe");
            AddTeam("Guam");
            AddTeam("Guatemala");
            AddTeam("Guinea");
            AddTeam("Guinea-Bissau");
            AddTeam("Guyana");
            AddTeam("Haiti");
            AddTeam("Honduras");
            AddTeam("Hong Kong");
            AddTeam("Hungary");
            AddTeam("Iceland");
            AddTeam("India");
            AddTeam("Indonesia");
            AddTeam("IR Iran");
            AddTeam("Iraq");
            AddTeam("Israel");
            AddTeam("Italy");
            AddTeam("Jamaica");
            AddTeam("Japan");
            AddTeam("Jordan");
            AddTeam("Kazakhstan");
            AddTeam("Kenya");
            AddTeam("Kiribati");
            AddTeam("Korea DPR");
            AddTeam("Korea Republic");
            AddTeam("Kosovo");
            AddTeam("Kuwait");
            AddTeam("Kyrgyzstan");
            AddTeam("Laos");
            AddTeam("Latvia");
            AddTeam("Lebanon");
            AddTeam("Lesotho");
            AddTeam("Liberia");
            AddTeam("Libya");
            AddTeam("Liechtenstein");
            AddTeam("Lithuania");
            AddTeam("Luxembourg");
            AddTeam("Macau");
            AddTeam("Madagascar");
            AddTeam("Malawi");
            AddTeam("Malaysia");
            AddTeam("Maldives");
            AddTeam("Mali");
            AddTeam("Malta");
            AddTeam("Marshall Islands");
            AddTeam("Martinique");
            AddTeam("Mauritania");
            AddTeam("Mauritius");
            AddTeam("Mexico");
            AddTeam("Moldova");
            AddTeam("Monaco");
            AddTeam("Mongolia");
            AddTeam("Montenegro");
            AddTeam("Montserrat");
            AddTeam("Morocco");
            AddTeam("Mozambique");
            AddTeam("Myanmar");
            AddTeam("Namibia");
            AddTeam("Naoero");
            AddTeam("Nepal");
            AddTeam("Netherlands");
            AddTeam("New Caledonia");
            AddTeam("New Zealand");
            AddTeam("Nicaragua");
            AddTeam("Niger");
            AddTeam("Nigeria");
            AddTeam("North Macedonia");
            AddTeam("Northern Ireland");
            AddTeam("Northern Mariana Islands");
            AddTeam("Norway");
            AddTeam("Oman");
            AddTeam("Pakistan");
            AddTeam("Palau");
            AddTeam("Palestine");
            AddTeam("Panama");
            AddTeam("Papua New Guinea");
            AddTeam("Paraguay");
            AddTeam("Peru");
            AddTeam("Philippines");
            AddTeam("Poland");
            AddTeam("Portugal");
            AddTeam("Puerto Rico");
            AddTeam("Qatar");
            AddTeam("Republic of Ireland");
            AddTeam("Réunion");
            AddTeam("Romania");
            AddTeam("Russia");
            AddTeam("Rwanda");
            AddTeam("Saint Kitts and Nevis");
            AddTeam("Saint Lucia");
            AddTeam("Saint Martin");
            AddTeam("Saint Vincent and the Grenadines");
            AddTeam("Samoa");
            AddTeam("San Marino");
            AddTeam("São Tomé and Príncipe");
            AddTeam("Saudi Arabia");
            AddTeam("Scotland");
            AddTeam("Senegal");
            AddTeam("Serbia");
            AddTeam("Seychelles");
            AddTeam("Sierra Leone");
            AddTeam("Singapore");
            AddTeam("Sint Maarten");
            AddTeam("Slovakia");
            AddTeam("Slovenia");
            AddTeam("Solomon Islands");
            AddTeam("Somalia");
            AddTeam("South Africa");
            AddTeam("South Sudan");
            AddTeam("Spain");
            AddTeam("Sri Lanka");
            AddTeam("Sudan");
            AddTeam("Suriname");
            AddTeam("Sweden");
            AddTeam("Switzerland");
            AddTeam("Syria");
            AddTeam("Tahiti");
            AddTeam("Tajikistan");
            AddTeam("Tanzania");
            AddTeam("Thailand");
            AddTeam("Timor-Leste");
            AddTeam("Togo");
            AddTeam("Tonga");
            AddTeam("Trinidad and Tobago");
            AddTeam("Tunisia");
            AddTeam("Turkey");
            AddTeam("Turkmenistan");
            AddTeam("Turks and Caicos Islands");
            AddTeam("Tuvalu");
            AddTeam("Uganda");
            AddTeam("Ukraine");
            AddTeam("United Arab Emirates");
            AddTeam("United States");
            AddTeam("Uruguay");
            AddTeam("US Virgin Islands");
            AddTeam("Uzbekistan");
            AddTeam("Vanuatu");
            AddTeam("Vatican City");
            AddTeam("Venezuela");
            AddTeam("Vietnam");
            AddTeam("Wales");
            AddTeam("Yemen");
            AddTeam("Zambia");
            AddTeam("Zanzibar");
            AddTeam("Zimbabwe");
            await _context.SaveChangesAsync();
        }
    }

    private void AddTeam(string name)
    {
        _context.Teams!.Add(new Team { Name = name, LogoPath = $"~/images/Teams/{name}.png" });
    }

    private async Task CheckTournamentsAsync()
    {
        if (!_context.Tournaments!.Any())
        {
            var startDate = DateTime.Today.AddMonths(2).ToUniversalTime();
            var endDate = DateTime.Today.AddMonths(3).ToUniversalTime();

            _context.Tournaments!.Add(new Tournament
            {
                StartDate = startDate,
                EndDate = endDate,
                IsActive = true,
                LogoPath = $"~/images/Tournaments/afc.jpg",
                Name = "Copa America 2020",
                Groups = new List<Group>
                    {
                        new() {
                             Name = "A",
                             GroupDetails = new List<GroupDetail>
                             {
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Colombia") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Ecuador") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Panama") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Canada") }
                             },
                             Matches = new List<Match>
                             {
                                 new() {
                                     Date = startDate.AddHours(14),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Colombia"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Ecuador")
                                 },
                                 new() {
                                     Date = startDate.AddHours(17),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Panama"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Canada")
                                 },
                                 new() {
                                     Date = startDate.AddDays(4).AddHours(14),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Colombia"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Panama")
                                 },
                                 new() {
                                     Date = startDate.AddDays(4).AddHours(17),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Ecuador"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Canada")
                                 },
                                 new() {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Canada"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Colombia")
                                 },
                                 new() {
                                     Date = startDate.AddDays(9).AddHours(16),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Ecuador"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Panama")
                                 }
                             }
                        },
                        new() {
                             Name = "B",
                             GroupDetails = new List<GroupDetail>
                             {
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Argentina") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Paraguay") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Mexico") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Chile") }
                             },
                             Matches = new List<Match>
                             {
                                 new() {
                                     Date = startDate.AddDays(1).AddHours(14),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Argentina"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Paraguay")
                                 },
                                 new() {
                                     Date = startDate.AddDays(1).AddHours(17),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Mexico"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Chile")
                                 },
                                 new() {
                                     Date = startDate.AddDays(5).AddHours(14),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Argentina"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Mexico")
                                 },
                                 new() {
                                     Date = startDate.AddDays(5).AddHours(17),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Paraguay"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Chile")
                                 },
                                 new() {
                                     Date = startDate.AddDays(10).AddHours(16),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Chile"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Argentina")
                                 },
                                 new() {
                                     Date = startDate.AddDays(10).AddHours(16),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Paraguay"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Mexico")
                                 }
                             }
                        },
                        new() {
                             Name = "C",
                             GroupDetails = new List<GroupDetail>
                             {
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Brasil") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Venezuela") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "USA") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Peru") }
                             },
                             Matches = new List<Match>
                             {
                                 new() {
                                     Date = startDate.AddDays(2).AddHours(14),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Brasil"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Venezuela")
                                 },
                                 new() {
                                     Date = startDate.AddDays(2).AddHours(17),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "USA"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Peru")
                                 },
                                 new() {
                                     Date = startDate.AddDays(6).AddHours(14),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Brasil"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "USA")
                                 },
                                 new() {
                                     Date = startDate.AddDays(6).AddHours(17),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Venezuela"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Peru")
                                 },
                                 new() {
                                     Date = startDate.AddDays(11).AddHours(16),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Peru"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Brasil")
                                 },
                                 new() {
                                     Date = startDate.AddDays(11).AddHours(16),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Venezuela"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "USA")
                                 }
                             }
                        },
                        new() {
                             Name = "D",
                             GroupDetails = new List<GroupDetail>
                             {
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Uruguay") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Bolivia") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Costa Rica") },
                                 new() { Team = _context.Teams!.FirstOrDefault(t => t.Name == "Honduras") }
                             },
                             Matches = new List<Match>
                             {
                                 new() {
                                     Date = startDate.AddDays(3).AddHours(14),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Uruguay"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Bolivia")
                                 },
                                 new() {
                                     Date = startDate.AddDays(3).AddHours(17),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Costa Rica"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Honduras")
                                 },
                                 new() {
                                     Date = startDate.AddDays(7).AddHours(14),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Uruguay"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Costa Rica")
                                 },
                                 new() {
                                     Date = startDate.AddDays(7).AddHours(17),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Bolivia"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Honduras")
                                 },
                                 new() {
                                     Date = startDate.AddDays(12).AddHours(16),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Honduras"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Uruguay")
                                 },
                                 new() {
                                     Date = startDate.AddDays(12).AddHours(16),
                                     Local = _context.Teams!.FirstOrDefault(t => t.Name == "Bolivia"),
                                     Visitor = _context.Teams!.FirstOrDefault(t => t.Name == "Costa Rica")
                                 }
                             }
                        }
                    }
            });

            startDate = DateTime.Today.AddMonths(1).ToUniversalTime();
            endDate = DateTime.Today.AddMonths(4).ToUniversalTime();

            await _context.SaveChangesAsync();
        }
    }
}