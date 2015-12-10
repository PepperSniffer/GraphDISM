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

        public GraphDismMain()
        {
            InitializeComponent();
            
            txtOutput.Text = "GraphDISM By Jules GROSPEILLER";
            cmbCompress.SelectedIndex = 0;
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
            string  command = "DISM /Export-Image /SourceImageFile:", source = "", index = "", destination = "";
            
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
                MessageBox.Show("Attention une erreure s'est produite","Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Commande réalisée\nVoir resultat","GraphDISM" );
            

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
            if (compt >=10)
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
            sfdSplitTo.Filter = "Fichier SWM(*.swm) | *.swm" ;
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
            command = (command + "\"" + source + "\"" + " /SWMFile:\"" + destination + "\""+ " /FileSize:\"" + size + "\"");

            
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
            FolderBrowserDialog fbdMoutTo = new FolderBrowserDialog() ;
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
    }
}