﻿using BO.DTO.Requests;
using BO.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IPageableRepository<TEntity>
    {
         Task<PageResponse<TEntity>> GetAllAsync(PageRequest pageRequest);
    }
}
