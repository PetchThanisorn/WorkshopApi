using MediatR;
using ReactAspWorkShop.BackEnd.Model.Request;
using ReactAspWorkShop.BackEnd.Model.Response.Common;
using ReactAspWorkShop.BackEnd.Model.Validate;
using ReactAspWorkShop.BackEnd.View.Infrastructure;

namespace ReactAspWorkShop.BackEnd.Model.Function.Command
{
    public class InsertManagedUser : IRequest<BaseResponse<bool>>
    {
        public InsertManagedUserRequest request { get; set; } = new();
        public class DatabaseHandler : IRequestHandler<InsertManagedUser, BaseResponse<bool>> 
        {
            private readonly IManagedUserService _Infrastructure;
            public DatabaseHandler(IManagedUserService infrastructure)
            {
                _Infrastructure = infrastructure;
            }

            public async Task<BaseResponse<bool>> Handle(InsertManagedUser command, CancellationToken cancellationToken)
            {
                try
                {
                    var response = new BaseResponse<bool>();
                    InsertManagedUserValidate validator = new();
                    var validationResult = await validator.ValidateAsync(command.request, cancellationToken);
                    if (!validationResult.IsValid)
                    {
                        response.Success = false;
                        response.Message = "Validation Failed";
                        response.Error = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
                    }
                    else
                    {
                        response.ResponseObject = await _Infrastructure.InsertManageUser(command.request);
                        response.Success = true;
                        response.Message = "Success";
                    }
                    return response;
                }
                catch (Exception ex)
                {
                    return new BaseResponse<bool>() { Message = ex.Message };
                }
            }
        }
    }
}
