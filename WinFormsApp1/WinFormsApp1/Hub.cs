using Opggessaye;
using System.Diagnostics;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Hub : Form
    {
        RiotAccount Default = new RiotAccount("Sokonis", "DENJI","l3YrA0qj7eerxV1KCey74gMzdVXyRJc_2Q37X_6tHNEPvSNv860YGJj8xavxAjJPrdaHhOeUuLLjiQ");
        private RiotApiHandler API;
        private RiotAccount Current;
        public Hub()
        {
            InitializeComponent();
            API = new();
            this.Text = "OPGGEssayé";
            Search_Puiid.Click += UseProfile;
            Name_player.Click += StartsWritting;
            Name_player.GotFocus += StartsWritting;
            Name_player.KeyDown += EnterWritting;

        }
        public async void UseProfile(object sender, EventArgs e)
        {
            try
            {
                RiotAccount Account = await API.GetByRiotID(Name_player.Text.Split('#')[0], Name_player.Text.Split('#')[1]);
                PlayerStat Next = new(Account, API);
                Transition.TransitionTo(this,Next);
                //resultlabel.Visible = true;
                //resultlabel.Text = $"Bonjour {Account.gameName}, \nton PUUID est : {Account.puuid} \nc'est fou non ?";
                //Masteries.Visible = true;
                



            }
            catch (System.IndexOutOfRangeException)
            {
                ShowError("Mettre un Pseudo sous le format EXEMPLE#RIOT");
                //MessageBox.Show("Mettre un Pseudo sous le format pseudo#EXEMPLE", "Erreur pseudo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (KeyNotFoundException ex)
            {
                //MessageBox.Show(ex.Message, "Joueur introuvable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ShowError("Joueur introuvable");
            }
            catch (HttpRequestException ex)
            {
                //MessageBox.Show(ex.Message, "Erreur de l'API", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ShowError("Erreur de l'API.");
            }


        }
        public void StartsWritting(object sender, EventArgs e)
        {
            Name_player.Text = System.String.Empty;
            Name_player.ForeColor = Color.Black;
        }
        public async void EnterWritting(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_Puiid.Focus();
                UseProfile(sender, e);
            }
        }
        private async void ShowError(string text)
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = text;
            await Task.Delay(5000);
            ErrorLabel.Visible = false;

        }
        
        
    }
}
