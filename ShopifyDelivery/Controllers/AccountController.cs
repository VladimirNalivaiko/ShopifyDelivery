using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.Configuration;
using Microsoft.AspNetCore.Mvc;
using ShopifyDelivery.BLL.Managers.Implementation;
using ShopifyDelivery.BLL.Model;

namespace ShopifyDelivery.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseApiController
    {
        private readonly ApplicationUserManager<ApplicationUser> _userManager;
        private readonly ApplicationSignInManager<ApplicationUser> _signInManager;
        public IConfiguration Configuration { get; }

        public AccountController(IConfiguration configuration,
            ApplicationUserManager<ApplicationUser> userManager,
            ApplicationSignInManager<ApplicationUser> signInManager)
        {
            Configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
        }


    }
}