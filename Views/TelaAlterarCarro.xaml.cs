using appProvaRegimental.Model;
namespace appProvaRegimental.Views;

public partial class TelaAlterarCarro : ContentPage
{
    public TelaAlterarCarro()
    {
        InitializeComponent();
    }
    private async void ToolbarItemClickedSalvar(object sender, EventArgs e)
    {
        try
        {
            Carro CarroAnexado = BindingContext as Carro;
            if (string.IsNullOrWhiteSpace(txtNomeCarro.Text))
            {
                await DisplayAlert("Erro", "Por favor, preencha o nome do carro!!", "OK");
                txtNomeCarro.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtPlacaCarro.Text))
            {
                await DisplayAlert("Erro", "Por favor, preencha a placa do carro!!", "OK");
                txtPlacaCarro.Focus();
            }
            else
            {
                Carro carro1 = new Carro()
                {
                    carID = CarroAnexado.carID,
                    carNome = txtNomeCarro.Text,
                    carPlaca = txtPlacaCarro.Text,
                };
                await App.Database.Update(carro1);
                await DisplayAlert("Sucesso", "Carro atualizado com sucesso!!", "OK");
                await Navigation.PushAsync(new TelaListaCarro());
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", $"Ocorreu um erro ao atualizar o carro: {ex.Message}", "OK");
        }
    }
}