namespace OnBoardingUI
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.sIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDePlantaciónFincaClaveDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pivotGridManejoDePlantaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msReportes = new System.Windows.Forms.MenuStrip();
            this.btnCatalogosMenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubMenuOnboardinEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubMenuEmpleadoRecurso = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // sIAToolStripMenuItem
            // 
            this.sIAToolStripMenuItem.Name = "sIAToolStripMenuItem";
            this.sIAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sIAToolStripMenuItem.Text = "SIA";
            // 
            // costosToolStripMenuItem
            // 
            this.costosToolStripMenuItem.Name = "costosToolStripMenuItem";
            this.costosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.costosToolStripMenuItem.Text = "Costos";
            // 
            // manejoDePlantaciónFincaClaveDeTrabajoToolStripMenuItem
            // 
            this.manejoDePlantaciónFincaClaveDeTrabajoToolStripMenuItem.Name = "manejoDePlantaciónFincaClaveDeTrabajoToolStripMenuItem";
            this.manejoDePlantaciónFincaClaveDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.manejoDePlantaciónFincaClaveDeTrabajoToolStripMenuItem.Text = "Manejo de Plantación (Finca Clave de Trabajo) Grid";
            // 
            // pivotGridManejoDePlantaciónToolStripMenuItem
            // 
            this.pivotGridManejoDePlantaciónToolStripMenuItem.Name = "pivotGridManejoDePlantaciónToolStripMenuItem";
            this.pivotGridManejoDePlantaciónToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.pivotGridManejoDePlantaciónToolStripMenuItem.Text = "Manejo de Plantación (Finca Clave de Trabajo) Pivot Grid";
            // 
            // msReportes
            // 
            this.msReportes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msReportes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCatalogosMenuPrincipal});
            this.msReportes.Location = new System.Drawing.Point(0, 0);
            this.msReportes.Name = "msReportes";
            this.msReportes.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msReportes.Size = new System.Drawing.Size(862, 32);
            this.msReportes.TabIndex = 13;
            this.msReportes.Text = "menuStrip1";
            // 
            // btnCatalogosMenuPrincipal
            // 
            this.btnCatalogosMenuPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSubMenuOnboardinEmpleado});
            this.btnCatalogosMenuPrincipal.Image = global::OnBoardingUI.Properties.Resources.application_view_columns;
            this.btnCatalogosMenuPrincipal.Name = "btnCatalogosMenuPrincipal";
            this.btnCatalogosMenuPrincipal.Size = new System.Drawing.Size(112, 28);
            this.btnCatalogosMenuPrincipal.Text = "Catalogos";
            // 
            // btnSubMenuOnboardinEmpleado
            // 
            this.btnSubMenuOnboardinEmpleado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSubMenuEmpleadoRecurso});
            this.btnSubMenuOnboardinEmpleado.Name = "btnSubMenuOnboardinEmpleado";
            this.btnSubMenuOnboardinEmpleado.Size = new System.Drawing.Size(236, 26);
            this.btnSubMenuOnboardinEmpleado.Text = "Onboarding Empleado";
            // 
            // btnSubMenuEmpleadoRecurso
            // 
            this.btnSubMenuEmpleadoRecurso.Name = "btnSubMenuEmpleadoRecurso";
            this.btnSubMenuEmpleadoRecurso.Size = new System.Drawing.Size(216, 26);
            this.btnSubMenuEmpleadoRecurso.Text = "Empleado Recursos";
            this.btnSubMenuEmpleadoRecurso.Click += new System.EventHandler(this.empleadoRecursosToolStripMenuItem_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::OnBoardingUI.Properties.Resources.report;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem1.Text = "Reportes";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 468);
            this.Controls.Add(this.msReportes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msReportes;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.Text = "Onboarding - Colaboradores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.msReportes.ResumeLayout(false);
            this.msReportes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem sIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDePlantaciónFincaClaveDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pivotGridManejoDePlantaciónToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msReportes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.ToolStripMenuItem btnCatalogosMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnSubMenuOnboardinEmpleado;
        private System.Windows.Forms.ToolStripMenuItem btnSubMenuEmpleadoRecurso;
    }
}

