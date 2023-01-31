using Dapper;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.BAL.Implementation
{
    public class Authentication:GMEntity<LoginDetails>,IAuthentication
    {
        public Authentication()
        {

        }

        public async Task<string>Login(LoginDetails loginDetails)
        {
            if (loginDetails == null)
            {
                throw new NullReferenceException("Please Enter Details.......!");
            }

            var connection = this.GetConnection();
            var userId = (await connection.QueryAsync<LoginDetails>($"select * from logindetails where emailid = '{loginDetails.EmailId}' and password = '{loginDetails.Password}'")).FirstOrDefault();

            if (userId == null)
            {
                throw new KeyNotFoundException(message: "Please Enter Valid Details");
            }

            var token = await this.GenerateToken(userId);
            return token;
        }

        public async Task<string> GenerateToken(LoginDetails loginDetails)
        {
            var secret = "bGtqaGdmZHNhQVNERkdISktMTExMTExLSkhHRkRTQVNERkdISktMQkpVSERSOFVHREpCVVRSUjg3SEU0NUhTRUJOT1Q1WU5YUjg2WUU0UE9EIFBVTkRBSS5TVU5JSS5USEFBQUEuLi4uIFVOQUdBIEFQUEFOIEVSVUtLQSBQQVJVLi5LT01NQUFBLEFUSEEgTU9UVEEgVEhBTEEgU1VOTkkgTUFISURFT0tPSklNQQ==";
            var symmetricKey = Convert.FromBase64String(secret);
            var tokenHandler = new JwtSecurityTokenHandler();
            JsonSerializer serializer = new JsonSerializer();
            var claims = new List<Claim>()
            {
                new (ClaimTypes.Name, loginDetails.EmailId),
                new ("UserId", loginDetails.Id.ToString()),
                new ("UserData", JsonConvert.SerializeObject(loginDetails)),
            };
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims.ToArray()),
                Expires = DateTime.Now.AddMinutes(1880),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey),
                    SecurityAlgorithms.HmacSha256Signature),
                Audience = "Jwt-Audience",
                Issuer = "Jwt-Issuer"
            };

            var secureToken = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(secureToken);
        }
    }
}
