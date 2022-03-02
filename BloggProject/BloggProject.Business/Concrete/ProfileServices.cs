using BloggProject.Business.Abstract;
using BloggProject.DataAccess.Abstract;
using BloggProject.DataAccess.Concrete;
using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BloggProject.Business.Concrete
{
    public class ProfileServices : IProfileServices
    {
        private IProfileRepository _profileRepository;
        public ProfileServices()
        {
            _profileRepository = new ProfileRepository();
        }
        public async Task<Profile> CreateProfile(Profile profile)
        {
            return await _profileRepository.CreateProfile(profile);
        }

        public async Task<bool> DeleteProfile(int id)
        {
            return await _profileRepository.DeleteProfile(id);
        }

        public async Task<IList<Profile>> GetAllProfiles()
        {
            var response = await _profileRepository.GetAllProfiles();
            return response;

        }

        public async Task<Profile> GetProfileByCity(string city)
        {
            return await _profileRepository.GetProfileByCity(city);
        }

        public async Task<Profile> GetProfileById(int id)
        {
            return await _profileRepository.GetProfileById(id);
        }

        public async Task<Profile> UpdateProfile(Profile profile)
        {
            return await _profileRepository.UpdateProfile(profile);

        }
    }
}
