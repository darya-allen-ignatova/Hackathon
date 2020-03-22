namespace DI.EventSetup.Business.Models
{
    public class ActivityResults
    {
        public int Id { get; set; }

        public int ActivityId { get; set; }

        public int GroupId { get; set; }

        public double Score { get; set; } = 0;
    }
}
