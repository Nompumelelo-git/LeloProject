using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using LeloProject.Models;

namespace LeloProject.Data
{
    public class ClaimRepository :  IClaimRepository
    {
        private readonly AppDbContext _appDbContext;

        public ClaimRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Claim> GetClaims
        { 
            get
            {
                return _appDbContext.Claims;
            }
        }
       

      public Claim GetClaimById(int claimId)
        {
            return _appDbContext.Claims.FirstOrDefault(c => c.claimID == claimId);
        }

        public void AddClaim(Claim claim)
        {
            _appDbContext.Claims.Add(claim);
        }

      
        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }
    }
}
