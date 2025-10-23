using System.Text;
using System.Text.RegularExpressions;
namespace ArchitectureClean.Domain.ValueObject
{
    public class Email
    {
        public string Value { get; } = default!;

        protected Email() { }

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Email é Obrigatório");

            if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("E-mail inválido.");

            Value = value.ToLower().Trim();
        }

        public override string ToString() => Value;

        public override bool Equals(object? obj)
        {
            if (obj is Email email)
            {
                return Value.Equals(email.Value, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode() => Value.GetHashCode();


    }
}