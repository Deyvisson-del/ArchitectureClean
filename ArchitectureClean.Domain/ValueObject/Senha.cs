using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
namespace ArchitectureClean.Domain.ValueObject
{
    public class Senha
    {
        public string Hash { get; } = string.Empty;

        protected Senha() { }

        public Senha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha)) throw new ArgumentException("A Senha não pode ser nula");

            if (senha.Length < 8) throw new ArgumentException("A Senha não pode ser menor que 8 digitos");

            if (!Regex.IsMatch(senha, @"[A-Z]")) throw new ArgumentException("A senha tem que ter ao menos uma Letra maiúscula");

            if (!Regex.IsMatch(senha, @"[!@#$%^&*(),.?""{}|<]")) throw new ArgumentException("A senha teve ter ao menos um caracter especial");

            if (!Regex.IsMatch(senha, @"[0-9]")) throw new ArgumentException("A senha teve conter ao menos um número");

            Hash = GerarHash(senha);
        }

        private static string GerarHash(string senha)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
            return Convert.ToBase64String(bytes);
        }

        public bool Verificar(string senha)
        {
            var hashVerficacao = GerarHash(senha);
            return Hash == hashVerficacao;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Senha other)
                return false;

            return Hash == other.Hash;
        }

        public override int GetHashCode() => Hash.GetHashCode();

        public static implicit operator Senha(string value)
       => new Senha(value);
    }
}