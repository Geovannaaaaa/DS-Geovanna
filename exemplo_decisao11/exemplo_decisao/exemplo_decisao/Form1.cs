using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_decisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Desabilitar componentes
            chk_manha.Visible = false;
            chk_tarde.Visible = false;
            chk_noite.Visible = false;
            lbl_resultadoCurso.Visible = false;
            lbl_resultadoPeriodo.Visible = false;
        }

        private void rdb_adm_CheckedChanged(object sender, EventArgs e)
        {
            //Habilitar checkbox em adm
            chk_manha.Visible = true;
            chk_tarde.Visible = true;
            chk_noite.Visible = true;
        }

        private void rdb_ds_CheckedChanged(object sender, EventArgs e)
        {
            //Habilitar checkbox em ds
            chk_manha.Visible = true;
            chk_tarde.Visible = true;
            chk_noite.Visible = false;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (rdb_adm.Checked)
            {
                lbl_resultadoCurso.Visible = true;
                lbl_resultadoCurso.Text = "ADM selecionado";
                lbl_resultadoCurso.ForeColor = Color.Blue;
            }
            else if (rdb_ds.Checked)
            {
                lbl_resultadoCurso.Visible = true;
                lbl_resultadoCurso.Text = "DS selecionado";
                lbl_resultadoCurso.ForeColor = Color.Red;
            }
            else {
                lbl_resultadoCurso.Visible = true;
                lbl_resultadoCurso.Text = "Selecione um curso";
            }

            //Teste de Checkbox

            if (chk_manha.Checked && chk_tarde.Checked && chk_noite.Checked)
            {
                lbl_resultadoPeriodo.Visible = true;
                lbl_resultadoPeriodo.Text = "Período Inválido";
            }

            else if (chk_tarde.Checked && chk_noite.Checked)
            {
                lbl_resultadoPeriodo.Visible = true;
                lbl_resultadoPeriodo.Text = "Período Inválido";
            }

            else if (chk_manha.Checked && chk_noite.Checked)
            {
                lbl_resultadoPeriodo.Visible = true;
                lbl_resultadoPeriodo.Text = "Período Inválido";
            }

            else if (chk_manha.Checked && chk_tarde.Checked)
            {
                lbl_resultadoPeriodo.Visible = true;
                lbl_resultadoPeriodo.Text = "Período Integral";
            }

            else if (chk_manha.Checked)
            {
                lbl_resultadoPeriodo.Visible = true;
                lbl_resultadoPeriodo.Text = "Período Inválido";
            }

            else if (chk_tarde.Checked)
            {
                lbl_resultadoPeriodo.Visible = true;
                lbl_resultadoPeriodo.Text = "Período Diurno";
            }
            else if (chk_noite.Checked)
            {
                lbl_resultadoPeriodo.Visible = true;
                lbl_resultadoPeriodo.Text = "Período Nortuno";
            }

            else 
            {
                lbl_resultadoPeriodo.Visible = true;
                lbl_resultadoPeriodo.Text = "Selecione um Período!";
            }
        }
    
    }
}
