using OnboardingBE;
using OnBoardingDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Threading.Tasks;

namespace OnboardingDAL
{
    public class EmpleadoRecursoDAL : IDALBase<EmpleadoRecursoBE>
    {

        public EmpleadoRecursoDAL()
        {
            NombreConexionSQL = ConfigurationManager.AppSettings["ConexionActiva"].ToString();
        }


        private String _nombreConexionSQL;

        public String NombreConexionSQL
        {
            get { return _nombreConexionSQL; }
            set { _nombreConexionSQL = value; }
        }

        SqlConnection _conexionSQL;
        SqlCommand _comandoSQL;

        const string _spListar = "OnboChrPEmpleadoRecursoListar";

        public SqlConnection ObtenerConexion()
        {
            SqlConnectionStringBuilder _conexionSQLBuilder = new SqlConnectionStringBuilder();
            _conexionSQLBuilder.IntegratedSecurity = false;

            if (NombreConexionSQL.Equals("Produccion"))
            {
                _conexionSQLBuilder.DataSource = ConfigurationManager.AppSettings["ServerProduccion"];
                _conexionSQLBuilder.InitialCatalog = ConfigurationManager.AppSettings["DatabaseProduccion"];
                _conexionSQLBuilder.UserID = ConfigurationManager.AppSettings["UsuarioProduccion"];
                _conexionSQLBuilder.Password = ConfigurationManager.AppSettings["ClaveProduccion"];

                return _conexionSQL = new SqlConnection(_conexionSQLBuilder.ConnectionString);
            }
            if (NombreConexionSQL.Equals("Desarrollo"))
            {
                _conexionSQLBuilder.DataSource = ConfigurationManager.AppSettings["ServerDesarrollo"];
                _conexionSQLBuilder.InitialCatalog = ConfigurationManager.AppSettings["DatabaseDesarrollo"];
                _conexionSQLBuilder.UserID = ConfigurationManager.AppSettings["UsuarioDesarrollo"];
                _conexionSQLBuilder.Password = ConfigurationManager.AppSettings["ClaveDesarrollo"];

                return _conexionSQL = new SqlConnection(_conexionSQLBuilder.ConnectionString);
            }
            return null;
        }


        public void CrearParametro(string nombre, object valor)
        {
            throw new NotImplementedException();
        }

        public void CrearComando(string nombre, CommandType tipo, SqlConnection conexion)
        {
            _comandoSQL = new SqlCommand(nombre, conexion);
            _comandoSQL.CommandType = tipo;
        }

        public void AgregarParametro(SqlParameter parametro)
        {
            _comandoSQL.Parameters.Add(parametro);
        }

        public bool Actualizar(EmpleadoRecursoBE entidad)
        {
            throw new NotImplementedException();
        }

        public IList<EmpleadoRecursoBE> Listar(EmpleadoRecursoBE entidad)
        {
            try
            {
                EmpleadoRecursoBE _empleadoRecurso;
                DataSet _ds = new DataSet();
                _ds = ListarDS(entidad);

                IList<EmpleadoRecursoBE> _lista = new List<EmpleadoRecursoBE>();

                foreach (DataRow _registros in _ds.Tables[0].Rows)
                {
                    _empleadoRecurso = new EmpleadoRecursoBE();

                    _empleadoRecurso.CodigoPlan = (int)_registros["CodigoPlan"];
                    _empleadoRecurso.CodigoEmpleado = (int)_registros["codigoempleado"];
                    _empleadoRecurso.NombreCompleto = _registros["NombreCompleto"].ToString();

                    _empleadoRecurso.Codigorecurso = (int)_registros["codigorecurso"];
                    _empleadoRecurso.NombreRecurso = _registros["NombreRecurso"].ToString();

                    _empleadoRecurso.NombreResponsable = _registros["nombreResponsable"].ToString();

                    _empleadoRecurso.FechaCumplimiento = (DateTime)_registros["fechaCumplimiento"];


                    _lista.Add(_empleadoRecurso);
                }
                return _lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Empleado Recurso (Listar):, " + ex.Message);
            }
        }

        public DataSet ListarDS(EmpleadoRecursoBE entidad)
        {
            try
            {
                CrearComando(_spListar, CommandType.StoredProcedure, ObtenerConexion());
                SqlDataAdapter _da;
                DataSet _ds = new DataSet();
                _conexionSQL.Open();
                _da = new SqlDataAdapter(_comandoSQL);
                _da.Fill(_ds);
                _conexionSQL.Close();
                return _ds;
            }
            catch (Exception ex)
            {
                if (_conexionSQL.State == ConnectionState.Open)
                    _conexionSQL.Close();
                throw new Exception("Empleado Recurso (ListarDS):, " + ex.Message);
            }
        }

        public int Crear(EmpleadoRecursoBE entidad)
        {
            throw new NotImplementedException();
        }


        public bool Eliminar(EmpleadoRecursoBE entidad)
        {
            throw new NotImplementedException();
        }

    }
}
