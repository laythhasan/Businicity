// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplictionUser.cs" >
//  Hamza Nayef 
// </copyright>
// <summary>
//   The Repository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using BisnicityApp.InterFaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Infrastrucer.Repositry
{
    public class ApplictionUser<T> : IApplictionUser<T> where T : class, new()
    {
        #region Members
        protected DataContext oDataContext;
        #endregion
        #region Ctor
        public ApplictionUser(DataContext dataContext)
        {
            this.oDataContext = dataContext;
        }
        #endregion
        #region Methods
        #region Methods :: FindUser
        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserrID"></param>
        /// <returns></returns>
        public T FindUser(string UserrID)
        {
            return this.oDataContext.Set<T>().Find(UserrID);
        }
        #endregion
        #region Methdos:: LstGetAllUsers
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IQueryable<T>> LstGetAllUsers()
        {
            return this.oDataContext.Set<T>();
        }
        #endregion
        #region Methods :: UpdateUser
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Object"></param>
        /// <returns></returns>
        public async Task UpdateUser(T Object)
        {
            this.oDataContext.Set<T>().Update(Object);
        }
        #endregion
        #endregion
    }
}
