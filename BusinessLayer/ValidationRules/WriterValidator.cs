using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adı Soyadı Kısmı Boş Geçilemez !");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez !");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Boş Geçilemez !");

            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Giriş Yapın");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakterlik Giriş Yapın");
        }
    
    }
}
