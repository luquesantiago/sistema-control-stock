using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using servicios;
using datos;

namespace logica
{
    public class CrearUsuario
    {
        public string permiso = "persona";
        public bool crear (string username, string password, string nombre, string gmail, string numeroTelefono, string tipoTelefono, DateTime fechaInicio, DateTime fechaFin,string localidad)
        {
       
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            if( agregarUsuario.nuevo(username, PasswordEncryptor.EncryptPassword(password)+PasswordEncryptor.EncryptPassword(username), nombre, gmail, numeroTelefono, tipoTelefono, fechaInicio, fechaFin, permiso,localidad)==true)
            {
                ArmarMail.Asunto = "Contraseña";
                ArmarMail.DireccionCorreo = gmail;
                ArmarMail.NuevaContraseña = password;
                ArmarMail.Preparar();
                return true;
            }
            else
            {
                return false;
            }

               
           
        }
        

    }
}