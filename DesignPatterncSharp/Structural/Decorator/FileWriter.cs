using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterncSharp.Structural.Decorator
{
    public interface IFileWriter
    {
        public void Write(string text);
    }

    public class FileWriter : IFileWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class CompressionWrapper : IFileWriter
    {
        private readonly IFileWriter writer;
        public CompressionWrapper(IFileWriter writer)
        {
            this.writer = writer;
        }
        public void Write(string text)
        {
            Console.WriteLine(text); text = text.Trim();// consider this as compressing
            writer.Write(text);
        }
    }

    public class EncryptionWrapper : IFileWriter
    {
        private readonly IFileWriter writer;
        public EncryptionWrapper(IFileWriter writer)
        {
            this.writer = writer;
        }
        public void Write(string text)
        {
            text = text.Trim();// consider this as encrypted
            writer.Write(text);
        }
    }

    public class FileWriterMain
    {
        static void Main(string[] args)
        {
            IFileWriter fw = new FileWriter();
            fw = new CompressionWrapper(fw);
            fw = new EncryptionWrapper(fw);

            fw.Write("hai from naval");


        }
    }
}

