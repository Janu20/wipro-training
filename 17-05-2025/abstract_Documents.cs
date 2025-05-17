abstract class Document
{
    public abstract void PrintContent();
    public void ShowDocumentType(String Type)
    {
        Console.WriteLine("Document Type : " + Type);
    }
}
 internal class WordDocument : Document
 {
     public override void PrintContent()
     {
         Console.WriteLine("Printing Word document");
     }
 }
 internal class PDFDocument : Document
 {
     public override void PrintContent()
     {
         Console.WriteLine("Printing PDF document");
     }
 }
     class Program
    {

        public static void Main()
        {
            Document D ;
            D = new WordDocument();
            D.ShowDocumentType(" WORD ");
            D.PrintContent();

            D = new PDFDocument();
            D.ShowDocumentType(" PDF ");
            D.PrintContent();



        }
    }
