namespace Core.Entities.Concrete
{
    public partial class User
    {
        public class UserOperationClaim
        {
            public int UserOperationClaimId { get; set; }
            public int UserId { get; set; }
            public int ClaimId { get; set; }
        }
    }
}