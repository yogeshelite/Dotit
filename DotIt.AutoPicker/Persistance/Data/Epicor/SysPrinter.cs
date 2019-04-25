using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysPrinter
    {
        public string Company { get; set; }
        public string PrinterId { get; set; }
        public string Description { get; set; }
        public string NetworkPath { get; set; }
        public bool PrintCollate { get; set; }
        public bool PageColor { get; set; }
        public bool PageLandscape { get; set; }
        public int PageLeftMargin { get; set; }
        public int PageRightMargin { get; set; }
        public int PageTopMargin { get; set; }
        public int PageBottomMargin { get; set; }
        public string PagePaperSizeKind { get; set; }
        public int PagePaperHeight { get; set; }
        public int PagePaperWidth { get; set; }
        public string PagePaperSourceKind { get; set; }
        public int PagePrinterResolutionX { get; set; }
        public int PagePrinterResolutionY { get; set; }
        public bool Srsprinter { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
