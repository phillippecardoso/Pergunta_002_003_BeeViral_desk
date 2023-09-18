using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pergunta_002_003_BeeViral_desk
{
  class ClsImprimeDados
  {
    public float colunaSize = 0;

    public void GeraDocumento(DataGridView dt)
    {
      System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
      string caminhoArquivo = @"C:\testeBeeViral\";
      PdfDocument pdf = new PdfDocument();
      pdf.Info.Author = "Teste BeeViral";
      pdf.Info.CreationDate = DateTime.Now;
      PdfPage pdfPage = pdf.AddPage();
      pdfPage.Orientation = PdfSharp.PageOrientation.Portrait;
      pdfPage.Size = PdfSharp.PageSize.A4;
      XGraphics graph = XGraphics.FromPdfPage(pdfPage);
      XPen pen = new XPen(XColor.FromArgb(100, 100, 160, 200), 0.1);

      colunaSize = ((float.Parse(pdfPage.Width.Value.ToString()) - 40) / 6);

      float XMarginSup = 30;

      if (!System.IO.Directory.Exists(caminhoArquivo)) {
        System.IO.Directory.CreateDirectory(caminhoArquivo);
      }

      caminhoArquivo = caminhoArquivo + "teste.pdf";

      foreach (DataGridViewRow r in dt.Rows)
      {
        if (int.Parse(r.Cells[2].Value.ToString()) >= 30) {
          DesenhaTituloValor(pdf, graph, pen, XMarginSup, ((colunaSize * 0) + 20), 6, "Nome");
          DesenhaValorString(pdf, graph, pen, XMarginSup + 20, ((colunaSize * 0) + 20), 6, r.Cells[0].Value.ToString());
          XMarginSup += 40;
        }
      }

      pdf.Save(caminhoArquivo);
      var p = new Process();
      p.StartInfo = new ProcessStartInfo(caminhoArquivo)
      {
        UseShellExecute = true
      };
      p.Start();
    }
    public XGraphics DesenhaTituloValor(PdfDocument pdf, XGraphics graph, XPen pen, float XMarginSup, float XMarginEsq, float Colunas, string valor)
    {

      XRect painelDados = new XRect(XMarginEsq + 2, XMarginSup, (colunaSize * Colunas) - 4, 13);
      graph.DrawRectangle(pen, new XSolidBrush(XColor.FromArgb(150, 255, 255, 255)), painelDados);
      graph.DrawString(valor,
                  new XFont("Calibri", 10, XFontStyle.Bold),
                  new XSolidBrush(XColor.FromArgb(100, 160, 200)),
                  painelDados,
                  XStringFormats.CenterLeft);


      return graph;

    }
    public XGraphics DesenhaValorString(PdfDocument pdf, XGraphics graph, XPen pen, float XMarginSup, float XMarginEsq, float Colunas, string valor)
    {

      XRect painelDados = new XRect(XMarginEsq + 2, XMarginSup, (colunaSize * Colunas) - 4, 13);
      graph.DrawRectangle(pen, new XSolidBrush(XColor.FromArgb(150, 255, 255, 255)), painelDados);
      graph.DrawString(valor,
            new XFont("Calibri", 8, XFontStyle.Regular),
            new XSolidBrush(XColor.FromArgb(100, 160, 200)),
            painelDados,
            XStringFormats.CenterLeft);


      return graph;

    }

  }
}
