﻿using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_Web.Models;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<TokenDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegistrationRequestDTO registrationRequestDTO);
        Task<TokenDTO> RefreshAccessToken(TokenDTO tokenDTO);
    }
}
