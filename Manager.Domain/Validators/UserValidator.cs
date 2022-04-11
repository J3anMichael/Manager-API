using FluentValidation;
using Manager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
            .NotEmpty()
            .WithMessage("A entidade não pode ser vazia.")
            .NotNull()
            .WithMessage("A entidade não pode ser nula.");

            RuleFor(x => x.Name)
            .NotNull()
            .WithMessage("O nome não pode ser nulo.")

            .NotNull()
            .WithMessage("O nome não pode ser vazio.")

            .MinimumLength(3)
            .WithMessage("O nome deve ter no mínimo 3 caracteres.")

            .MaximumLength(80)
            .WithMessage("O nome deve ter no máximo 80 caracteres.");


            RuleFor(x => x.Password)
            .NotNull()
            .WithMessage("A senha não pode ser nula.")

            .NotNull()
            .WithMessage("A senha não pode estar com campo vazio.")

            .MinimumLength(6)
            .WithMessage("A senha deve ter no mínimo 6 caracteres.")

            .MaximumLength(30)
            .WithMessage("A senha deve ter no máximo 30 caracteres.");


            RuleFor(x => x.Email)
            .NotNull()
            .WithMessage("O e-mail não pode ser nulo.")

            .NotNull()
            .WithMessage("O e-mail não pode ser vazio.")

            .MinimumLength(3)
            .WithMessage("O e-mail deve ter no mínimo 10 caracteres.")

            .MaximumLength(80)
            .WithMessage("O e-mail deve ter no máximo 180 caracteres.")

            //.Matches();
            .WithMessage("O e-mail informado não é válido.");

        }
    }
}
