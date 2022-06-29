using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml.Serialization;

namespace exercicioWinForms_Serializacao
{
    public partial class frmSerializacaoPaciente : Form
    {
        public frmSerializacaoPaciente()
        {
            InitializeComponent();
        }
        public void populaDataGrid(List<Paciente> lista)
        {
            dgPacientes.Rows.Clear();
            foreach (Paciente p in lista)
            {
                dgPacientes.Rows.Add(p.Nome, (p.DataNascimento).ToShortDateString(), p.Cpf);
            }
        }
        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream procurador = new FileStream(@"C:\caminho\paciente.xml", FileMode.Create);
                XmlSerializer serializadorXML = new XmlSerializer(typeof(Paciente));

                foreach (Paciente p in listaPaciente)
                {
                    serializadorXML.Serialize(procurador, p);                  
                }
                procurador.Close();

                MessageBox.Show("Sucesso para serializar com XML");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        
        private void btnAdicionarPaciente_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente(tbNomePaciente.Text, DateTime.Parse(tbDataNascimento.Text), tbCPF.Text);
            listaPaciente.Add(p);
            populaDataGrid(listaPaciente);
        }

        List<Paciente> listaPaciente = new List<Paciente>();
    }
}
