using DotIt.AutoPickerApi.Data.DotIt;
using DotIt.AutoPickerApi.Data.Epicor;
using DotIt.AutoPickerApi.Data.Repository;
using DotIt.AutoPickerApi.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPickerApi.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        void SaveDotitChanges();
        
    }

    public class UnitOfWork<T> : IUnitOfWork
        where T :class
    {
        DotitExtensionContext _DotitExtensionContext;
         ERP102TestContext _ERPContext;

      
        public UnitOfWork(DotitExtensionContext dotitExtensionContext, ERP102TestContext erpContext)
        {
            _DotitExtensionContext = dotitExtensionContext;
             _ERPContext=erpContext;
        }

      
        public void SaveDotitChanges()
        {
            _DotitExtensionContext.SaveChangesAsync();
        }
    }
}
