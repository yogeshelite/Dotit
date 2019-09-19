
using DotIt.AutoPickerApi.Data.Epicor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPickerApi.Data.Repository
{
  public interface IEpicorRepository
    {
        Task<string> GetItemImageByPartNumberAsync(string PartNumber);

    }


    public class EpicorRepository: IEpicorRepository
    {
        ERP102TestContext _erp102TestContext;
        public EpicorRepository()
        {       
        }

      


        public async Task<string> GetItemImageByPartNumberAsync(string PartNumber)
        {
            try
            {
                using (_erp102TestContext = new ERP102TestContext())
                {
                    var image = _erp102TestContext.Part.Join(_erp102TestContext.Image, p => new { p.Company, p.ImageId }, i => new { i.Company, i.ImageId }, (p, i) => new { p, i }).Join(_erp102TestContext.FileStore, pi => new { pi.p.Company, pi.i.ImageSysRowId }, fl => new { Company = fl.Company, ImageSysRowId = fl.SysRowId }, (pi, fl) => new { PartNumber = pi.p.PartNum, fl.Content }).FirstOrDefault(f => f.PartNumber == PartNumber);
                    return (image != null && image.Content.LongCount() > 0) ? string.Format("data:image/jpeg;base64,{0}", Convert.ToBase64String(image.Content)) : "img/bg-showcase-2.jpg";
                }
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
