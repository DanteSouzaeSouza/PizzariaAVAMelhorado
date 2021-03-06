﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaAVAMelhorado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //preenche o ComboBox com os sabores das Pizzas
            cboSabor.Items.Add("Mussarela");
            cboSabor.Items.Add("Palmito");
            cboSabor.Items.Add("Atum");
            cboSabor.Items.Add("Calabresa");
            cboSabor.Items.Add("Doce");

            //seleciona o item da lista que tem índice = 0, o primeiro da lista
            cboSabor.SelectedIndex = 0;
            rdbSemBorda.Select();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //seleciona o item da lista que tem índice = 0, o primeiro da lista
            cboSabor.SelectedIndex = 0;
            //coloca o cursor no comboBox
            cboSabor.Focus();

            //Deixa os CheckBox sem seleção
            chkAzeitona.Checked = false;
            chkCebola.Checked = false;

            //deixa o RadioButton rdbSemBorda selecionado
            rdbSemBorda.Checked = true;

            // reativa o grupo "Adicionais"
            grpAdicionais.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //declaração das variáveis
            string strSabor;

            //variável para concatenar os textos
            string strPedido = null;

            //variável recebe o Texto do ComboBox
            strSabor = cboSabor.Text;

            //verififca se tem algum item do CombBox selecionado por meio da propriedade Text
            //Se o texto for Nulo ou Vazio emite mensagem ao usuário e coloca o foco do cursor no cboSabor

            if (string.IsNullOrEmpty(cboSabor.Text))
            {
                MessageBox.Show("Selecione um sabor de pizza!", "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSabor.Focus();
                return;
            }

            //estrutura switch para os sabores das pizzas.
            // a variávelo strPedido recebe o texto de strSabor 
            switch (strSabor)
            {
                case "Mussarela":
                    strPedido = "Mussarela";
                    break;
                case "Palmito":
                    strPedido = "Palmito";
                    break;
                case "Atum":
                    strPedido = "Atum";
                    break;
                case "Calabresa":
                    strPedido = "Calabresa";
                    break;
                case "Doce":
                    strPedido = "Doce";
                    break;
            }

            //neste caso podemos ter os dois selecionados, um ou nenhum.
            //concatena o texto de strPedido com a String definida 
            //verifica se CheckBox está selecionado
            if (chkAzeitona.Checked)
            {
                //concatena o texto de strPedido com a String definida 
                strPedido = strPedido + " com Azeitonas";
            }
            if (chkCebola.Checked)
            {
                strPedido = strPedido + " com Cebola";
            }

            //verifica se RadioButton selecionado
            if (rdbComBorda.Checked)
            {
                //concatena o texto de strPedido com a String definida
                strPedido = strPedido + " com borda recheada";
            }
            else
            {
                strPedido = strPedido + " sem borda";
            }

            // emite mensagem da formação do pedido
            MessageBox.Show(strPedido, "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboSabor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Captando o valor selecionado do ComboBox
            int selectedVal = cboSabor.SelectedIndex;
            
            // checando se o valor selecionado é o do item Doce
            if (selectedVal == 4)
            {
                // desativa o groupBox que tem os adicionais
                grpAdicionais.Enabled = false;
            }
            else
            {
                // ativa o groupBox dos adicionais
                grpAdicionais.Enabled = true;
            }
        }
    }
}
