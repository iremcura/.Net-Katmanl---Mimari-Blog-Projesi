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
    public class RolRepository : IRolRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rol"></param>
        /// <returns></returns>
        public async Task<Rol> CreateRol(Rol rol)
        {
            using (var rolDBContext = new BlogDBContext())
            {
                await rolDBContext.AddAsync(rol);
                await rolDBContext.SaveChangesAsync();
                return rol;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public async Task<bool> DeleteRol(int id)
        {   
            using (var rolDBContext = new BlogDBContext())
            {
                    var deletedRol = await GetRolById(id);
                    if (deletedRol == null)
                        return false;
                    rolDBContext.Rols.Remove(deletedRol);
                    await rolDBContext.SaveChangesAsync();
                    return true;
            }
            
        }

        public async Task<IList<Rol>> GetAllRols()
        {
            using (var rolDBContext = new BlogDBContext())
            {
                return await rolDBContext.Rols.ToListAsync();
            }
        }

        public async Task<Rol> GetRolById(int id)
        {
            using (var rolDBContext = new BlogDBContext())
            {
                return await rolDBContext.Rols.FindAsync(id);
            }
        }

        public async  Task<Rol> GetRolByName(string rol_name)
        {
            using (var rolDBContext = new BlogDBContext())
            {
                return await rolDBContext.Rols.Where(w => w.Name == rol_name).FirstOrDefaultAsync();
            }
        }

        public async Task<Rol> UpdateRol(Rol rol)
        {
            using (var rolDBContext = new BlogDBContext())
            {
                rolDBContext.Rols.Update(rol);
                await rolDBContext.SaveChangesAsync();
                return rol;
            }
        }
    }
}
