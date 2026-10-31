using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Opggessaye
{
    public static class Transition
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        // Constantes d'animation Windows
        private const int AW_HIDE = 0x00010000;
        private const int AW_ACTIVATE = 0x00020000;
        private const int AW_BLEND = 0x00080000; // Effet fondu
        private const int AW_SLIDE = 0x00040000; // Effet glissement

        /// <summary>
        /// Change de fenêtre avec un effet de fondu progressif.
        /// </summary>
        public static void TransitionTo(Form currentForm, Form nextForm, int durationMs = 250)
        {
            // Alignement de la nouvelle fenêtre sur la position actuelle
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Location = currentForm.Location;

            // 1. Afficher la nouvelle fenêtre en fondu
            AnimateWindow(nextForm.Handle, durationMs, AW_ACTIVATE | AW_BLEND);
            nextForm.Show();

            // 2. Masquer ou fermer l'ancienne fenêtre en fondu
            AnimateWindow(currentForm.Handle, durationMs, AW_HIDE | AW_BLEND);
            currentForm.Hide(); // Ou currentForm.Close();
        }
    }
}
