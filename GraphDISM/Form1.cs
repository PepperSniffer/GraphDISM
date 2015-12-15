using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphDISM
{
    public partial class GraphDismMain : Form
    {
        int compt = 0;
        string multiplePackages = "";
        /// <summary>
        /// Programme de gestion graphique de l'outil en ligne de commande Micrsoft DISM
        /// </summary>
        public GraphDismMain()
        {
            InitializeComponent();

            txtOutput.Text = "GraphDISM By Jules GROSPEILLER";
            cmbCompress.SelectedIndex = 0;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnResetOutput, "Remet l'affichage des resultats des operations à zero");
            ToolTip1.SetToolTip(this.btnGetInfo, "Permet d'afficher les informations de l'image séléctionnée");
            ToolTip1.SetToolTip(this.txtPathInfo, "Chemin de l'image");
            ToolTip1.SetToolTip(this.btnOpenFileInfo, "Permet de selectionner l'image");
            ToolTip1.SetToolTip(this.chkOpenNewFormInfo, "Ouvre les informations dans une nouvelle fenêtre ");
            ToolTip1.SetToolTip(this.btnOpenWimMount, "Permet de selectionner l'image");
            ToolTip1.SetToolTip(this.btnExport, "Exporte l'image séléctionnée avec les options cochées");
            ToolTip1.SetToolTip(this.btnOpenSplit, "Permet de selectionner l'image");
            ToolTip1.SetToolTip(this.cbbMoutIndex, "Permet de selectionner l'index à monter");
            ToolTip1.SetToolTip(this.btnMountTo, "Permet de selectionner le repertoire où monter l'image \nSelectionne l'endroit de l'image montée pour la demonter");
            ToolTip1.SetToolTip(this.btnUnmout, "Demonte l'image du dossier selectionné avec les options cochées plus bas");
            ToolTip1.SetToolTip(this.btnMount, "Monte l'image avec les options cochées plus bas");
            ToolTip1.SetToolTip(this.chkCheckIntegrityMount, "Verifie l'integritée des fichiers lors du montage");
            ToolTip1.SetToolTip(this.chkCheckIntegrityUnmount, "Verifie l'integritée des fichiers lors du demontage");
            ToolTip1.SetToolTip(this.chkBoot, "Ajoute l'option bootable à l'image");
            ToolTip1.SetToolTip(this.chkCommitUnmount, "Applique les changements lors du demontage de l'image");
            ToolTip1.SetToolTip(this.chkOptimizeMount, "Monte l'image en même temps que l'on y accede processus cours mais accès au repertoire plus long");
            ToolTip1.SetToolTip(this.chkReadOnlyMout, "Applique la propriété de lecture seules au fichiers montés");
            ToolTip1.SetToolTip(this.chkVerifyExport, "Verifie l'integritée des fichiers lors de l'export");
            ToolTip1.SetToolTip(this.chkAppendUnmount, "Ajoute l'image montée comme un nouvel index au lieu de remplacer le précédent");
            ToolTip1.SetToolTip(this.chkVerifySplit, "Verifie l'integritée des fichiers lors du split");
            ToolTip1.SetToolTip(this.btnExportTo, "Permet de selectionner l'emplacement vers laquelle exporter");
            ToolTip1.SetToolTip(this.btnOpenWimExp, "Permet de selectionner l'image à exporter");
            ToolTip1.SetToolTip(this.btnSplit, "Split l'image selectionnée vers la destination selectionnée avec les option cochées");
            ToolTip1.SetToolTip(this.btnSplitTo, "Permet de selectionner la destination des fichiers images decoupés");
            ToolTip1.SetToolTip(this.cmbCompress, "Permet de choisir le mode de compression de l'image (Rapide par default)");
            ToolTip1.SetToolTip(this.numIndex, "Permet de selectionner l'index à exporter");
            ToolTip1.SetToolTip(this.txtSizeSplit, "Taille des fichiers SWM une fois splités 4096 Mo par default pour compatibilité avec FAT32");
            ToolTip1.SetToolTip(this.btnChoosePackages, "Permet de selectionner un ou plusieurs packages windows updates ou autre à ajouter");
            ToolTip1.SetToolTip(this.btnPackagesTo, "Selectionne  le dossier de l'image montée soit la destination des packages séléctionnés");
            ToolTip1.SetToolTip(this.btnAddPackage, "Execute la commande d'ajouts de packages");
            ToolTip1.SetToolTip(this.btnCleanupMount, "Execute la commande de nettoyage de points de montage \nCela vous permet de supprimer manuellement les dossiers montés \nMais vous empeche de les demonter");





        }

        /// <summary>
        /// Selectionne l'image pour les informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFileInfo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdWimInfo = new OpenFileDialog();
            ofdWimInfo.Filter = "Fichier WIM (*.wim)|*.wim|Fichier SWM (*.swm)|*.swm|Tout fichiers (*.*)|*.*";
            if (ofdWimInfo.ShowDialog() == DialogResult.OK)
            {
                txtPathInfo.Text = ofdWimInfo.FileName;
            }
        }
        /// <summary>
        /// Execute DISM pour recuperer les infos de l'image selectionne 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            string command = "DISM /Get-WimInfo /wimfile:", arguments = "";


            arguments = txtPathInfo.Text;
            command = (command + "\"" + arguments + "\"");
            ProcessStartInfo wimInfo = new ProcessStartInfo("cmd");
            wimInfo.UseShellExecute = false;
            wimInfo.RedirectStandardOutput = true;
            wimInfo.CreateNoWindow = true;
            wimInfo.RedirectStandardInput = true;
            wimInfo.StandardOutputEncoding = Encoding.GetEncoding(850);

            var proc = Process.Start(wimInfo);
            proc.StandardInput.WriteLine(@command);
            proc.StandardInput.WriteLine("exit");

            string outputTemp = proc.StandardOutput.ReadToEnd();
            txtOutput.Text = outputTemp;

            if (outputTemp.Contains("Erreur : "))
                MessageBox.Show("Attention une erreure s'est produite", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (chkOpenNewFormInfo.Checked)
                {

                    Form FormInfoExt = new FormInfoExt(outputTemp);
                    FormInfoExt.Show();
                }
                else
                    MessageBox.Show("Commande réalisée\nVoir resultat", "GraphDISM");
            }


        }
        /// <summary>
        /// Selectionne l'image de destination pour exporter 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdExportTo = new SaveFileDialog();
            sfdExportTo.Filter = "Fichier WIM (*.wim)|*.wim|Fichier SWM (*.swm)|*.swm|Tout fichiers (*.*)|*.*";
            sfdExportTo.Title = "Exporter vers un fichier WIM ou SWM";
            sfdExportTo.OverwritePrompt = false;
            if (sfdExportTo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtExportTo.Text = sfdExportTo.FileName;
            }
        }


        /// <summary>
        /// Selectionne l'image source a exporter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenWimExp_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofdWimExport = new OpenFileDialog();
            ofdWimExport.Filter = "Fichier WIM (*.wim)|*.wim|Fichier SWM (*.swm)|*.swm|Tout fichiers (*.*)|*.*";
            if (ofdWimExport.ShowDialog() == DialogResult.OK)
            {
                txtExportFrom.Text = ofdWimExport.FileName;
            }
        }

        /// <summary>
        /// Execute la commande DISM pour exporter les images selectionnees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            string command = "DISM /Export-Image /SourceImageFile:", source = "", index = "", destination = "";

            destination = txtExportTo.Text;
            source = txtExportFrom.Text;
            index = numIndex.Text;
            command = (command + "\"" + source + "\"" + " /SourceIndex:" + index + " /DestinationImageFile:\"" + destination + "\"");

            if (cmbCompress.Text == "Maximum")
                command = command + " /Compress:max";
            if (cmbCompress.Text == "Recovery")
                command = command + " /Compress:recovery";
            if (cmbCompress.Text == "Aucune")
                command = command + " /Compress:none";
            if (chkVerifyExport.Checked)
                command = command + " /CheckIntegrity";
            if (chkBoot.Checked)
                command = command + " /Bootable";

            ProcessStartInfo wimExport = new ProcessStartInfo("cmd");
            wimExport.UseShellExecute = false;
            wimExport.RedirectStandardOutput = true;
            wimExport.CreateNoWindow = true;
            wimExport.RedirectStandardInput = true;
            wimExport.StandardOutputEncoding = Encoding.GetEncoding(850);


            var proc = Process.Start(wimExport);
            proc.StandardInput.WriteLine(@command);
            proc.StandardInput.WriteLine("exit");

            string outputTemp = proc.StandardOutput.ReadToEnd();
            txtOutput.Text = outputTemp;
            if (outputTemp.Contains("Erreur : "))
                MessageBox.Show("Attention une erreure s'est produite", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Commande réalisée\nVoir resultat", "GraphDISM");


        }
        /// <summary>
        /// Bouton qui remet a zero la textbox d'ouput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetOutput_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "GraphDISM By Jules GROSPEILLER";
            compt++;
            if (compt >= 10)
                txtOutput.Text = "Ceci n'est pas un Easter Egg";

        }
        /// <summary>
        /// Selectionne l'image a spliter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenSplit_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdWimToSwm = new OpenFileDialog();
            ofdWimToSwm.Filter = "Fichier WIM (*.wim)|*.wim|Tout fichiers (*.*)|*.*";
            ofdWimToSwm.Title = "Ouvrir une Wim ...";
            if (ofdWimToSwm.ShowDialog() == DialogResult.OK)
            {
                txtOpenSplit.Text = ofdWimToSwm.FileName;
            }
        }
        /// <summary>
        /// Selectionne l'emplacement des images splitees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSplitTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdSplitTo = new SaveFileDialog();
            sfdSplitTo.Filter = "Fichier SWM(*.swm) | *.swm";
            sfdSplitTo.Title = "Splitter vers ...";

            if (sfdSplitTo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSplitTo.Text = sfdSplitTo.FileName;
            }
        }
        /// <summary>
        /// Execute la commande DISM pour spliter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSplit_Click(object sender, EventArgs e)
        {
            string command = "DISM /Split-Image /ImageFile:", source = "", size = "", destination = "";

            destination = txtSplitTo.Text;
            source = txtOpenSplit.Text;
            size = txtSizeSplit.Text;
            command = (command + "\"" + source + "\"" + " /SWMFile:\"" + destination + "\"" + " /FileSize:\"" + size + "\"");


            if (chkVerifySplit.Checked)
                command = command + " /CheckIntegrity";

            ProcessStartInfo wimExport = new ProcessStartInfo("cmd");
            wimExport.UseShellExecute = false;
            wimExport.RedirectStandardOutput = true;
            wimExport.CreateNoWindow = true;
            wimExport.RedirectStandardInput = true;
            wimExport.StandardOutputEncoding = Encoding.GetEncoding(850);

            var proc = Process.Start(wimExport);
            proc.StandardInput.WriteLine(@command);
            proc.StandardInput.WriteLine("exit");

            string outputTemp = proc.StandardOutput.ReadToEnd();
            txtOutput.Text = outputTemp;
            if (outputTemp.Contains("Erreur : "))
                MessageBox.Show("Attention une erreure s'est produite", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Commande réalisée\nVoir resultat", "GraphDISM");

        }
        /// <summary>
        /// Selectionne l'image source pour Monter 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenWimMount_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdWimMount = new OpenFileDialog();
            ofdWimMount.Filter = "Fichier WIM (*.wim)|*.wim|Fichier SWM (*.swm)|*.swm|Tout fichiers (*.*)|*.*";
            if (ofdWimMount.ShowDialog() == DialogResult.OK)
            {
                txtMountFrom.Text = ofdWimMount.FileName;
            }
        }
        /// <summary>
        /// Selectionne le dossier de destionation pour spliter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMountTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdMoutTo = new FolderBrowserDialog();
            fbdMoutTo.Description = "Selectionnez le repertoire où monter l'image";
            if (fbdMoutTo.ShowDialog() == DialogResult.OK)
                txtMountTo.Text = fbdMoutTo.SelectedPath;
        }
        /// <summary>
        /// Execute la commande DISM pour monter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string command = "DISM /Mount-Image /ImageFile:", source = "", index = "", destination = "";

            destination = txtMountTo.Text;
            source = txtMountFrom.Text;
            index = cbbMoutIndex.Text;
            command = (command + "\"" + source + "\"" + " /Index:\"" + index + "\"" + " /MountDir:\"" + destination + "\"");


            if (chkReadOnlyMout.Checked)
                command += " /ReadOnly";
            if (chkOptimizeMount.Checked)
                command += " /Optimize";
            if (chkCheckIntegrityMount.Checked)
                command += " /CheckIntegrity";

            ProcessStartInfo wimMount = new ProcessStartInfo("cmd");
            wimMount.UseShellExecute = false;
            wimMount.RedirectStandardOutput = true;
            wimMount.CreateNoWindow = true;
            wimMount.RedirectStandardInput = true;
            wimMount.StandardOutputEncoding = Encoding.GetEncoding(850);

            var proc = Process.Start(wimMount);
            proc.StandardInput.WriteLine(@command);
            proc.StandardInput.WriteLine("exit");

            string outputTemp = proc.StandardOutput.ReadToEnd();
            txtOutput.Text = outputTemp;
            if (outputTemp.Contains("Erreur : "))
                MessageBox.Show("Attention une erreure s'est produite", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Commande réalisée\nVoir resultat", "GraphDISM");
        }

        private void btnUnmout_Click(object sender, EventArgs e)
        {
            string command = "DISM /Unmount-Image /MountDir:", mountDir = "";
            mountDir = txtMountTo.Text;
            command = (command + "\"" + mountDir + "\"");

            if (chkCommitUnmount.Checked)
                command += " /Commit";

            else
            {
                command += " /Discard";
            }


            if (chkCheckIntegrityUnmount.Checked)
                command += " /CheckIntegrity";
            if (chkAppendUnmount.Checked)
                command += " /Append";

            ProcessStartInfo wimUnmount = new ProcessStartInfo("cmd");
            wimUnmount.UseShellExecute = false;
            wimUnmount.RedirectStandardOutput = true;
            wimUnmount.CreateNoWindow = true;
            wimUnmount.RedirectStandardInput = true;
            wimUnmount.StandardOutputEncoding = Encoding.GetEncoding(850);

            var proc = Process.Start(wimUnmount);
            proc.StandardInput.WriteLine(@command);
            proc.StandardInput.WriteLine("exit");

            string outputTemp = proc.StandardOutput.ReadToEnd();
            txtOutput.Text = outputTemp;
            if (outputTemp.Contains("Erreur : "))
                MessageBox.Show("Attention une erreure s'est produite", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Commande réalisée\nVoir resultat", "GraphDISM");
        }

        private void btnChoosePackages_Click(object sender, EventArgs e)
        {
            multiplePackages = "";
            OpenFileDialog ofdAddPackage = new OpenFileDialog();
            ofdAddPackage.Filter = "Fichier CAB (*.cab)|*.cab|Tout fichiers (*.*)|*.*";
            ofdAddPackage.Multiselect = true;
            if (ofdAddPackage.ShowDialog() == DialogResult.OK)
            {
                string[] result = ofdAddPackage.FileNames;
                foreach (string file in result)
                {
                    multiplePackages += " /PackagePath:\"" + file + "\"";
                }
            }
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            string command = "DISM /Image:\"", mountDir;
            mountDir = txtFolderPathPackage.Text;
            command = (command + mountDir + "\" /Add-Package" + multiplePackages);

            ProcessStartInfo wimUnmount = new ProcessStartInfo("cmd");
            wimUnmount.UseShellExecute = false;
            wimUnmount.RedirectStandardOutput = true;
            wimUnmount.CreateNoWindow = true;
            wimUnmount.RedirectStandardInput = true;
            wimUnmount.StandardOutputEncoding = Encoding.GetEncoding(850);

            var proc = Process.Start(wimUnmount);
            proc.StandardInput.WriteLine(@command);
            proc.StandardInput.WriteLine("exit");

            string outputTemp = proc.StandardOutput.ReadToEnd();
            txtOutput.Text = outputTemp;
            if (outputTemp.Contains("Erreur : "))
                MessageBox.Show("Attention une erreure s'est produite", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Commande réalisée\nVoir resultat", "GraphDISM");
            
        }

        private void btnPackagesTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdbMountedRep = new FolderBrowserDialog();
            fdbMountedRep.Description = "Selectionnez le repertoire l'image est montée";
            if (fdbMountedRep.ShowDialog() == DialogResult.OK)
                txtFolderPathPackage.Text = fdbMountedRep.SelectedPath;
        }

        private void btnCleanupMount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Attention vous êtes sur le point de nettoyer les points de montages de vos images. Après cette action vos images montées ne seronts plus demontables\nVoulez-vous continuer ?", "Attention !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string command = "DISM /Cleanup-Mountpoints";
                
                ProcessStartInfo wimUnmount = new ProcessStartInfo("cmd");
                wimUnmount.UseShellExecute = false;
                wimUnmount.RedirectStandardOutput = true;
                wimUnmount.CreateNoWindow = true;
                wimUnmount.RedirectStandardInput = true;
                wimUnmount.StandardOutputEncoding = Encoding.GetEncoding(850);

                var proc = Process.Start(wimUnmount);
                proc.StandardInput.WriteLine(@command);
                proc.StandardInput.WriteLine("exit");

                string outputTemp = proc.StandardOutput.ReadToEnd();
                txtOutput.Text = outputTemp;
                if (outputTemp.Contains("Erreur : "))
                    MessageBox.Show("Attention une erreure s'est produite", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Commande réalisée\nVoir resultat", "GraphDISM");
            }
        }
    }
}