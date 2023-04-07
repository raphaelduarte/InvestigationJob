using InvestigationJob.Models.Interface;

namespace InvestigationJob.Models.Service
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<UserModel> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
