using System;
using System.IO;
using System.Windows.Forms;

namespace EditeurTexte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Créer une instance de la classe OpenFileDialog
        OpenFileDialog ofd = new OpenFileDialog();

        // Méthode appelée lors du clic sur le menu "Ouvrir"
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {


            // Définir les filtres de fichier pour afficher uniquement les fichiers texte (.txt) ou tous les fichiers
            ofd.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";

            // Si l'utilisateur a sélectionné un fichier et a cliqué sur le bouton "Ouvrir"
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Récupérer le nom du fichier sélectionné
                string filename = openFileDialog.FileName;

                // Lire le contenu du fichier et l'afficher dans le contrôle TextBox
                string text = File.ReadAllText(filename);
                textBox1.Text = text;
            }
        }

        // Méthode appelée lors du clic sur le menu "Enregistrer"
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créer une instance de la classe SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Définir les filtres de fichier pour afficher uniquement les fichiers texte (.txt) ou tous les fichiers
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";

            // Si l'utilisateur a sélectionné un emplacement de fichier et a cliqué sur le bouton "Enregistrer"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Récupérer le nom du fichier sélectionné
                string filename = saveFileDialog.FileName;

                // Écrire le contenu du contrôle TextBox dans le fichier
                File.WriteAllText(filename, textBox1.Text);
            }
        }

        // Méthode appelée lors du clic sur le menu "Couper"
        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Utiliser la méthode Cut du contrôle TextBox pour couper le texte sélectionné
            textBox1.Cut();
        }

        // Méthode appelée lors du clic sur le menu "Copier"
        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Utiliser la méthode Copy du contrôle TextBox pour copier le texte sélectionné
            textBox1.Copy();
        }

        // Méthode appelée lors du clic sur le menu "Coller"
        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Utiliser la méthode Paste du contrôle TextBox pour coller le texte depuis le presse-papiers
            textBox1.Paste();
        }
    }
}
