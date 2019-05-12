using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Interfaces;
using System;

namespace Protectos.Infra.Data.UoW
{
    public class UnitOfWOrk : IUnitOfWork
    {
        private readonly ProtectosContext _context;
        private bool _disposed;
        public UnitOfWOrk(ProtectosContext context)
        {
            // teste
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
