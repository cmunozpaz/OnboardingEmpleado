using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace GestionSiaUI.Utilidades
{
    class ValidarClaveDominio
    {
        private string m_path;
        private string m_dominio;
        private static string m_filtro = string.Empty;

        public ValidarClaveDominio()
        {
            this.m_dominio = "launion.com.gt";
            this.m_path = "LDAP://launion.com.gt/DC=launion,DC=com,DC=gt";

        }

        public bool ValidaUsuario(string usuario, string pwd)
        {
            string dominioNombreUsuario = this.m_dominio + @"\" + usuario;

            // Parametros de entrada que utilizara el directorio para la busqueda.
            DirectoryEntry entrada = new DirectoryEntry(this.m_path, dominioNombreUsuario, pwd);

            try
            {
                //Enlace ó conexion nativa que forza la autenticación.
                object obj = entrada.NativeObject;

                DirectorySearcher buscador = new DirectorySearcher(entrada);
                buscador.Filter = "(SAMAccountName=" + usuario + ")";
                buscador.PropertiesToLoad.Add("cn");

                SearchResult resultado = buscador.FindOne();

                if (null == resultado)
                {
                    return false;
                }
                this.m_path = resultado.Path;
                m_filtro = (string)resultado.Properties["cn"][0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }
    }
}
