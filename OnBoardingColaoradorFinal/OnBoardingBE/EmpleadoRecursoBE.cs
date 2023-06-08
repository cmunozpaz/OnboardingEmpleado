using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingBE
{
    public class EmpleadoRecursoBE
    {
        private int _codigoPlan;
        private int _codigoEmpleado;
        private String _nombreCompleto;
        private int _codigorecurso;
        private String _nombreRecurso;
        private String _nombreResponsable;
        private DateTime _fechaCumplimiento;

        public int CodigoPlan
        {
            get { return _codigoPlan; }
            set { _codigoPlan = value; }
        }
        public int CodigoEmpleado
        {
            get { return _codigoEmpleado; }
            set { _codigoEmpleado = value; }
        }

        public String NombreCompleto
        {
            get { return _nombreCompleto; }
            set { _nombreCompleto = value; }
        }

        public int Codigorecurso
        {
            get { return _codigorecurso; }
            set { _codigorecurso = value; }
        }


        public String NombreRecurso
        {
            get { return _nombreRecurso; }
            set { _nombreRecurso = value; }
        }

        public String NombreResponsable
        {
            get { return _nombreResponsable; }
            set { _nombreResponsable = value; }
        }


        public DateTime FechaCumplimiento
        {
            get { return _fechaCumplimiento; }
            set { _fechaCumplimiento = value; }
        }



    }
}
