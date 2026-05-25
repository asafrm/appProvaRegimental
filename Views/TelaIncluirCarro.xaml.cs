namespace appProvaRegimental.Views;

public partial class TelaIncluirPessoa : ContentPage
{
    public TelaIncluirPessoa()
    {
        InitializeComponent();
    }

    private async void OnSalvarClicked(object sender, EventArgs e)
    {
        string nome = txtNome.Text;
        string cpf = txtCpf.Text;
        string telefone = txtTelefone.Text;
        string email = txtEmail.Text;

        if (string.IsNullOrWhiteSpace(nome))
        {
            await DisplayAlert("Aviso", "Informe o nome.", "OK");
            return;
        }

        await DisplayAlert(
            "Sucesso",
            "Pessoa cadastrada com sucesso!",
            "OK");
    }
}
