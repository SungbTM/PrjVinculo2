namespace PrjVinculo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao = "Coca Cola 2L";
            produto.Preco = 8;
            produto.Categoria = "Bebida";

            Navigation.PushAsync(new ProdutoPage() { BindingContext = produto});
        }

        private void btnAndares_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AndaresPage());
        }

        private void btnProduto2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProdutoPage2());
        }

        private void btnCelular_Clicked(object sender, EventArgs e)
        {
            Celular2 celular2 = new Celular2();

            BackgroundColor = Colors.Red;

            celular2.Marca = "Samsung";
            celular2.Numero = 154234534;
            celular2.Operadora = "Claro";
            celular2.Capinha = true;
            celular2.Processador = "SnapDragon Elite";
            celular2.Bateria = 4000;
            celular2.Tela = 6.9;
            celular2.Memoria = 512;
            celular2.Preco4 = 6700;
            celular2.Categoria4 = "Aparelho celular";
            Navigation.PushAsync(new Celular() { BindingContext=celular2});
        }

        private void btnIphone_Clicked(object sender, EventArgs e)
        {
            Iphone iphone = new Iphone();

            
        }
    }
}
