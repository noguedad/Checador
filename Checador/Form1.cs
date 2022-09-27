using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Checador.Properties;

namespace Checador
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int openFiles = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Recargar()
        {
            datosArchivoActual.listaDpto.Clear();
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.listaDepto))
            {
                List<string> list = new List<string>();
                list.AddRange(Properties.Settings.Default.listaDepto.Split('|'));
                foreach (string s in list)
                {

                    datosArchivo.listaDptoRow r = datosArchivoActual.listaDpto.NewlistaDptoRow();
                    r.noDpto = Convert.ToInt32(s.Split(':')[0]);
                    r.nombreDepto = s.Split(':')[1];
                    datosArchivoActual.listaDpto.AddlistaDptoRow(r);
                }
            }
        }

        private void Limpiar()
        {
            datosArchivoActual.Clear();
            Recargar();
            openFiles = 0;
            UpdateCount();
        }
        private void doLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Limpiar();
        }

        private void UpdateCount()
        {
            numArchivos.Caption  = $"Número de archivos: {openFiles}";
            numRegistros.Caption = $"Número de Registros: {datosArchivoActual.Checador.Rows.Count}";
        }


        private void doCargarArchivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (xOpenFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    using (FileLoader loader = new FileLoader(xOpenFileDialog.FileName))
                    {
                        dataRow row = new dataRow();
                        DateTime fechaI = DateTime.Now;
                        DateTime fechaF = DateTime.Now;
                        while (loader.ReadRow(row))
                        {
                            datosArchivo.ChecadorRow r = datosArchivoActual.Checador.NewChecadorRow();
                            if (row[0] != "notrab")
                            {
                                string tmp;
                                
                                tmp = Properties.Settings.Default.noEmpleado != -1 ? row[Settings.Default.noEmpleado].Trim() : "0";
                                r.noEmpleado = Convert.ToInt32(tmp);
                                tmp = Properties.Settings.Default.nombreEmpleado != -1 ? row[Settings.Default.nombreEmpleado].Trim() : "";
                                r.nombreEmpleado = tmp;
                                tmp = Properties.Settings.Default.fecha != -1 ? row[Settings.Default.fecha].Substring(0, row[Settings.Default.fecha].Length - 2) : "1/1/2000";
                                tmp = tmp.Replace("ene", "01");
                                tmp = tmp.Replace("feb", "02");
                                tmp = tmp.Replace("mar", "03");
                                tmp = tmp.Replace("abr", "04");
                                tmp = tmp.Replace("may", "05");
                                tmp = tmp.Replace("jun", "06");
                                tmp = tmp.Replace("jul", "07");
                                tmp = tmp.Replace("ago", "08");
                                tmp = tmp.Replace("sep", "09");
                                tmp = tmp.Replace("oct", "10");
                                tmp = tmp.Replace("nov", "11");
                                tmp = tmp.Replace("dic", "12");
                                r.fecha = DateTime.Parse(tmp);  
                                if (Properties.Settings.Default.tEntrada != -1)
                                    r.tEntrada = row[3] == "  :" ? "" : row[Settings.Default.tEntrada].Trim();
                                else
                                    r.tEntrada = "";
                                if (Properties.Settings.Default.tSalida != -1)
                                    r.tSalida = row[4] == "  :" ? "" : row[Settings.Default.tSalida].Trim();
                                else
                                    r.tSalida = "";
                                if (Properties.Settings.Default.tComidaS != -1)
                                    r.tComidaS = row[5] == "  :" ? "" : row[Settings.Default.tComidaS].Trim();
                                else
                                    r.tComidaS = "";
                                if (Properties.Settings.Default.tComidaE != -1)
                                    r.tComidaE = row[6] == "  :" ? "" : row[Settings.Default.tComidaE].Trim();
                                else
                                    r.tComidaE = "";
                                if (Properties.Settings.Default.noDpto != -1)
                                    r.noDpto = Convert.ToInt32(row[Settings.Default.noDpto].Trim());
                                else
                                    r.noDpto = 0;
                                if (!r.IsfechaNull())
                                    r.diaSemana = r.fecha.ToString("dddd");
                                if (datosArchivoActual.Checador.Count == 0)
                                {
                                    fechaI = r.fecha;
                                    fechaF = r.fecha;
                                }
                                else 
                                {
                                    if (r.fecha > fechaF)
                                        fechaF = r.fecha;
                                    if (r.fecha < fechaI)
                                        fechaI = r.fecha;
                                }
                                if (!r.IsnombreEmpleadoNull())
                                {
                                    r.nombreEmpleado = r.nombreEmpleado.Replace('�', 'Ñ');
                                    r.nombreEmpleado = r.nombreEmpleado.Replace('?', 'Ñ');
                                }
                                if (!r.IsnoDptoNull())
                                    if (datosArchivoActual.listaDpto.FindBynoDpto(r.noDpto) != null)
                                        r.nombreDepto = datosArchivoActual.listaDpto.FindBynoDpto(r.noDpto).nombreDepto;
                                datosArchivoActual.Checador.AddChecadorRow(r);
                            }

                        }
                        fInicial.EditValue = fechaI;
                        fFinal.EditValue = fechaF;
                    }
                    openFiles++;
                }
                UpdateCount();
            }
            catch(Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error al Generar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void doGenTarjetas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (openFiles > 0 && datosArchivoActual.Checador.Rows.Count > 0)
            {
                tarjetaR rep = new tarjetaR();
                rep.Parameters["fInicial"].Value = fInicial.EditValue;
                rep.Parameters["fFinal"].Value = fFinal.EditValue;
                rep.DataSource = datosArchivoActual.Checador;
                DevExpress.XtraReports.UI.ReportPrintTool tool = new DevExpress.XtraReports.UI.ReportPrintTool(rep);
                tool.ShowRibbonPreview();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("No se han cargado datos!...", "Error al Generar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Recargar();
            UpdateCount();
        }

        private void doTarjetaEmp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (openFiles > 0 && datosArchivoActual.Checador.Rows.Count > 0)
            {
                tarjetaR rep = new tarjetaR();
                rep.Parameters["fInicial"].Value = fInicial.EditValue;
                rep.Parameters["fFinal"].Value = fFinal.EditValue;
                rep.DataSource = datosArchivoActual.Checador;
                rep.FilterString = vistaLista.ActiveFilterString;
                DevExpress.XtraReports.UI.ReportPrintTool tool = new DevExpress.XtraReports.UI.ReportPrintTool(rep);
                tool.ShowRibbonPreview();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("No se han cargado datos!...", "Error al Generar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void doExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void doAcercaDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            infoPopup.ShowPopup(new Point(this.Location.X + ((this.Width - infoPopup.Width) / 2), (this.Location.Y + (this.Height - infoPopup.Height) / 2)));
        }

        private void infoPopup_Paint(object sender, PaintEventArgs e)
        {
            lblVersion.Text = $"Version: {Application.ProductVersion}";
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t1soluciones.com.mx");
        }

        private void doModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vistaLista.OptionsBehavior.Editable)
            {
                vistaLista.OptionsBehavior.Editable = false;
                vistaLista.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                vistaLista.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                vistaLista.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
                doEliminar.Enabled = false;
                doModificar.Caption = "Modificar Datos";
            }
            else
            {
                vistaLista.OptionsBehavior.Editable = true;
                vistaLista.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                vistaLista.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                vistaLista.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
                doEliminar.Enabled = true;
              
                doModificar.Caption = "Bloquear Datos";
            }
        }

        private void fInicial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void doEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("¿Desea eliminar el registro seleccionado?","Eliminar Registro",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                vistaLista.DeleteSelectedRows();
        }

        private void doAjustes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            editConfig f = new editConfig();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Recargar();
                foreach(datosArchivo.ChecadorRow r in datosArchivoActual.Checador)
                {
                    if(!r.IsnoDptoNull())
                    {
                        if(datosArchivoActual.listaDpto.FindBynoDpto(r.noDpto) != null)
                        {
                            r.nombreDepto = datosArchivoActual.listaDpto.FindBynoDpto(r.noDpto).nombreDepto;
                        }
                    }
                }
            }
        }
    }
}
