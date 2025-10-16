namespace ArchitectureClean.Domain.ValueObject
{
    public class Email
    {
        public string Value { get; } = default!;

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Email é Obrigatório");

            if(!value.Contains("@")) throw new ArgumentException("Email Inválido");
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Email email)
            {
                return Value.Equals(email.Value, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode() => Value.GetHashCode();
       
        public override string ToString() => Value;

    }
}