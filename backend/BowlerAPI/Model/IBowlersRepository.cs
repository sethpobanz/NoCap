using BowlerAPI.Model;

public interface IBowlersRepository
{
    IEnumerable<Bowler> GetBowlersWithTeams();
}

