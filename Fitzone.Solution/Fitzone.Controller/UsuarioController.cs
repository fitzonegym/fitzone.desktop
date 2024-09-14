using Fitzone.Controller.Interfaces;
using Fitzone.EF;
using Fitzone.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Controller
{
    public class UsuarioController : IControllersClasesPrincipales<Usuario>
    {
        Contexto contexto = new Contexto();
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convierte la contraseña en bytes
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convierte los bytes en una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool Anular(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario>? GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario? GetByName(string NombreUsuario)
        {
            return contexto.Usuario.FirstOrDefault(i => i.NombreUsuario == NombreUsuario);
        }

        public bool Insert(Usuario entidad)
        {
            // Encriptar la contraseña antes de guardar
            entidad.Password = new UsuarioController().HashPassword(entidad.Password);

            // Guardar en la base de datos
            
            contexto.Usuario.Add(entidad);
            contexto.SaveChanges();

            return true;    
        }

        public bool VerificarContraseña(string contraseñaIngresada, string contraseñaAlmacenada)
        {
            // Hasheamos la contraseña ingresada
            string hashIngresado = new UsuarioController().HashPassword(contraseñaIngresada);

            // Comparamos el hash ingresado con el hash almacenado
            return hashIngresado.ToUpper() == contraseñaAlmacenada;
        }

        public bool Update(Usuario entidad, int id)
        {
            throw new NotImplementedException();
        }
    }
}
