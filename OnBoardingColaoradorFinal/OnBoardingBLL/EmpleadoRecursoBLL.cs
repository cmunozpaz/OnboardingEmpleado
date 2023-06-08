using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnboardingBE;
using OnBoardingBLL;
using OnboardingDAL;


namespace OnboardingBLL
{
    public class EmpleadoRecursoBLL : IBLLBase<EmpleadoRecursoBE>
    {
        public bool Actualizar(EmpleadoRecursoBE entidad)
        {
            throw new NotImplementedException();
        }

        public int Crear(EmpleadoRecursoBE entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(EmpleadoRecursoBE entidad)
        {
            throw new NotImplementedException();
        }

        public IList<EmpleadoRecursoBE> Listar(EmpleadoRecursoBE entidad)
        {
            try
            {
                EmpleadoRecursoDAL _dal = new EmpleadoRecursoDAL();
                return _dal.Listar(entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet ListarDS(EmpleadoRecursoBE entidad)
        {
            try
            {
                EmpleadoRecursoDAL _dal = new EmpleadoRecursoDAL();
                return _dal.ListarDS(entidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ValidarDatos(EmpleadoRecursoBE entidad, string operacion)
        {
            throw new NotImplementedException();
        }
    }
}
