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
        // Caminho dos arquivos.
        string pacienteXML = @"C:\testes\paciente.xml";

        string pacienteSOAP = @"C:\testes\pacienteSOAP.xml";

        string pacienteJSON = @"C:\testes\paciente.json";

        public frmSerializacaoPaciente()
        {
            InitializeComponent();
        }
        // Método local para popular o DataGrid
        public void populaDataGrid(List<Paciente> lista)
        {
            dgPacientes.Rows.Clear();
            foreach (Paciente p in lista)
            {
                dgPacientes.Rows.Add(p.Nome, (p.DataNascimento).ToShortDateString(), p.Cpf);
            }
        }
        // Botão adicionando os valores digitados no DataGrid e na Lista de Pacientes
        private void btnAdicionarPaciente_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente(tbNomePaciente.Text, DateTime.Parse(tbDataNascimento.Text), tbCPF.Text);
            listaPaciente.Add(p);
            populaDataGrid(listaPaciente);
        }
        // Botão para limpar as linhas do DataGrid
        private void btnLimpaDataGrid_Click(object sender, EventArgs e)
        {
            dgPacientes.Rows.Clear();
        }
        // Botão para serializar os valores da Lista de Paciente em arquivo XML
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
        // Botão para desserializar os valores do arquivo XML para a Lista de Paciente
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
        // Botão para serializar os valores da Lista de Paciente em arquivo XML (SOAP)
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
        // Botão para desserializar os valores do arquivo XML (SOAP) para a Lista de Paciente
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
        // Botão para serializar os valores da Lista de Paciente em arquivo JSON
        private void btnSerializarJSON_Click(object sender, EventArgs e)
        {
            try
            {

                JsonSerializer serializadorJSON = new JsonSerializer();
                serializadorJSON.Formatting = Formatting.Indented;
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
        // Botão para desserializar os valores do arquivo JSON para a Lista de Paciente
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

        // Lista global para receber os objetos da classe Paciente
        List<Paciente> listaPaciente = new List<Paciente>();
    
    }
}
