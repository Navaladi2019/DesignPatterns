using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.ISP
{
    class HPLaserJet : IPrintScanContent,IPrintDuplex
    {
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

        public bool PrintDuplexContent(string Content)
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
