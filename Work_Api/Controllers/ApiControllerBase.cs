namespace ReactAspWorkShop.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]

    public abstract class ApiControllerBase : ControllerBase
    {
        private ISender _mediator = null;
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}

//using MediatR;
//using Microsoft.AspNetCore.Mvc;

//[ApiController]
//[Route("[controller]")]

//public abstract class ApiControllerBase : ControllerBase
//{
//    private ISender _mendiator = null;
//    protected ISender Mediatr => _mendiator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
//}