using BloggProject.DataAccess.Abstract;
using BloggProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggProject.DataAccess.Concrete
{
   public class ProfileRepository : IProfileRepository
    {
        public async Task<Profile> CreateProfile(Profile profile)
        {
            using (var profileDBContext = new BlogDBContext()) // using demek connection aç parantez bittiği an kapa demek
            {
                await profileDBContext.AddAsync(profile);
                await profileDBContext.SaveChangesAsync();
                return profile;
            }
        }

        public async  Task<Profile> GetProfileByCity(string city)
        {
            using (var profileDBContext = new BlogDBContext())
            {
                return await profileDBContext.Profiles.Where(w => w.City == city).FirstOrDefaultAsync();
            }
        }

        public async Task<Profile> GetProfileById(int id)
        {
            using (var profileDBContext = new BlogDBContext())
            {
                return await profileDBContext.Profiles.FindAsync(id);
            }
        }

        public async Task<Profile> UpdateProfile(Profile profile)
        {
            using(var profileDBContext = new BlogDBContext())
            {
                profileDBContext.Profiles.Update(profile);
                await profileDBContext.SaveChangesAsync();
                return profile;
            }
        }

        public async Task<bool> DeleteProfile(int id)
        {
            using (var profileDBContext = new BlogDBContext())
            {
                var deletedProfile = await GetProfileById(id);
                if (deletedProfile == null)
                    return false;
                profileDBContext.Profiles.Remove(deletedProfile);
                await profileDBContext.SaveChangesAsync();
                return true;
            }
        }

        public async Task<IList<Profile>> GetAllProfiles()
        {
            using (var profileDBContext = new BlogDBContext())
            {
                return await profileDBContext.Profiles.ToListAsync();
            }
        }

        
    }
}
