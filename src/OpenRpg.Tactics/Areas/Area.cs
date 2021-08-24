namespace OpenRpg.Tactics.Areas
{
    public class Area
    {
        public int XSize { get; set; }
        public int YSize { get; set; }
        public AreaCell[] Squares { get; set; }
    }
}