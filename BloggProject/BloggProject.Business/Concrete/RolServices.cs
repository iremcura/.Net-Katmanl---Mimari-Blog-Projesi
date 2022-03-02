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
    public class RolServices : IRolServices
    {
        private IRolRepository _rolRepository;
        /// <summary>
        /// 
        /// </summary>
        public RolServices()
        {
            _rolRepository = new RolRepository();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rol"></param>
        /// <returns></returns>
        public async Task<Rol> CreateRol(Rol rol)
        {
            return await _rolRepository.CreateRol(rol);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteRol(int id)
        {
            return await _rolRepository.DeleteRol(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Rol>> GetAllRols()
        {
            var response = await _rolRepository.GetAllRols();
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Rol> GetRolById(int id)
        {
            return await _rolRepository.GetRolById(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rol_name"></param>
        /// <returns></returns>
        public async Task<Rol> GetRolByName(string rol_name)
        {
            return await _rolRepository.GetRolByName(rol_name);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rol"></param>
        /// <returns></returns>
        public async Task<Rol> UpdateRol(Rol rol)
        {
            return await _rolRepository.UpdateRol(rol);
        }
    }
}
