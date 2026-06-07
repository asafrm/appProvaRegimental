using appProvaRegimental.Model;
using System.Collections.ObjectModel;

namespace appProvaRegimental.Views;

public partial class TelaListaCarro : ContentPage
{
    ObservableCollection<Carro> listagemCarros = new ObservableCollection<Carro>();
    public TelaListaCarro()
    {
        InitializeComponent();

        lstCarros.ItemsSource = listagemCarros;
    }
    private async void irTelaIncluirCarro(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new TelaIncluirCarro());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", "Ocorreu um erro ao tentar incluir o carro.", ex.Message, "OK");
        }
    }
    protected async override void OnAppearing()
    {
        try
        {
            listagemCarros.Clear();
            List<Carro> temp = await App.Database.GetAll();
            temp.ForEach(i => listagemCarros.Add(i));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", "Ocorreu um erro ao carregar a lista de carros.", ex.Message, "OK");
        }
    }

private async void excluirCarro(object sender, EventArgs e)
    {
        try
        {
            MenuItem itemSelecionado = sender as MenuItem;
            Carro carroSelecionado = itemSelecionado.BindingContext as Carro;
            bool confirmacao = await DisplayAlert("Confirmação", $"Tem certeza que deseja excluir o carro {carroSelecionado.carNome}?", "Sim", "Não");
            if (confirmacao)
            {
                await App.Database.Delete(carroSelecionado.carID);
                listagemCarros.Remove(carroSelecionado);
                await DisplayAlert("Sucesso", "Carro excluído com sucesso!!", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", "Ocorreu um erro ao tentar excluir o carro.", ex.Message, "OK");
        }
    }

    private async void txtBuscar(object sender, TextChangedEventArgs e)
    {
        try
        {
            string busca = e.NewTextValue;
            lstCarros.IsRefreshing = true;

            listagemCarros.Clear();
            List<Carro> temp = await App.Database.Search(busca);
            temp.ForEach(i => listagemCarros.Add(i));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", "Ocorreu um erro ao tentar buscar os carros.", ex.Message, "OK");
        }
        finally
        {
            lstCarros.IsRefreshing = false;
        }
    }
    private void lstCarrosItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        try
        {
            Carro carro1 = e.SelectedItem as Carro;
            Navigation.PushAsync(new TelaAlterarCarro { BindingContext = carro1 });
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", "Ocorreu um erro ao tentar abrir os detalhes do carro.", ex.Message, "OK");
        }
    }
    private async void refCarregando(object sender, EventArgs e)
    {
        try
        {
            lstCarros.IsRefreshing = true;
            listagemCarros.Clear();
            List<Carro> temp = await App.Database.GetAll();
            temp.ForEach(i => listagemCarros.Add(i));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", "Ocorreu um erro ao tentar atualizar a lista de carros.", ex.Message, "OK");
        }
        finally
        {
            lstCarros.IsRefreshing = false;
        }
    }
}