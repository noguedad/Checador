using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checador
{
    public partial class editConfig : DevExpress.XtraEditors.XtraForm
    {
        public editConfig()
        {
            InitializeComponent();
        }

        private void editConfig_Load(object sender, EventArgs e)
        {
           // this.DialogResult = DialogResult.Cancel;

            noEmpleado.EditValue = Properties.Settings.Default.noEmpleado;
            nombreEmpleado.EditValue = Properties.Settings.Default.nombreEmpleado;
            fecha.EditValue = Properties.Settings.Default.fecha;
            noDpto.EditValue = Properties.Settings.Default.noDpto;
            tEntrada.EditValue = Properties.Settings.Default.tEntrada;
            tComidaS.EditValue = Properties.Settings.Default.tComidaS;
            tComidaE.EditValue = Properties.Settings.Default.tComidaE;
            tSalida.EditValue = Properties.Settings.Default.tSalida;

            c_noEmpleado.Checked = Properties.Settings.Default.noEmpleado != -1 ? true : false;
            c_nombreEmpleado.Checked = Properties.Settings.Default.nombreEmpleado != -1 ? true : false;

            c_fecha.Checked = Properties.Settings.Default.fecha != -1 ? true : false;
            c_noDpto.Checked = Properties.Settings.Default.noDpto != -1 ? true : false;
            c_tEntrada.Checked = Properties.Settings.Default.tEntrada != -1 ? true : false;
            c_tComidaS.Checked = Properties.Settings.Default.tComidaS != -1 ? true : false;
            c_tComidaE.Checked = Properties.Settings.Default.tComidaE != -1 ? true : false;
            c_tSalida.Checked = Properties.Settings.Default.tSalida != -1 ? true : false;
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

        private void c_noEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            noEmpleado.ReadOnly = !c_noEmpleado.Checked;
        }

        private void c_nombreEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            nombreEmpleado.ReadOnly = !c_noEmpleado.Checked;
        }

        private void c_fecha_CheckedChanged(object sender, EventArgs e)
        {
            fecha.ReadOnly = c_fecha.Checked;
        }

        private void c_noDpto_CheckedChanged(object sender, EventArgs e)
        {
            noDpto.ReadOnly = !c_noDpto.Checked;
        }

        private void c_tEntrada_CheckedChanged(object sender, EventArgs e)
        {
            tEntrada.ReadOnly = !c_tEntrada.Checked;
        }

        private void c_tComidaS_CheckedChanged(object sender, EventArgs e)
        {
            tComidaS.ReadOnly = !c_tComidaS.Checked;
        }

        private void c_tComidaE_CheckedChanged(object sender, EventArgs e)
        {
            tComidaE.ReadOnly = !c_tComidaE.Checked;
        }

        private void c_tSalida_CheckedChanged(object sender, EventArgs e)
        {
            tSalida.ReadOnly = !c_tSalida.Checked;
        }

        private void Guardar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (datosArchivo.listaDptoRow r in datosArchivoActual.listaDpto)
            {
                sb.Append(r.noDpto.ToString());
                sb.Append(":");
                sb.Append(r.IsnombreDeptoNull() == true ? "-" : r.nombreDepto);
                sb.Append("|");
            }
            Properties.Settings.Default.listaDepto = sb.ToString(0, sb.Length - 1);
            Properties.Settings.Default.noEmpleado = c_noEmpleado.Checked ? Convert.ToInt32(noEmpleado.EditValue) : -1;
            Properties.Settings.Default.nombreEmpleado = c_nombreEmpleado.Checked ? Convert.ToInt32(nombreEmpleado.EditValue) : -1;
            Properties.Settings.Default.fecha = c_fecha.Checked ? Convert.ToInt32(fecha.EditValue) : -1;
            Properties.Settings.Default.noDpto = c_noDpto.Checked ? Convert.ToInt32(noDpto.EditValue) : -1;
            Properties.Settings.Default.tEntrada = c_tEntrada.Checked ? Convert.ToInt32(tEntrada.EditValue) : -1;
            Properties.Settings.Default.tComidaS = c_tComidaS.Checked ? Convert.ToInt32(tComidaS.EditValue) : -1;
            Properties.Settings.Default.tComidaE = c_tComidaE.Checked ? Convert.ToInt32(tComidaE.EditValue) : -1;
            Properties.Settings.Default.tSalida = c_tSalida.Checked ? Convert.ToInt32(tSalida.EditValue) : -1;
            
        }

        private void doGuardarPermanentemente_Click(object sender, EventArgs e)
        {
            Guardar();
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void doGuardarT_Click(object sender, EventArgs e)
        {
            Guardar();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}