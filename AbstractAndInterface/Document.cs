using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    public abstract class Document
    {
        public abstract void Save();
        public abstract void Open();

        public void Close()
        {
            Console.WriteLine("Document Close");
        }

        public string Title { get; set; }
        public void Copy()
        {
            Console.WriteLine("Document Edit");
        }

    }

    public class WordDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Word Open");
        }

        public void Print()
        {
            Console.WriteLine("Word Print");
        }

        public override void Save()
        {
            Console.WriteLine("Word Save");
        }

    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Excel Open");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            Console.WriteLine("Excel Save");
        }

    }
    public class PDFDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("PDF Open");
        }
        public override void Save()
        {
            Console.WriteLine("PDF Save");
        }

    }

    public class DocumentPrinter
    {
        public void PrintDocument(IPrintable document)
        {
            document.Print();
        }
    }
}
