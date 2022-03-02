using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BloggProject.DataAccess.Abstract
{
    public interface IProfileRepository
    {

        Task<Profile> CreateProfile(Profile profile);
        Task<Profile> GetProfileByCity(string city);
        Task<Profile> GetProfileById(int id);
        Task<Profile> UpdateProfile(Profile profile);
        Task<bool> DeleteProfile(int id);
        Task<IList<Profile>> GetAllProfiles();
    }
}
