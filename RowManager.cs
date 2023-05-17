using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfMerger
{
    internal class RowManager
    {
        private DataGridView gridView;
        private List<Button> buttonsToEnable;

        public RowManager(DataGridView gridView, List<Button> buttonsToEnable)
        {
            this.gridView = gridView;
            this.buttonsToEnable = buttonsToEnable;
        }

        public void createRow(FileDialog fileDialog)
        {
            foreach (String fileName in fileDialog.FileNames)
            {
                var rowIndex = this.gridView.Rows.Add();

                this.gridView.Rows[rowIndex].Cells[0].Value = fileName;

                this.handleButtonsEnabling();
            }

            fileDialog.FileName = "";
        }

        public void deleteRow(int rowIndex)
        {
            this.gridView.Rows.RemoveAt(rowIndex);

            this.handleButtonsEnabling();
        }

        private void handleButtonsEnabling()
        {
            foreach (Button buttonToEnable in buttonsToEnable)
            {
                buttonToEnable.Enabled = gridView.Rows.Count > 0;
            }
        }

        public List<string> getFiles()
        {
            List<string> files = new List<string>();
  
            foreach (DataGridViewRow row in gridView.Rows)
            {
                files.Add(row.Cells[0].Value.ToString());
            }

            return files;
        }

        public void clearRows ()
        {
            this.gridView.Rows.Clear();
            this.handleButtonsEnabling();
        }

        public void unselectRows ()
        {
            this.gridView.ClearSelection();
        }
    }
}
