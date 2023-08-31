namespace Vault.Entities.DbSet
{
    public class JobStatus
    {
        public string Active { get; set; }
        public string Busy { get; set; }
        public string PTO { get; set; }
        public string OOO { get; set; }
        public string Complete { get; set; }
    }
}