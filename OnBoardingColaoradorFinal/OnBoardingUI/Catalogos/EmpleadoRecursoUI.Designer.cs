namespace OnBoardingUI.Catalogos
{
    partial class EmpleadoRecursoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoRecursoUI));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridEmpleadoRecurso = new DevExpress.XtraGrid.GridControl();
            this.gridEmpleadoRecursoPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodigoPlan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.codigoempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.codigorecurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreRecurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nombreResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fechaCumplimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnServidor = new DevExpress.XtraBars.BarButtonItem();
            this.btnDB = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcAgrupacionClave = new DevExpress.XtraEditors.GroupControl();
            this.dtFechaCumplimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoRecurso = new System.Windows.Forms.TextBox();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.lblFechaCumplimiento = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigoRecurso = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigoEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoPlan = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoPlan = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadoRecurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadoRecursoPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAgrupacionClave)).BeginInit();
            this.gcAgrupacionClave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoPlan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridEmpleadoRecurso);
            this.panelControl1.Controls.Add(this.gcAgrupacionClave);
            this.panelControl1.Location = new System.Drawing.Point(0, 31);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1455, 628);
            this.panelControl1.TabIndex = 0;
            // 
            // gridEmpleadoRecurso
            // 
            this.gridEmpleadoRecurso.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridEmpleadoRecurso.Location = new System.Drawing.Point(7, 192);
            this.gridEmpleadoRecurso.MainView = this.gridEmpleadoRecursoPrincipal;
            this.gridEmpleadoRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.gridEmpleadoRecurso.MenuManager = this.barManager1;
            this.gridEmpleadoRecurso.Name = "gridEmpleadoRecurso";
            this.gridEmpleadoRecurso.Size = new System.Drawing.Size(1435, 430);
            this.gridEmpleadoRecurso.TabIndex = 1;
            this.gridEmpleadoRecurso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridEmpleadoRecursoPrincipal});
            // 
            // gridEmpleadoRecursoPrincipal
            // 
            this.gridEmpleadoRecursoPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoPlan,
            this.codigoempleado,
            this.NombreCompleto,
            this.codigorecurso,
            this.NombreRecurso,
            this.nombreResponsable,
            this.fechaCumplimiento});
            this.gridEmpleadoRecursoPrincipal.GridControl = this.gridEmpleadoRecurso;
            this.gridEmpleadoRecursoPrincipal.Name = "gridEmpleadoRecursoPrincipal";
            this.gridEmpleadoRecursoPrincipal.OptionsBehavior.Editable = false;
            this.gridEmpleadoRecursoPrincipal.DoubleClick += new System.EventHandler(this.gridAgrupacionClavePrincipal_DoubleClick);
            // 
            // CodigoPlan
            // 
            this.CodigoPlan.Caption = "Codigo Plan";
            this.CodigoPlan.FieldName = "CodigoPlan";
            this.CodigoPlan.Name = "CodigoPlan";
            this.CodigoPlan.Visible = true;
            this.CodigoPlan.VisibleIndex = 0;
            this.CodigoPlan.Width = 97;
            // 
            // codigoempleado
            // 
            this.codigoempleado.Caption = "Codigo Empleado";
            this.codigoempleado.FieldName = "codigoempleado";
            this.codigoempleado.Name = "codigoempleado";
            this.codigoempleado.Visible = true;
            this.codigoempleado.VisibleIndex = 1;
            this.codigoempleado.Width = 116;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.Caption = "Nombre Completo";
            this.NombreCompleto.FieldName = "NombreCompleto";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Visible = true;
            this.NombreCompleto.VisibleIndex = 2;
            this.NombreCompleto.Width = 116;
            // 
            // codigorecurso
            // 
            this.codigorecurso.Caption = "Codigo Recurso";
            this.codigorecurso.FieldName = "codigorecurso";
            this.codigorecurso.Name = "codigorecurso";
            this.codigorecurso.Visible = true;
            this.codigorecurso.VisibleIndex = 3;
            this.codigorecurso.Width = 116;
            // 
            // NombreRecurso
            // 
            this.NombreRecurso.Caption = "Nombre Recurso";
            this.NombreRecurso.FieldName = "NombreRecurso";
            this.NombreRecurso.Name = "NombreRecurso";
            this.NombreRecurso.Visible = true;
            this.NombreRecurso.VisibleIndex = 4;
            this.NombreRecurso.Width = 116;
            // 
            // nombreResponsable
            // 
            this.nombreResponsable.Caption = "nombre Responsable";
            this.nombreResponsable.FieldName = "nombreResponsable";
            this.nombreResponsable.Name = "nombreResponsable";
            this.nombreResponsable.Visible = true;
            this.nombreResponsable.VisibleIndex = 5;
            this.nombreResponsable.Width = 116;
            // 
            // fechaCumplimiento
            // 
            this.fechaCumplimiento.Caption = "fecha Cumplimiento";
            this.fechaCumplimiento.FieldName = "fechaCumplimiento";
            this.fechaCumplimiento.Name = "fechaCumplimiento";
            this.fechaCumplimiento.Visible = true;
            this.fechaCumplimiento.VisibleIndex = 6;
            this.fechaCumplimiento.Width = 130;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnCancelar,
            this.btnEliminar,
            this.btnGuardar,
            this.btnSalir,
            this.btnServidor,
            this.btnDB});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEditar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGuardar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 0;
            this.btnNuevo.ImageOptions.Image = global::OnBoardingUI.Properties.Resources.application_add;
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Id = 1;
            this.btnEditar.ImageOptions.Image = global::OnBoardingUI.Properties.Resources.application_edit;
            this.btnEditar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.LargeImage")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Caption = "Cancelar";
            this.btnCancelar.Id = 2;
            this.btnCancelar.ImageOptions.Image = global::OnBoardingUI.Properties.Resources.cancel;
            this.btnCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.LargeImage")));
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.ImageOptions.Image = global::OnBoardingUI.Properties.Resources.application_delete;
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 4;
            this.btnGuardar.ImageOptions.Image = global::OnBoardingUI.Properties.Resources.disk;
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 5;
            this.btnSalir.ImageOptions.Image = global::OnBoardingUI.Properties.Resources.door_in;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnServidor),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDB)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnServidor
            // 
            this.btnServidor.Caption = "Servidor:";
            this.btnServidor.Id = 6;
            this.btnServidor.Name = "btnServidor";
            // 
            // btnDB
            // 
            this.btnDB.Caption = "DB";
            this.btnDB.Id = 7;
            this.btnDB.Name = "btnDB";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1455, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 667);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1455, 35);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 635);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1455, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 635);
            // 
            // gcAgrupacionClave
            // 
            this.gcAgrupacionClave.Controls.Add(this.dtFechaCumplimiento);
            this.gcAgrupacionClave.Controls.Add(this.txtCodigoRecurso);
            this.gcAgrupacionClave.Controls.Add(this.txtCodigoEmpleado);
            this.gcAgrupacionClave.Controls.Add(this.lblFechaCumplimiento);
            this.gcAgrupacionClave.Controls.Add(this.lblCodigoRecurso);
            this.gcAgrupacionClave.Controls.Add(this.lblCodigoEmpleado);
            this.gcAgrupacionClave.Controls.Add(this.txtCodigoPlan);
            this.gcAgrupacionClave.Controls.Add(this.lblCodigoPlan);
            this.gcAgrupacionClave.Location = new System.Drawing.Point(7, 7);
            this.gcAgrupacionClave.Margin = new System.Windows.Forms.Padding(4);
            this.gcAgrupacionClave.Name = "gcAgrupacionClave";
            this.gcAgrupacionClave.Size = new System.Drawing.Size(1435, 177);
            this.gcAgrupacionClave.TabIndex = 0;
            this.gcAgrupacionClave.Text = "Agrupacion Clave";
            // 
            // dtFechaCumplimiento
            // 
            this.dtFechaCumplimiento.Location = new System.Drawing.Point(185, 128);
            this.dtFechaCumplimiento.Name = "dtFechaCumplimiento";
            this.dtFechaCumplimiento.Size = new System.Drawing.Size(200, 23);
            this.dtFechaCumplimiento.TabIndex = 8;
            // 
            // txtCodigoRecurso
            // 
            this.txtCodigoRecurso.Location = new System.Drawing.Point(185, 90);
            this.txtCodigoRecurso.Name = "txtCodigoRecurso";
            this.txtCodigoRecurso.Size = new System.Drawing.Size(141, 23);
            this.txtCodigoRecurso.TabIndex = 7;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(185, 49);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(141, 23);
            this.txtCodigoEmpleado.TabIndex = 6;
            // 
            // lblFechaCumplimiento
            // 
            this.lblFechaCumplimiento.Location = new System.Drawing.Point(9, 133);
            this.lblFechaCumplimiento.Margin = new System.Windows.Forms.Padding(4);
            this.lblFechaCumplimiento.Name = "lblFechaCumplimiento";
            this.lblFechaCumplimiento.Size = new System.Drawing.Size(116, 16);
            this.lblFechaCumplimiento.TabIndex = 5;
            this.lblFechaCumplimiento.Text = "Fecha Cumplimiento";
            // 
            // lblCodigoRecurso
            // 
            this.lblCodigoRecurso.Location = new System.Drawing.Point(9, 90);
            this.lblCodigoRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.lblCodigoRecurso.Name = "lblCodigoRecurso";
            this.lblCodigoRecurso.Size = new System.Drawing.Size(89, 16);
            this.lblCodigoRecurso.TabIndex = 4;
            this.lblCodigoRecurso.Text = "Código Recurso";
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(9, 52);
            this.lblCodigoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(99, 16);
            this.lblCodigoEmpleado.TabIndex = 2;
            this.lblCodigoEmpleado.Text = "Código Empleado";
            // 
            // txtCodigoPlan
            // 
            this.txtCodigoPlan.Enabled = false;
            this.txtCodigoPlan.Location = new System.Drawing.Point(661, 32);
            this.txtCodigoPlan.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPlan.MenuManager = this.barManager1;
            this.txtCodigoPlan.Name = "txtCodigoPlan";
            this.txtCodigoPlan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPlan.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoPlan.Size = new System.Drawing.Size(133, 42);
            this.txtCodigoPlan.TabIndex = 1;
            // 
            // lblCodigoPlan
            // 
            this.lblCodigoPlan.Location = new System.Drawing.Point(604, 60);
            this.lblCodigoPlan.Margin = new System.Windows.Forms.Padding(4);
            this.lblCodigoPlan.Name = "lblCodigoPlan";
            this.lblCodigoPlan.Size = new System.Drawing.Size(44, 16);
            this.lblCodigoPlan.TabIndex = 0;
            this.lblCodigoPlan.Text = "Codigo:";
            // 
            // EmpleadoRecursoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 702);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmpleadoRecursoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado Recurso";
            this.Load += new System.EventHandler(this.AgrupacionClaveManejoPlantacionUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadoRecurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadoRecursoPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAgrupacionClave)).EndInit();
            this.gcAgrupacionClave.ResumeLayout(false);
            this.gcAgrupacionClave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoPlan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl gcAgrupacionClave;
        private DevExpress.XtraEditors.LabelControl lblCodigoPlan;
        private DevExpress.XtraEditors.TextEdit txtCodigoPlan;
        private DevExpress.XtraEditors.LabelControl lblCodigoEmpleado;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarButtonItem btnGuardar;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraEditors.LabelControl lblCodigoRecurso;
        private DevExpress.XtraGrid.GridControl gridEmpleadoRecurso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridEmpleadoRecursoPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn codigoempleado;
        private DevExpress.XtraBars.BarButtonItem btnServidor;
        private DevExpress.XtraBars.BarButtonItem btnDB;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn codigorecurso;
        private DevExpress.XtraGrid.Columns.GridColumn NombreRecurso;
        private DevExpress.XtraGrid.Columns.GridColumn nombreResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn fechaCumplimiento;
        private System.Windows.Forms.TextBox txtCodigoRecurso;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private DevExpress.XtraEditors.LabelControl lblFechaCumplimiento;
        private System.Windows.Forms.DateTimePicker dtFechaCumplimiento;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoPlan;
    }
}