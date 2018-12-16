using System;

namespace LojaVirtual.BLL._Base
{
    public interface IUnitOfWork : IDisposable
    {
        void AbrirTransacao();
        void Commit();
        void Rollback();
    }
}
