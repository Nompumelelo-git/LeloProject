using LeloProject.Models;

namespace LeloProject.Data
{
    public interface IClaimRepository 
    {
        IEnumerable<Claim> GetClaims { get; }

        Claim GetClaimById(int claimId);

        void AddClaim(Claim claim);

        void SaveChanges();
       
    }
}
