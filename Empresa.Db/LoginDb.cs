using System;
using System.Linq;
using System.Text.RegularExpressions; 
using Empresa.Models;
using Microsoft.AspNetCore.Identity;

namespace Empresa.Db
{
    public class LoginDb
    {
        public static class TipoUsuario
        {
            public const int Colaborador = 0;
            public const int Tecnico = 1;
        }

        private readonly PasswordHasher<Login> _passwordHasher;

        public LoginDb()
        {
            _passwordHasher = new PasswordHasher<Login>();
        }

        public void Create(Login login)
        {
            
            if (string.IsNullOrWhiteSpace(login.Nome) || string.IsNullOrWhiteSpace(login.Email) || string.IsNullOrWhiteSpace(login.Usuario))
                throw new Exception("Dados inválidos: Os campos obrigatórios não podem estar vazios.");

            
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(login.Email, emailPattern))
                throw new Exception("Dados inválidos: Formato de e-mail incorreto.");

            
            string senhaPattern = @"^(?=.*[A-Z])(?=.*[^a-zA-Z0-9]).{6,}$";
            if (!Regex.IsMatch(login.Senha, senhaPattern))
                throw new Exception("Dados inválidos: A senha não atinge os critérios de segurança do sistema.");

            using (var ctx = new AppDbContext())
            {
                
                bool usuarioExiste = ctx.Usuarios.Any(u => u.Usuario == login.Usuario || u.Email == login.Email);

                if (usuarioExiste)
                {
                    
                    throw new Exception("Já existe um usuário cadastrado com este E-mail ou Nome de Usuário.");
                }

                
                login.Senha = _passwordHasher.HashPassword(login, login.Senha);

                ctx.Usuarios.Add(login);
                ctx.SaveChanges();
            }
        }

        public Login Autenticar(string usuario, string senha)
        {
            using (var ctx = new AppDbContext())
            {
                var user = ctx.Usuarios.FirstOrDefault(u => u.Usuario == usuario);

                if (user == null)
                    return null;

                var result = _passwordHasher.VerifyHashedPassword(user, user.Senha, senha);

                if (result == PasswordVerificationResult.Success)
                {
                    return user;
                }

                return null;
            }
        }

        public bool ResetarSenha(string usuario, string email, string novaSenha)
        {
            
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(novaSenha))
                throw new Exception("Backend rejeitou: Campos obrigatórios não podem estar vazios.");

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
                throw new Exception("Backend rejeitou: Formato de e-mail incorreto.");

            string senhaPattern = @"^(?=.*[A-Z])(?=.*[^a-zA-Z0-9]).{6,}$";
            if (!Regex.IsMatch(novaSenha, senhaPattern))
                throw new Exception("Backend rejeitou: A nova senha não cumpre os requisitos mínimos de complexidade.");

            using (var ctx = new AppDbContext())
            {
                
                var user = ctx.Usuarios.FirstOrDefault(u => u.Usuario == usuario && u.Email == email);

                if (user != null)
                {
                    
                    var verificacao = _passwordHasher.VerifyHashedPassword(user, user.Senha, novaSenha);
                    if (verificacao == PasswordVerificationResult.Success)
                    {
                        throw new Exception("A nova senha não pode ser igual à sua senha atual.");
                    }

                    
                    user.Senha = _passwordHasher.HashPassword(user, novaSenha);
                    ctx.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }
    }
