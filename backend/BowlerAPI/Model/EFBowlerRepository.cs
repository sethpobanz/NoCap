using BowlerAPI.Model;
using System.Linq;

public class EFBowlerRepository : IBowlersRepository
{
    private readonly BowlingLeagueContext _context;

    public EFBowlerRepository(BowlingLeagueContext context)
    {
        _context = context;
    }

    public IEnumerable<Bowler> GetBowlersWithTeams()
    {
        var query = from bowler in _context.Bowlers
                    join team in _context.Teams on bowler.TeamId equals team.TeamId
                    select new Bowler
                    {
                        BowlerId = bowler.BowlerId,
                        BowlerFirstName = bowler.BowlerFirstName,
                        BowlerLastName = bowler.BowlerLastName,
                        BowlerMiddleInit = bowler.BowlerMiddleInit,
                        BowlerAddress = bowler.BowlerAddress,
                        BowlerCity = bowler.BowlerCity,
                        BowlerState = bowler.BowlerState,
                        BowlerZip = bowler.BowlerZip,
                        BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                        Team = team // Assign the joined team to the Bowler's Team property
                    };

        return query.ToList();
    }
}


