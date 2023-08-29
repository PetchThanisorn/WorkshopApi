using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReactAspWorkShop.BackEnd.Model.Function.Command;
using ReactAspWorkShop.BackEnd.Model.Response.Common;

namespace ReactAspWorkShop.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ManagedUserController : ApiControllerBase
    {
        [HttpPost("InsertManageUser")]
        public async Task<ActionResult<BaseResponse<bool>>> InsertManageUser(InsertManagedUser Execute) => Ok(await Mediator.Send(Execute));

    }
} //
