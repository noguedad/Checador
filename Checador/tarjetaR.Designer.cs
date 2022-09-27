
namespace Checador
{
    partial class tarjetaR
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarjetaR));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.panel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.fNoDepto = new DevExpress.XtraReports.UI.XRLabel();
            this.fNumeroEmpleado = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.fNombreEmpleado = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.fNombreDepto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.fInicial = new DevExpress.XtraReports.Parameters.Parameter();
            this.fFinal = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.panel1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 195.7108F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.MultiColumn.ColumnWidth = 300F;
            this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("fecha", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.StylePriority.UsePadding = false;
            // 
            // panel1
            // 
            this.panel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.panel1.CanGrow = false;
            this.panel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel3});
            this.panel1.Dpi = 254F;
            this.panel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.SizeF = new System.Drawing.SizeF(300F, 195.7108F);
            this.panel1.StylePriority.UseBorders = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Concat([tComidaE],\' - \', [tSalida])")});
            this.xrLabel7.Font = new System.Drawing.Font("Montserrat", 8F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 120.0001F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(300F, 40F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "fNoEmp";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Concat([tEntrada],\' - \', [tComidaS])")});
            this.xrLabel6.Font = new System.Drawing.Font("Montserrat", 8F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 80.00005F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(300F, 40F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "fNoEmp";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([diaSemana])")});
            this.xrLabel5.Font = new System.Drawing.Font("Montserrat", 8F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 40.00003F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(300F, 40F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "fNoEmp";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fecha]")});
            this.xrLabel3.Font = new System.Drawing.Font("Montserrat", 8F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(300F, 40F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "fNoEmp";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel3.TextFormatString = "{0:dd MMM yyyy}";
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.fNoDepto,
            this.fNumeroEmpleado,
            this.xrLabel2,
            this.fNombreEmpleado,
            this.xrLabel4,
            this.fNombreDepto,
            this.xrLine1});
            this.GroupHeader1.Dpi = 254F;
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("noEmpleado", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
            this.GroupHeader1.HeightF = 170F;
            this.GroupHeader1.KeepTogether = true;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(25.00006F, 32.56849F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(280F, 40F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "DEPARTAMENTO:";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // fNoDepto
            // 
            this.fNoDepto.Dpi = 254F;
            this.fNoDepto.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[noDpto]")});
            this.fNoDepto.Font = new System.Drawing.Font("Montserrat", 8F);
            this.fNoDepto.LocationFloat = new DevExpress.Utils.PointFloat(305.0001F, 32.56848F);
            this.fNoDepto.Multiline = true;
            this.fNoDepto.Name = "fNoDepto";
            this.fNoDepto.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.fNoDepto.SizeF = new System.Drawing.SizeF(100F, 40F);
            this.fNoDepto.StylePriority.UseFont = false;
            this.fNoDepto.StylePriority.UseTextAlignment = false;
            this.fNoDepto.Text = "fNoDepto";
            this.fNoDepto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // fNumeroEmpleado
            // 
            this.fNumeroEmpleado.Dpi = 254F;
            this.fNumeroEmpleado.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[noEmpleado]")});
            this.fNumeroEmpleado.Font = new System.Drawing.Font("Montserrat", 8F);
            this.fNumeroEmpleado.LocationFloat = new DevExpress.Utils.PointFloat(425.0001F, 72.56856F);
            this.fNumeroEmpleado.Multiline = true;
            this.fNumeroEmpleado.Name = "fNumeroEmpleado";
            this.fNumeroEmpleado.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.fNumeroEmpleado.SizeF = new System.Drawing.SizeF(200F, 40F);
            this.fNumeroEmpleado.StylePriority.UseFont = false;
            this.fNumeroEmpleado.StylePriority.UseTextAlignment = false;
            this.fNumeroEmpleado.Text = "fNoEmp";
            this.fNumeroEmpleado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(25.00006F, 72.56859F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(400F, 40F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "NÚMERO DE EMPLEADO:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // fNombreEmpleado
            // 
            this.fNombreEmpleado.Dpi = 254F;
            this.fNombreEmpleado.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nombreEmpleado]")});
            this.fNombreEmpleado.Font = new System.Drawing.Font("Montserrat", 8F);
            this.fNombreEmpleado.LocationFloat = new DevExpress.Utils.PointFloat(205.0001F, 112.5687F);
            this.fNombreEmpleado.Multiline = true;
            this.fNombreEmpleado.Name = "fNombreEmpleado";
            this.fNombreEmpleado.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.fNombreEmpleado.SizeF = new System.Drawing.SizeF(1123.667F, 40F);
            this.fNombreEmpleado.StylePriority.UseFont = false;
            this.fNombreEmpleado.StylePriority.UseTextAlignment = false;
            this.fNombreEmpleado.Text = "fNoEmp";
            this.fNombreEmpleado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(25.00006F, 112.5687F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(180F, 40F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "NOMBRE:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // fNombreDepto
            // 
            this.fNombreDepto.Dpi = 254F;
            this.fNombreDepto.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nombreDepto]")});
            this.fNombreDepto.Font = new System.Drawing.Font("Montserrat", 8F);
            this.fNombreDepto.LocationFloat = new DevExpress.Utils.PointFloat(405F, 32.56858F);
            this.fNombreDepto.Multiline = true;
            this.fNombreDepto.Name = "fNombreDepto";
            this.fNombreDepto.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.fNombreDepto.SizeF = new System.Drawing.SizeF(923.6665F, 40.00001F);
            this.fNombreDepto.StylePriority.UseFont = false;
            this.fNombreDepto.StylePriority.UseTextAlignment = false;
            this.fNombreDepto.Text = "fNoDepto";
            this.fNombreDepto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.Dpi = 254F;
            this.xrLine1.LineWidth = 2F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(5.767458E-05F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1949.1F, 8F);
            // 
            // xrRichText1
            // 
            this.xrRichText1.Dpi = 254F;
            this.xrRichText1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(5.767458E-05F, 240F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(1959F, 95.43159F);
            this.xrRichText1.StylePriority.UseFont = false;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrRichText1,
            this.xrPictureBox1});
            this.PageHeader.Dpi = 254F;
            this.PageHeader.HeightF = 421.4286F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper(FormatString(\'DEL {0:dd} DE {0:MMMM} AL {1:dd} DE {1:MMMM} DE {1:yyyy}\',?fI" +
                    "nicial, ?fFinal))")});
            this.xrLabel10.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(5.767458E-05F, 335.4316F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(1959F, 50F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "DEL";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel10.WordWrap = false;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Dpi = 254F;
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::Checador.Properties.Resources.mexicogobierno_3_png, true);
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(1289.982F, 240F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Cover;
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(Checador.datosArchivo.ChecadorDataTable);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8});
            this.GroupFooter1.Dpi = 254F;
            this.GroupFooter1.HeightF = 254F;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            this.GroupFooter1.PrintAtBottom = true;
            this.GroupFooter1.RepeatEveryPage = true;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nombreEmpleado]")});
            this.xrLabel8.Font = new System.Drawing.Font("Montserrat", 8F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(1149.1F, 189.0001F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(800F, 40F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "fNoEmp";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // fInicial
            // 
            this.fInicial.Description = "Fecha Inicial";
            this.fInicial.Name = "fInicial";
            this.fInicial.Type = typeof(System.DateTime);
            this.fInicial.ValueInfo = "2022-04-05";
            this.fInicial.Visible = false;
            // 
            // fFinal
            // 
            this.fFinal.Description = "Fecha Final";
            this.fFinal.Name = "fFinal";
            this.fFinal.Type = typeof(System.DateTime);
            this.fFinal.ValueInfo = "2022-04-05";
            this.fFinal.Visible = false;
            // 
            // tarjetaR
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.PageHeader,
            this.GroupFooter1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 100);
            this.PageHeight = 2794;
            this.PageWidth = 2159;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.fInicial,
            this.fFinal});
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = 25;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPanel panel1;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel fNoDepto;
        private DevExpress.XtraReports.UI.XRLabel fNumeroEmpleado;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel fNombreEmpleado;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel fNombreDepto;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.Parameters.Parameter fInicial;
        private DevExpress.XtraReports.Parameters.Parameter fFinal;
    }
}
