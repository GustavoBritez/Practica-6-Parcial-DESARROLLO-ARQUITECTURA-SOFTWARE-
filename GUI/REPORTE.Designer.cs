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
            MONTOTO = new Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView();
            SuspendLayout();
            // 
            // MONTOTO
            // 
            MONTOTO.AutoScroll = true;
            MONTOTO.BackColor = Color.FromArgb(237, 237, 237);
            MONTOTO.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            MONTOTO.Dock = DockStyle.Fill;
            MONTOTO.EnableContextMenu = true;
            MONTOTO.HorizontalScrollOffset = 0;
            MONTOTO.IsTextSearchEnabled = true;
            MONTOTO.IsTextSelectionEnabled = true;
            MONTOTO.Location = new Point(0, 0);
            messageBoxSettings2.EnableNotification = true;
            MONTOTO.MessageBoxSettings = messageBoxSettings2;
            MONTOTO.MinimumZoomPercentage = 50;
            MONTOTO.Name = "MONTOTO";
            MONTOTO.PageBorderThickness = 1;
            pdfViewerPrinterSettings2.Copies = 1;
            pdfViewerPrinterSettings2.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings2.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings2.PrintLocation = (PointF)resources.GetObject("pdfViewerPrinterSettings2.PrintLocation");
            pdfViewerPrinterSettings2.ShowPrintStatusDialog = true;
            MONTOTO.PrinterSettings = pdfViewerPrinterSettings2;
            MONTOTO.ReferencePath = null;
            MONTOTO.ScrollDisplacementValue = 0;
            MONTOTO.ShowHorizontalScrollBar = true;
            MONTOTO.ShowVerticalScrollBar = true;
            MONTOTO.Size = new Size(800, 450);
            MONTOTO.SpaceBetweenPages = 8;
            MONTOTO.TabIndex = 0;
            textSearchSettings2.CurrentInstanceColor = Color.FromArgb(127, 255, 171, 64);
            textSearchSettings2.HighlightAllInstance = true;
            textSearchSettings2.OtherInstanceColor = Color.FromArgb(127, 254, 255, 0);
            MONTOTO.TextSearchSettings = textSearchSettings2;
            MONTOTO.ThemeName = "Office2016DarkGray";
            MONTOTO.VerticalScrollOffset = 0;
            MONTOTO.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016DarkGray;
            MONTOTO.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // REPORTE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MONTOTO);
            Name = "REPORTE";
            Text = "REPORTE";
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView MONTOTO;
    }
}