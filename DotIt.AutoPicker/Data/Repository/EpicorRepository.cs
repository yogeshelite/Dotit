using DotIt.AutoPicker.Data.Epicor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Data.Repository
{
    public class EpicorRepository
    {
        Erp102TestContext _erp102TestContext;
        public EpicorRepository(Erp102TestContext erp102TestContext)
        {
            _erp102TestContext = erp102TestContext;
        }


        public string GetItemImageByPartNumber(string PartNumber)
        {

            var image = _erp102TestContext.Part.Join(_erp102TestContext.Image, p => new { p.Company, p.ImageId }, i => new { i.Company, i.ImageId }, (p, i) => new { p, i }).Join(_epicor10Context.FileStore, pi => new { pi.p.Company, pi.i.ImageSysRowId }, fl => new { Company = fl.Company, ImageSysRowId = fl.SysRowId }, (pi, fl) => new { PartNumber = pi.p.PartNum, Content = fl.Content }).FirstOrDefault(f => f.PartNumber == PartNumber);
            return (image != null && image.Content.LongCount() > 0) ? string.Format("data:image/jpeg;base64,{0}", Convert.ToBase64String(image.Content)) : "img/bg-showcase-2.jpg";


        }
    }
}
