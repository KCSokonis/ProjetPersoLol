namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private RAH API;
        public Form1()
        {
            InitializeComponent();
            API = new();
            button1.Click += ShowInfo;

        }
        public async void ShowInfo(object sender, EventArgs e)
        {
            
            Result.Text = await API.GetByRiotID("Sokonis","DENJI");

        }
    }
}
