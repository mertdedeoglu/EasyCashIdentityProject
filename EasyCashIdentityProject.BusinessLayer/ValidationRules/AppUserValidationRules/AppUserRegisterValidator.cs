using FluentValidation;
using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                    .WithMessage("Ad alanı boş geçilemez.")
                .MaximumLength(30)
                    .WithMessage("Lutfen en fazla 30 karakter girisi yapin.")
                .MinimumLength(1)
                    .WithMessage("Lutfen en az 2 karakter veri girisi yapin.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alani bos gecilemez.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanici alani bos gecilemez.");
            RuleFor(x => x.Email)
                .NotEmpty()
                    .WithMessage("Email alani bos gecilemez.")
                .EmailAddress()
                    .WithMessage("Lutfen gecerli bir mail adresi giriniz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Sifre alani bos gecilemez.");
            RuleFor(x => x.ConfirmPassword)
                .NotEmpty()
                    .WithMessage("Sifre tekrar alani bos gecilemez.")
                .Equal(y => y.Password)
                    .WithMessage("Parolaniz eslesmiyor.");
        }
    }
}
