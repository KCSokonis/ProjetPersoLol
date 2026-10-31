namespace Opggessaye
{
    partial class PlayerStat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Masteries = new Button();
            resultlabel = new RichTextBox();
            ErrorLabel = new Label();
            SuspendLayout();
            // 
            // Masteries
            // 
            Masteries.Font = new Font("Yu Gothic", 9.75F);
            Masteries.Location = new Point(189, 109);
            Masteries.Name = "Masteries";
            Masteries.Size = new Size(200, 50);
            Masteries.TabIndex = 2;
            Masteries.Text = "Top 5 masteries";
            Masteries.UseVisualStyleBackColor = true;
            Masteries.Visible = true;
            // 
            // PlayerStat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 450);
            Controls.Add(ErrorLabel);
            Controls.Add(resultlabel);
            Controls.Add(Masteries);
            Name = "PlayerStat";
            ResumeLayout(false);
            // 
            // resultlabel
            // 
            resultlabel.Dock = DockStyle.Bottom;
            resultlabel.Height = 300; // Définit uniquement la hauteur souhaitée en bas
            resultlabel.BackColor = BackColor;
            resultlabel.BorderStyle = BorderStyle.None;
            resultlabel.Font = new Font("Yu Gothic", 11.75F);
            resultlabel.Name = "resultlabel";
            resultlabel.ReadOnly = true;
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

        }

        private Button Masteries;
        private System.Windows.Forms.RichTextBox resultlabel;
        private System.Windows.Forms.Label ErrorLabel;
        #endregion
    }
}