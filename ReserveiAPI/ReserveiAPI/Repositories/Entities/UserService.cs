using AutoMapper;
using ReserveiAPI.Objects.DTO_s.Entities;
using ReserveiAPI.Repositories.Interfaces;

namespace ReserveiAPI.Repositories.Entities
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService (IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public Task Create(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> GetAll()
        {
            var usersModel = await _userRepository.GetAll();
            userModel.ToList().ForEach(userDTO => usersModel.PasswordUser = "");
            return _mapper.Map<IEnumerable<UserDTO>>(usersModel);
        }

        public async Task<UserDTO> GetById(int id)
        {
            var userModel = await _userRepository.GetById(id);
            if(userModel is not null) userModel.PasswordUser = "";
            return _mapper.Map<UserDTO>(userModel);
        }

        public Task Update(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
