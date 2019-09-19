using DotIt.AutoPickerApi.Data.DotIt;
using DotIt.AutoPickerApi.Data.Epicor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPickerApi.Data.Repository
{
    public class GenericRepository<T> where T : class
    {
        private DotitExtensionContext _DotitExtDataContext;
        private ERP102TestContext _ERPContext;
        public GenericRepository(DotitExtensionContext dotitExtDataContext, ERP102TestContext erpContext)
        {
            _DotitExtDataContext = dotitExtDataContext;
            _ERPContext = erpContext;

        }


    }
}