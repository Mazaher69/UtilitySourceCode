using Refit;

namespace ClassLibrary1.Interface
{
    [Headers("Accept: application/json")]
    public interface IUserService
    {
        [Get("/api/user/")]
        Task<List<UserDTO>> GetUsersAsync();

        [Post("/api/user")]
        Task PostAsync(UserDTO userDTO);
    }
}
