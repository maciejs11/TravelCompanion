using Inzynierka.Models.Administration;
using Inzynierka.Models.ApplicationUsers;
using Inzynierka.Models.TripAdverts;
using Inzynierka.Models.UserProfiles;
using Inzynierka.ViewModels;
using Inzynierka.ViewModels.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITripAdvertRepository _tripAdvertRepository;
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IAdministrationRepository _administrationRepository;

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager,
                                        ITripAdvertRepository tripAdvertRepository, IUserProfileRepository userProfileRepository,
                                        IAdministrationRepository administrationRepository)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _tripAdvertRepository = tripAdvertRepository;
            _userProfileRepository = userProfileRepository;
            _administrationRepository = administrationRepository;
            
        }

        public async Task<IActionResult> DeleteUser (string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if(user == null)
            {
                return View("NotFoundUser");
            }
            else
            {
                _tripAdvertRepository.DeleteTripAdvertByUserId(user.Id);
                var result = await _userManager.DeleteAsync(user);
                
                if (result.Succeeded)
                {
                    return RedirectToAction("ListUsers");                   
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View("ListUsers");
        }

        
        public IActionResult ListUsers(string search = null)
        {
            if(!string.IsNullOrEmpty(search))
            {
                var foundUsers = _administrationRepository.Search(search);
                return View(foundUsers);
            }
            var users = _userManager.Users.OrderBy(x => x.UserName);
            return View(users);
        }

        [HttpPost]
        public IActionResult DeleteTripAdvertAdmin(Guid id)
        {
            _tripAdvertRepository.DeleteTripAdvertAdmin(id);
            return RedirectToAction("ListTripAdverts");

        }

        [HttpGet]
        public IActionResult ListTripAdverts()
        {
            var tripAdverts = _tripAdvertRepository.GetAllTripAdverts().OrderByDescending(t => t.AdvertDate);
            return View(tripAdverts);
        }

        //TODO: zrobić delete role

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if(ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                IdentityResult result = await _roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Administration");
                }
                foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }           
            return View(model);
        }
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            foreach(var user in _userManager.Users)
            {
                if(await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);

            role.Name = model.RoleName;
            var result = await _roleManager.UpdateAsync(role);
         
            if(result.Succeeded)
            {
                return RedirectToAction("ListRoles");
            }

            foreach( var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
          
            return View(model);
        }


        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return View("NotFoundUser");
            }
            else
            {

                var result = await _roleManager.DeleteAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View("Listroles");
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await _roleManager.FindByIdAsync(roleId);

            if(role==null)
            {
                ViewBag.ErrorMessage = $"Rola o id = {roleId} nie została odnaleziona";
            }

            var model = new List<UserRoleViewModel>();

            foreach(var user in _userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if(await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);

            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rola o id = {roleId} nie została odnaleziona";
            }

            for(int i = 0; i<model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].UserId);
                IdentityResult result = null;

                if(model[i].IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }

                else if (!model[i].IsSelected && (await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }

                else
                {
                    continue;
                }

                if(result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { Id = roleId });
                }

            }

            return RedirectToAction("EditRole", new { Id = roleId });
        }

    }
}
