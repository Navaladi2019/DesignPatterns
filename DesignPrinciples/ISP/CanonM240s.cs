using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.ISP
{
    class CanonM240s : IPrintScanContent,IFaxContent
    {
        public bool FaxContent(string Content)
        {
            Console.WriteLine(Content);
            return true;
        }

        public bool PhotoCopyContent(string Content)
        {
            Console.WriteLine(Content);
            return true;
        }

        public bool PrintContent(string Content)
        {
            Console.WriteLine(Content);
            return true;
        }

        public bool ScanContent(string Content)
        {
            Console.WriteLine(Content);
            return true;
        }
    }
}
