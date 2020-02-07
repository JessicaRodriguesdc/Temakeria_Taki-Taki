using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temakeria
{
    public partial class rg : Form
    {
        public rg()
        {
            InitializeComponent();

            txtBuscarNome.Enabled = false;
            txtNome.Enabled = false;
            maskedTel.Enabled = false;
            maskedCel.Enabled = false;
            txtEmail.Enabled = false;
            txtEnd.Enabled = false;
            txtNum.Enabled = false;
            txtBairro.Enabled = false;
            txtRG.Enabled = false;
            txtCpf.Enabled = false;

        }

        SqlConnection sqlCon = null;
        //private string strcon = "data source = LAPTOP-B6ES8MDB\\SQLEXPRESS;Initial Catalog = Temakeria; Integrated Security = True;";
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Temakeria;Data Source=LAPTOP-B6ES8MDB";
        private string strSql = string.Empty;

        private void addFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            
            txtNome.Enabled = true;
            maskedTel.Enabled = true;
            maskedCel.Enabled = true;
            txtEmail.Enabled = true;
            txtEnd.Enabled = true;
            txtNum.Enabled = true;
            txtBairro.Enabled = true;
            txtRG.Enabled = true;
            txtCpf.Enabled = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into FuncionarioTemakeria (Nome,Telefone,Celular,Email,Endereco,Numero,Bairro,RG,CPF) values (@Nome,@Telefone,@Celular,@Email,@Endereco,@Numero,@Bairro,@RG,@CPF)";

            sqlCon  = new SqlConnection(strCon);
            SqlCommand comando =new  SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome",SqlDbType.VarChar).Value=txtNome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = maskedTel.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = maskedCel.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEnd.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txtNum.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtBairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txtRG.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txtCpf.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }

            txtBuscarNome.Enabled = true;

            txtNome.Clear();
            maskedTel.Clear();
            maskedCel.Clear();
            txtEmail.Clear();
            txtEnd.Clear();
            txtNum.Clear();
            txtBairro.Clear();
            txtRG.Clear();
            txtCpf.Clear();

            txtNome.Enabled = false;
            maskedTel.Enabled = false;
            maskedCel.Enabled = false;
            txtEmail.Enabled = false;
            txtEnd.Enabled = false;
            txtNum.Enabled = false;
            txtBairro.Enabled = false;
            txtRG.Enabled = false;
            txtCpf.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBuscarNome.Enabled = true;

            strSql = "select*from FuncionarioTemakeria where Nome=@pesquisa";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txtBuscarNome.Text;

            try
            {
                if(txtBuscarNome.Text == string.Empty)
                {
                    MessageBox.Show("VOCE NAO INFORMOU O NOME.");
                }
                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == false)
                {
                    throw new Exception("ESTE FUNCIONARIO NAO ESTA CADASTRADO.");
                }

                dr.Read();

                txtNome.Text = Convert.ToString(dr["Nome"]);
                maskedTel.Text = Convert.ToString(dr["Telefone"]);
                maskedCel.Text = Convert.ToString(dr["Celular"]);
                txtEmail.Text = Convert.ToString(dr["Email"]);
                txtEnd.Text = Convert.ToString(dr["Endereco"]);
                txtNum.Text = Convert.ToString(dr["Numero"]);
                txtBairro.Text = Convert.ToString(dr["Bairro"]);
                txtRG.Text = Convert.ToString(dr["RG"]);
                txtCpf.Text = Convert.ToString(dr["CPF"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }

            txtBuscarNome.Clear();
        }

        private void btnEdt_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void maskedCel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
