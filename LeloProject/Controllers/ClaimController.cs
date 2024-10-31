using LeloProject.Data;
using LeloProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeloProject.Controllers
{
    public class ClaimController : Controller
    {
        private readonly IClaimRepository _claimRepository;

        public ClaimController(IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(Claim claim)
        {
            if(ModelState.IsValid)
            {
                _claimRepository.AddClaim(claim);
                _claimRepository.SaveChanges();

                return RedirectToAction("ClaimAdded");
            }
            else
             return View(claim);
        }

        public IActionResult ClaimAdded()
        {
            return View();
        }

    }
}
