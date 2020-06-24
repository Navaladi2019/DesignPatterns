using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.ISP
{
    interface IPrintScanContent
    {
        bool PrintContent(string Content);
        bool ScanContent(string Content);
        bool PhotoCopyContent(string Content);


        // Moving below to seperate interface and keeping only the common thing in common interface so that low vwl print do not need to implement functionality it do not need or it do not have functionality available.
        //bool FaxContent(string content);
        //bool PrintDuplexContent(string content);
    }

    interface IFaxContent
    {
        bool FaxContent(string content);
    }


    interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }

}
