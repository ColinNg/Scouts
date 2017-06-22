public class Achievement
{
        public int AchievementId { get; set; }
        public string Description { get; set; }
        public datetime Introduced { get; set; }
        public datetime Retired { get; set; }
        
        public IList<Achievement> Requirements { get; set; }
        public bool Achieved { get; set; }
}
