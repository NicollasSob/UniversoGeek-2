﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversoGeek.Domain.Shared.Transaction;

namespace UniversoGeek.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context.UniversoGeekDbContext _context;

        public UnitOfWork(Context.UniversoGeekDbContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
