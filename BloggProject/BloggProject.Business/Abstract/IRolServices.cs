using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BloggProject.Business.Abstract
{
   public interface IRolServices
    {
        Task<Rol> CreateRol(Rol rol);
        Task<Rol> GetRolByName(string rol_name);
        Task<Rol> GetRolById(int id);
        Task<Rol> UpdateRol(Rol rol);
        Task<bool> DeleteRol(int id);
        Task<IList<Rol>> GetAllRols();
    }
}
