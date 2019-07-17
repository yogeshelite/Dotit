using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotIt.AutoPicker.Models
{
    public partial class Epicor10Context : DbContext
    {
        public Epicor10Context()
        {
        }

        public Epicor10Context(DbContextOptions<Epicor10Context> options)
            : base(options)
        {
        }

        public virtual DbSet<FileStore> FileStore { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<UserFile> UserFile { get; set; }

        // Unable to generate entity type for table 'dbo.ttEFTHead'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ttMrpProc'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ttMrpProcQueue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ttMrpQueue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ttProcessSet'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ttProcessTask'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ttProcessTaskParam'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ttQuickSearch'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ttQuickSearchCriteria'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ttQuickSearchValueList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Security_backup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CnvProgs_backup'. Please see the warning messages.

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //        optionsBuilder.UseSqlServer("Server=DotitSQL;Database=Epicor10;User ID=DotitReader;Password=mFaS2Nbk-2ZA;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<UserFile>(entity =>
            {
                entity.HasKey(e => e.DcdUserID);

                entity.ToTable("UserFile", "Erp");

                entity.HasIndex(e => e.DspPayrollMgr);

                entity.HasIndex(e => e.SysRowID)
                    .HasName("IX_UserFile_SysIndex")
                    .IsUnique();

                entity.Property(e => e.DcdUserID)
                    .HasColumnName("DcdUserID")
                    .HasMaxLength(75)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(50);

                //entity.Property(e => e.AdvBAQRights).HasColumnName("AdvBAQRights");

                //entity.Property(e => e.BPMAdvancedUser).HasColumnName("BPMAdvancedUser");

                //entity.Property(e => e.CanDesignQSearch).HasColumnName("CanDesignQSearch");

                //entity.Property(e => e.CanEditHelpLinks)
                //    .IsRequired()
                //    .HasMaxLength(8);

                //entity.Property(e => e.CanMaintainFavURLs).HasColumnName("CanMaintainFavURLs");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompList).IsRequired();

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurComp)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.CurMenuID)
                    .IsRequired()
                    .HasColumnName("CurMenuID")
                    .HasMaxLength(8);

                entity.Property(e => e.DomainName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.EMailAddress)
                    .IsRequired()
                    .HasColumnName("EMailAddress")
                    .HasMaxLength(50);

                //entity.Property(e => e.EntConType)
                //    .IsRequired()
                //    .HasMaxLength(2);

                //entity.Property(e => e.EntSearchURL)
                //    .IsRequired()
                //    .HasColumnName("EntSearchURL")
                //    .HasMaxLength(500);

                //entity.Property(e => e.FormOpenMode)
                //    .IsRequired()
                //    .HasMaxLength(2);

                //entity.Property(e => e.FormatCulture)
                //    .IsRequired()
                //    .HasMaxLength(50);

                //entity.Property(e => e.GlbCompSM).HasColumnName("GlbCompSM");

                entity.Property(e => e.GroupList).IsRequired();

                //entity.Property(e => e.JCDept)
                //    .IsRequired()
                //    .HasColumnName("JCDept")
                //    .HasMaxLength(8);

                //entity.Property(e => e.LangNameID)
                //    .IsRequired()
                //    .HasColumnName("LangNameID")
                //    .HasMaxLength(8);

                //entity.Property(e => e.LastDate).HasColumnType("date");

                //entity.Property(e => e.LastGraphType)
                //    .IsRequired()
                //    .HasMaxLength(8);

                //entity.Property(e => e.MobilePassword)
                //    .IsRequired()
                //    .HasMaxLength(90);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfficePhone)
                    .IsRequired()
                    .HasMaxLength(20);

                //entity.Property(e => e.OSUserID)
                //    .IsRequired()
                //    .HasColumnName("OSUserID")
                //    .HasMaxLength(75);

                //entity.Property(e => e.MobilePassword)
                //    .IsRequired()
                //    .HasMaxLength(90);

                //entity.Property(e => e.PayrollMgr)
                //    .IsRequired()
                //    .HasMaxLength(32);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                //entity.Property(e => e.PwdExpires).HasColumnType("date");

                //entity.Property(e => e.PwdLastChanged).HasColumnType("date");

                //entity.Property(e => e.ShopTrackerReuseLast)
                //    .IsRequired()
                //    .HasMaxLength(50);

                //entity.Property(e => e.StartMenuClient)
                //    .IsRequired()
                //    .HasMaxLength(8);

                //entity.Property(e => e.StartMenuEWA)
                //    .IsRequired()
                //    .HasColumnName("StartMenuEWA")
                //    .HasMaxLength(8);

                //entity.Property(e => e.StartMenuMobile)
                //    .IsRequired()
                //    .HasMaxLength(8);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SysRevID)
                    .IsRequired()
                    .HasColumnName("SysRevID")
                    .IsRowVersion();

                entity.Property(e => e.SysRowID).HasColumnName("SysRowID");

                //entity.Property(e => e.TEAprRetrieveApproved).HasColumnName("TEAprRetrieveApproved");

                //entity.Property(e => e.TEAprRetrieveEntered).HasColumnName("TEAprRetrieveEntered");

                //entity.Property(e => e.TEAprRetrievePartiallyApproved).HasColumnName("TEAprRetrievePartiallyApproved");

                //entity.Property(e => e.TEAprRetrieveRejected).HasColumnName("TEAprRetrieveRejected");
                
                //entity.Property(e => e.TEAprRetrieveSubmitted).HasColumnName("TEAprRetrieveSubmitted");

                //entity.Property(e => e.TERetrieveApproved).HasColumnName("TERetrieveApproved");
                
                //entity.Property(e => e.TERetrieveEntered).HasColumnName("TERetrieveEntered");

                //entity.Property(e => e.TERetrievePartiallyApproved).HasColumnName("TERetrievePartiallyApproved");

                //entity.Property(e => e.TERetrieveRejected).HasColumnName("TERetrieveRejected");

                //entity.Property(e => e.TERetrieveSubmitted).HasColumnName("TERetrieveSubmitted");

                //entity.Property(e => e.ViewStatusPanelUserID).HasColumnName("ViewStatusPanelUserID");

                //entity.Property(e => e.ViewStatusPanelWorkstationID).HasColumnName("ViewStatusPanelWorkstationID");

                entity.Property(e => e.ZIP)
                    .IsRequired()
                    .HasColumnName("ZIP")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<FileStore>(entity =>
            {
                entity.HasKey(e => e.SysRowId);

                entity.ToTable("FileStore", "Ice");

                entity.HasIndex(e => new { e.Category, e.FileType })
                    .HasName("IX_FileStore_Category");

                entity.Property(e => e.SysRowId)
                    .HasColumnName("SysRowID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ForeignSysRowId).HasColumnName("ForeignSysRowID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RelatedToSchemaName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RelatedToTable)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SecCode)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.SysRevId)
                    .IsRequired()
                    .HasColumnName("SysRevID")
                    .IsRowVersion();

                entity.Property(e => e.TenantId)
                    .IsRequired()
                    .HasColumnName("TenantID")
                    .HasMaxLength(6);
            });
            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.ImageId });

                entity.ToTable("Image", "Erp");

                entity.HasIndex(e => e.SysRowId)
                    .HasName("IX_Image_SysIndex")
                    .IsUnique();

                entity.Property(e => e.Company).HasMaxLength(8);

                entity.Property(e => e.ImageId)
                    .HasColumnName("ImageID")
                    .HasMaxLength(256);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Height).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ImageCategoryId)
                    .IsRequired()
                    .HasColumnName("ImageCategoryID")
                    .HasMaxLength(50);

                entity.Property(e => e.ImageFileName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ImageFileThumbnail).IsRequired();

                entity.Property(e => e.ImageSubCategoryId)
                    .IsRequired()
                    .HasColumnName("ImageSubCategoryID")
                    .HasMaxLength(50);

                entity.Property(e => e.ImageSysRowId).HasColumnName("ImageSysRowID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Reference1)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Reference2)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Reference3)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Reference4)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Reference5)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.SysRevId)
                    .IsRequired()
                    .HasColumnName("SysRevID")
                    .IsRowVersion();

                entity.Property(e => e.SysRowId).HasColumnName("SysRowID");

                entity.Property(e => e.ThumbnailSysRowId).HasColumnName("ThumbnailSysRowID");

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");
            });

           

            modelBuilder.Entity<Part>(entity =>
            {
                entity.HasKey(e => new { e.Company, e.PartNum });

                entity.ToTable("Part", "Erp");

                entity.HasIndex(e => e.SysRowId)
                    .HasName("IX_Part_SysIndex")
                    .IsUnique();

                entity.HasIndex(e => new { e.Company, e.ClassId })
                    .HasName("IX_Part_PartClass");

                entity.HasIndex(e => new { e.Company, e.Snmask })
                    .HasName("IX_Part_CompSNMask");

                entity.HasIndex(e => new { e.Company, e.Upccode1 })
                    .HasName("IX_Part_UPCCode1");

                entity.HasIndex(e => new { e.Company, e.Upccode2 })
                    .HasName("IX_Part_UPCCode2");

                entity.HasIndex(e => new { e.Company, e.Upccode3 })
                    .HasName("IX_Part_UPCCode3");

                entity.HasIndex(e => new { e.Company, e.InActive, e.PartNum })
                    .HasName("IX_Part_InactivePartNum");

                entity.HasIndex(e => new { e.Company, e.Method, e.LowLevelCode })
                    .HasName("IX_Part_MethodLowLevel");

                entity.HasIndex(e => new { e.Company, e.Method, e.PartNum })
                    .HasName("IX_Part_MethodPart");

                entity.HasIndex(e => new { e.Company, e.ProdCode, e.PartNum })
                    .HasName("IX_Part_ProdCode");

                entity.HasIndex(e => new { e.Company, e.SearchWord, e.PartNum })
                    .HasName("IX_Part_SearchWord");

                entity.HasIndex(e => new { e.Company, e.TypeCode, e.PartNum })
                    .HasName("IX_Part_TypePart");

                entity.HasIndex(e => new { e.Company, e.UomclassId, e.PartNum })
                    .HasName("IX_Part_UOMClass");

                entity.HasIndex(e => new { e.Company, e.Method, e.SearchWord, e.PartNum })
                    .HasName("IX_Part_MethodWord");

                entity.HasIndex(e => new { e.Company, e.TrackLots, e.TypeCode, e.PartNum })
                    .HasName("IX_Part_LotTypePart");

                entity.HasIndex(e => new { e.Company, e.TrackSerialNum, e.TypeCode, e.PartNum })
                    .HasName("IX_Part_TrackSerialNumPart");

                entity.HasIndex(e => new { e.Company, e.TrackSerialNum, e.TypeCode, e.SearchWord })
                    .HasName("IX_Part_TrackSerialNumWord");

                entity.HasIndex(e => new { e.Company, e.TypeCode, e.SearchWord, e.PartNum })
                    .HasName("IX_Part_TypeSearch");

                entity.HasIndex(e => new { e.Company, e.TrackLots, e.TypeCode, e.SearchWord, e.PartNum })
                    .HasName("IX_Part_LotTypeWord");

                entity.Property(e => e.Company).HasMaxLength(8);

                entity.Property(e => e.PartNum).HasMaxLength(50);

                entity.Property(e => e.Aesexp)
                    .IsRequired()
                    .HasColumnName("AESExp")
                    .HasMaxLength(8);

                entity.Property(e => e.AgproductMark).HasColumnName("AGProductMark");

                entity.Property(e => e.AguseGoodMark).HasColumnName("AGUseGoodMark");

                entity.Property(e => e.AnalysisCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.BasePartNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClassId)
                    .IsRequired()
                    .HasColumnName("ClassID")
                    .HasMaxLength(4);

                entity.Property(e => e.Cnspecification)
                    .IsRequired()
                    .HasColumnName("CNSpecification")
                    .HasMaxLength(30);

                entity.Property(e => e.CommentText).IsRequired();

                entity.Property(e => e.CommercialBrand)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CommercialCategory)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CommercialColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CommercialSize1)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CommercialSize2)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CommercialStyle)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CommercialSubBrand)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CommercialSubCategory)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CommodityCode)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CostMethod)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Csfcj5).HasColumnName("CSFCJ5");

                entity.Property(e => e.Csflmw).HasColumnName("CSFLMW");

                entity.Property(e => e.Dedenomination)
                    .IsRequired()
                    .HasColumnName("DEDenomination")
                    .HasMaxLength(3);

                entity.Property(e => e.DefaultDim)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.DeinternationalSecuritiesId)
                    .IsRequired()
                    .HasColumnName("DEInternationalSecuritiesID")
                    .HasMaxLength(12);

                entity.Property(e => e.DeisInvestment).HasColumnName("DEIsInvestment");

                entity.Property(e => e.DeisSecurityFinancialDerivative).HasColumnName("DEIsSecurityFinancialDerivative");

                entity.Property(e => e.DeisServices).HasColumnName("DEIsServices");

                entity.Property(e => e.DepayStatCode)
                    .IsRequired()
                    .HasColumnName("DEPayStatCode")
                    .HasMaxLength(3);

                entity.Property(e => e.Diameter).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DiameterInside).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DiameterOutside).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DiameterUm)
                    .IsRequired()
                    .HasColumnName("DiameterUM")
                    .HasMaxLength(6);

                entity.Property(e => e.DiffPrc2PrchUom).HasColumnName("DiffPrc2PrchUOM");

                entity.Property(e => e.Durometer)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Eccnnumber)
                    .IsRequired()
                    .HasColumnName("ECCNNumber")
                    .HasMaxLength(25);

                entity.Property(e => e.Edicode)
                    .IsRequired()
                    .HasColumnName("EDICode")
                    .HasMaxLength(15);

                entity.Property(e => e.EngineeringAlert)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.EstimateId)
                    .IsRequired()
                    .HasColumnName("EstimateID")
                    .HasMaxLength(256);

                entity.Property(e => e.EstimateOrPlan)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ExpLicNumber)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ExpLicType)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ExternalCrmlastSync)
                    .HasColumnName("ExternalCRMLastSync")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExternalCrmpartId)
                    .IsRequired()
                    .HasColumnName("ExternalCRMPartID")
                    .HasMaxLength(200);

                entity.Property(e => e.ExternalCrmsyncRequired).HasColumnName("ExternalCRMSyncRequired");

                entity.Property(e => e.FsassetClassCode)
                    .IsRequired()
                    .HasColumnName("FSAssetClassCode")
                    .HasMaxLength(50);

                entity.Property(e => e.FspricePerCode)
                    .IsRequired()
                    .HasColumnName("FSPricePerCode")
                    .HasMaxLength(2);

                entity.Property(e => e.FssalesUnitPrice)
                    .HasColumnName("FSSalesUnitPrice")
                    .HasColumnType("decimal(17, 5)");

                entity.Property(e => e.Gravity).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.GrossWeightUom)
                    .IsRequired()
                    .HasColumnName("GrossWeightUOM")
                    .HasMaxLength(6);

                entity.Property(e => e.HazClass)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.HazGvrnmtId)
                    .IsRequired()
                    .HasColumnName("HazGvrnmtID")
                    .HasMaxLength(8);

                entity.Property(e => e.HazPackInstr).IsRequired();

                entity.Property(e => e.HazSub)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.HazTechName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Hts)
                    .IsRequired()
                    .HasColumnName("HTS")
                    .HasMaxLength(10);

                entity.Property(e => e.ImageFileName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ImageId)
                    .IsRequired()
                    .HasColumnName("ImageID")
                    .HasMaxLength(256);

                entity.Property(e => e.InchapterId)
                    .IsRequired()
                    .HasColumnName("INChapterID")
                    .HasMaxLength(12);

                entity.Property(e => e.InternalPricePerCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.InternalUnitPrice).HasColumnType("decimal(17, 5)");

                entity.Property(e => e.IsorigCountry)
                    .IsRequired()
                    .HasColumnName("ISOrigCountry")
                    .HasMaxLength(6);

                entity.Property(e => e.Isregion)
                    .IsRequired()
                    .HasColumnName("ISRegion")
                    .HasMaxLength(3);

                entity.Property(e => e.IssuppUnitsFactor)
                    .HasColumnName("ISSuppUnitsFactor")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Ium)
                    .IsRequired()
                    .HasColumnName("IUM")
                    .HasMaxLength(6);

                entity.Property(e => e.LotAppendDate)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LotPrefix)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LotSeqId)
                    .IsRequired()
                    .HasColumnName("LotSeqID")
                    .HasMaxLength(12);

                entity.Property(e => e.Mdpv).HasColumnName("MDPV");

                entity.Property(e => e.MfgComment).IsRequired();

                entity.Property(e => e.MtlAnalysisCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.MtlBurRate).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.NaftaorigCountry)
                    .IsRequired()
                    .HasColumnName("NAFTAOrigCountry")
                    .HasMaxLength(6);

                entity.Property(e => e.Naftapref)
                    .IsRequired()
                    .HasColumnName("NAFTAPref")
                    .HasMaxLength(8);

                entity.Property(e => e.Naftaprod)
                    .IsRequired()
                    .HasColumnName("NAFTAProd")
                    .HasMaxLength(8);

                entity.Property(e => e.NetVolume).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NetVolumeUom)
                    .IsRequired()
                    .HasColumnName("NetVolumeUOM")
                    .HasMaxLength(6);

                entity.Property(e => e.NetWeight).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NetWeightUom)
                    .IsRequired()
                    .HasColumnName("NetWeightUOM")
                    .HasMaxLength(6);

                entity.Property(e => e.OnHoldDate).HasColumnType("date");

                entity.Property(e => e.OnHoldReasonCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.OwnershipStatus)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.PartDescription).IsRequired();

                entity.Property(e => e.PartHeight).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PartLength).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PartLengthWidthHeightUm)
                    .IsRequired()
                    .HasColumnName("PartLengthWidthHeightUM")
                    .HasMaxLength(6);

                entity.Property(e => e.PartSpecificPackingUom).HasColumnName("PartSpecificPackingUOM");

                entity.Property(e => e.PartWidth).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PdmobjId)
                    .IsRequired()
                    .HasColumnName("PDMObjID")
                    .HasMaxLength(8);

                entity.Property(e => e.Pesunattype)
                    .IsRequired()
                    .HasColumnName("PESUNATType")
                    .HasMaxLength(100);

                entity.Property(e => e.Pesunatuom)
                    .IsRequired()
                    .HasColumnName("PESUNATUOM")
                    .HasMaxLength(100);

                entity.Property(e => e.PhantomBom).HasColumnName("PhantomBOM");

                entity.Property(e => e.PhotoFile)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.PricePerCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.PricingFactor).HasColumnType("decimal(14, 5)");

                entity.Property(e => e.PricingUom)
                    .IsRequired()
                    .HasColumnName("PricingUOM")
                    .HasMaxLength(6);

                entity.Property(e => e.ProdCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Pum)
                    .IsRequired()
                    .HasColumnName("PUM")
                    .HasMaxLength(6);

                entity.Property(e => e.PurComment).IsRequired();

                entity.Property(e => e.PurchasingFactor).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.PurchasingFactorDirection)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.RcoverThreshold)
                    .HasColumnName("RCOverThreshold")
                    .HasColumnType("decimal(17, 3)");

                entity.Property(e => e.RcunderThreshold)
                    .HasColumnName("RCUnderThreshold")
                    .HasColumnType("decimal(17, 3)");

                entity.Property(e => e.RefCategory)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ReturnableContainer)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RevChargeMethod)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.SalesUm)
                    .IsRequired()
                    .HasColumnName("SalesUM")
                    .HasMaxLength(6);

                entity.Property(e => e.SchedBcode)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.SearchWord)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.SellingFactor).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SellingFactorDirection)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SnbaseDataType)
                    .IsRequired()
                    .HasColumnName("SNBaseDataType")
                    .HasMaxLength(10);

                entity.Property(e => e.Snformat)
                    .IsRequired()
                    .HasColumnName("SNFormat")
                    .HasMaxLength(80);

                entity.Property(e => e.SnlastUsedSeq)
                    .IsRequired()
                    .HasColumnName("SNLastUsedSeq")
                    .HasMaxLength(40);

                entity.Property(e => e.Snmask)
                    .IsRequired()
                    .HasColumnName("SNMask")
                    .HasMaxLength(20);

                entity.Property(e => e.SnmaskExample)
                    .IsRequired()
                    .HasColumnName("SNMaskExample")
                    .HasMaxLength(80);

                entity.Property(e => e.SnmaskPrefix)
                    .IsRequired()
                    .HasColumnName("SNMaskPrefix")
                    .HasMaxLength(10);

                entity.Property(e => e.SnmaskSuffix)
                    .IsRequired()
                    .HasColumnName("SNMaskSuffix")
                    .HasMaxLength(10);

                entity.Property(e => e.Snprefix)
                    .IsRequired()
                    .HasColumnName("SNPrefix")
                    .HasMaxLength(30);

                entity.Property(e => e.Specification)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SubPart)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SyncToExternalCrm).HasColumnName("SyncToExternalCRM");

                entity.Property(e => e.SysRevId)
                    .IsRequired()
                    .HasColumnName("SysRevID")
                    .IsRowVersion();

                entity.Property(e => e.SysRowId).HasColumnName("SysRowID");

                entity.Property(e => e.TaxCatId)
                    .IsRequired()
                    .HasColumnName("TaxCatID")
                    .HasMaxLength(10);

                entity.Property(e => e.Thickness).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ThicknessMax).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ThicknessUm)
                    .IsRequired()
                    .HasColumnName("ThicknessUM")
                    .HasMaxLength(6);

                entity.Property(e => e.TypeCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(17, 5)");

                entity.Property(e => e.UomclassId)
                    .IsRequired()
                    .HasColumnName("UOMClassID")
                    .HasMaxLength(12);

                entity.Property(e => e.Upccode1)
                    .IsRequired()
                    .HasColumnName("UPCCode1")
                    .HasMaxLength(20);

                entity.Property(e => e.Upccode2)
                    .IsRequired()
                    .HasColumnName("UPCCode2")
                    .HasMaxLength(20);

                entity.Property(e => e.Upccode3)
                    .IsRequired()
                    .HasColumnName("UPCCode3")
                    .HasMaxLength(20);

                entity.Property(e => e.UseHtsdesc).HasColumnName("UseHTSDesc");

                entity.Property(e => e.UserChar1)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserChar2)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserChar3)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserChar4)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserDate1).HasColumnType("datetime");

                entity.Property(e => e.UserDate2).HasColumnType("datetime");

                entity.Property(e => e.UserDate3).HasColumnType("datetime");

                entity.Property(e => e.UserDate4).HasColumnType("datetime");

                entity.Property(e => e.UserDecimal1).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UserDecimal2).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UserDecimal3).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.UserDecimal4).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.WarrantyCode)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            
           
        }
    }
}
