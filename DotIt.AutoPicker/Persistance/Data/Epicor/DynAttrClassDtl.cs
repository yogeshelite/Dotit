using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DynAttrClassDtl
    {
        public DynAttrClassDtl()
        {
            DynAttrClassDtlListVal = new HashSet<DynAttrClassDtlListVal>();
            DynAttrValue = new HashSet<DynAttrValue>();
        }

        public string Company { get; set; }
        public string AttrClassId { get; set; }
        public string AttributeId { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToTableName { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public string FieldDataType { get; set; }
        public string FieldFormat { get; set; }
        public string FieldLabel { get; set; }
        public decimal IncrPrec { get; set; }
        public string InitialCharacter { get; set; }
        public DateTime? InitialDate { get; set; }
        public decimal InitialDecimal { get; set; }
        public int InitialInteger { get; set; }
        public bool InitialLogical { get; set; }
        public DateTime? MaxDate { get; set; }
        public decimal MaxDecimal { get; set; }
        public int MaxInteger { get; set; }
        public DateTime? MinDate { get; set; }
        public decimal MinDecimal { get; set; }
        public int MinInteger { get; set; }
        public bool WebAttribute { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual DynAttrClass DynAttrClass { get; set; }
        public virtual ICollection<DynAttrClassDtlListVal> DynAttrClassDtlListVal { get; set; }
        public virtual ICollection<DynAttrValue> DynAttrValue { get; set; }
    }
}
