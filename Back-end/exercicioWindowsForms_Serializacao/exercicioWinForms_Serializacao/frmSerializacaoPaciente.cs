using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using Newtonsoft.Json;
using System.IO;

namespace exercicioWinForms_Serializacao
{
    public partial class frmSerializacaoPaciente : Form
    {
        string pacienteXML = @"C:\testes\paciente.xml";

        string pacienteSOAP = @"C:\testes\pacienteSOAP.xml";

        string pacienteJSON = @"C:\testes\paciente.json";

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

        private void btnAdicionarPaciente_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente(tbNomePaciente.Text, DateTime.Parse(tbDataNascimento.Text), tbCPF.Text);
            listaPaciente.Add(p);
            populaDataGrid(listaPaciente);
        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream procurador = new FileStream(pacienteXML, FileMode.Create);
                XmlSerializer serializadorXML = new XmlSerializer(typeof(List<Paciente>));

                serializadorXML.Serialize(procurador, listaPaciente);                  
                
                procurador.Close();

                MessageBox.Show("Sucesso para serializar com XML");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnDesseralizarXML_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer serializadorXML = new XmlSerializer(typeof(List<Paciente>));
                StreamReader procurador = new StreamReader(pacienteXML);

                listaPaciente.Clear();
                listaPaciente.AddRange((List<Paciente>)serializadorXML.Deserialize(procurador));

                procurador.Close();

                populaDataGrid(listaPaciente);

                MessageBox.Show("Desserialização efetuada com sucesso.", "Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnSerializarSOAP_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream procurador = new FileStream(pacienteSOAP, FileMode.Create);

                SoapFormatter serializadorSOAP = new SoapFormatter();

                serializadorSOAP.Serialize(procurador, listaPaciente);
                
                procurador.Close();

                MessageBox.Show("Sucesso para serializar SOAP");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnDesseralizarSOAP_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream procurador = new FileStream(pacienteSOAP, FileMode.Open);

                SoapFormatter serializadorSOAP = new SoapFormatter();

                listaPaciente.Clear();
                listaPaciente = (List<Paciente>) serializadorSOAP.Deserialize(procurador);

                procurador.Close();

                populaDataGrid(listaPaciente);

                MessageBox.Show("Desserialização efetuada com sucesso.", "Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void btnSerializarJSON_Click(object sender, EventArgs e)
        {
            try
            {

                Newtonsoft.Json.JsonSerializer serializadorJSON = new JsonSerializer();
                StreamWriter procurador = new StreamWriter(pacienteJSON);
                JsonWriter escritorJSON = new JsonTextWriter(procurador);

                serializadorJSON.Serialize(escritorJSON, listaPaciente);
    
                procurador.Close();
                escritorJSON.Close();

                MessageBox.Show("Sucesso para serializar com JSON");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDesseralizarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText(pacienteJSON);

                listaPaciente.Clear();
                listaPaciente.AddRange(JsonConvert.DeserializeObject<List<Paciente>>(json));

                populaDataGrid(listaPaciente);

                MessageBox.Show("Desserialização efetuada com sucesso.", "Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLimpaDataGrid_Click(object sender, EventArgs e)
        {
            dgPacientes.Rows.Clear();
        }

        List<Paciente> listaPaciente = new List<Paciente>();
    
    }
}
