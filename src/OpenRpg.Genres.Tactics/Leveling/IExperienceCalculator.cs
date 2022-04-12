namespace OpenRpg.Genres.Tactics.Leveling
{
    public interface IExperienceCalculator
    {
        int GetExperienceRequiredForLevel(int level);
    }
}