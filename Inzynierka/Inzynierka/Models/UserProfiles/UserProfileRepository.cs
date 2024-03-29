﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Inzynierka.Data;
using Inzynierka.Models.ApplicationUsers;
using Inzynierka.Models.TripAdverts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Inzynierka.Models.UserProfiles
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly AppDbContext _appDbContext;
        public readonly IHttpContextAccessor _httpContextAccessor;
        public readonly UserManager<ApplicationUser> _userManager;

        public UserProfileRepository(AppDbContext appDbContext, IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            _appDbContext = appDbContext;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public ApplicationUser GetUserProfile()
        {
            string UserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return _appDbContext.ApplicationUsers.Where(u => u.Id ==UserId).Single();
        }

        public ApplicationUser GetUserProfileByEmail(string email)
        {
            return _appDbContext.ApplicationUsers.Where(u => u.Email == email).FirstOrDefault();
        }

        public IEnumerable<TripAdvert> GetTripAdvertsByUserId(string email)
        {
            return _appDbContext.TripAdverts.Where(t => t.UserEmail == email).OrderByDescending(t => t.AdvertDate);
        }

        public IEnumerable<TripAdvert> GetMyTripAdverts()
        {
            string UserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return _appDbContext.TripAdverts.Where(t => t.UserId == UserId).OrderByDescending(t => t.AdvertDate);
        }

        public IEnumerable<ApplicationUser> Search(string search)
        {
            return _userManager.Users.Where(x => x.Email.Contains(search));
        }
    }
}
