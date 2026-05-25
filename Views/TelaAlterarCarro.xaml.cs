private async void OnSalvarClicked(object sender, EventArgs e)
{
    string modelo = txtModelo.Text;
    string marca = txtMarca.Text;
    string ano = txtAno.Text;
    string placa = txtPlaca.Text;

    await DisplayAlert(
        "Sucesso",
        "Dados alterados com sucesso!",
        "OK"
    );
}
