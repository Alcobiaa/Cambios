namespace Cambios.Servicos
{
    using System.Windows.Forms;

    public class DialogService
    {
        public void ShowMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }
    }
}
