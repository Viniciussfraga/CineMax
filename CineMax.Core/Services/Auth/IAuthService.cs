﻿using CineMax.Core.DTOs.AuthDTOs.Requests;
using CineMax.Core.DTOs.AuthDTOs.Responses;

namespace CineMax.Core.Services.Auth
{
    public interface IAuthService
    {
        Task<RegisterUserResponse> RegisterUser(RegisterUserRequest registerUser);
        Task<UserLoginResponse> Login(UserLoginRequest userLogin);
    }
}
