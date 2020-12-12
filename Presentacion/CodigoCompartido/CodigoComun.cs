
using Presentacion.Ventanas.VentanaEmergente;
using Presentacion.Ventanas.VentanaError;
using SoporteUsuario.CacheUsuario;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.CodigoCompartido
{
    public  class CodigoComun
    {
        private static FormError formError;
        private  Form activeForm = null;
        public  Form ActiveForm { get => activeForm; set => activeForm = value; }
        public static void BtnCerrar(Form form)
        {
            form.Close();
        }
        public static void  BtnMinimizar(Form form)
        {
            if (form.WindowState == FormWindowState.Normal) form.WindowState = FormWindowState.Minimized;
            else form.WindowState = FormWindowState.Normal;
        }

        public static void  CambiosTbx(TextBox textBox, string texto, int R, int G, int B)
        {
            if (textBox.Text == texto)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.FromArgb(R, G, B);
            }
        }

        public static void Timer(Form form, Timer timer)
        {
            if (form.Opacity <= 1) form.Opacity += 0.02;
            if (form.Opacity == 1) timer.Stop();
        }

        public  void AbrirFormHijo(Form childForm, Panel panel)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public static DataGridView EstiloDataGrid(DataGridView dataGridView)
        {
            dataGridView.BackgroundColor = Color.FromArgb(48, 56, 80);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(40, 50, 70);
            dataGridView.RowsDefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridView.RowsDefaultCellStyle.ForeColor = Color.White;
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.GridColor = Color.SteelBlue;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 50, 70);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 50, 70);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersHeight = 20;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            return dataGridView;

        }

        public static double NominalAEfectiva(double nominal)
        {
            double tasa;
            tasa = ((Math.Pow(((nominal / 100)+1),12))-1)*100;
            return tasa;
        }
        public static double EfectivaANominal(double efectiva)
        {
            double tasa;
            tasa = ((Math.Pow(((efectiva / 100) + 1), (0.08333333))) - 1)*100;
            return tasa;
        }

        public static double CalcularCuota(double monto, double tasaNominal, int plazo)
        {
            double cuota;
            cuota = (monto * (tasaNominal / 100)) * (Math.Pow((1 + (tasaNominal / 100)), plazo)) / ((Math.Pow((1 + (tasaNominal / 100)), plazo))-1);
            return cuota;
        }

        public static void PlanDeCuotas(DataGridView dataGridView,double monto,int plazo, double tasaNominal,double cuota)
        {
            for (int i = 0; i <= plazo; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = i;
            }
            dataGridView.Rows[0].Cells[1].Value = 0;
            dataGridView.Rows[0].Cells[2].Value = 0;
            dataGridView.Rows[0].Cells[3].Value = 0;
            dataGridView.Rows[0].Cells[4].Value = 0;
            dataGridView.Rows[0].Cells[5].Value = monto;
            dataGridView.Rows[1].Cells[1].Value = dataGridView.Rows[0].Cells[5].Value;
            dataGridView.Rows[1].Cells[2].Value = cuota;
            dataGridView.Rows[1].Cells[3].Value = monto * (tasaNominal/100);
            dataGridView.Rows[1].Cells[4].Value = cuota - Convert.ToDouble(dataGridView.Rows[1].Cells[3].Value);
            dataGridView.Rows[1].Cells[5].Value = Convert.ToDouble(dataGridView.Rows[1].Cells[1].Value) - Convert.ToDouble(dataGridView.Rows[1].Cells[4].Value);

            for(int j=2; j<= plazo; j++)
            {
                dataGridView.Rows[j].Cells[1].Value = dataGridView.Rows[j - 1].Cells[5].Value;
                dataGridView.Rows[j].Cells[2].Value = cuota;
                dataGridView.Rows[j].Cells[3].Value = Convert.ToDouble(dataGridView.Rows[j].Cells[1].Value) * (tasaNominal / 100);
                dataGridView.Rows[j].Cells[4].Value = cuota - Convert.ToDouble(dataGridView.Rows[j].Cells[3].Value);
                dataGridView.Rows[j].Cells[5].Value = Convert.ToDouble(dataGridView.Rows[j].Cells[1].Value) - Convert.ToDouble(dataGridView.Rows[j].Cells[4].Value);
            }

            dataGridView.Columns["Column2"].DefaultCellStyle.Format = "N3";
            dataGridView.Columns["Column3"].DefaultCellStyle.Format = "N3";
            dataGridView.Columns["Column4"].DefaultCellStyle.Format = "N3";
            dataGridView.Columns["Column5"].DefaultCellStyle.Format = "N3";
            dataGridView.Columns["Column6"].DefaultCellStyle.Format = "N3";
        }

        public static void ValidarTextBoxNumero(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
             if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
        public static void ValidarTextBoxLetras(object sender, KeyPressEventArgs e)
        {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        public static void AbrirWebs(string pagina)
        {
            System.Diagnostics.Process.Start(pagina);
        }

        public static double CalcularTotalIngresos(double ingresos, double otrosIngresos, double factor)
        {
            return (ingresos + otrosIngresos *(factor));
        }
        public static void CambioLblExportando(Label label1)
        {
           

            if (label1.Text == "Exportando")
            {
                label1.Text = "Exportando.";
            }
            else if (label1.Text == "Exportando.")
            {
                label1.Text = "Exportando..";
            }
            else if (label1.Text == "Exportando..")
            {
                label1.Text = "Exportando...";
            }
            else if (label1.Text == "Exportando...")
            {
                label1.Text = "Exportando";
            }
        }

        public static string RetornarMorasTotales(ComboBox numeroDeMoras, ComboBox diasDeMora)
        {
            return (numeroDeMoras.Text + " moras de " + diasDeMora.Text + " días"); 
        }

        public static int CalcularEdad(DateTimePicker dateTimePicker)
        {
            return (DateTime.Now.Year - dateTimePicker.Value.Year);
        }

        public static double RetornarTotalDeducciones(double deduccionesSeguridadSocial, double otrasDeducciones)
        {
            return (deduccionesSeguridadSocial + otrasDeducciones);
        }
        public static void RetornarFormatoNumero(TextBox[] textBoxes)
        {
            try
            {
                foreach (TextBox textBox in textBoxes)
                {
                    if (textBox.Text != string.Empty) textBox.Text = string.Format("{0:n0}", double.Parse(textBox.Text));
                }
            }
            catch
            {
                formError = new FormError("Formato de entrada numérico incorrecto");
            }

        
        }
        public static void Alerta(string mensaje, FormVentanaEmergente.enmTipo tipo)
        {
            FormVentanaEmergente formVentanaEmergente = new FormVentanaEmergente();
            formVentanaEmergente.MostrarAlerta(mensaje, tipo);

        }

        public static void SetScroll(Form form, int puntoY)
        {
            form.AutoScrollPosition = new Point(0, puntoY);
        }
    }
}
 