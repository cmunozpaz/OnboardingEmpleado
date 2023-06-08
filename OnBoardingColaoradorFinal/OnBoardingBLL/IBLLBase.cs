using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using OnboardingBE;
using OnBoardingDAL;
using System.Threading.Tasks;


namespace OnBoardingBLL
{
    public interface IBLLBase<T>
    {
        //Devuelve una lista del tipo de la entidad que se envíe
        IList<T> Listar(T entidad);

        //Devuelve un dataset con información obtenida según la entidad que se envíe
        DataSet ListarDS(T entidad);

        //Se utiliza para crear un nuevo registro del tipo de la entidad enviada. 
        //Puede devolver el "identity" del último registro creado
        int Crear(T entidad);

        //Se utiliza para actualizar un registro del tipo de la entidad enviada.
        bool Actualizar(T entidad);

        //Se utiliza para eliminar un registro del tipo de la entidad enviada
        bool Eliminar(T entidad);

        //Se utiliza para aplicar validaciones a los datos que se desea almacenar en la base de datos
        //Aquí también se puede aplicar reglas de negocio a los datos enviados
        bool ValidarDatos(T entidad, string operacion);
    }
}
