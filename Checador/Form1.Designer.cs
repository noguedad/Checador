
namespace Checador
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.doCargarArchivo = new DevExpress.XtraBars.BarButtonItem();
            this.doGenTarjetas = new DevExpress.XtraBars.BarButtonItem();
            this.doLimpiar = new DevExpress.XtraBars.BarButtonItem();
            this.numRegistros = new DevExpress.XtraBars.BarStaticItem();
            this.numArchivos = new DevExpress.XtraBars.BarStaticItem();
            this.doTarjetaEmp = new DevExpress.XtraBars.BarButtonItem();
            this.doAcercaDe = new DevExpress.XtraBars.BarButtonItem();
            this.doExit = new DevExpress.XtraBars.BarButtonItem();
            this.doModificar = new DevExpress.XtraBars.BarButtonItem();
            this.fInicial = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.fFinal = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.doEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.doAjustes = new DevExpress.XtraBars.BarButtonItem();
            this.rpChecador = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgChecador = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTarjetas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgInformacion = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.datosArchivoActual = new Checador.datosArchivo();
            this.checadorBS = new System.Windows.Forms.BindingSource(this.components);
            this.vistaDatos = new DevExpress.XtraGrid.GridControl();
            this.vistaLista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnoDpto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreDepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiaSemana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltComidaS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltComidaE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xOpenFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.infoPopup = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.lblVersion = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosArchivoActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checadorBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPopup)).BeginInit();
            this.infoPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.doCargarArchivo,
            this.doGenTarjetas,
            this.doLimpiar,
            this.numRegistros,
            this.numArchivos,
            this.doTarjetaEmp,
            this.doAcercaDe,
            this.doExit,
            this.doModificar,
            this.fInicial,
            this.fFinal,
            this.doEliminar,
            this.doAjustes});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 440;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpChecador});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1067, 174);
            // 
            // doCargarArchivo
            // 
            this.doCargarArchivo.Caption = "Cargar Archivo";
            this.doCargarArchivo.Id = 1;
            this.doCargarArchivo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("doCargarArchivo.ImageOptions.Image")));
            this.doCargarArchivo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("doCargarArchivo.ImageOptions.LargeImage")));
            this.doCargarArchivo.Name = "doCargarArchivo";
            this.doCargarArchivo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.doCargarArchivo_ItemClick);
            // 
            // doGenTarjetas
            // 
            this.doGenTarjetas.Caption = "Generar Todas Tarjetas";
            this.doGenTarjetas.Id = 2;
            this.doGenTarjetas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("doGenTarjetas.ImageOptions.Image")));
            this.doGenTarjetas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("doGenTarjetas.ImageOptions.LargeImage")));
            this.doGenTarjetas.Name = "doGenTarjetas";
            this.doGenTarjetas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.doGenTarjetas_ItemClick);
            // 
            // doLimpiar
            // 
            this.doLimpiar.Caption = "Limpiar Datos";
            this.doLimpiar.Id = 3;
            this.doLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("doLimpiar.ImageOptions.Image")));
            this.doLimpiar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("doLimpiar.ImageOptions.LargeImage")));
            this.doLimpiar.Name = "doLimpiar";
            this.doLimpiar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.doLimpiar_ItemClick);
            // 
            // numRegistros
            // 
            this.numRegistros.Caption = "%RegNum%";
            this.numRegistros.Id = 4;
            this.numRegistros.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("numRegistros.ImageOptions.Image")));
            this.numRegistros.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("numRegistros.ImageOptions.LargeImage")));
            this.numRegistros.Name = "numRegistros";
            this.numRegistros.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // numArchivos
            // 
            this.numArchivos.Caption = "%FilesNum%";
            this.numArchivos.Id = 5;
            this.numArchivos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("numArchivos.ImageOptions.Image")));
            this.numArchivos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("numArchivos.ImageOptions.LargeImage")));
            this.numArchivos.Name = "numArchivos";
            this.numArchivos.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // doTarjetaEmp
            // 
            this.doTarjetaEmp.Caption = "Generar Segun Filtro";
            this.doTarjetaEmp.Id = 6;
            this.doTarjetaEmp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("doTarjetaEmp.ImageOptions.Image")));
            this.doTarjetaEmp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("doTarjetaEmp.ImageOptions.LargeImage")));
            this.doTarjetaEmp.Name = "doTarjetaEmp";
            this.doTarjetaEmp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.doTarjetaEmp_ItemClick);
            // 
            // doAcercaDe
            // 
            this.doAcercaDe.Caption = "Acerca de...";
            this.doAcercaDe.Id = 7;
            this.doAcercaDe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("doAcercaDe.ImageOptions.Image")));
            this.doAcercaDe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("doAcercaDe.ImageOptions.LargeImage")));
            this.doAcercaDe.Name = "doAcercaDe";
            this.doAcercaDe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.doAcercaDe_ItemClick);
            // 
            // doExit
            // 
            this.doExit.Caption = "Salir";
            this.doExit.Id = 8;
            this.doExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("doExit.ImageOptions.Image")));
            this.doExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("doExit.ImageOptions.LargeImage")));
            this.doExit.Name = "doExit";
            this.doExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.doExit_ItemClick);
            // 
            // doModificar
            // 
            this.doModificar.Caption = "Modificar Datos";
            this.doModificar.Id = 9;
            this.doModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("doModificar.ImageOptions.Image")));
            this.doModificar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("doModificar.ImageOptions.LargeImage")));
            this.doModificar.Name = "doModificar";
            this.doModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.doModificar_ItemClick);
            // 
            // fInicial
            // 
            this.fInicial.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.False;
            this.fInicial.Caption = "Fecha Inicial:";
            this.fInicial.Edit = this.repositoryItemDateEdit1;
            this.fInicial.EditWidth = 100;
            this.fInicial.Id = 10;
            this.fInicial.Name = "fInicial";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // fFinal
            // 
            this.fFinal.Caption = "Fecha Final:";
            this.fFinal.Edit = this.repositoryItemDateEdit2;
            this.fFinal.EditWidth = 100;
            this.fFinal.Id = 11;
            this.fFinal.Name = "fFinal";
            this.fFinal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.fInicial_ItemClick);
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // doEliminar
            // 
            this.doEliminar.Caption = "Eliminar Seleccionado";
            this.doEliminar.Enabled = false;
            this.doEliminar.Id = 12;
            this.doEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("doEliminar.ImageOptions.Image")));
            this.doEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("doEliminar.ImageOptions.LargeImage")));
            this.doEliminar.Name = "doEliminar";
            this.doEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.doEliminar_ItemClick);
            // 
            // doAjustes
            // 
            this.doAjustes.Caption = "Ajustes";
            this.doAjustes.Id = 13;
            this.doAjustes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("doAjustes.ImageOptions.Image")));
            this.doAjustes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("doAjustes.ImageOptions.LargeImage")));
            this.doAjustes.Name = "doAjustes";
            this.doAjustes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.doAjustes_ItemClick);
            // 
            // rpChecador
            // 
            this.rpChecador.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgChecador,
            this.rpgTarjetas,
            this.rpgInformacion});
            this.rpChecador.Name = "rpChecador";
            this.rpChecador.Text = "Checador";
            // 
            // rpgChecador
            // 
            this.rpgChecador.ItemLinks.Add(this.doCargarArchivo);
            this.rpgChecador.ItemLinks.Add(this.doLimpiar);
            this.rpgChecador.ItemLinks.Add(this.doModificar);
            this.rpgChecador.ItemLinks.Add(this.doEliminar);
            this.rpgChecador.ItemLinks.Add(this.numArchivos);
            this.rpgChecador.ItemLinks.Add(this.numRegistros);
            this.rpgChecador.Name = "rpgChecador";
            this.rpgChecador.Text = "Checador";
            // 
            // rpgTarjetas
            // 
            this.rpgTarjetas.ItemLinks.Add(this.doGenTarjetas);
            this.rpgTarjetas.ItemLinks.Add(this.doTarjetaEmp);
            this.rpgTarjetas.ItemLinks.Add(this.fInicial);
            this.rpgTarjetas.ItemLinks.Add(this.fFinal);
            this.rpgTarjetas.Name = "rpgTarjetas";
            this.rpgTarjetas.Text = "Tarjetas";
            // 
            // rpgInformacion
            // 
            this.rpgInformacion.ItemLinks.Add(this.doAcercaDe);
            this.rpgInformacion.ItemLinks.Add(this.doAjustes);
            this.rpgInformacion.ItemLinks.Add(this.doExit);
            this.rpgInformacion.Name = "rpgInformacion";
            this.rpgInformacion.Text = "Aplicación";
            // 
            // datosArchivoActual
            // 
            this.datosArchivoActual.DataSetName = "datosArchivo";
            this.datosArchivoActual.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checadorBS
            // 
            this.checadorBS.DataMember = "Checador";
            this.checadorBS.DataSource = this.datosArchivoActual;
            // 
            // vistaDatos
            // 
            this.vistaDatos.DataSource = this.checadorBS;
            this.vistaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaDatos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.vistaDatos.Location = new System.Drawing.Point(0, 174);
            this.vistaDatos.MainView = this.vistaLista;
            this.vistaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.vistaDatos.MenuManager = this.ribbonControl1;
            this.vistaDatos.Name = "vistaDatos";
            this.vistaDatos.Size = new System.Drawing.Size(1067, 564);
            this.vistaDatos.TabIndex = 1;
            this.vistaDatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaLista});
            // 
            // vistaLista
            // 
            this.vistaLista.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaLista.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.vistaLista.ColumnPanelRowHeight = 50;
            this.vistaLista.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnoEmpleado,
            this.colnombreEmpleado,
            this.colnoDpto,
            this.colnombreDepto,
            this.colfecha,
            this.coldiaSemana,
            this.coltEntrada,
            this.coltComidaS,
            this.coltComidaE,
            this.coltSalida});
            this.vistaLista.DetailHeight = 431;
            this.vistaLista.GridControl = this.vistaDatos;
            this.vistaLista.Name = "vistaLista";
            this.vistaLista.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vistaLista.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vistaLista.OptionsBehavior.Editable = false;
            this.vistaLista.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colnoEmpleado, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.vistaLista.ViewCaption = "Vista de Lista";
            // 
            // colnoEmpleado
            // 
            this.colnoEmpleado.AppearanceHeader.Options.UseTextOptions = true;
            this.colnoEmpleado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colnoEmpleado.Caption = "No. Empleado";
            this.colnoEmpleado.FieldName = "noEmpleado";
            this.colnoEmpleado.MinWidth = 27;
            this.colnoEmpleado.Name = "colnoEmpleado";
            this.colnoEmpleado.Visible = true;
            this.colnoEmpleado.VisibleIndex = 0;
            this.colnoEmpleado.Width = 50;
            // 
            // colnoDpto
            // 
            this.colnoDpto.AppearanceHeader.Options.UseTextOptions = true;
            this.colnoDpto.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colnoDpto.Caption = "No. Dpto.";
            this.colnoDpto.FieldName = "noDpto";
            this.colnoDpto.MinWidth = 27;
            this.colnoDpto.Name = "colnoDpto";
            this.colnoDpto.Visible = true;
            this.colnoDpto.VisibleIndex = 2;
            this.colnoDpto.Width = 50;
            // 
            // colnombreEmpleado
            // 
            this.colnombreEmpleado.AppearanceHeader.Options.UseTextOptions = true;
            this.colnombreEmpleado.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colnombreEmpleado.Caption = "Nombre Empleado";
            this.colnombreEmpleado.FieldName = "nombreEmpleado";
            this.colnombreEmpleado.MinWidth = 27;
            this.colnombreEmpleado.Name = "colnombreEmpleado";
            this.colnombreEmpleado.Visible = true;
            this.colnombreEmpleado.VisibleIndex = 1;
            this.colnombreEmpleado.Width = 300;
            // 
            // colnombreDepto
            // 
            this.colnombreDepto.AppearanceHeader.Options.UseTextOptions = true;
            this.colnombreDepto.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colnombreDepto.Caption = "Departamento";
            this.colnombreDepto.FieldName = "nombreDepto";
            this.colnombreDepto.MinWidth = 27;
            this.colnombreDepto.Name = "colnombreDepto";
            this.colnombreDepto.Visible = true;
            this.colnombreDepto.VisibleIndex = 3;
            this.colnombreDepto.Width = 200;
            // 
            // colfecha
            // 
            this.colfecha.AppearanceHeader.Options.UseTextOptions = true;
            this.colfecha.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 27;
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 4;
            this.colfecha.Width = 100;
            // 
            // coldiaSemana
            // 
            this.coldiaSemana.AppearanceHeader.Options.UseTextOptions = true;
            this.coldiaSemana.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.coldiaSemana.Caption = "Día de la Semana";
            this.coldiaSemana.FieldName = "diaSemana";
            this.coldiaSemana.MinWidth = 27;
            this.coldiaSemana.Name = "coldiaSemana";
            this.coldiaSemana.Visible = true;
            this.coldiaSemana.VisibleIndex = 5;
            this.coldiaSemana.Width = 100;
            // 
            // coltEntrada
            // 
            this.coltEntrada.AppearanceHeader.Options.UseTextOptions = true;
            this.coltEntrada.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.coltEntrada.Caption = "Entrada";
            this.coltEntrada.FieldName = "tEntrada";
            this.coltEntrada.MinWidth = 27;
            this.coltEntrada.Name = "coltEntrada";
            this.coltEntrada.Visible = true;
            this.coltEntrada.VisibleIndex = 6;
            this.coltEntrada.Width = 60;
            // 
            // coltComidaS
            // 
            this.coltComidaS.AppearanceHeader.Options.UseTextOptions = true;
            this.coltComidaS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.coltComidaS.Caption = "Comida Salida";
            this.coltComidaS.FieldName = "tComidaS";
            this.coltComidaS.MinWidth = 27;
            this.coltComidaS.Name = "coltComidaS";
            this.coltComidaS.Visible = true;
            this.coltComidaS.VisibleIndex = 7;
            this.coltComidaS.Width = 60;
            // 
            // coltComidaE
            // 
            this.coltComidaE.AppearanceHeader.Options.UseTextOptions = true;
            this.coltComidaE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.coltComidaE.Caption = "Comida Entrada";
            this.coltComidaE.FieldName = "tComidaE";
            this.coltComidaE.MinWidth = 27;
            this.coltComidaE.Name = "coltComidaE";
            this.coltComidaE.Visible = true;
            this.coltComidaE.VisibleIndex = 8;
            this.coltComidaE.Width = 60;
            // 
            // coltSalida
            // 
            this.coltSalida.AppearanceHeader.Options.UseTextOptions = true;
            this.coltSalida.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.coltSalida.Caption = "Salida";
            this.coltSalida.FieldName = "tSalida";
            this.coltSalida.MinWidth = 27;
            this.coltSalida.Name = "coltSalida";
            this.coltSalida.Visible = true;
            this.coltSalida.VisibleIndex = 9;
            this.coltSalida.Width = 60;
            // 
            // xOpenFileDialog
            // 
            this.xOpenFileDialog.DefaultExt = "csv";
            this.xOpenFileDialog.FileName = "xtraOpenFileDialog1";
            this.xOpenFileDialog.Filter = "Archivos CSV | *.csv";
            this.xOpenFileDialog.Title = "Abrir archivo a cargar";
            // 
            // infoPopup
            // 
            this.infoPopup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.infoPopup.Controls.Add(this.lblVersion);
            this.infoPopup.Controls.Add(this.labelControl4);
            this.infoPopup.Controls.Add(this.labelControl3);
            this.infoPopup.Controls.Add(this.labelControl2);
            this.infoPopup.Controls.Add(this.labelControl1);
            this.infoPopup.Controls.Add(this.hyperlinkLabelControl1);
            this.infoPopup.Controls.Add(this.pictureEdit1);
            this.infoPopup.Location = new System.Drawing.Point(246, 324);
            this.infoPopup.Margin = new System.Windows.Forms.Padding(4);
            this.infoPopup.Name = "infoPopup";
            this.infoPopup.Ribbon = this.ribbonControl1;
            this.infoPopup.Size = new System.Drawing.Size(613, 468);
            this.infoPopup.TabIndex = 3;
            this.infoPopup.Visible = false;
            this.infoPopup.Paint += new System.Windows.Forms.PaintEventHandler(this.infoPopup_Paint);
            // 
            // lblVersion
            // 
            this.lblVersion.Appearance.Options.UseTextOptions = true;
            this.lblVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblVersion.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVersion.Location = new System.Drawing.Point(0, 414);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(613, 27);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Versión:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelControl4.Location = new System.Drawing.Point(0, 441);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(613, 27);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "t1Soluciones © 2021. Todos los derechos reservados";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl3.Location = new System.Drawing.Point(0, 295);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.labelControl3.Size = new System.Drawing.Size(613, 71);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Clinica Hospital Matamoros\r\nDr. Manuel F. Rodriguez Brayda";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.Location = new System.Drawing.Point(0, 224);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.labelControl2.Size = new System.Drawing.Size(613, 71);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Instituto de Seguridad y Servicios Sociales \r\npara los Trabajadores del Estado";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 197);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(613, 27);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Programado para el";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.Options.UseTextOptions = true;
            this.hyperlinkLabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hyperlinkLabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.hyperlinkLabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.hyperlinkLabelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(0, 148);
            this.hyperlinkLabelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(613, 49);
            this.hyperlinkLabelControl1.TabIndex = 4;
            this.hyperlinkLabelControl1.Text = "Visitar Sitio Web";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = global::Checador.Properties.Resources.t1BadgeColor;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit1.MenuManager = this.ribbonControl1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(613, 148);
            this.pictureEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.infoPopup);
            this.Controls.Add(this.vistaDatos);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form1.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Tarjetas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosArchivoActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checadorBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPopup)).EndInit();
            this.infoPopup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpChecador;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgChecador;
        private DevExpress.XtraBars.BarButtonItem doCargarArchivo;
        private DevExpress.XtraBars.BarButtonItem doGenTarjetas;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTarjetas;
        private DevExpress.XtraBars.BarButtonItem doLimpiar;
        private DevExpress.XtraBars.BarStaticItem numRegistros;
        private DevExpress.XtraBars.BarStaticItem numArchivos;
        private datosArchivo datosArchivoActual;
        private System.Windows.Forms.BindingSource checadorBS;
        private DevExpress.XtraGrid.GridControl vistaDatos;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaLista;
        private DevExpress.XtraGrid.Columns.GridColumn colnoEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colnoDpto;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreDepto;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn coldiaSemana;
        private DevExpress.XtraGrid.Columns.GridColumn coltEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn coltComidaS;
        private DevExpress.XtraGrid.Columns.GridColumn coltComidaE;
        private DevExpress.XtraGrid.Columns.GridColumn coltSalida;
        private DevExpress.XtraEditors.XtraOpenFileDialog xOpenFileDialog;
        private DevExpress.XtraBars.BarButtonItem doTarjetaEmp;
        private DevExpress.XtraBars.BarButtonItem doAcercaDe;
        private DevExpress.XtraBars.BarButtonItem doExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgInformacion;
        private DevExpress.XtraBars.PopupControlContainer infoPopup;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblVersion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraBars.BarButtonItem doModificar;
        private DevExpress.XtraBars.BarEditItem fInicial;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem fFinal;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem doEliminar;
        private DevExpress.XtraBars.BarButtonItem doAjustes;
    }
}

