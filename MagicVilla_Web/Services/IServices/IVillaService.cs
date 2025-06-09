﻿using System.Linq.Expressions;
using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(VillaCreateDTO dto);
        Task<T> DeleteAsync<T>(int id);
        Task <T> UpdateAsync<T>(VillaUpdateDTO dto);
    }
}
