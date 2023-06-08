using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace OnBoardingDAL
{
    public interface IDALBase<T>
    {
        string NombreConexionSQL
        {
            get;
            set;
        }

        /// <summary>
        /// Retorna la conexión SQL que se utilizará para enviar o recibir datos
        /// </summary>
        /// <returns></returns>
        SqlConnection ObtenerConexion();

        /// <summary>
        /// Este método crea el parámetro requerido, en base al nombre que se envía y al valor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="valor"></param>
        void CrearParametro(string nombre, object valor);

        /// <summary>
        /// Crea e inicializa el comando
        /// </summary>
        /// <param name="nombre">El nombre del comando</param>
        /// <param name="tipo">El tipo de comando. ej: Stored Procedure, Text, etc</param>
        /// <param name="conexion">La conexión SQL que utilizará el comando</param>
        void CrearComando(string nombre, CommandType tipo, SqlConnection conexion);

        /// <summary>
        /// Agrega un parámetro al comando
        /// </summary>
        /// <param name="tipo">El tipo del comando. ej. int, double, varchar, etc</param>
        /// <param name="nombre">El nombre del comando</param>
        /// <param name="valor">El valor asignado al comando</param>
        /// <param name="direccion">Define si es de entrada o de salida</param>
        /// <param name="largo">Define el tamaño del parametro</param>
        void AgregarParametro(SqlParameter parametro);

        /// <summary>
        /// Esta función devuelve una lista del tipo de la entidad que se requiera utilizando los datos
        /// obtenidos con la función EjecutarComando
        /// </summary>
        /// <returns></returns>
        IList<T> Listar(T entidad);

        /// <summary>
        /// Esta función devuelve un dataset con los datos obtenidos con la función EjecutarComando
        /// </summary>
        /// <returns></returns>
        DataSet ListarDS(T entidad);

        /// <summary>
        /// Esta función inserta un registro en la base de datos y devuelve un identificador
        /// del registro insertado
        /// </summary>
        /// <param name="entidad">El tipo de entidad a insertar</param>
        /// <returns></returns>
        int Crear(T entidad);

        /// <summary>
        /// Esta función actualiza un registro en la base de datos y devuelve una confirmación
        /// indicando si la actualización se realizó con éxito o no
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        bool Actualizar(T entidad);

        /// <summary>
        /// Esta función elimina un registro en la base de datos y devuelve una confirmación
        /// indicando si la eliminación se realizó con éxito o no
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        bool Eliminar(T entidad); 
    }
}
