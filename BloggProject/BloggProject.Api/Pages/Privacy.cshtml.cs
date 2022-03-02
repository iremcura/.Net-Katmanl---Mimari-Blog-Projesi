using BloggProject.Business.Abstract;
using BloggProject.Business.Concrete;
using BloggProject.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggProject.Api.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private IProfileServices _profileServices;
        public Task<IList<Profile>> profile;
        
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
            _profileServices = new ProfileServices();
        }

        public void OnGet()
        {
            var data = _profileServices.GetAllProfiles();
        }
    }
}
