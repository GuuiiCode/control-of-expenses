using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ControlExpenses.Application.Behavior
{
    public class ValidatorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger<ValidatorBehavior<TRequest, TResponse>> _logger;
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidatorBehavior(ILogger<ValidatorBehavior<TRequest, TResponse>> logger, 
                                         IEnumerable<IValidator<TRequest>> validators)
        {
            _logger = logger;
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var typeName = request.GetType().Name;

            _logger.LogInformation("----- Validating command {CommandType}", typeName);

            var failures = _validators
                .Select(validator => validator.Validate(request))
                .SelectMany(validatonResult => validatonResult.Errors)
                .Where(error => error != null)
                .ToList();

            if (failures.Any())
            {
                _logger.LogWarning("Validation errors - {CommandType} - Command: {@Command} - Errors: {@ValidationErrors}", typeName, request, failures);

                throw new FluentValidation.ValidationException(failures);

                //throw new DomainException(
                //    message: $"Command Validation Errors for type {typeof(TRequest).Name}",
                //    innerException: new ValidationException("Validation exception", failures)
                //);
            }

            return await next();
        }
    }
}
