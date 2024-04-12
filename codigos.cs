using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noticias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAperte_Click(object sender, EventArgs e)
        {
            if (cbxEntretenimento.Checked && cbxNoticias.Checked && cbxTecnologia.Checked)
            {
                lblResultado.Text = "Você escolheu as três opções.";
            }
            else if (cbxEntretenimento.Checked && cbxTecnologia.Checked)
            {
                lblResultado.Text = "Você escolheu Entretenimento e Tecnologia";
            }
            else if (cbxEntretenimento.Checked && cbxNoticias.Checked)
            {
                lblResultado.Text = "Você escolheu Entretenimento e Noticias";
            }
            else if (cbxTecnologia.Checked && cbxNoticias.Checked)
            {
                lblResultado.Text = "Você escolheu Tecnologia e Noticias";
            }
            else if (cbxTecnologia.Checked && cbxEntretenimento.Checked)
            {
                lblResultado.Text = "Você escolheu Tecnologia e Entretenimento";
            }
            else if (cbxNoticias.Checked && cbxEntretenimento.Checked)
            {
                lblResultado.Text = "Você escolheu Noticias e Entretenimento";
            }
            else if (cbxNoticias.Checked && cbxTecnologia.Checked)
            {
                lblResultado.Text = "Você escolheu Noticias e Tecnologia";
            }
            else if ( cbxEntretenimento.Checked )
            {
                lblResultado.Text = "Você escolheu Entretenimento";
            }
            else if ( cbxTecnologia.Checked )
            {
                lblResultado.Text = "Você escolheu Tecnologia.";
            }
            else if ( cbxNoticias.Checked )
            {
                lblResultado.Text = "Você escolheu Noticias.";
            }
            else
            {
                lblResultado.Text = " Você não escolheu nada.";
            }
        }

    } // 3 checkbox, 1 label(para mostrar o resultado) e 1 button
