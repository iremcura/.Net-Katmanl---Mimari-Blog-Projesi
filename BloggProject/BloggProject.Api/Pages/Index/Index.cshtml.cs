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
using System.Text.Json;
using System.Threading.Tasks;

namespace BloggProject.Api.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IProfileServices _profileServices;
        public Task<IList<Profiles>> profile;
        public string message;

        public IndexModel(ILogger<IndexModel>logger)
        {
            _logger = logger;
            _profileServices = new ProfileServices();
        }

        public void OnGet()
        {
            var data = _profileServices.GetAllProfiles();
            message = "Ben Geldim";
        }
    }
}
