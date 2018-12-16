using LojaVirtual.BLL._Base;
using LojaVirtual.DAL.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LojaVirtual.DAL._Base
{
    public abstract class RepositorioBase<TEntity> : IDisposable,
       IRepositorioBase<TEntity> where TEntity : class
    {
        private readonly LojaVirtualContexto _ctx = new LojaVirtualContexto();

        public IQueryable<TEntity> GetAll()
        {
            return _ctx.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return _ctx.Set<TEntity>().Find(key);
        }

        public void Atualizar(TEntity obj)
        {
            _ctx.Entry(obj).State = EntityState.Modified;
        }

        public void SalvarTodos()
        {
            _ctx.SaveChanges();
        }

        public IEnumerable<string> ObterErros()
        {
            var erros = new List<string>();
            var validacoes = _ctx.GetValidationErrors();
            if (validacoes == null || !validacoes.Any())
                return erros;
            foreach (var erro in validacoes)
            {
                if (erro == null)
                    continue;
                erros.AddRange(erro.ValidationErrors
                        .Select(t => $"{erro.Entry.Entity.ToString()}: {t.ErrorMessage}".Trim()).ToList());
            }
            return erros;
        }

        public void Adicionar(TEntity obj)
        {
            _ctx.Set<TEntity>().Add(obj);
        }

        public void Excluir(Func<TEntity, bool> predicate)
        {
            _ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => _ctx.Set<TEntity>().Remove(del));
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
