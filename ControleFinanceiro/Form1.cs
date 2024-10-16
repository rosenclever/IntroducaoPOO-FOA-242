using ControleFinanceiro.Model;

namespace ControleFinanceiro
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }



        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void VerificarCaixasPreenchidas()
        {
            if (txtNome.Text != "" && txtCpf.Text != "")
                btnInserir.Enabled = true;
            else
                btnInserir.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            Cliente cliente = new Cliente(nome, cpf);

            lstClientes.Items.Add(cliente.ToString());
            LimparCaixas();
        }
        private void LimparCaixas()
        {
            txtCpf.Clear();
            txtNome.Clear();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstClientes.SelectedIndex >= 0)
            {
                string[] itens = lstClientes.GetItemText(lstClientes.SelectedItem).Split(" - ");
                txtNome.Text = itens[0];
                txtCpf.Text = itens[1];
                btnExcluir.Enabled = true;
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            lstClientes.Items.RemoveAt(lstClientes.SelectedIndex);
            LimparCaixas();
            btnExcluir.Enabled=false;
        }
    }
}
