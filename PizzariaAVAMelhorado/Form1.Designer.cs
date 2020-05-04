namespace PizzariaAVAMelhorado
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSabores = new System.Windows.Forms.Label();
            this.grpAdicionais = new System.Windows.Forms.GroupBox();
            this.grpBordas = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.chkAzeitona = new System.Windows.Forms.CheckBox();
            this.rdbSemBorda = new System.Windows.Forms.RadioButton();
            this.rdbComBorda = new System.Windows.Forms.RadioButton();
            this.cboSabor = new System.Windows.Forms.ComboBox();
            this.grpAdicionais.SuspendLayout();
            this.grpBordas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSabores
            // 
            this.lblSabores.AutoSize = true;
            this.lblSabores.Location = new System.Drawing.Point(192, 25);
            this.lblSabores.Name = "lblSabores";
            this.lblSabores.Size = new System.Drawing.Size(35, 13);
            this.lblSabores.TabIndex = 0;
            this.lblSabores.Text = "Sabor";
            // 
            // grpAdicionais
            // 
            this.grpAdicionais.Controls.Add(this.chkAzeitona);
            this.grpAdicionais.Controls.Add(this.chkCebola);
            this.grpAdicionais.Location = new System.Drawing.Point(27, 89);
            this.grpAdicionais.Name = "grpAdicionais";
            this.grpAdicionais.Size = new System.Drawing.Size(200, 100);
            this.grpAdicionais.TabIndex = 2;
            this.grpAdicionais.TabStop = false;
            this.grpAdicionais.Text = "Adicionais:";
            // 
            // grpBordas
            // 
            this.grpBordas.Controls.Add(this.rdbComBorda);
            this.grpBordas.Controls.Add(this.rdbSemBorda);
            this.grpBordas.Location = new System.Drawing.Point(280, 89);
            this.grpBordas.Name = "grpBordas";
            this.grpBordas.Size = new System.Drawing.Size(200, 100);
            this.grpBordas.TabIndex = 3;
            this.grpBordas.TabStop = false;
            this.grpBordas.Text = "Borda Recheada";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(78, 229);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(340, 229);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(51, 19);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(59, 17);
            this.chkCebola.TabIndex = 0;
            this.chkCebola.Text = "Cebola";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // chkAzeitona
            // 
            this.chkAzeitona.AutoSize = true;
            this.chkAzeitona.Location = new System.Drawing.Point(51, 52);
            this.chkAzeitona.Name = "chkAzeitona";
            this.chkAzeitona.Size = new System.Drawing.Size(67, 17);
            this.chkAzeitona.TabIndex = 1;
            this.chkAzeitona.Text = "Azeitona";
            this.chkAzeitona.UseVisualStyleBackColor = true;
            // 
            // rdbSemBorda
            // 
            this.rdbSemBorda.AutoSize = true;
            this.rdbSemBorda.Location = new System.Drawing.Point(58, 18);
            this.rdbSemBorda.Name = "rdbSemBorda";
            this.rdbSemBorda.Size = new System.Drawing.Size(77, 17);
            this.rdbSemBorda.TabIndex = 0;
            this.rdbSemBorda.TabStop = true;
            this.rdbSemBorda.Text = "Sem Borda";
            this.rdbSemBorda.UseVisualStyleBackColor = true;
            // 
            // rdbComBorda
            // 
            this.rdbComBorda.AutoSize = true;
            this.rdbComBorda.Location = new System.Drawing.Point(58, 51);
            this.rdbComBorda.Name = "rdbComBorda";
            this.rdbComBorda.Size = new System.Drawing.Size(77, 17);
            this.rdbComBorda.TabIndex = 1;
            this.rdbComBorda.TabStop = true;
            this.rdbComBorda.Text = "Com Borda";
            this.rdbComBorda.UseVisualStyleBackColor = true;
            // 
            // cboSabor
            // 
            this.cboSabor.FormattingEnabled = true;
            this.cboSabor.Location = new System.Drawing.Point(244, 22);
            this.cboSabor.Name = "cboSabor";
            this.cboSabor.Size = new System.Drawing.Size(121, 21);
            this.cboSabor.TabIndex = 6;
            this.cboSabor.SelectedIndexChanged += new System.EventHandler(this.cboSabor_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 268);
            this.Controls.Add(this.cboSabor);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grpBordas);
            this.Controls.Add(this.grpAdicionais);
            this.Controls.Add(this.lblSabores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAdicionais.ResumeLayout(false);
            this.grpAdicionais.PerformLayout();
            this.grpBordas.ResumeLayout(false);
            this.grpBordas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSabores;
        private System.Windows.Forms.GroupBox grpAdicionais;
        private System.Windows.Forms.CheckBox chkAzeitona;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.GroupBox grpBordas;
        private System.Windows.Forms.RadioButton rdbComBorda;
        private System.Windows.Forms.RadioButton rdbSemBorda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cboSabor;
    }
}

