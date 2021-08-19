namespace OpenRpg.Tactics.Leveling
{
    public interface IExperienceCalculator
    {
        int GetExperienceRequiredForLevel(int level);
    }
}