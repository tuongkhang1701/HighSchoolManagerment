namespace HighSchoolManagerment.Application.Interfaces
{
    public interface IUserService
    {
        User FindByEmail(string username);
    }
}