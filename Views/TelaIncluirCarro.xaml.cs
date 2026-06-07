using appProvaRegimental.Model;
namespace appProvaRegimental.Views;

public partial class TelaIncluirCarro : ContentPage
{
    public TelaIncluirCarro()
    {
        InitializeComponent();
    }

    private async void ToolbarItemClickedSalvar(object sender, EventArgs e)
    {
        try
        {

            if (string.IsNullOrWhiteSpace(txtNomeCarro.Text))
            {
                DisplayAlert("Erro", "Por favor, preencha o nome do carro!!", "OK");
                txtNomeCarro.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtPlacaCarro.Text))
            {
                DisplayAlert("Erro", "Por favor, preencha a placa do carro!!", "OK");
                txtPlacaCarro.Focus();
            }
            else
            {
                Carro carro1 = new Carro()
                {
                    carNome = txtNomeCarro.Text,
                    carPlaca = txtPlacaCarro.Text,
                };
                await App.Database.Insert(carro1);

                await DisplayAlert("Sucesso", "Carro cadastrado com sucesso!", "OK");

                await Navigation.PushAsync(new TelaListaCarro());
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", $"Ocorreu um erro ao cadastrar o carro:", ex.Message, "OK");
            txtNomeCarro.Text = "";
            txtPlacaCarro.Text = "";
            txtNomeCarro.Focus();
        }
    }
}
