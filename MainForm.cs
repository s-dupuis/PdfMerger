using IronPdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PdfMerger
{
    public partial class MainForm : Form
    {
        private RowManager rowManager;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var buttonsToEnable = new List<Button>();
            buttonsToEnable.Add(this.buttonMergeFiles);
            buttonsToEnable.Add(this.buttonDeleteFiles);

            this.rowManager = new RowManager(
                this.filesDataGridView,
                buttonsToEnable
            );
        }

        private void buttonAddFiles_Click(object sender, EventArgs e)
        {
            var result = this.selectFilesDialog.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                this.rowManager.createRow(this.selectFilesDialog);
            }
        }

        private void buttonMergeFiles_Click(object sender, EventArgs e)
        {
            var files = this.rowManager.getFiles();
            var Documents = new List<PdfDocument>();

            foreach(string file in files)
            {
                Trace.WriteLine("Loading file " + file);
                Documents.Add(new PdfDocument(file));
            }

            var mergedDocument = PdfDocument.Merge(Documents);
            var result = this.saveMergedFileDialog.ShowDialog();

            if (result.Equals(DialogResult.OK)) {
                Trace.WriteLine("Saving file " + this.saveMergedFileDialog.FileName);
                mergedDocument.SaveAs(this.saveMergedFileDialog.FileName);
            }

            this.saveMergedFileDialog.FileName = "";
        }

        private void filesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeleteFiles_Click(object sender, EventArgs e)
        {
            this.rowManager.clearRows();
        }
    }
}
