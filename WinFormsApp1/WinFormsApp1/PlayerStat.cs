using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Opggessaye
{
    public partial class PlayerStat : Form
    {
        RiotAccount User;
        private RiotApiHandler API;
        public PlayerStat(RiotAccount User, RiotApiHandler aPI)
        {

            API = aPI;
            this.User = User;
            this.Text = $"{this.User.gameName} Stats.";
            InitializeComponent();
            Masteries.Click += ShowTop5;

        }
        public async void ShowTop5(object sender, EventArgs e)
        {
            try
            {
                System.String label = "";
                List<Opggessaye.ChampionMasteries> info = await API.GetMasteries(User);
                List<System.String> MasteryInfo = API.ShowMasteries(info);
                foreach (System.String text in MasteryInfo)
                {
                    label += text;
                }
                resultlabel.Text = label;
                //resultlabel.Text = "orem ipsum dolor sit amet, consectetur adipiscing elit. Sed non risus. Suspendisse lectus tortor, dignissim sit amet, adipiscing nec, ultricies sed, dolor. Cras elementum ultrices diam. Maecenas ligula massa, varius a, semper congue, euismod non, mi. Proin porttitor, orci nec nonummy molestie, enim est eleifend mi, non fermentum diam nisl sit amet erat. Duis semper. Duis arcu massa, scelerisque vitae, consequat in, pretium a, enim. Pellentesque congue. Ut in risus volutpat libero pharetra tempor. Cras vestibulum bibendum augue. Praesent egestas leo in pede. Praesent blandit odio eu enim. Pellentesque sed dui ut augue blandit sodales. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam nibh. Mauris ac mauris sed pede pellentesque fermentum. Maecenas adipiscing ante non diam sodales hendrerit.\r\n\r\nUt velit mauris, egestas sed, gravida nec, ornare ut, mi. Aenean ut orci vel massa suscipit pulvinar. Nulla sollicitudin. Fusce varius, ligula non tempus aliquam, nunc turpis ullamcorper nibh, in tempus sapien eros vitae ligula. Pellentesque rhoncus nunc et augue. Integer id felis. Curabitur aliquet pellentesque diam. Integer quis metus vitae elit lobortis egestas. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi vel erat non mauris convallis vehicula. Nulla et sapien. Integer tortor tellus, aliquam faucibus, convallis id, congue eu, quam. Mauris ullamcorper felis vitae erat. Proin feugiat, augue non elementum posuere, metus purus iaculis lectus, et tristique ligula justo vitae magna.\r\nAliquam convallis sollicitudin purus. Praesent aliquam, enim at fermentum mollis, ligula massa adipiscing nisl, ac euismod nibh nisl eu lectus. Fusce vulputate sem at sapien. Vivamus leo. Aliquam euismod libero eu enim. Nulla nec felis sed leo placerat imperdiet. Aenean suscipit nulla in justo. Suspendisse cursus rutrum augue. Nulla tincidunt tincidunt mi. Curabitur iaculis, lorem vel rhoncus faucibus, felis magna fermentum augue, et ultricies lacus lorem varius purus. Curabitur eu amet.";
                resultlabel.Visible = true;
            }
            catch (HttpRequestException ex)
            {
                ShowError("Erreur de l'API.");
            }

        }
        private async void ShowError(string text)
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = text;
            await Task.Delay(5000);
            ErrorLabel.Visible = false;

        }

        private void resultlabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
