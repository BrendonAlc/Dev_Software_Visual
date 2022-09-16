using System;
using Trabalho;

namespace Batatinha
{
    class Program
    {
        static string welcome()
        {
            return "Bem Vindo!";
        }

        record ChavesUsuario(string nome, string email, string password);

        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            app.MapGet("/", welcome);

            BaseUsuario baseUsuarios = new baseUsuarios("usuarios.txt");

            var getUsuarios = () => {
                return baseUsuarios.Serializar();
            };

            app.MapGet("/usuarios", getUsuarios);

            var getUsuario = (string email) => {
                return baseUsuarios.BuscarPorEmail(email).Serializar();
            };

            app.MapGet("/usuarios/{email}", getUsuarios);

            var postUsuario = (ChavesUsuario u) => {
                var usuario = new Usuario(u.nome, u.email, u.password);
                baseUsuarios.AdicionarUsuario(usuario);
                
            }

            app.MapPost("/cadastrar", postUsuarios);

            app.Run();
        }
    }
}
