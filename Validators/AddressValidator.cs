using FluentValidation;
using JobarCharityInitProject.Infrastructure.Integrations.Data.Models;
using Repository_pattern_API.DTOs.AddressDto;
using Repository_pattern_API.Infrastructure.Integrations.Data.Models;

namespace Repository_pattern_API.Validators
{
    public class AddressCreateValidator : AbstractValidator<AddressCreateDto>
    {
        public AddressCreateValidator()
        {
            RuleFor(a => a.Country).NotEmpty().WithMessage("Country is required.")
            .MaximumLength(56).WithMessage("Country must not exceed 56 characters.");
            RuleFor(a => a.City).NotEmpty().WithMessage("City is required.")
            .MaximumLength(85).WithMessage("City must not exceed 85 characters.");
            RuleFor(a => a.StreetName).NotEmpty().WithMessage("Street Name is required.")
            .MaximumLength(100).WithMessage("Street Name must not exceed 100 characters.");
            RuleFor(a => a.HomeNum).MaximumLength(15).WithMessage("Home Num must not exceed 15 characters.");
            RuleFor(a => a.FullAddress).NotEmpty().WithMessage("Full Address is required.")
            .MaximumLength(300).WithMessage("Full Address must not exceed 300 characters.");
        }
    }

    public class AddressUpdateValidator : AbstractValidator<AddressUpdateDto>
    {
        public AddressUpdateValidator()
        {
            RuleFor(p => p.Id).GreaterThan(0);
            RuleFor(a => a.Country).NotEmpty().WithMessage("Country is required.")
            .MaximumLength(56).WithMessage("Country must not exceed 56 characters.");
            RuleFor(a => a.City).NotEmpty().WithMessage("City is required.")
            .MaximumLength(85).WithMessage("City must not exceed 85 characters.");
            RuleFor(a => a.StreetName).NotEmpty().WithMessage("Street Name is required.")
            .MaximumLength(100).WithMessage("Street Name must not exceed 100 characters.");
            RuleFor(a => a.HomeNum).MaximumLength(15).WithMessage("Home Num must not exceed 15 characters.");
            RuleFor(a => a.FullAddress).NotEmpty().WithMessage("Full Address is required.")
            .MaximumLength(300).WithMessage("Full Address must not exceed 300 characters.");
        }
    }
}