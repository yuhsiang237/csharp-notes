using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace IText7Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfFont sysFont = PdfFontFactory.CreateFont("./../../../NotoSansCJKtc-Regular.otf", iText.IO.Font.PdfEncodings.IDENTITY_H);

            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter(@"demo.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("標題 HEADER")
               .SetFont(sysFont)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);

            document.Add(header);
            document.Close();
        }
    }
}
