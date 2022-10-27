using ML.Data.Dtos;
using ML.Domain.Models;

namespace ML.Client.Services.Users
{
    public interface IUserService
    {
        Task<IEnumerable<User>>GetAllUsers();
        Task<User>GetUserById(int Id);
        Task<RegistrationResponse>CreateUser(RegistrationRequest registrationRequest);
        void UpdateUser(User user);

        Task<LoginResponse> HandleLogin(LoginRequest loginRequest);
    }
}
