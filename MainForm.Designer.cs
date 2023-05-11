namespace PdfMerger
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.buttonMergeFiles = new System.Windows.Forms.Button();
            this.selectFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveMergedFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.filesDataGridView = new System.Windows.Forms.DataGridView();
            this.Fichier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déplacerToutEnBasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déplacerToutEnHautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déplacerVersLeBasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déplacerVersLeHautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDeleteFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filesDataGridView)).BeginInit();
            this.filesGridViewContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddFiles.Location = new System.Drawing.Point(232, 325);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(120, 41);
            this.buttonAddFiles.TabIndex = 0;
            this.buttonAddFiles.Text = "Ajouter des fichiers";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // buttonMergeFiles
            // 
            this.buttonMergeFiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMergeFiles.Enabled = false;
            this.buttonMergeFiles.Location = new System.Drawing.Point(232, 384);
            this.buttonMergeFiles.Name = "buttonMergeFiles";
            this.buttonMergeFiles.Size = new System.Drawing.Size(120, 41);
            this.buttonMergeFiles.TabIndex = 1;
            this.buttonMergeFiles.Text = "Fusionner les fichiers";
            this.buttonMergeFiles.UseVisualStyleBackColor = true;
            this.buttonMergeFiles.Click += new System.EventHandler(this.buttonMergeFiles_Click);
            // 
            // selectFilesDialog
            // 
            this.selectFilesDialog.Filter = "Fichiers|*.pdf";
            this.selectFilesDialog.Multiselect = true;
            // 
            // saveMergedFileDialog
            // 
            this.saveMergedFileDialog.FileName = ".pdf";
            // 
            // filesDataGridView
            // 
            this.filesDataGridView.AllowUserToAddRows = false;
            this.filesDataGridView.AllowUserToDeleteRows = false;
            this.filesDataGridView.AllowUserToResizeRows = false;
            this.filesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fichier});
            this.filesDataGridView.ContextMenuStrip = this.filesGridViewContextMenuStrip;
            this.filesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.filesDataGridView.Name = "filesDataGridView";
            this.filesDataGridView.ReadOnly = true;
            this.filesDataGridView.Size = new System.Drawing.Size(543, 289);
            this.filesDataGridView.TabIndex = 2;
            this.filesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filesDataGridView_CellContentClick);
            // 
            // Fichier
            // 
            this.Fichier.HeaderText = "Fichier";
            this.Fichier.Name = "Fichier";
            this.Fichier.ReadOnly = true;
            this.Fichier.Width = 500;
            // 
            // filesGridViewContextMenuStrip
            // 
            this.filesGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem,
            this.déplacerToutEnBasToolStripMenuItem,
            this.déplacerToutEnHautToolStripMenuItem,
            this.déplacerVersLeBasToolStripMenuItem,
            this.déplacerVersLeHautToolStripMenuItem});
            this.filesGridViewContextMenuStrip.Name = "filesGridViewContextMenuStrip";
            this.filesGridViewContextMenuStrip.Size = new System.Drawing.Size(189, 114);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // déplacerToutEnBasToolStripMenuItem
            // 
            this.déplacerToutEnBasToolStripMenuItem.Name = "déplacerToutEnBasToolStripMenuItem";
            this.déplacerToutEnBasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.déplacerToutEnBasToolStripMenuItem.Text = "Déplacer tout en bas";
            // 
            // déplacerToutEnHautToolStripMenuItem
            // 
            this.déplacerToutEnHautToolStripMenuItem.Name = "déplacerToutEnHautToolStripMenuItem";
            this.déplacerToutEnHautToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.déplacerToutEnHautToolStripMenuItem.Text = "Déplacer tout en haut";
            // 
            // déplacerVersLeBasToolStripMenuItem
            // 
            this.déplacerVersLeBasToolStripMenuItem.Name = "déplacerVersLeBasToolStripMenuItem";
            this.déplacerVersLeBasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.déplacerVersLeBasToolStripMenuItem.Text = "Déplacer vers le bas";
            // 
            // déplacerVersLeHautToolStripMenuItem
            // 
            this.déplacerVersLeHautToolStripMenuItem.Name = "déplacerVersLeHautToolStripMenuItem";
            this.déplacerVersLeHautToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.déplacerVersLeHautToolStripMenuItem.Text = "Déplacer vers le haut";
            // 
            // buttonDeleteFiles
            // 
            this.buttonDeleteFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteFiles.Enabled = false;
            this.buttonDeleteFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.buttonDeleteFiles.Image = global::PdfMerger.Properties.Resources.delete;
            this.buttonDeleteFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteFiles.Location = new System.Drawing.Point(404, 308);
            this.buttonDeleteFiles.Name = "buttonDeleteFiles";
            this.buttonDeleteFiles.Size = new System.Drawing.Size(152, 25);
            this.buttonDeleteFiles.TabIndex = 3;
            this.buttonDeleteFiles.Text = "Supprimer tous les fichiers";
            this.buttonDeleteFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteFiles.UseVisualStyleBackColor = true;
            this.buttonDeleteFiles.Click += new System.EventHandler(this.buttonDeleteFiles_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.buttonDeleteFiles);
            this.Controls.Add(this.filesDataGridView);
            this.Controls.Add(this.buttonMergeFiles);
            this.Controls.Add(this.buttonAddFiles);
            this.Name = "MainForm";
            this.Text = "Fusionner des PDF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filesDataGridView)).EndInit();
            this.filesGridViewContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.Button buttonMergeFiles;
        private System.Windows.Forms.OpenFileDialog selectFilesDialog;
        private System.Windows.Forms.SaveFileDialog saveMergedFileDialog;
        private System.Windows.Forms.DataGridView filesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fichier;
        private System.Windows.Forms.ContextMenuStrip filesGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déplacerToutEnBasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déplacerToutEnHautToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déplacerVersLeBasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déplacerVersLeHautToolStripMenuItem;
        private System.Windows.Forms.Button buttonDeleteFiles;
    }
}

