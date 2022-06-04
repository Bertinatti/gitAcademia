using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio001
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxFabricante.Clear();
            txtBoxModelo.Clear();
            foreach (int indicesChecked in checkListBoxOpcionais.CheckedIndices)
            {
                checkListBoxOpcionais.SetItemChecked(indicesChecked, false);
            }
            comboBoxPortas.ResetText();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string opcionais = "";
            bool ar, dh, abs, ve, ab;
            int portas = 2;

            ar = false;
            dh = false;
            abs = false;
            ve = false;
            ab = false;

            foreach (string itemSelecionado in checkListBoxOpcionais.CheckedItems)
            {
                opcionais += itemSelecionado + ", ";
                if (itemSelecionado.Equals("Airbag"))
                {
                    ab = true;
                }
                else if (itemSelecionado.Equals("Ar-condicionado"))
                {
                    ar = true;
                }
                else if (itemSelecionado.Equals("Direção hidráulica"))
                {
                    dh = true;
                }
                else if (itemSelecionado.Equals("Freio ABS"))
                {
                    abs = true;
                }
                else if (itemSelecionado.Equals("Vidros elétricos"))
                {
                    ve = true;
                }
            }

            foreach (string itemComboBox in comboBoxPortas.Items)
            {
                if(comboBoxPortas.SelectedIndex == 0)
                {
                    portas = 2;
                }
                else if (comboBoxPortas.SelectedIndex == 1)
                {
                    portas = 3;
                }
                else if (comboBoxPortas.SelectedIndex == 2)
                {
                    portas = 4;
                }
                else if (comboBoxPortas.SelectedIndex == 3)
                {
                    portas = 5;
                }
            }
            MessageBox.Show("Modelo: " + txtBoxModelo.Text.ToUpper() + "\n" +
                            "Fabricante: " + txtBoxFabricante.Text.ToUpper() + "\n" +
                            "Opcionais: " + opcionais.ToUpper() + "\n" +
                            "Portas: " + comboBoxPortas.Text.ToUpper());

            Carro carro = new Carro(txtBoxModelo.Text.ToUpper(), txtBoxFabricante.Text.ToUpper(), ar, dh, abs, ab, ve, portas);

            carro.MostrarDadosCarro();

        }
    }
}
