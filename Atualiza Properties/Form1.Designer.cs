namespace Atualiza_Properties
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIniciarProcesso = new System.Windows.Forms.Button();
            this.lblFrances = new System.Windows.Forms.Label();
            this.btnPastaFrances = new System.Windows.Forms.Button();
            this.lblIngles = new System.Windows.Forms.Label();
            this.btnPastaIngles = new System.Windows.Forms.Button();
            this.btnJsonTraduzido = new System.Windows.Forms.Button();
            this.lblJson = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtResultadoJson = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtResultLabelsAdd = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtLabelProblema = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPropDestino = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPropDestino);
            this.groupBox1.Controls.Add(this.btnIniciarProcesso);
            this.groupBox1.Controls.Add(this.lblFrances);
            this.groupBox1.Controls.Add(this.btnPastaFrances);
            this.groupBox1.Controls.Add(this.lblIngles);
            this.groupBox1.Controls.Add(this.btnPastaIngles);
            this.groupBox1.Controls.Add(this.btnJsonTraduzido);
            this.groupBox1.Controls.Add(this.lblJson);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1330, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuraçao";
            // 
            // btnIniciarProcesso
            // 
            this.btnIniciarProcesso.Location = new System.Drawing.Point(1033, 221);
            this.btnIniciarProcesso.Name = "btnIniciarProcesso";
            this.btnIniciarProcesso.Size = new System.Drawing.Size(289, 54);
            this.btnIniciarProcesso.TabIndex = 6;
            this.btnIniciarProcesso.Text = "Iniciar";
            this.btnIniciarProcesso.UseVisualStyleBackColor = true;
            this.btnIniciarProcesso.Click += new System.EventHandler(this.btnIniciarProcesso_Click);
            // 
            // lblFrances
            // 
            this.lblFrances.AutoSize = true;
            this.lblFrances.Location = new System.Drawing.Point(385, 178);
            this.lblFrances.Name = "lblFrances";
            this.lblFrances.Size = new System.Drawing.Size(328, 25);
            this.lblFrances.TabIndex = 5;
            this.lblFrances.Text = "Pasta com os Propeties Exemplo";
            // 
            // btnPastaFrances
            // 
            this.btnPastaFrances.Location = new System.Drawing.Point(29, 169);
            this.btnPastaFrances.Name = "btnPastaFrances";
            this.btnPastaFrances.Size = new System.Drawing.Size(239, 42);
            this.btnPastaFrances.TabIndex = 4;
            this.btnPastaFrances.Text = "Pasta Properties";
            this.btnPastaFrances.UseVisualStyleBackColor = true;
            this.btnPastaFrances.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblIngles
            // 
            this.lblIngles.AutoSize = true;
            this.lblIngles.Location = new System.Drawing.Point(385, 119);
            this.lblIngles.Name = "lblIngles";
            this.lblIngles.Size = new System.Drawing.Size(232, 25);
            this.lblIngles.TabIndex = 3;
            this.lblIngles.Text = "Pasta arquivos Modelo";
            // 
            // btnPastaIngles
            // 
            this.btnPastaIngles.Location = new System.Drawing.Point(29, 110);
            this.btnPastaIngles.Name = "btnPastaIngles";
            this.btnPastaIngles.Size = new System.Drawing.Size(239, 42);
            this.btnPastaIngles.TabIndex = 2;
            this.btnPastaIngles.Text = "Json Recebidos";
            this.btnPastaIngles.UseVisualStyleBackColor = true;
            this.btnPastaIngles.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnJsonTraduzido
            // 
            this.btnJsonTraduzido.Location = new System.Drawing.Point(29, 43);
            this.btnJsonTraduzido.Name = "btnJsonTraduzido";
            this.btnJsonTraduzido.Size = new System.Drawing.Size(239, 42);
            this.btnJsonTraduzido.TabIndex = 1;
            this.btnJsonTraduzido.Text = "Json Enviados";
            this.btnJsonTraduzido.UseVisualStyleBackColor = true;
            this.btnJsonTraduzido.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblJson
            // 
            this.lblJson.AutoSize = true;
            this.lblJson.Location = new System.Drawing.Point(387, 60);
            this.lblJson.Name = "lblJson";
            this.lblJson.Size = new System.Drawing.Size(292, 25);
            this.lblJson.TabIndex = 0;
            this.lblJson.Text = "Arquivo Json a ser Importado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 546);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1330, 546);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtResultadoJson);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1314, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Qtd Labels Json";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResultadoJson
            // 
            this.txtResultadoJson.AcceptsReturn = true;
            this.txtResultadoJson.AcceptsTab = true;
            this.txtResultadoJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultadoJson.Location = new System.Drawing.Point(3, 3);
            this.txtResultadoJson.Multiline = true;
            this.txtResultadoJson.Name = "txtResultadoJson";
            this.txtResultadoJson.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultadoJson.Size = new System.Drawing.Size(1308, 493);
            this.txtResultadoJson.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtResultLabelsAdd);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1355, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Arquivos Adicionados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResultLabelsAdd
            // 
            this.txtResultLabelsAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultLabelsAdd.Location = new System.Drawing.Point(3, 3);
            this.txtResultLabelsAdd.Multiline = true;
            this.txtResultLabelsAdd.Name = "txtResultLabelsAdd";
            this.txtResultLabelsAdd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultLabelsAdd.Size = new System.Drawing.Size(1349, 287);
            this.txtResultLabelsAdd.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtLabelProblema);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1355, 293);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arquivos Nao Adicionados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtLabelProblema
            // 
            this.txtLabelProblema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLabelProblema.Location = new System.Drawing.Point(3, 3);
            this.txtLabelProblema.Multiline = true;
            this.txtLabelProblema.Name = "txtLabelProblema";
            this.txtLabelProblema.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLabelProblema.Size = new System.Drawing.Size(1349, 287);
            this.txtLabelProblema.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pasta com os arquivos Finais";
            // 
            // btnPropDestino
            // 
            this.btnPropDestino.Location = new System.Drawing.Point(29, 233);
            this.btnPropDestino.Name = "btnPropDestino";
            this.btnPropDestino.Size = new System.Drawing.Size(239, 42);
            this.btnPropDestino.TabIndex = 7;
            this.btnPropDestino.Text = "Properties Destino";
            this.btnPropDestino.UseVisualStyleBackColor = true;
            this.btnPropDestino.Click += new System.EventHandler(this.btnPropDestino_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 838);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFrances;
        private System.Windows.Forms.Button btnPastaFrances;
        private System.Windows.Forms.Label lblIngles;
        private System.Windows.Forms.Button btnPastaIngles;
        private System.Windows.Forms.Button btnJsonTraduzido;
        private System.Windows.Forms.Label lblJson;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnIniciarProcesso;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtResultadoJson;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtResultLabelsAdd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtLabelProblema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPropDestino;
    }
}

