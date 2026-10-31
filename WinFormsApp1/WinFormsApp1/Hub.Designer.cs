using System.Reflection.Emit;

namespace WinFormsApp1
{
    partial class Hub
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Search_Puiid = new Button();
            Masteries = new Button();
            Name_player = new TextBox();
            resultlabel = new System.Windows.Forms.RichTextBox();
            ErrorLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Search_Puiid
            // 
            Search_Puiid.Font = new Font("Yu Gothic", 9.75F);
            Search_Puiid.Location = new Point(323, 156);
            Search_Puiid.Name = "Search_Puiid";
            Search_Puiid.Size = new Size(119, 23);
            Search_Puiid.TabIndex = 0;
            Search_Puiid.Text = "Find Profile";
            Search_Puiid.UseVisualStyleBackColor = true;
            // 
            // Masteries
            // 
            Masteries.Font = new Font("Yu Gothic", 9.75F);
            Masteries.Location = new Point(323, 185);
            Masteries.Name = "Masteries";
            Masteries.Size = new Size(119, 23);
            Masteries.TabIndex = 2;
            Masteries.Text = "Top 5 masteries";
            Masteries.UseVisualStyleBackColor = true;
            Masteries.Visible = false;
            // 
            // Name_player
            // 
            Name_player.PlaceholderText = "EXEMPLE#RIOT";
            Name_player.ForeColor = SystemColors.ScrollBar;
            Name_player.CharacterCasing = CharacterCasing.Upper;
            Name_player.Cursor = Cursors.IBeam;
            Name_player.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);

            Name_player.Location = new Point(263, 109);
            Name_player.Name = "Name_player";
            Name_player.Size = new Size(244, 41);
            Name_player.TabIndex = 2;
            Name_player.TextAlign = HorizontalAlignment.Center;
            // 
            // resultlabel
            // 
            resultlabel = new System.Windows.Forms.RichTextBox();
            resultlabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultlabel.BackColor = this.BackColor; // Identique au fond de la fenêtre
            resultlabel.BorderStyle = BorderStyle.None;
            resultlabel.Font = new Font("Yu Gothic", 11.75F);
            resultlabel.Location = new Point(263, 231);
            resultlabel.Name = "resultlabel";
            resultlabel.ReadOnly = true;
            resultlabel.ScrollBars = RichTextBoxScrollBars.Vertical; // Barre de défilement si le texte est long
            resultlabel.Size = new Size(500, 500);
            resultlabel.TabIndex = 3;
            resultlabel.Text = "";
            resultlabel.Visible = false;
            // 
            // ErrorLabel
            // 
            ErrorLabel.Anchor = AnchorStyles.None;
            ErrorLabel.BackColor = Color.Transparent;
            ErrorLabel.Font = new Font("Yu Gothic", 10F);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(293, 56);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(185, 50);
            ErrorLabel.TabIndex = 5;
            ErrorLabel.Text = "test";
            ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            ErrorLabel.Visible = false;
            // 
            // Hub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(ErrorLabel);
            Controls.Add(resultlabel);
            Controls.Add(Name_player);
            Controls.Add(Search_Puiid);
            Controls.Add(Masteries);
            Name = "Hub";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Search_Puiid;
        private Button Masteries;
        private TextBox Name_player;

        private System.Windows.Forms.RichTextBox resultlabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}
