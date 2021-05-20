namespace Cambios
{
    using Cambios.Modelos;
    using Cambios.Servicos;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class form1 : Form
    {
        #region Atributos

        private List<Rate> Rates;
        
        private NetworkService networkService;

        private ApiService apiService;

        private DialogService dialogService;

        private DataService dataservice;

        #endregion

        public form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            dataservice = new DataService();
            LoadRates();
        }

        private async void LoadRates()
        {
            bool load;

            lbl_Resultado.Text = "A atualizar Taxas...";

            var connection = networkService.CheckConnection();

            if(!connection.IsSuccess)
            {
                LoadLocalRates();
                load = false;
            }
            else
            {
                await LoadApiRates();
                load = true;
            }

            if(Rates.Count == 0)
            {
                lbl_Resultado.Text = "Não há ligação á Internet" + Environment.NewLine +
                    "e não foram préviamente carregadas as taxas." + Environment.NewLine +
                    "Tente mais tarde!";

                lbl_Status.Text = "Primeira inicialização deverá ter ligação á Internet";

                return;
            }

            cb_Origem.DataSource = Rates;
            cb_Origem.DisplayMember = "Name";

            // Corrige o Bug da Microsoft 
            cb_Destino.BindingContext = new BindingContext();

            cb_Destino.DataSource = Rates;
            cb_Destino.DisplayMember = "Name";

            lbl_Resultado.Text = "Taxas carregadas...";

            if(load)
            {
                lbl_Status.Text = string.Format("Taxas carregadas da internet em {0:F}", DateTime.Now);
            }
            else
            {
                lbl_Status.Text = string.Format("Taxas carregadas da Base de Dados.");
            }

            progressBar1.Value = 100;

            btn_Converter.Enabled = true;
            btn_Troca.Enabled = true;
        }

        private void LoadLocalRates()
        {
            Rates = dataservice.GetData();
        }

        private async Task LoadApiRates()
        {
            progressBar1.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com", "/api/rates");

            Rates = (List<Rate>)response.Result;

            dataservice.DeleteData();

            dataservice.SaveData(Rates);
        }

        private void btn_Converter_Click(object sender, EventArgs e)
        {
            Converter();
        }

        private void Converter()
        {
            if(string.IsNullOrEmpty(txt_Valor.Text))
            {
                dialogService.ShowMessage("Erro", "Insira um valor a converter");
                return;
            }

            decimal valor;

            if(!decimal.TryParse(txt_Valor.Text, out valor))
            {
                dialogService.ShowMessage("Erro de conversão", "Valor terá que ser numérico");
                return;
            }

            if(cb_Origem.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro", "Tem que escolher uma moeda a converter");
                return;
            }

            if (cb_Destino.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro", "Tem que escolher uma moeda de destino a converter");
                return;
            }

            var taxaOrigem = (Rate) cb_Origem.SelectedItem;

            var taxaDestino = (Rate)cb_Destino.SelectedItem;

            var valorConvertido = valor / (decimal)taxaOrigem.TaxRate * (decimal) taxaDestino.TaxRate;

            lbl_Resultado.Text = string.Format("{0} {1:C2} = {2} {3:C2}", taxaOrigem.Code, valor, taxaDestino.Code, valorConvertido);
        }

        private void btn_Troca_Click(object sender, EventArgs e)
        {
            Troca();
        }

        private void Troca()
        {
            var aux = cb_Origem.SelectedItem;
            cb_Origem.SelectedItem = cb_Destino.SelectedItem;
            cb_Destino.SelectedItem = aux;
            Converter();
        }
    }
}
