namespace Checador
{
    partial class editConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editConfig));
            this.datosArchivoActual = new Checador.datosArchivo();
            this.gridDptos = new DevExpress.XtraGrid.GridControl();
            this.listaDptoBS = new System.Windows.Forms.BindingSource(this.components);
            this.vistaDptos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnoDpto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.noSelector = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colnombreDepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.noEmpleado = new DevExpress.XtraEditors.SpinEdit();
            this.nombreEmpleado = new DevExpress.XtraEditors.SpinEdit();
            this.fecha = new DevExpress.XtraEditors.SpinEdit();
            this.tComidaE = new DevExpress.XtraEditors.SpinEdit();
            this.tComidaS = new DevExpress.XtraEditors.SpinEdit();
            this.tEntrada = new DevExpress.XtraEditors.SpinEdit();
            this.tSalida = new DevExpress.XtraEditors.SpinEdit();
            this.noDpto = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.c_noEmpleado = new DevExpress.XtraEditors.CheckEdit();
            this.c_nombreEmpleado = new DevExpress.XtraEditors.CheckEdit();
            this.c_fecha = new DevExpress.XtraEditors.CheckEdit();
            this.c_noDpto = new DevExpress.XtraEditors.CheckEdit();
            this.c_tEntrada = new DevExpress.XtraEditors.CheckEdit();
            this.c_tComidaS = new DevExpress.XtraEditors.CheckEdit();
            this.c_tComidaE = new DevExpress.XtraEditors.CheckEdit();
            this.c_tSalida = new DevExpress.XtraEditors.CheckEdit();
            this.doGuardarP = new DevExpress.XtraEditors.SimpleButton();
            this.doGuardarT = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.datosArchivoActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDptoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tComidaE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tComidaS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDpto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_noEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_nombreEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_noDpto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_tEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_tComidaS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_tComidaE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_tSalida.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // datosArchivoActual
            // 
            this.datosArchivoActual.DataSetName = "datosArchivo";
            this.datosArchivoActual.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridDptos
            // 
            this.gridDptos.DataSource = this.listaDptoBS;
            this.gridDptos.Location = new System.Drawing.Point(12, 146);
            this.gridDptos.MainView = this.vistaDptos;
            this.gridDptos.Name = "gridDptos";
            this.gridDptos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.noSelector});
            this.gridDptos.Size = new System.Drawing.Size(495, 182);
            this.gridDptos.TabIndex = 0;
            this.gridDptos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaDptos});
            // 
            // listaDptoBS
            // 
            this.listaDptoBS.DataMember = "listaDpto";
            this.listaDptoBS.DataSource = this.datosArchivoActual;
            // 
            // vistaDptos
            // 
            this.vistaDptos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnoDpto,
            this.colnombreDepto});
            this.vistaDptos.GridControl = this.gridDptos;
            this.vistaDptos.Name = "vistaDptos";
            this.vistaDptos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.vistaDptos.OptionsView.ShowGroupPanel = false;
            // 
            // colnoDpto
            // 
            this.colnoDpto.Caption = "No.";
            this.colnoDpto.ColumnEdit = this.noSelector;
            this.colnoDpto.FieldName = "noDpto";
            this.colnoDpto.Name = "colnoDpto";
            this.colnoDpto.Visible = true;
            this.colnoDpto.VisibleIndex = 0;
            this.colnoDpto.Width = 60;
            // 
            // noSelector
            // 
            this.noSelector.AutoHeight = false;
            this.noSelector.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.noSelector.IsFloatValue = false;
            this.noSelector.MaskSettings.Set("mask", "d");
            this.noSelector.MaxValue = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.noSelector.Name = "noSelector";
            // 
            // colnombreDepto
            // 
            this.colnombreDepto.Caption = "Departamento";
            this.colnombreDepto.FieldName = "nombreDepto";
            this.colnombreDepto.Name = "colnombreDepto";
            this.colnombreDepto.Visible = true;
            this.colnombreDepto.VisibleIndex = 1;
            this.colnombreDepto.Width = 391;
            // 
            // noEmpleado
            // 
            this.noEmpleado.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.noEmpleado.Location = new System.Drawing.Point(160, 12);
            this.noEmpleado.Name = "noEmpleado";
            this.noEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.noEmpleado.Properties.IsFloatValue = false;
            this.noEmpleado.Properties.MaskSettings.Set("mask", "d");
            this.noEmpleado.Size = new System.Drawing.Size(53, 22);
            this.noEmpleado.TabIndex = 1;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nombreEmpleado.Location = new System.Drawing.Point(160, 40);
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nombreEmpleado.Properties.IsFloatValue = false;
            this.nombreEmpleado.Properties.MaskSettings.Set("mask", "d");
            this.nombreEmpleado.Size = new System.Drawing.Size(53, 22);
            this.nombreEmpleado.TabIndex = 3;
            // 
            // fecha
            // 
            this.fecha.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.fecha.Location = new System.Drawing.Point(160, 68);
            this.fecha.Name = "fecha";
            this.fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fecha.Properties.IsFloatValue = false;
            this.fecha.Properties.MaskSettings.Set("mask", "d");
            this.fecha.Size = new System.Drawing.Size(53, 22);
            this.fecha.TabIndex = 5;
            // 
            // tComidaE
            // 
            this.tComidaE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tComidaE.Location = new System.Drawing.Point(383, 67);
            this.tComidaE.Name = "tComidaE";
            this.tComidaE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tComidaE.Properties.IsFloatValue = false;
            this.tComidaE.Properties.MaskSettings.Set("mask", "d");
            this.tComidaE.Size = new System.Drawing.Size(53, 22);
            this.tComidaE.TabIndex = 11;
            // 
            // tComidaS
            // 
            this.tComidaS.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tComidaS.Location = new System.Drawing.Point(383, 39);
            this.tComidaS.Name = "tComidaS";
            this.tComidaS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tComidaS.Properties.IsFloatValue = false;
            this.tComidaS.Properties.MaskSettings.Set("mask", "d");
            this.tComidaS.Size = new System.Drawing.Size(53, 22);
            this.tComidaS.TabIndex = 9;
            // 
            // tEntrada
            // 
            this.tEntrada.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tEntrada.Location = new System.Drawing.Point(383, 12);
            this.tEntrada.Name = "tEntrada";
            this.tEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tEntrada.Properties.IsFloatValue = false;
            this.tEntrada.Properties.MaskSettings.Set("mask", "d");
            this.tEntrada.Size = new System.Drawing.Size(53, 22);
            this.tEntrada.TabIndex = 7;
            // 
            // tSalida
            // 
            this.tSalida.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tSalida.Location = new System.Drawing.Point(383, 95);
            this.tSalida.Name = "tSalida";
            this.tSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tSalida.Properties.IsFloatValue = false;
            this.tSalida.Properties.MaskSettings.Set("mask", "d");
            this.tSalida.Size = new System.Drawing.Size(53, 22);
            this.tSalida.TabIndex = 15;
            // 
            // noDpto
            // 
            this.noDpto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.noDpto.Location = new System.Drawing.Point(160, 96);
            this.noDpto.Name = "noDpto";
            this.noDpto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.noDpto.Properties.IsFloatValue = false;
            this.noDpto.Properties.MaskSettings.Set("mask", "d");
            this.noDpto.Size = new System.Drawing.Size(53, 22);
            this.noDpto.TabIndex = 13;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(14, 124);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(148, 16);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Lista de Departamentos:";
            // 
            // c_noEmpleado
            // 
            this.c_noEmpleado.Location = new System.Drawing.Point(12, 11);
            this.c_noEmpleado.Name = "c_noEmpleado";
            this.c_noEmpleado.Properties.AutoWidth = true;
            this.c_noEmpleado.Properties.Caption = "No. Empleado:";
            this.c_noEmpleado.Size = new System.Drawing.Size(112, 20);
            this.c_noEmpleado.TabIndex = 18;
            this.c_noEmpleado.CheckedChanged += new System.EventHandler(this.c_noEmpleado_CheckedChanged);
            // 
            // c_nombreEmpleado
            // 
            this.c_nombreEmpleado.Location = new System.Drawing.Point(12, 41);
            this.c_nombreEmpleado.Name = "c_nombreEmpleado";
            this.c_nombreEmpleado.Properties.AutoWidth = true;
            this.c_nombreEmpleado.Properties.Caption = "Nombre Empleado:";
            this.c_nombreEmpleado.Size = new System.Drawing.Size(142, 20);
            this.c_nombreEmpleado.TabIndex = 19;
            this.c_nombreEmpleado.CheckedChanged += new System.EventHandler(this.c_nombreEmpleado_CheckedChanged);
            // 
            // c_fecha
            // 
            this.c_fecha.Location = new System.Drawing.Point(12, 70);
            this.c_fecha.Name = "c_fecha";
            this.c_fecha.Properties.AutoWidth = true;
            this.c_fecha.Properties.Caption = "Fecha:";
            this.c_fecha.Size = new System.Drawing.Size(63, 20);
            this.c_fecha.TabIndex = 20;
            this.c_fecha.CheckedChanged += new System.EventHandler(this.c_fecha_CheckedChanged);
            // 
            // c_noDpto
            // 
            this.c_noDpto.Location = new System.Drawing.Point(12, 95);
            this.c_noDpto.Name = "c_noDpto";
            this.c_noDpto.Properties.AutoWidth = true;
            this.c_noDpto.Properties.Caption = "No. Departamento:";
            this.c_noDpto.Size = new System.Drawing.Size(140, 20);
            this.c_noDpto.TabIndex = 21;
            this.c_noDpto.CheckedChanged += new System.EventHandler(this.c_noDpto_CheckedChanged);
            // 
            // c_tEntrada
            // 
            this.c_tEntrada.Location = new System.Drawing.Point(219, 11);
            this.c_tEntrada.Name = "c_tEntrada";
            this.c_tEntrada.Properties.AutoWidth = true;
            this.c_tEntrada.Properties.Caption = "Hora Entrada:";
            this.c_tEntrada.Size = new System.Drawing.Size(107, 20);
            this.c_tEntrada.TabIndex = 22;
            this.c_tEntrada.CheckedChanged += new System.EventHandler(this.c_tEntrada_CheckedChanged);
            // 
            // c_tComidaS
            // 
            this.c_tComidaS.Location = new System.Drawing.Point(219, 41);
            this.c_tComidaS.Name = "c_tComidaS";
            this.c_tComidaS.Properties.AutoWidth = true;
            this.c_tComidaS.Properties.Caption = "Hora Salida Comida:";
            this.c_tComidaS.Size = new System.Drawing.Size(145, 20);
            this.c_tComidaS.TabIndex = 23;
            this.c_tComidaS.CheckedChanged += new System.EventHandler(this.c_tComidaS_CheckedChanged);
            // 
            // c_tComidaE
            // 
            this.c_tComidaE.Location = new System.Drawing.Point(219, 70);
            this.c_tComidaE.Name = "c_tComidaE";
            this.c_tComidaE.Properties.AutoWidth = true;
            this.c_tComidaE.Properties.Caption = "Hora Entrada Comida:";
            this.c_tComidaE.Size = new System.Drawing.Size(158, 20);
            this.c_tComidaE.TabIndex = 24;
            this.c_tComidaE.CheckedChanged += new System.EventHandler(this.c_tComidaE_CheckedChanged);
            // 
            // c_tSalida
            // 
            this.c_tSalida.Location = new System.Drawing.Point(219, 97);
            this.c_tSalida.Name = "c_tSalida";
            this.c_tSalida.Properties.AutoWidth = true;
            this.c_tSalida.Properties.Caption = "Hora Salida:";
            this.c_tSalida.Size = new System.Drawing.Size(94, 20);
            this.c_tSalida.TabIndex = 25;
            this.c_tSalida.CheckedChanged += new System.EventHandler(this.c_tSalida_CheckedChanged);
            // 
            // doGuardarP
            // 
            this.doGuardarP.Appearance.Options.UseTextOptions = true;
            this.doGuardarP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.doGuardarP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("doGuardar.ImageOptions.Image")));
            this.doGuardarP.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.doGuardarP.Location = new System.Drawing.Point(347, 334);
            this.doGuardarP.Name = "doGuardarP";
            this.doGuardarP.Size = new System.Drawing.Size(160, 59);
            this.doGuardarP.TabIndex = 26;
            this.doGuardarP.Text = "Guardar Permanentemente";
            this.doGuardarP.Click += new System.EventHandler(this.doGuardarPermanentemente_Click);
            // 
            // doGuardarT
            // 
            this.doGuardarT.Appearance.Options.UseTextOptions = true;
            this.doGuardarT.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.doGuardarT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.doGuardarT.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.doGuardarT.Location = new System.Drawing.Point(181, 334);
            this.doGuardarT.Name = "doGuardarT";
            this.doGuardarT.Size = new System.Drawing.Size(160, 59);
            this.doGuardarT.TabIndex = 27;
            this.doGuardarT.Text = "Guardar Temporalmente";
            this.doGuardarT.Click += new System.EventHandler(this.doGuardarT_Click);
            // 
            // editConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 405);
            this.Controls.Add(this.doGuardarT);
            this.Controls.Add(this.doGuardarP);
            this.Controls.Add(this.c_tSalida);
            this.Controls.Add(this.c_tComidaE);
            this.Controls.Add(this.c_tComidaS);
            this.Controls.Add(this.c_tEntrada);
            this.Controls.Add(this.c_noDpto);
            this.Controls.Add(this.c_fecha);
            this.Controls.Add(this.c_nombreEmpleado);
            this.Controls.Add(this.c_noEmpleado);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.tSalida);
            this.Controls.Add(this.noDpto);
            this.Controls.Add(this.tComidaE);
            this.Controls.Add(this.tComidaS);
            this.Controls.Add(this.tEntrada);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.nombreEmpleado);
            this.Controls.Add(this.noEmpleado);
            this.Controls.Add(this.gridDptos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editConfig.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editConfig";
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.editConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosArchivoActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDptoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tComidaE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tComidaS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDpto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_noEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_nombreEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_noDpto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_tEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_tComidaS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_tComidaE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_tSalida.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public datosArchivo datosArchivoActual;
        private DevExpress.XtraGrid.GridControl gridDptos;
        private System.Windows.Forms.BindingSource listaDptoBS;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaDptos;
        private DevExpress.XtraGrid.Columns.GridColumn colnoDpto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit noSelector;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreDepto;
        private DevExpress.XtraEditors.SpinEdit noEmpleado;
        private DevExpress.XtraEditors.SpinEdit nombreEmpleado;
        private DevExpress.XtraEditors.SpinEdit fecha;
        private DevExpress.XtraEditors.SpinEdit tComidaE;
        private DevExpress.XtraEditors.SpinEdit tComidaS;
        private DevExpress.XtraEditors.SpinEdit tEntrada;
        private DevExpress.XtraEditors.SpinEdit tSalida;
        private DevExpress.XtraEditors.SpinEdit noDpto;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.CheckEdit c_noEmpleado;
        private DevExpress.XtraEditors.CheckEdit c_nombreEmpleado;
        private DevExpress.XtraEditors.CheckEdit c_fecha;
        private DevExpress.XtraEditors.CheckEdit c_noDpto;
        private DevExpress.XtraEditors.CheckEdit c_tEntrada;
        private DevExpress.XtraEditors.CheckEdit c_tComidaS;
        private DevExpress.XtraEditors.CheckEdit c_tComidaE;
        private DevExpress.XtraEditors.CheckEdit c_tSalida;
        private DevExpress.XtraEditors.SimpleButton doGuardarP;
        private DevExpress.XtraEditors.SimpleButton doGuardarT;
    }
}