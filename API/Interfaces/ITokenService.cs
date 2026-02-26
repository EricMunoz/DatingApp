using System;
using API.Entities;

namespace API.Interfaces;

public interface ITokenService
{
    /// <summary>
    /// Creates a JWT Token to return when logging into the system
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    string CreateToken(AppUser user);
}
