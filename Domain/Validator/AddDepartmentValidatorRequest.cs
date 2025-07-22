using Domain.DTO;
using FluentValidation;

namespace DS.Domain.Validator
{
    public class AddDepartmentValidatorRequest : AbstractValidator<AddDepartmentRequest>
    {
        public AddDepartmentValidatorRequest()
        {
            RuleFor(model => model.Name).NotEmpty();

            RuleFor(model=>model.Code).NotEmpty();
            
            RuleFor(model => model.Descriptions).NotEmpty();   
        }
    }
}
