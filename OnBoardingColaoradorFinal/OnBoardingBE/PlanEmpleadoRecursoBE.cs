using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingBE
{
    public class PlanEmpleadoRecursoBE
    {
        private int? _codigoPlan;
        private int _codigoEmpleado;
        private int _codigoRecurso;
        private DateTime _fechaCumplimiento;
        private char? _estado;
        private String _usuarioInserto;
        private DateTime _fechaInserto;
        private String _usuarioModifico;
        private DateTime _fechaModifico;

        public int? CodigoPlan
        {
            get { return _codigoPlan; }
            set { _codigoPlan = value; }
        }

        public int CodigoEmpleado
        {
            get { return _codigoEmpleado; }
            set { _codigoEmpleado = value; }
        }

        public int CodigoRecurso
        {
            get { return _codigoRecurso; }
            set { _codigoRecurso = value; }
        }

        public DateTime FechaCumplimiento
        {
            get { return _fechaCumplimiento; }
            set { _fechaCumplimiento = value; }
        }

        public char? Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public String UsuarioInserto
        {
            get { return _usuarioInserto; }
            set { _usuarioInserto = value; }
        }
        public DateTime FechaInserto
        {
            get { return _fechaInserto; }
            set { _fechaInserto = value; }
        }
        public String UsuarioModifico
        {
            get { return _usuarioModifico; }
            set { _usuarioModifico = value; }
        }
        public DateTime FechaModifico
        {
            get { return _fechaModifico; }
            set { _fechaModifico = value; }
        }


    }
}
