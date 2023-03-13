﻿using EPAMapp.Domain.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace EPAMapp.DAL.DataBaseExists
{
    public static class Exist<T> where T : BaseEntity
    {
        public static bool DataBaseIsNotExist(DbContext context)
        {
            if (context.Set<T>() == default(DbSet<T>))
                return true;

            return false;
        }
        public static bool EntityIsNotExist(T entity)
        {
            if (entity == null)
                return true;

            return false;
        }
        public static bool EntityIsNoExist(List<T> entities)
        {
            if (entities == null || !entities.Any())
                return true;

            return false;
        }
    }
}