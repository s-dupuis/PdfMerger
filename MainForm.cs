using IronPdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PdfMerger
{
    public partial class MainForm : Form
    {
        private RowManager rowManager;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

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

        private void filesDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var row = this.filesDataGridView.Rows[e.RowIndex];
                this.rowManager.unselectRows();
                row.Selected = true;

                Rectangle r = row.DataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point p = new Point(e.Location.X + r.X, e.Location.Y + r.Y);

                this.filesGridViewContextMenuStrip.Show(this.filesDataGridView, p);
            }
        }

        private void buttonDeleteFiles_Click(object sender, EventArgs e)
        {
            this.rowManager.clearRows();
        }

        private void filesDataGridView_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void filesDataGridView_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = this.filesDataGridView.PointToClient(new Point(e.X, e.Y));

            rowIndexOfItemUnderMouseToDrop = this.filesDataGridView.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            if (e.Effect == DragDropEffects.Move && rowIndexOfItemUnderMouseToDrop >= 0)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                this.filesDataGridView.Rows.RemoveAt(rowIndexFromMouseDown);
                this.filesDataGridView.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
            }
        }

        private void filesDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = this.filesDataGridView.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {          
                Size dragSize = SystemInformation.DragSize;

                dragBoxFromMouseDown = new Rectangle(
                          new Point(
                            e.X - (dragSize.Width / 2),
                            e.Y - (dragSize.Height / 2)),
                      dragSize);
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void filesDataGridView_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {                    
                    DragDropEffects dropEffect = this.filesDataGridView.DoDragDrop(
                          this.filesDataGridView.Rows[rowIndexFromMouseDown],
                          DragDropEffects.Move);
                }
            }
        }

        private void filesDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void filesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                this.rowManager.deleteRow(e.RowIndex);
            }
        }
    }
}
