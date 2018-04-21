using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using Daishi.Microservices.Components.Serialisation;
using System.Text;
using System.Linq;

namespace Atualiza_Properties
{
    public partial class Form1 : Form
    {

        private List<ModelJson> modelJsonEnviados = new List<ModelJson>();
        private List<ModelJson> modelJsonRecebidos = new List<ModelJson>();

        private List<FileInfo> filesJsonEnviados = new List<FileInfo>();
        private List<FileInfo> filesJsonRecebidos = new List<FileInfo>();
        private List<FileInfo> propertiesExemplo = new List<FileInfo>();
        private List<FileInfo> propertiesFinais = new List<FileInfo>();
        int qtdAdd;

        public Form1()
        {
            InitializeComponent();
        }


        #region Form Components
        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo dir = new DirectoryInfo(folderDialog.SelectedPath);
                    buscaArquivosJsonEnviados(dir);
                    lblJson.Text = "Pasta Json: " + dir.FullName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo dir = new DirectoryInfo(folderDialog.SelectedPath);
                    buscaArquivosJsonRecebidos(dir);
                    lblIngles.Text = "Pasta Json recebidos: " + dir.FullName;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo dir = new DirectoryInfo(folderDialog.SelectedPath);
                    propertiesExemplo = buscaArquivosProperties(dir);
                    lblFrances.Text += "Pasta Prop Frances (Final): " + dir.FullName;
                }
            }
        }

        private void btnPropDestino_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo dir = new DirectoryInfo(folderDialog.SelectedPath);
                    propertiesFinais = buscaArquivosProperties(dir);
                    lblFrances.Text += "Pasta Prop Frances (Final): " + dir.FullName;
                }
            }

        }

        private void btnIniciarProcesso_Click(object sender, EventArgs e)
        {
           

            preencheModelComJsonsEnviados();
            preencheModelComJsonsRecebidos();
            verificaPropertNosArquivos();
            //lePropriedadeJson();

            txtResultadoJson.Text += qtdAdd;
        }
        #endregion


        #region Busca Array de Arquivos nas Pastas
        private void buscaArquivosJsonEnviados(DirectoryInfo dir)
        {
            foreach (FileInfo flInfo in dir.GetFiles())
            {
                filesJsonEnviados.Add(flInfo);
            }
            foreach (DirectoryInfo dirInfo in dir.GetDirectories())
            {
                buscaArquivosJsonEnviados(dirInfo);
            }

        }

        private void buscaArquivosJsonRecebidos(DirectoryInfo dir)
        {
            foreach (FileInfo flInfo in dir.GetFiles())
            {
                filesJsonRecebidos.Add(flInfo);
            }
            foreach (DirectoryInfo dirInfo in dir.GetDirectories())
            {
                buscaArquivosJsonRecebidos(dirInfo);
            }

        }

        private List<FileInfo> buscaArquivosProperties(DirectoryInfo dir)
        {
            List<FileInfo> files = new List<FileInfo>();
            foreach (FileInfo flInfo in dir.GetFiles())
            {
                files.Add(flInfo);
            }
            return files;
        }
        #endregion


        #region Manipula Json
        private void preencheModelComJsonsEnviados()
        {

            foreach (FileInfo f in filesJsonEnviados)
            {
                if (f.Extension.Equals(".json"))
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(f.FullName);

                    setObjetoComJson(sr.ReadToEnd(), f, "enviado");

                    sr.Close();
                }

            }

        }

        private void preencheModelComJsonsRecebidos()
        {

            foreach (FileInfo f in filesJsonRecebidos)
            {
                if (f.Extension.Equals(".json"))
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(f.FullName);

                    setObjetoComJson(sr.ReadToEnd(), f, "recebido");

                    sr.Close();
                }

            }
        }

        private void setObjetoComJson(string jsonTexto, FileInfo folder, string tipo)
        {
            //modelJson = new List<ModelJson>();
            int count = 0;

            JsonTextReader reader = new JsonTextReader(new StringReader(jsonTexto));

            while (reader.Read())
            {
                if (reader.Value != null &&
                    reader.Path.Replace("[", "")
                                .Replace("]", "")
                                .Replace("'", "") != reader.Value.ToString())
                {

                    if (tipo == "enviado")
                    {
                        modelJsonEnviados.Add(new ModelJson
                        {
                            keyName = reader.Path.Replace("[", "").Replace("]", "").Replace("'", ""),
                            keyValue = reader.Value.ToString(),
                            folder = folder.Name
                        });
                    }
                    else
                    {
                        modelJsonRecebidos.Add(new ModelJson
                        {
                            keyName = reader.Path.Replace("[", "").Replace("]", "").Replace("'", ""),
                            keyValue = reader.Value.ToString(),
                            folder = folder.Name
                        });

                    }

                    count++;
                }
            }
            reader.Close();
        }
        #endregion


        private void verificaPropertNosArquivos()
        {

            string line;


            foreach (FileInfo f in propertiesExemplo)
            {
                StreamReader file = new System.IO.StreamReader(f.FullName);
                while ((line = file.ReadLine()) != null)
                {

                    if (line.Contains("="))
                    {
                        var textToFind = line.Substring(0, line.IndexOf("=", StringComparison.Ordinal));

                        bool localizaNosEnviados = modelJsonEnviados.Any(item => item.keyName.Equals(textToFind));

                        if (localizaNosEnviados)
                        {
                            var localizaNosRecebidos = modelJsonRecebidos.Find(item => item.keyName.Equals(textToFind));

                            if (localizaNosRecebidos != null)
                            {

                                txtResultadoJson.Text += textToFind + "|Recebido|"
                                                        + localizaNosRecebidos.keyName + "="
                                                        + localizaNosRecebidos.keyValue + "|"
                                                        + f.Name + "\r\n";

                                gravaPropertyDestino(f.Name, localizaNosRecebidos);
                            }
                            else
                            {
                                txtResultadoJson.Text += textToFind + "|Nao Recebido" + "\r\n";
                            }
                        }
                        else
                        {
                            txtResultadoJson.Text += textToFind + "|Nao Enviado|" + f.Name + "\r\n";
                        }
                    }
                }
                file.Close();
            }
        }

       

        private void gravaPropertyDestino(string nomeArquivo, ModelJson propriedade)
        {

            FileInfo arquivoFinal = propertiesFinais.Find(item => item.Name.Equals(nomeArquivo));
            
            string propriedadeTexto = "" + propriedade.keyName + "=" + propriedade.keyValue;

            try
            {
                if (!PropriedadeExisteArqFrances(arquivoFinal.FullName, propriedade.keyName))
                {
                    using (StreamWriter file = new StreamWriter(arquivoFinal.FullName, true))
                    {
                        file.WriteLine(propriedadeTexto);
                        file.Close();
                        txtResultLabelsAdd.Text += propriedade.keyName +"|"+arquivoFinal.Name+ "  \r\n";
                        qtdAdd++;
                      
                    }
                }
                else
                {
                    
                     txtLabelProblema.Text += "Ja Existe no Arquivo: "+propriedade.keyName +" \r\n";
                }



            }
            catch (Exception ex)
            {
                  txtLabelProblema.Text += "Erro: " + ex.ToString() + "\r\n";
            }

        }

        private bool PropriedadeExisteArqFrances(string arquivo, string texto)
        {
            string line;
            bool retorno = false;

            StreamReader file = new System.IO.StreamReader(arquivo);

            while ((line = file.ReadLine()) != null)
            {
                if (line.ToUpper().Contains(texto.ToUpper()))
                {
                    retorno = true;
                    file.Close();
                    break;
                }
            }

            file.Close();

            return retorno;
        }


    }
}
