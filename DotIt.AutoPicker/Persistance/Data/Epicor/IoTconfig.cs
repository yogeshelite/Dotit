using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IoTconfig
    {
        public IoTconfig()
        {
            IoTconfigCompany = new HashSet<IoTconfigCompany>();
        }

        public string Company { get; set; }
        public string IoThubName { get; set; }
        public string IoThubConnectionString { get; set; }
        public string RuleProcessingMode { get; set; }
        public string EventHubConnectionString { get; set; }
        public string ConsumerGroupName { get; set; }
        public string ServiceBusConnectionString { get; set; }
        public string QueueName { get; set; }
        public string RuleStorageSharedAccessSignatureUrl { get; set; }
        public int CompanyVisibility { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<IoTconfigCompany> IoTconfigCompany { get; set; }
    }
}
