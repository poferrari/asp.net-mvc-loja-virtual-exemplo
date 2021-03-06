﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtual.BLL._Base
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity Find(params object[] key);
        void Atualizar(TEntity obj);
        void SalvarTodos();
        IEnumerable<string> ObterErros();
        void Adicionar(TEntity obj);
        void Excluir(Func<TEntity, bool> predicate);
    }
}
