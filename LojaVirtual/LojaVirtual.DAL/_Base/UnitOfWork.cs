using LojaVirtual.BLL._Base;
using LojaVirtual.DAL.Contexto;
using System;
using System.Data.Entity;

namespace LojaVirtual.DAL._Base
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly LojaVirtualContexto _contexto;
        private DbContextTransaction _transaction;

        public UnitOfWork(LojaVirtualContexto contexto)
        {
            _contexto = contexto;
        }

        public void AbrirTransacao()
        {
            _transaction = _contexto.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
