using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eduardo_servico_ti
{
    public partial class cadastro : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        string idREGISTRO;
        public cadastro()
        {
            InitializeComponent();

            servidor = "Server=localhost;Database=eduardo-servico_ti_bd;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            ATUALIZA_cadastro();

        }
        private void LIMPAR_Formulario()
        {
            // Limpar FORM
            textBoxNOMECLIENTE.Clear();
            textBoxCEL.Clear();
            richTextBoxOBS.Clear();
            richTextBoxQCL.Clear();
            textBoxPROC.Clear();
            textBoxPLACA.Clear();
            textBoxFONTE.Clear();
            textBoxRAM.Clear();
            textBoxVID.Clear();
            textBoxPLACA.Clear();
            textBoxACESS.Clear();
        }
        private void ATUALIZA_cadastro()
        {
            try
            {
                conexao.Open();

                comando.CommandText = "SELECT * FROM clientes;";
                MySqlDataAdapter adaptadorCADASTRO = new MySqlDataAdapter(comando);
                DataTable tabelaCadastro = new DataTable();
                adaptadorCADASTRO.Fill(tabelaCadastro);

                dataGridView1.DataSource = tabelaCadastro;
                dataGridView1.Columns["idclientes"].HeaderText = "Código";
            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNOMECLIENTE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSTATUS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxORCA_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxOBS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPROC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPLACA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFONTE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRAM_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxACESS_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxQCL_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSALVAR_Click(object sender, EventArgs e)
        {
            labelNome.ForeColor = Color.Black;
            labelCel.ForeColor = Color.Black;

            try
            {
                if (textBoxNOMECLIENTE.Text != "" && textBoxCEL.Text != "")
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO clientes(nome, celular, processador, placamae, fonte, ram, video, acessorios, status, dataentrada, orcamento, obsevacao, queixa) VALUES ('" + textBoxNOMECLIENTE.Text + "', '" + textBoxCEL.Text + "', '" + textBoxPROC.Text + "', '" + textBoxPLACA.Text + "', '" + textBoxFONTE.Text + "', '" + textBoxRAM.Text + "', '" + textBoxVID.Text + "', '" + textBoxACESS.Text + "', '" + comboBoxSTATUS.Text + "', '" + textBox1.Text + "', '" + textBoxORCA.Text + "', '" + richTextBoxOBS.Text + "', '" + richTextBoxQCL.Text + "');";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Serviço adicionado com sucesso!");

                    LIMPAR_Formulario();
                }
                else
                {
                    MessageBox.Show("Nome e/ou Celular estão em branco. Por favor preencha!");

                    if (textBoxNOMECLIENTE.Text == "")
                    {
                        textBoxNOMECLIENTE.Focus();
                        labelNome.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBoxCEL.Focus();
                        labelCel.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception erro_mysql)
            {
                // Mensagem de erro - MySQL
                // MessageBox.Show(erro_mysql.Message);

                // Mensagem de erro - USUÁRIO
                MessageBox.Show("Erro de Sistema. Solicite ajuda!");
            }
            finally
            {
                conexao.Close();
            }
            ATUALIZA_cadastro();
            LIMPAR_Formulario();

        }

        private void buttonALT_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();

                comando.CommandText = "UPDATE clientes SET nome = '" + textBoxNOMECLIENTE.Text + "', celular = '" + textBoxCEL.Text + "', processador = '" + textBoxPROC.Text + "', placamae = '" + textBoxPLACA.Text + "', fonte = '" + textBoxFONTE.Text + "', ram = '" + textBoxRAM.Text + "', video = '" + textBoxVID.Text + "', acessorios = '" + textBoxACESS.Text + "', status = '" + comboBoxSTATUS.Text + "', dataentrada = '" + textBox1.Text + "', orcamento = '" + textBoxORCA.Text + "', obsevacao = '" + richTextBoxOBS.Text + "', queixa = '" + richTextBoxQCL.Text + "' WHERE idclientes = " + idREGISTRO + ";";
                int resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Cliente(s) atualizado(s) com sucesso! - " + resultado + " registros atualizados...");
                }
                else
                {
                    MessageBox.Show("Contato não encontrado!");
                }
            }
            catch (Exception erro_mysql)
            {
                // Mensagem de erro - MySQL
                MessageBox.Show(erro_mysql.Message);

                // Mensagem de erro - USUÁRIO
                MessageBox.Show("Erro de Sistema. Solicite ajuda!");
            }
            finally
            {
                conexao.Close();
            }
            ATUALIZA_cadastro();
            LIMPAR_Formulario();
        }

        private void buttonEX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente EXCLUIR este registro?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();

                    comando.CommandText = "DELETE FROM clientes WHERE idclientes = " + idREGISTRO + ";";
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente(s) removido(s) com sucesso! - " + resultado + " registros removidos...");
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado!");
                    }
                }
                catch (Exception erro_mysql)
                {
                    // Mensagem de erro - MySQL
                    MessageBox.Show(erro_mysql.Message);

                    // Mensagem de erro - USUÁRIO
                    MessageBox.Show("Erro de Sistema. Solicite ajuda!");
                }
                finally
                {
                    conexao.Close();
                }
                ATUALIZA_cadastro();
            }
            else
            {
                // MessageBox.Show("NÃO");
            }
            LIMPAR_Formulario();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idREGISTRO = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            textBoxNOMECLIENTE.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxCEL.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPROC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxPLACA.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxFONTE.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxRAM.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxVID.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxACESS.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBoxSTATUS.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBoxORCA.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            richTextBoxOBS.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            richTextBoxQCL.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPESQ.Text == "")
                {
                    ATUALIZA_cadastro();
                }
                else
                {
                    conexao.Open();

                    comando.CommandText = "SELECT * FROM clientes WHERE nome LIKE '%" + textBoxPESQ.Text + "%';";
                    MySqlDataAdapter adaptadorSERVICO = new MySqlDataAdapter(comando);
                    DataTable tabelaSERVICO = new DataTable();
                    adaptadorSERVICO.Fill(tabelaSERVICO);

                    dataGridView1.DataSource = tabelaSERVICO;
                    dataGridView1.Columns["idclientes"].HeaderText = "Código";
                }
            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

