using Xamarin.Forms;

namespace Mynewapp.Views
{
    public partial class Homepage : MasterDetailPage
    {
        public Homepage()
        {
            IsPresented = true;
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            IsPresented = false;
        }
    }
}