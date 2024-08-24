using ReserveiAPI.Objects.DTO_s.Entities;

namespace ReserveiAPI.Repositories.Interfaces
{
    public interface IUserService
    {

        Task<IEnumerable<UserDTO>> GetAll();
        Task<UserDTO> GetById(int id);
        Task Create (UserDTO userDTO);
        Task Update(UserDTO userDTO);
        Task Delete(UserDTO userDTO);

    }
}
