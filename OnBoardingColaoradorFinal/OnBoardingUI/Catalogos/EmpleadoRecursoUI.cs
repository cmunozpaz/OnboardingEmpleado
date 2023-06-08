using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnboardingBE;
using OnBoardingBLL;
using System.Configuration;
using DevExpress.XtraEditors;
using OnboardingBLL;


namespace OnBoardingUI.Catalogos
{
    public partial class EmpleadoRecursoUI : Form
    {
        
        private Boolean Agregando = false;

        public EmpleadoRecursoUI()
        {
            InitializeComponent();
        }

        private void EstadoBotonesEditandoAgregando()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        public void EstadoCajasTextoHabilitar()
        {
            txtCodigoPlan.Enabled = false;
            txtCodigoEmpleado.Enabled = true;
            txtCodigoRecurso.Enabled = true;
            dtFechaCumplimiento.Enabled = true;
        }

        public void EstadoBotonesPorDefecto()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;

            gridEmpleadoRecurso.Enabled = true;
        }

        public void EstadoCajasTextoPorDefecto()
        {
            txtCodigoPlan.Enabled = false;
            txtCodigoPlan.Text = String.Empty;
            txtCodigoEmpleado.Enabled = false;
            txtCodigoEmpleado.Text = String.Empty;
            txtCodigoRecurso.Enabled = false;
            txtCodigoRecurso.Text = String.Empty;
            dtFechaCumplimiento.Enabled = false;
            dtFechaCumplimiento.Text = String.Empty;
        }

        public void LlenarObjetosConDatos()
        {
            try
            {
                if (gridEmpleadoRecursoPrincipal.RowCount > 0)
                {
                    int index = Convert.ToInt32(gridEmpleadoRecursoPrincipal.GetFocusedRowCellValue("CodigoPlan").ToString(), 10);
                    txtCodigoPlan.Text = gridEmpleadoRecursoPrincipal.GetFocusedRowCellValue("CodigoPlan").ToString();
                    txtCodigoEmpleado.Text = gridEmpleadoRecursoPrincipal.GetFocusedRowCellValue("codigoempleado").ToString();
                    txtCodigoRecurso.Text = gridEmpleadoRecursoPrincipal.GetFocusedRowCellValue("codigorecurso").ToString();
                    dtFechaCumplimiento.Text = gridEmpleadoRecursoPrincipal.GetFocusedRowCellValue("fechaCumplimiento").ToString();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Error al editar los datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarGrid()
        {
            try
            {
                EmpleadoRecursoBLL _bll = new EmpleadoRecursoBLL();
                DataSet ds = new DataSet();
                ds = _bll.ListarDS(new OnboardingBE.EmpleadoRecursoBE());

                gridEmpleadoRecurso.DataSource = ds.Tables[0];
                gridEmpleadoRecurso.RefreshDataSource();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AgrupacionClaveManejoPlantacionUI_Load(object sender, EventArgs e)
        {
            this.LlenarGrid();
            this.EstadoBotonesPorDefecto();
            this.EstadoCajasTextoPorDefecto();

            btnDB.Caption = ConfigurationManager.AppSettings["ConexionActiva"].ToString();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PlanEmpleadoRecursoBE _planEmpleadoRecurso = new PlanEmpleadoRecursoBE();


            try
            {
                _planEmpleadoRecurso.CodigoPlan = 1;
                _planEmpleadoRecurso.CodigoEmpleado =  Int32.Parse(txtCodigoEmpleado.Text.Trim()); 
                _planEmpleadoRecurso.CodigoRecurso = Int32.Parse(txtCodigoRecurso.Text.Trim());
                _planEmpleadoRecurso.FechaCumplimiento = DateTime.Parse(dtFechaCumplimiento.Text);  
                _planEmpleadoRecurso.Estado = 'A';
                _planEmpleadoRecurso.UsuarioInserto = "CMUNOZ";

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Por favor verifique si hay datos para guardar  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                PlanEmpleadoRecursoBLL _bll = new PlanEmpleadoRecursoBLL();
                if (Agregando)
                {
                    _bll.Crear(_planEmpleadoRecurso);
                }
                

                this.LlenarGrid();
                this.EstadoBotonesPorDefecto();
                this.EstadoCajasTextoPorDefecto();


            }
            catch (Exception ex)
            {
                
                XtraMessageBox.Show("El Registro ya existe en la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.EstadoBotonesEditandoAgregando();
            this.EstadoCajasTextoHabilitar();
            Agregando = true;
        }

        private void gridAgrupacionClavePrincipal_DoubleClick(object sender, EventArgs e)
        {
            this.LlenarObjetosConDatos();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigoPlan.Text))
            {
                this.EstadoBotonesEditandoAgregando();
                this.EstadoCajasTextoHabilitar();
            }
            else
            {
                this.EstadoBotonesEditandoAgregando();
                this.LlenarObjetosConDatos();
            }
            Agregando = false;
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridEmpleadoRecursoPrincipal.RowCount > 0)
            {
                this.LlenarObjetosConDatos();

                PlanEmpleadoRecursoBE _planEmpleadoRecursoEliminar = new PlanEmpleadoRecursoBE();

                _planEmpleadoRecursoEliminar.CodigoPlan = Convert.ToInt32(txtCodigoPlan.Text.Trim(),10);
                
                _planEmpleadoRecursoEliminar.CodigoEmpleado = Convert.ToInt32(txtCodigoEmpleado.Text.Trim(), 10);
                _planEmpleadoRecursoEliminar.CodigoRecurso = Convert.ToInt32(txtCodigoRecurso.Text.Trim(), 10);
                _planEmpleadoRecursoEliminar.UsuarioInserto = "CMUNOZ";
                


                if (XtraMessageBox.Show("Eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        PlanEmpleadoRecursoBLL _bll = new PlanEmpleadoRecursoBLL();
                        _bll.Eliminar(_planEmpleadoRecursoEliminar);
                        this.LlenarGrid();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                this.EstadoBotonesPorDefecto();
                this.EstadoCajasTextoPorDefecto();
            }
        }

        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.EstadoBotonesPorDefecto();
            this.EstadoCajasTextoPorDefecto();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
