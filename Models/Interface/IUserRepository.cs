namespace InvestigationJob.Models.Interface
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAllUser();
        UserModel GetById(int id);
    }
}
