using ReactAspWorkShop.BackEnd.Model.Request;

namespace ReactAspWorkShop.BackEnd.View.Infrastructure
{
    public interface IManagedUserService
    {
        Task<bool> InsertManageUser(InsertManagedUserRequest request);
    }
}
