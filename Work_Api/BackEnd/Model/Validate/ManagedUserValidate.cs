using FluentValidation;
using ReactAspWorkShop.BackEnd.Model.Request;

namespace ReactAspWorkShop.BackEnd.Model.Validate
{
    public class ManagedUserValidate
    {
    }

    public class InsertManagedUserValidate : AbstractValidator<InsertManagedUserRequest>
    {
        public InsertManagedUserValidate() 
        {
            RuleFor(R => R.Email).NotEmpty().WithMessage("{PropertyName} ต้องระบุคำ").NotNull().WithMessage("{PropertyName} ต้องไม่ null");
        }
    }

    public class UpdateManagedUserValidate : AbstractValidator<UpdateManagedUserRequest>
    {
        public UpdateManagedUserValidate()
        {
            RuleFor(R => R.Email).NotEmpty().WithMessage("{PropertyName} ต้องระบุคำ").NotNull().WithMessage("{PropertyName} ต้องไม่ null");
        }
    }

    public class DeleteManagedUserValidate : AbstractValidator<DeleteManagedUserRequest>
    {
        public DeleteManagedUserValidate()
        {
            RuleFor(R => R.Id).NotEmpty().WithMessage("{PropertyName} ต้องระบุคำ").NotNull().WithMessage("{PropertyName} ต้องไม่ null");
        }
    }
}
