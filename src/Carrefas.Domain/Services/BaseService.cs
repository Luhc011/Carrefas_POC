using Carrefas.Domain.Interfaces.Notifications;
using Carrefas.Domain.Models;
using Carrefas.Domain.Notifications;
using FluentValidation;
using FluentValidation.Results;

namespace Carrefas.Domain.Services
{
    public abstract class BaseService
    {
        private readonly INotifier _notifier;

        protected BaseService(INotifier notifier)
        {
            _notifier = notifier;
        }

        protected void Notify(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notify(error.ErrorMessage);
            }
        }

        protected void Notify(string message)
        {
            _notifier.Handle(new Notification(message));
        }

        protected bool RunValidation<Validation, Entitie>(Validation validation, Entitie entitie)
            where Validation : AbstractValidator<Entitie> where Entitie : Entity
        {
            var validator = validation.Validate(entitie);

            if (validator.IsValid) return true;
            
            Notify(validator);
            
            return false;
        }
    }
}
