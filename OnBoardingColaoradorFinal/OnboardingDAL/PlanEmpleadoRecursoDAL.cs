using OnboardingBE;
using OnBoardingDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace OnboardingDAL
{
    public class PlanEmpleadoRecursoDAL : IDALBase<PlanEmpleadoRecursoBE>
    {

        public PlanEmpleadoRecursoDAL()
        {
            NombreConexionSQL = ConfigurationManager.AppSettings["ConexionActiva"].ToString();
        }

        private string _nombreConexionSQL;

        public string NombreConexionSQL
        {
            get { return _nombreConexionSQL; }
            set { _nombreConexionSQL = value; }
        }

        SqlConnection _conexionSQL;
        SqlCommand _comandoSQL;

        SqlParameter _codigoPlan;
        SqlParameter _codigoEmpleado;
        SqlParameter _codigoRecurso;
        SqlParameter _fechaCumplimiento;
        SqlParameter _estado;
        SqlParameter _usuarioInserto;
        SqlParameter _fechaInserto;
        SqlParameter _usuarioModifico;
        SqlParameter _fechaModifico;

   
   

        const string _spCrear = "OnboChrPPlanEmpleadoRecursoCrear";
        const string _spEliminar = "OnboChrPEmpleadoRecursoEliminar";

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
            switch (nombre)
            {
                case "CodigoPlan":
                    _codigoPlan = new SqlParameter();
                    _codigoPlan.ParameterName = "@CodigoPlan";
                    _codigoPlan.SqlDbType = SqlDbType.Int;
                    _codigoPlan.Direction = ParameterDirection.Input;
                    _codigoPlan.Value = valor;
                    break;

                case "CodigoEmpleado":
                    _codigoEmpleado = new SqlParameter();
                    _codigoEmpleado.ParameterName = "@CodigoEmpleado";
                    _codigoEmpleado.SqlDbType = SqlDbType.Int;
                    _codigoEmpleado.Direction = ParameterDirection.Input;
                    _codigoEmpleado.Value = valor;
                    break;

                case "CodigoRecurso":
                    _codigoRecurso = new SqlParameter();
                    _codigoRecurso.ParameterName = "@CodigoRecurso";
                    _codigoRecurso.SqlDbType = SqlDbType.Int;
                    _codigoRecurso.Direction = ParameterDirection.Input;
                    _codigoRecurso.Value = valor;
                    break;

                case "Estado":
                    _estado = new SqlParameter();
                    _estado.ParameterName = "@Estado";
                    _estado.SqlDbType = SqlDbType.Char;
                    _estado.Direction = ParameterDirection.Input;
                    _estado.Value = valor;
                    break;

                case "FechaCumplimiento":
                    _fechaCumplimiento = new SqlParameter();
                    _fechaCumplimiento.ParameterName = "@FechaCumplimiento";
                    _fechaCumplimiento.SqlDbType = SqlDbType.DateTime;
                    _fechaCumplimiento.Direction = ParameterDirection.Input;
                    _fechaCumplimiento.Value = valor;
                    break;

                case "UsuarioInserto":
                    _usuarioInserto = new SqlParameter();
                    _usuarioInserto.ParameterName = "@UsuarioInserto";
                    _usuarioInserto.SqlDbType = SqlDbType.NVarChar;
                    _usuarioInserto.Direction = ParameterDirection.Input;
                    _usuarioInserto.Value = valor;
                    break;
                case "FechaInserto":
                    _fechaInserto = new SqlParameter();
                    _fechaInserto.ParameterName = "@FechaInserto";
                    _fechaInserto.SqlDbType = SqlDbType.DateTime;
                    _fechaInserto.Direction = ParameterDirection.Input;
                    _fechaInserto.Value = valor;
                    break;
                case "UsuarioModifico":
                    _usuarioModifico = new SqlParameter();
                    _usuarioModifico.ParameterName = "@UsuarioModifico";
                    _usuarioModifico.SqlDbType = SqlDbType.NVarChar;
                    _usuarioModifico.Direction = ParameterDirection.Input;
                    _usuarioModifico.Value = valor;
                    break;
                case "FechaModifico":
                    _fechaModifico = new SqlParameter();
                    _fechaModifico.ParameterName = "@FechaModifico";
                    _fechaModifico.SqlDbType = SqlDbType.DateTime;
                    _fechaModifico.Direction = ParameterDirection.Input;
                    _fechaModifico.Value = valor;
                    break;
            }

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


        public bool Actualizar(PlanEmpleadoRecursoBE entidad)
        {
            throw new NotImplementedException();
        }

        

        public int Crear(PlanEmpleadoRecursoBE entidad)
        {
            try
            {
                CrearComando(_spCrear, CommandType.StoredProcedure, ObtenerConexion());

                CrearParametro("CodigoPlan", entidad.CodigoPlan.ToString());
                AgregarParametro(_codigoPlan);

                CrearParametro("CodigoEmpleado", entidad.CodigoEmpleado.ToString());
                AgregarParametro(_codigoEmpleado);

                CrearParametro("CodigoRecurso", entidad.CodigoRecurso.ToString());
                AgregarParametro(_codigoRecurso);

                CrearParametro("FechaCumplimiento", entidad.FechaCumplimiento.ToString());
                AgregarParametro(_fechaCumplimiento);
                

                CrearParametro("UsuarioInserto", entidad.UsuarioInserto.ToString());
                AgregarParametro(_usuarioInserto);

                _conexionSQL.Open();
                _comandoSQL.ExecuteScalar();
                _conexionSQL.Close();

                return 0;
            }
            catch (Exception ex)
            {
                if (_conexionSQL.State == ConnectionState.Open)
                    _conexionSQL.Close();
                throw new Exception("PlanEmpleadoRecurso (Crear):" + ex.Message);
            }
        }

        public bool Eliminar(PlanEmpleadoRecursoBE entidad)
        {
            try
            {
                CrearComando(_spEliminar, CommandType.StoredProcedure, ObtenerConexion());

                CrearParametro("CodigoPlan", entidad.CodigoPlan.ToString());
                AgregarParametro(_codigoPlan);

                CrearParametro("UsuarioInserto", entidad.UsuarioInserto.ToString());
                AgregarParametro(_usuarioInserto);

                _conexionSQL.Open();
                _comandoSQL.ExecuteScalar();
                _conexionSQL.Close();

                return true;
            }
            catch (Exception ex)
            {
                if (_conexionSQL.State == ConnectionState.Open)
                    _conexionSQL.Close();
                throw new Exception("PlanEmpleadoRecurso (Eliminar):, " + ex.Message);
            }
        }

        public IList<PlanEmpleadoRecursoBE> Listar(PlanEmpleadoRecursoBE entidad)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarDS(PlanEmpleadoRecursoBE entidad)
        {
            throw new NotImplementedException();
        }

       
    }
}
