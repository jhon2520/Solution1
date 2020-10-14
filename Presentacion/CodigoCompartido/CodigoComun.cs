
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
    public class CodigoComun
    {
        private Form activeForm = null;
        public Form ActiveForm { get => activeForm; set => activeForm = value; }
        public void BtnCerrar(Form form)
        {
            form.Close();
        }
        public void BtnMinimizar(Form form)
        {
            if (form.WindowState == FormWindowState.Normal) form.WindowState = FormWindowState.Minimized;
            else form.WindowState = FormWindowState.Normal;
        }

        public void CambiosTbx(TextBox textBox, string texto, int R, int G, int B)
        {
            if (textBox.Text == texto)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.FromArgb(R, G, B);
            }
        }

        public void Timer(Form form, Timer timer)
        {
            if (form.Opacity <= 1) form.Opacity += 0.02;
            if (form.Opacity == 1) timer.Stop();
        }

        public void AbrirFormHijo(Form childForm, Panel panel)
        {
            if (this.ActiveForm != null)
            {
                this.ActiveForm.Close();
            }
            this.ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public DataGridView EstiloDataGrid(DataGridView dataGridView)
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

        public double NominalAEfectiva(double nominal)
        {
            double tasa;
            tasa = ((Math.Pow(((nominal / 100)+1),12))-1)*100;
            return tasa;
        }
        public double EfectivaANominal(double efectiva)
        {
            double tasa;
            tasa = ((Math.Pow(((efectiva / 100) + 1), (0.08333333))) - 1)*100;
            return tasa;
        }

        public double CalcularCuota(double monto, double tasaNominal, int plazo)
        {
            double cuota;
            cuota = (monto * (tasaNominal / 100)) * (Math.Pow((1 + (tasaNominal / 100)), plazo)) / ((Math.Pow((1 + (tasaNominal / 100)), plazo))-1);
            return cuota;
        }

        public void PlanDeCuotas(DataGridView dataGridView,double monto,int plazo, double tasaNominal,double cuota)
        {
            for (int i = 0; i <= plazo; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = i;
            }
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

            dataGridView.Columns["Column2"].DefaultCellStyle.Format = "C2";
            dataGridView.Columns["Column3"].DefaultCellStyle.Format = "C2";
            dataGridView.Columns["Column4"].DefaultCellStyle.Format = "C2";
            dataGridView.Columns["Column5"].DefaultCellStyle.Format = "C2";
            dataGridView.Columns["Column6"].DefaultCellStyle.Format = "C2";
        }

        public void ValidarTextBoxNumero(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void AbrirWebs(string pagina)
        {
            System.Diagnostics.Process.Start(pagina);
        }
  
    }
}
