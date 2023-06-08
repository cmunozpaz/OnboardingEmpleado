using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;                                                                                                                                                       
using System.Net;
using OnboardingBE;
using DevExpress.XtraEditors;
using System.Security.Principal;
using System.IO;


namespace OnBoardingUI
{
    public partial class MenuPrincipal : Form
    {
        Catalogos.EmpleadoRecursoUI empleadoRecursos;

        
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
       
        private void empleadoRecursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (empleadoRecursos == null)
            {
                empleadoRecursos = new Catalogos.EmpleadoRecursoUI();
                empleadoRecursos.MdiParent = this;
                empleadoRecursos.FormClosed += new FormClosedEventHandler(empleadoRecursos_FormClosed);
                empleadoRecursos.Show();
            }
            else
            {
                empleadoRecursos.Activate();
            }
        }

        private void empleadoRecursos_FormClosed(object sender, EventArgs e)
        {
            empleadoRecursos = null;
        }
    }
}
