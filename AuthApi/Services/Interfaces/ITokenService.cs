﻿using AuthApi.Models;

namespace AuthApi.Services.Interfaces;

public interface ITokenService
{
    Task<string> CreateToken(User user, List<string> roles, string key, string issuer, string audience);
}
