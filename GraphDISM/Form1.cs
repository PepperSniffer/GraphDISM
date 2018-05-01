using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GraphDISM {
    public partial class GraphDismMain : Form {
        int compt = 0;
        string multiplePackages = "";

        /// <summary>
        /// Programme de gestion graphique de l'outil en ligne de commande Microsoft DISM
        /// </summary>
        public GraphDismMain() {
            InitializeComponent();

            txtOutput.Text = "GraphDISM By Jules GROSPEILLER";
            cmbCompress.SelectedIndex = 0;

            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnResetOutput, "Remet l'affichage des resultats des operations à zero");
            ToolTip1.SetToolTip(this.btnGetInfo, "Permet d'afficher les informations de l'image séléctionnée");
            ToolTip1.SetToolTip(this.txtPathInfo, "Chemin de l'image");
            ToolTip1.SetToolTip(this.btnOpenFileInfo, "Permet de selectionner l'image");
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
            ToolTip1.SetToolTip(this.btnCleanupMount, "Execute la commande de nettoyage de points de montage \n" +
                                                      "Cela vous permet de supprimer manuellement les dossiers montés \n" +
                                                      "Mais vous empeche de les demonter");
            ToolTip1.SetToolTip(this.btnChooseDismPath, "Vous permet de selectionner un autre executable DISM pour la prise en charge des commandes utilisées par le programme");
            ToolTip1.SetToolTip(this.chkUseDism, "Si cochée alors toutes les commandes du programmes seront redirigé vers l'éxécutable séléctionné");
            ToolTip1.SetToolTip(this.label22, "Chalut !");
        }

        /// <summary>
        /// Execute la commande puis mets a jour txtOutput en fonction du resultat
        /// prends en compte les paramètres de l'onglet options
        /// </summary>
        /// <param name="command">Commande DISM à executer</param>
        public void DISM(string command) {
            progressBar.Visible = true;
            txtOutput.Text = "";

            // backgroundworker permettant l'execution dans un autre thread
            //ajoute de la fluidité
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;

            //execution de la commande
            bw.DoWork += new DoWorkEventHandler(
                delegate (object o, DoWorkEventArgs args) {
                    BackgroundWorker b = o as BackgroundWorker;

                    string file = "DISM";
                    string outputTemp;

                    if (chkUseDism.Checked) {
                        //recupère le chemin de l'executable que l'utilisateur souhaite utiliser
                        if (File.Exists(txtDISMPath.Text)) {
                            file = txtDISMPath.Text;
                        }
                    }

                    ProcessStartInfo dismExec = new ProcessStartInfo(file);
                    dismExec.Arguments = command;
                    dismExec.UseShellExecute = false;
                    dismExec.RedirectStandardOutput = true;
                    dismExec.CreateNoWindow = true;
                    dismExec.RedirectStandardInput = true;
                    dismExec.StandardOutputEncoding = Encoding.GetEncoding(850);
                    var proc = Process.Start(dismExec);
                    bw.ReportProgress(1, outputTemp = "**Exécutable lancé** " + file + "\r\n**Commande éxécutée** " + command);

                    while (!proc.StandardOutput.EndOfStream) {
                        //renvoie la ligne generé par la commande
                        bw.ReportProgress(1, proc.StandardOutput.ReadLine());
                    }

                });

            // what to do when progress changed (update the progress bar for example)
            bw.ProgressChanged += new ProgressChangedEventHandler(
                delegate (object o, ProgressChangedEventArgs args) {
                    //exemple de retour de progression :
                    //[==========================100.0%==========================] 
                    if (args.UserState.ToString().StartsWith("[")) {
                        //dans ce cas on fait evoluer la progressbar en fonction 
                        progressBar.Style = ProgressBarStyle.Continuous;
                        progressBar.PerformStep();
                    }
                    txtOutput.AppendText(args.UserState.ToString() + "\r\n");
                });

            // what to do when worker completes its task (notify the user)
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
                delegate (object o, RunWorkerCompletedEventArgs args) {
                    //reinitialisation de la progressbar
                    progressBar.Value = 0;
                    progressBar.Style = ProgressBarStyle.Marquee;
                    progressBar.Visible = false;

                    if (txtOutput.Text.Contains("Erreur : "))
                        MessageBox.Show("Attention une erreure s'est produite", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Commande réalisée\nVoir resultat", "GraphDISM");
                });

            //execute le background worker en arrière plan
            bw.RunWorkerAsync();
        }

        /// <summary>
        /// Selectionne l'image pour les informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFileInfo_Click(object sender, EventArgs e) {
            OpenFileDialog ofdWimInfo = new OpenFileDialog();
            ofdWimInfo.Filter = "Fichier WIM (*.wim)|*.wim|Fichier SWM (*.swm)|*.swm|Tout fichiers (*.*)|*.*";
            if (ofdWimInfo.ShowDialog() == DialogResult.OK) {
                txtPathInfo.Text = ofdWimInfo.FileName;
            }
        }


        /// <summary>
        /// Execute DISM pour recuperer les infos de l'image selectionne 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetInfo_Click(object sender, EventArgs e) {
            string command = "/Get-WimInfo /wimfile:", arguments = "";

            arguments = txtPathInfo.Text;
            command = (command + "\"" + arguments + "\"");

            DISM(command);

        }


        /// <summary>
        /// Selectionne l'image de destination pour exporter 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportTo_Click(object sender, EventArgs e) {
            SaveFileDialog sfdExportTo = new SaveFileDialog();
            sfdExportTo.Filter = "Fichier WIM (*.wim)|*.wim|Fichier SWM (*.swm)|*.swm|Tout fichiers (*.*)|*.*";
            sfdExportTo.Title = "Exporter vers un fichier WIM ou SWM";
            sfdExportTo.OverwritePrompt = false;
            if (sfdExportTo.ShowDialog() == DialogResult.OK) {
                txtExportTo.Text = sfdExportTo.FileName;
            }
        }


        /// <summary>
        /// Selectionne l'image source a exporter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenWimExp_Click(object sender, EventArgs e) {
            OpenFileDialog ofdWimExport = new OpenFileDialog();
            ofdWimExport.Filter = "Fichier WIM (*.wim)|*.wim|Fichier SWM (*.swm)|*.swm|Tout fichiers (*.*)|*.*";
            if (ofdWimExport.ShowDialog() == DialogResult.OK) {
                txtExportFrom.Text = ofdWimExport.FileName;
            }
        }

        /// <summary>
        /// Execute la commande DISM pour exporter les images selectionnees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e) {
            string command = "/Export-Image /SourceImageFile:", source = "", index = "", destination = "";

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

            DISM(command);
        }


        /// <summary>
        /// remet a zero la textbox d'ouput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetOutput_Click(object sender, EventArgs e) {
            txtOutput.Text = "GraphDISM By Jules GROSPEILLER";
            compt++;
            if (compt >= 10) {
                txtOutput.Text = "Chechi n'est pas un eashter egg vas t'en !";
                compt = 0;
            }
        }


        /// <summary>
        /// Selectionne l'image à spliter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenSplit_Click(object sender, EventArgs e) {
            OpenFileDialog ofdWimToSwm = new OpenFileDialog();
            ofdWimToSwm.Filter = "Fichier WIM (*.wim)|*.wim|Tout fichiers (*.*)|*.*";
            ofdWimToSwm.Title = "Ouvrir une Wim ...";
            if (ofdWimToSwm.ShowDialog() == DialogResult.OK) {
                txtOpenSplit.Text = ofdWimToSwm.FileName;
            }
        }


        /// <summary>
        /// Selectionne l'emplacement des images splitées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSplitTo_Click(object sender, EventArgs e) {
            SaveFileDialog sfdSplitTo = new SaveFileDialog();
            sfdSplitTo.Filter = "Fichier SWM(*.swm) | *.swm";
            sfdSplitTo.Title = "Splitter vers ...";

            if (sfdSplitTo.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                txtSplitTo.Text = sfdSplitTo.FileName;
            }
        }


        /// <summary>
        /// Execute la commande DISM pour spliter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSplit_Click(object sender, EventArgs e) {
            string command = "/Split-Image /ImageFile:", source = "", size = "", destination = "";

            destination = txtSplitTo.Text;
            source = txtOpenSplit.Text;
            size = txtSizeSplit.Text;
            command = (command + "\"" + source + "\"" + " /SWMFile:\"" + destination + "\"" + " /FileSize:\"" + size + "\"");


            if (chkVerifySplit.Checked)
                command = command + " /CheckIntegrity";

            DISM(command);


        }


        /// <summary>
        /// Selectionne l'image source pour Monter 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenWimMount_Click(object sender, EventArgs e) {
            OpenFileDialog ofdWimMount = new OpenFileDialog();
            ofdWimMount.Filter = "Fichier WIM (*.wim)|*.wim|Fichier SWM (*.swm)|*.swm|Tout fichiers (*.*)|*.*";
            if (ofdWimMount.ShowDialog() == DialogResult.OK) {
                txtMountFrom.Text = ofdWimMount.FileName;
            }
        }


        /// <summary>
        /// Selectionne le dossier de destionation pour spliter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMountTo_Click(object sender, EventArgs e) {
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
        private void button1_Click(object sender, EventArgs e) {
            string command = "/Mount-Image /ImageFile:", source = "", index = "", destination = "";

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

            DISM(command);

        }


        /// <summary>
        /// Execute le commande DISM pour demonter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnmout_Click(object sender, EventArgs e) {
            string command = "/Unmount-Image /MountDir:", mountDir = "";
            mountDir = txtMountTo.Text;
            command = (command + "\"" + mountDir + "\"");

            if (chkCommitUnmount.Checked)
                command += " /Commit";

            else {
                command += " /Discard";
            }

            if (chkCheckIntegrityUnmount.Checked)
                command += " /CheckIntegrity";
            if (chkAppendUnmount.Checked)
                command += " /Append";

            DISM(command);
        }


        /// <summary>
        /// permet la selection des package à importer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoosePackages_Click(object sender, EventArgs e) {
            multiplePackages = "";
            OpenFileDialog ofdAddPackage = new OpenFileDialog();
            ofdAddPackage.Filter = "Fichier CAB (*.cab)|*.cab|Tout fichiers (*.*)|*.*";
            ofdAddPackage.Multiselect = true;
            if (ofdAddPackage.ShowDialog() == DialogResult.OK) {
                string[] result = ofdAddPackage.FileNames;
                foreach (string file in result) {
                    multiplePackages += " /PackagePath:\"" + file + "\"";
                }
            }
        }


        /// <summary>
        /// Execute la commande d'ajout de package
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPackage_Click(object sender, EventArgs e) {
            string command = "/Image:\"", mountDir;
            mountDir = txtFolderPathPackage.Text;
            command = (command + mountDir + "\" /Add-Package" + multiplePackages);

            DISM(command);
        }


        /// <summary>
        /// Selectionne le repertoire dans lequel l'image est montée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPackagesTo_Click(object sender, EventArgs e) {
            FolderBrowserDialog fdbMountedRep = new FolderBrowserDialog();
            fdbMountedRep.Description = "Selectionnez le repertoire l'image est montée";
            if (fdbMountedRep.ShowDialog() == DialogResult.OK)
                txtFolderPathPackage.Text = fdbMountedRep.SelectedPath;
        }


        /// <summary>
        /// Bonouton de cleanup des point de montage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCleanupMount_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Attention vous êtes sur le point de nettoyer les points de montages de vos images.\n" +
                                                  "Après cette action vos images montées ne seronts plus demontables\n" +
                                                  "Voulez-vous continuer ?", "Attention !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                string command = "/Cleanup-Mountpoints";

                DISM(command);
            }
        }


        /// <summary>
        /// Bouton de selection de l'executable de DISM souhaité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseDismPath_Click(object sender, EventArgs e) {
            OpenFileDialog ofdDISMexe = new OpenFileDialog();
            ofdDISMexe.Filter = "DISM.exe|*.exe";
            ofdDISMexe.Title = "Selectionnez l'éxécutable DISM que vous souhaitez";
            if (ofdDISMexe.ShowDialog() == DialogResult.OK) {
                txtDISMPath.Text = ofdDISMexe.FileName;
            }
        }


        /// <summary>
        /// Ouvre une nouvelle fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenNewWindow_Click(object sender, EventArgs e) {
            Form FormInfoExt = new FormInfoExt(txtOutput.Text);
            FormInfoExt.Show();
        }


        /// <summary>
        /// Ouvre le lien du projet sur github
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //renvoi vers le lien github
            Process.Start("https://github.com/PepperSniffer/GraphDISM");
        }
    }
}