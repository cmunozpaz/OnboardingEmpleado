using OnboardingBE;
using OnBoardingBLL;
using OnboardingDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingBLL
{
    public class PlanEmpleadoRecursoBLL : IBLLBase<PlanEmpleadoRecursoBE>
    {
        public bool Actualizar(PlanEmpleadoRecursoBE entidad)
        {
            throw new NotImplementedException();
        }

        public int Crear(PlanEmpleadoRecursoBE entidad)
        {
            try
            {
                PlanEmpleadoRecursoDAL _dal = new PlanEmpleadoRecursoDAL();
                return _dal.Crear(entidad);
            }
            catch (Exception ex)
            {
                throw new Exception("PlanEmpleadoRecurso (Crear): " + ex.Message);
            }
        }

        public bool Eliminar(PlanEmpleadoRecursoBE entidad)
        {
            try
            {
                PlanEmpleadoRecursoDAL _dal = new PlanEmpleadoRecursoDAL();
                return _dal.Eliminar(entidad);
            }
            catch (Exception ex)
            {
                throw new Exception("PlanEmpleadoRecurso (Eliminar): " + ex.Message);
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

        public bool ValidarDatos(PlanEmpleadoRecursoBE entidad, string operacion)
        {
            throw new NotImplementedException();
        }

       
    }
}
