using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Concrete
{
    public partial class User
    {
        public class OperationClaim
        {
            [Key]
            public int ClaimId { get; set; }

            public string Name { get; set; }
        }
    }
}