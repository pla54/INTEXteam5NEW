using INTEXteam5.Models;
using INTEXteam5.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;


namespace INTEXteam5.Controllers
{
    public class HomeController : Controller
    {
        private IIntexRepository _repo;

        public HomeController(IIntexRepository temp)
        {
          _repo = temp;
        }


        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        // Modify the constructor to accept both ILogger<HomeController> and UserManager<IdentityUser>
        //public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, IIntexRepository temp)
        //{
        //    _logger = logger;
        //    _userManager = userManager; // Now userManager is defined as a parameter
        //    _repo = temp;
        //}

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Secrets()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult MyCart()
        {
            return View();
        }
        public IActionResult MyOrder()
        {
            return View();
        }
        public IActionResult Order(int pageNum)
        {
            int pageSize = 20;


            var blah = new OrdersListViewModel
            {
                Orders = _repo.Orders
                    .OrderBy(x => x.TransactionId)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Orders.Count()
                }
            };
            return View(blah);
        }
        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult Product(int pageNum)
        {
            int pageSize = 5;

            var blah = new ProductListViewModel
            {
                Products = _repo.Products
                    .OrderBy(x => x.Name)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Products.Count()
                }
            };

            return View(blah);
        }
        public IActionResult Caleb()
        {
            return View();
        }

        //[HttpGet]
        //[Authorize(Roles = "Admin")]
        //public IActionResult AdminAction()
        //{
        //    return View("Admin");
        //}
        //[HttpGet]
        //[Authorize(Roles = "Admin")]
        //public IActionResult ViewUsers()
        //{
        //    List<IdentityUser> users = _userManager.Users.ToList();
        //    return View(users);
        //}


        //[HttpGet]
        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> EditRoles(string userId)
        //{
        //    var user = await _userManager.FindByIdAsync(userId);
        //    var viewModel = new EditRoles
        //    {
        //        UserId = user.Id,
        //        UserName = user.UserName,
        //        Roles = _roleManager.Roles.Select(r => new UserRoleViewModel
        //        {
        //            RoleId = r.Id,
        //            RoleName = r.Name,
        //            IsSelected = _userManager.IsInRoleAsync(user, r.Name).Result
        //        }).ToList()
        //    };

        //    return View(viewModel);
        //}

        //[HttpPost]
        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> EditRoles(EditRoles model)
        //{
        //    var user = await _userManager.FindByIdAsync(model.UserId);

        //    foreach (var role in model.Roles)
        //    {
        //        if (role.IsSelected && !(await _userManager.IsInRoleAsync(user, role.RoleName)))
        //        {
        //            await _userManager.AddToRoleAsync(user, role.RoleName);
        //        }
        //        else if (!role.IsSelected && await _userManager.IsInRoleAsync(user, role.RoleName))
        //        {
        //            await _userManager.RemoveFromRoleAsync(user, role.RoleName);
        //        }
        //    }

        //    return RedirectToAction("ViewUsers"); // Or wherever you want to redirect
        //}
        ////public async Task<IActionResult> Delete(string id)
        ////{
        ////    IdentityUser user = await _userManager.FindByIdAsync(id);
        ////    IdentityResult result = await _userManager.DeleteAsync(user);

        ////    return RedirectToAction("ViewUsers");
        ////}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
