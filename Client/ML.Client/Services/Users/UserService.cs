using Microsoft.EntityFrameworkCore.Diagnostics;
using ML.Data.Dtos;
using ML.Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace ML.Client.Services.Users
{
    public class UserService : IUserService
    {
        private readonly HttpClient client;
        private readonly IConfiguration config;

        private string errorMessage;

        public UserService(HttpClient Client, IConfiguration Config)
        {
            client = Client;
            config = Config;
        }

        public async Task<RegistrationResponse> CreateUser(RegistrationRequest registrationRequest)
        {
            try
            {
                var response = await client.PostAsJsonAsync("api/user", registrationRequest);
                errorMessage = response.ReasonPhrase;

                if (!response.IsSuccessStatusCode)
                {
                    return new RegistrationResponse
                    {
                        FirstName = string.Empty,
                        LastName = string.Empty,
                        IdNumber = 0,
                        PhoneNumber = 0,
                        Address = string.Empty,
                    };
                }

                var apiResponse = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<RegistrationResponse>(apiResponse);

                return user;

            }
            catch (Exception ex)
            {
                errorMessage = "Could not create user";
                Console.WriteLine($"{errorMessage} | {ex.Message}");
                throw new Exception(errorMessage, ex);

            }
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await client.GetFromJsonAsync<IEnumerable<User>>("api/user/");
        }

        public async Task<User> GetUserById(int Id)
        {
            return await client.GetFromJsonAsync<User>("api/user/" + Id);
        }

        public async Task<LoginResponse> HandleLogin(LoginRequest loginRequest)
        {
            try
            {
                var response = await client.PostAsJsonAsync("api/user/", loginRequest);

                errorMessage = response.ReasonPhrase;

                if (!response.IsSuccessStatusCode)
                {
                    return new LoginResponse
                    {
                        Username = string.Empty,
                        Password = string.Empty,
                        FirstName = string.Empty,
                        IsAdmin = false
                    };
                }

                //response.EnsureSuccessStatusCode();

                var apiResponse = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<LoginResponse>(apiResponse);

                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{errorMessage} | {ex.Message}");
                throw new Exception(errorMessage, ex);

            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                var response = client.PutAsJsonAsync("api/employee/" + user.Id, user);

            }
            catch (Exception ex)
            {
                errorMessage = "Could not update user";
                Console.WriteLine($"{errorMessage} | {ex.Message}");
                throw new Exception(errorMessage, ex);

            }
        }

        
    }
}
