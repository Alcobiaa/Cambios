namespace Cambios
{
    using Cambios.Modelos;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Windows.Forms;

    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            LoadRates();
        }

        private async void LoadRates()
        {
            //bool load;

            progressBar1.Value = 0;

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://cambios.somee.com");

            var response = await client.GetAsync("/api/rates");

            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase);
                return;
            }

            var rates = JsonConvert.DeserializeObject<List<Rate>>(result);

            cb_Origem.DataSource = rates;
            cb_Origem.DisplayMember = "Name";

            cb_Destino.BindingContext = new BindingContext();

            cb_Destino.DataSource = rates;
            cb_Destino.DisplayMember = "Name";

            progressBar1.Value = 100;
        }
    }
}
