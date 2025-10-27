using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Syncfusion.Pdf;
using System.Drawing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Tables;
using BLL;
using BE;

namespace SYNC
{
    public class Class1
    {

        private readonly BLL_OrdenProduccion _bllOrden = new BLL_OrdenProduccion();

        public MemoryStream GenerarReporte(DataTable table)
        {
            try
            {
                PdfDocument pdfDocument = new PdfDocument();   

                PdfPage page = pdfDocument.Pages.Add();

                PdfGraphics Graficos = page.Graphics;

                PdfFont titleFont = new PdfStandardFont(PdfFontFamily.Helvetica, 18, PdfFontStyle.Bold);

                Graficos.DrawString(
                "SYNCFUSION",
                titleFont,
                PdfBrushes.Red,
                new Syncfusion.Drawing.PointF(20,20) );

                MemoryStream streamer = new MemoryStream();
                pdfDocument.Save( streamer );
                return streamer;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }





        /*public MemoryStream GenerarReporteOrdenesProduccion()
        {

            List<Orden_ProduccionBE> ordenes = _bllOrden.TraerOrdenesProduccion();

            DataTable dtOrdenes = MapOrdenesToDataTable(ordenes);

            using (PdfDocument document = new PdfDocument())
            {
                PdfPage page = document.Pages.Add();
                PdfGraphics graphics = page.Graphics;


                PdfFont titleFont = new PdfStandardFont(PdfFontFamily.Helvetica, 18, PdfFontStyle.Bold);
                graphics.DrawString("Reporte General de Órdenes de Producción", titleFont, PdfBrushes.DarkBlue, new PointF(10, 10));

                PdfLightTable pdfTable = new PdfLightTable
                {
                    DataSource = dtOrdenes
                };

                pdfTable.Style.DefaultStyle.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
                pdfTable.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);

                if (dtOrdenes.Rows.Count == 0)
                {
                    PdfFont infoFont = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Regular);
                    graphics.DrawString("No hay órdenes registradas.", infoFont, PdfBrushes.Gray, new PointF(10, 50));
                }
                else
                {
                    pdfTable.Draw(page, new PointF(10, 50));
                }

                MemoryStream stream = new MemoryStream();
                document.Save(stream);
                stream.Position = 0;
                return stream;
            }
        }

        private DataTable MapOrdenesToDataTable(List<Orden_ProduccionBE> ordenes)
        {
            DataTable dt = new DataTable("OrdenesProduccion");
            dt.Columns.Add("ID_ORDEN", typeof(int));
            dt.Columns.Add("ID_CLIENTE", typeof(int));
            dt.Columns.Add("ID_EMPLEADO", typeof(int));
            dt.Columns.Add("ID_MATERIA", typeof(int));
            dt.Columns.Add("CODIGO_PROD", typeof(string));
            dt.Columns.Add("FECHA_ORDEN", typeof(DateTime));
            dt.Columns.Add("CANTIDAD_USADA", typeof(int));
            dt.Columns.Add("CANTIDAD_PROD", typeof(int));
            dt.Columns.Add("COSTO_TOTAL_ORDEN", typeof(decimal));
            dt.Columns.Add("ESTADO", typeof(string));

            if (ordenes != null)
            {
                foreach (var o in ordenes)
                {
                    dt.Rows.Add(
                        o.Id_orden,
                        o.Id_cliente,
                        o.Id_empleado,
                        o.Id_materia,
                        o.CodProducto,
                        o.FechaOrden,
                        o.CantUsada,
                        o.CantProd,
                        o.Costo_Total,
                        o.Estado
                    );
                }
            }

            return dt;
        }*/
    }
}