using Data.Config;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorios
{
    public class RepositoryGenerics<T> : IGenerics<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<ContextBase> _OptionBuilder;
        public RepositoryGenerics()
        {
            _OptionBuilder = new DbContextOptions<ContextBase>();
        }
        public async Task Add(T Objeto)
        {
            using (var data = new ContextBase(_OptionBuilder))
            {
                await data.Set<T>().AddAsync(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task Delete(T Objeto)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> List()
        {
            throw new NotImplementedException();
        }

        public async Task Update(T Objeto)
        {
            throw new NotImplementedException();
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);



        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
        #endregion
    }
}
