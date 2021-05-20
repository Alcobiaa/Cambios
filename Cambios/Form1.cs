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
        
        private NetworkService networkService;

        private ApiService apiService;

        #endregion

        public List<Rate> Rates { get; set; }

        public form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            LoadRates();
        }

        private async void LoadRates()
        {
            //bool load;

            lbl_Resultado.Text = "A atualizar Taxas...";

            var connection = networkService.CheckConnection();

            if(!connection.IsSuccess)
            {
                MessageBox.Show(connection.Message);
                return;
            }
            else
            {
                await LoadApiRates();
            }

            cb_Origem.DataSource = Rates;
            cb_Origem.DisplayMember = "Name";

            // Corrige o Bug da Microsoft 
            cb_Destino.BindingContext = new BindingContext();

            cb_Destino.DataSource = Rates;
            cb_Destino.DisplayMember = "Name";

            progressBar1.Value = 100;

            lbl_Resultado.Text = "Taxas carregadas...";
        }

        private async Task LoadApiRates()
        {
            progressBar1.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com", "/api/rates");

            Rates = (List<Rate>)response.Result;
        }
    }
}
