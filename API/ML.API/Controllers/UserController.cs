using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ML.Data.Dtos;
using ML.Data.Interfaces;
using ML.Domain.Interfaces;
using ML.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ML.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UserController(IUnitOfWork UnitOfWork, IMapper Mapper)
        {
            unitOfWork = UnitOfWork;
            mapper = Mapper;
        }


        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                var users = unitOfWork.Users.FindAll();
                if (users == null)
                {
                    return null;
                }
                return users.ToList();
            }
            catch (Exception ex)
            {
                throw new NullReferenceException($"{nameof(User)} could not retreive records: | {ex.Message}");
            }
        }

        [HttpGet("{Id}")]
        public User GetUserById(int Id)
        {
            try
            {
                var user = unitOfWork.Users.FindByCondition(u => u.Id == Id).FirstOrDefault();
                if (user == null)
                {
                    return null;
                }

                return user;
            }
            catch (Exception ex)
            {
                throw new NullReferenceException($"{nameof(User)} could not find record: | {ex.Message}");
            }
        }

        [HttpPost]
        public ActionResult<RegistrationResponse> CreateUser(RegistrationRequest registrationRequest)
        {
            try
            {
                User userModel = mapper.Map<User>(registrationRequest);
                User userToCreate = unitOfWork.Users.Create(userModel);
                var result = mapper.Map<RegistrationResponse>(userToCreate);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not create record | {ex.Message}");
            }

            unitOfWork.CompleteAsync();
        }

        [HttpPut("{id}")]
        public void UpdateUser(User user)
        {
            try
            {
                unitOfWork.Users.Update(user);
            }
            catch (Exception ex)
            {

                throw new Exception($"Could not update record | {ex.Message}");
            }
            
        }

        [HttpDelete("{id}")]
        public void DeleteUser(User user)
        {
            try
            {
                unitOfWork.Users.Delete(user);
            }
            catch (Exception ex)
            {

                throw new Exception($"Could not delete record | {ex.Message}");
            }
            
        }
    }
}
