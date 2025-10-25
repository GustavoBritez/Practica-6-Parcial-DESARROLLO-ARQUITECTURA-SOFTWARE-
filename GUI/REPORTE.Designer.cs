namespace GUI
{
    partial class REPORTE
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
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings2 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings2 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REPORTE));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings2 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            groupView1 = new Syncfusion.Windows.Forms.Tools.GroupView();
            pdfDocumentView1 = new Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView();
            SuspendLayout();
            // 
            // groupView1
            // 
            groupView1.Location = new Point(48, 289);
            groupView1.Name = "groupView1";
            groupView1.Size = new Size(199, 112);
            groupView1.TabIndex = 0;
            groupView1.Text = "groupView1";
            // 
            // pdfDocumentView1
            // 
            pdfDocumentView1.BackColor = Color.FromArgb(237, 237, 237);
            pdfDocumentView1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            pdfDocumentView1.EnableContextMenu = true;
            pdfDocumentView1.HorizontalScrollOffset = 0;
            pdfDocumentView1.IsTextSearchEnabled = true;
            pdfDocumentView1.IsTextSelectionEnabled = true;
            pdfDocumentView1.Location = new Point(113, 92);
            messageBoxSettings2.EnableNotification = true;
            pdfDocumentView1.MessageBoxSettings = messageBoxSettings2;
            pdfDocumentView1.MinimumZoomPercentage = 50;
            pdfDocumentView1.Name = "pdfDocumentView1";
            pdfDocumentView1.PageBorderThickness = 1;
            pdfViewerPrinterSettings2.Copies = 1;
            pdfViewerPrinterSettings2.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings2.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings2.PrintLocation = (PointF)resources.GetObject("pdfViewerPrinterSettings2.PrintLocation");
            pdfViewerPrinterSettings2.ShowPrintStatusDialog = true;
            pdfDocumentView1.PrinterSettings = pdfViewerPrinterSettings2;
            pdfDocumentView1.ReferencePath = null;
            pdfDocumentView1.ScrollDisplacementValue = 0;
            pdfDocumentView1.ShowHorizontalScrollBar = true;
            pdfDocumentView1.ShowVerticalScrollBar = true;
            pdfDocumentView1.Size = new Size(150, 150);
            pdfDocumentView1.SpaceBetweenPages = 8;
            pdfDocumentView1.TabIndex = 1;
            textSearchSettings2.CurrentInstanceColor = Color.FromArgb(127, 255, 171, 64);
            textSearchSettings2.HighlightAllInstance = true;
            textSearchSettings2.OtherInstanceColor = Color.FromArgb(127, 254, 255, 0);
            pdfDocumentView1.TextSearchSettings = textSearchSettings2;
            pdfDocumentView1.ThemeName = "Office2016Black";
            pdfDocumentView1.VerticalScrollOffset = 0;
            pdfDocumentView1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Black;
            pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // REPORTE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pdfDocumentView1);
            Controls.Add(groupView1);
            Name = "REPORTE";
            Text = "REPORTE";
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GroupView groupView1;
        private Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView pdfDocumentView1;
    }
}