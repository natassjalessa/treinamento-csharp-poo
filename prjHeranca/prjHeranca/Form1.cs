using Microsoft.VisualBasic;
namespace prjHeranca
{
    public partial class Form1 : Form
    {
        Livro liv = new Livro();
        CD cd = new CD();
        DVD dvd = new DVD();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            liv.descricao = txtDesPro.Text;
            liv.autor = txtAutor.Text;
            liv.edicao = txtEdicao.Text;
            liv.editora = txtEditora.Text;
            liv.estoqueDisponivel = int.Parse(txtEstoque.Text);
            liv.genero = txtGenero.Text;
            liv.precoCusto = double.Parse(txtPreco.Text);
            MessageBox.Show("Livro cadastrado com sucesso");

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(Interaction.InputBox("Digite a quantidade"));
            liv.comprar(qtde);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(Interaction.InputBox("Digite a quantidade"));
            liv.vender(qtde);

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            liv.listarProdutos();
        }

        private void btnComprarCD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(Interaction.InputBox("Digite a quantidade"));
            cd.comprar(qtde);

        }

        private void btnCadastrarCD_Click(object sender, EventArgs e)
        {
            cd.artista = txtArtista.Text;
            cd.gravadora = txtGravadora.Text;
            cd.paisOrigem = txtOrigem.Text;
            cd.descricao = txtDesPro.Text;
            cd.genero = txtGenero.Text;
            cd.estoqueDisponivel = int.Parse(txtEstoque.Text);
            cd.precoCusto = double.Parse(txtPreco.Text);

            MessageBox.Show("Livro cadastrado com sucesso");
        }

        private void btnVenderCD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(Interaction.InputBox("Digite a quantidade"));
            cd.vender(qtde);
        }

        private void btnListarCD_Click(object sender, EventArgs e)
        {
            cd.listarProdutos();
        }

        private void btnCadastrarDVD_Click(object sender, EventArgs e)
        {
            dvd.diretor = txtDiretor.Text;
            dvd.duracao = txtDuracao.Text;
            dvd.censura = txtCensura.Text;
            dvd.descricao = txtDesPro.Text;
            dvd.genero = txtGenero.Text;
            dvd.estoqueDisponivel = int.Parse(txtEstoque.Text);
            dvd.precoCusto = double.Parse(txtPreco.Text);
        }

        private void btnComprarDVD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(Interaction.InputBox("Digite a quantidade"));
            dvd.comprar(qtde);
        }

        private void btnVenderDVD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(Interaction.InputBox("Digite a quantidade"));
            dvd.vender(qtde);
        }

        private void btnListarDVD_Click(object sender, EventArgs e)
        {
            dvd.listarProdutos();
        }
    }
}