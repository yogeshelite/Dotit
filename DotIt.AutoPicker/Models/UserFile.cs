﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Models
{
    public partial class UserFile
    {
        public string DcdUserId { get; set; }
        public string PassWord { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string OfficePhone { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? LastDate { get; set; }
        public int LastTime { get; set; }
        public bool UserDisabled { get; set; }
        public bool SecurityMgr { get; set; }
        public bool CanChangeSaveSettings { get; set; }
        public bool SaveSettings { get; set; }
        public string CurComp { get; set; }
        public DateTime? PwdLastChanged { get; set; }
        public int PwdExpiresDays { get; set; }
        public DateTime? PwdExpires { get; set; }
        public int PwdGrace { get; set; }
        public string GroupList { get; set; }
        public string CompList { get; set; }
        public bool DspPayrollMgr { get; set; }
        public string PayrollMgr { get; set; }
        public int ShpTrackerIntMinute { get; set; }
        public bool ViewFavoriteBar { get; set; }
        public bool ViewMenuTree { get; set; }
        public bool ViewStatusBar { get; set; }
        public int WinX { get; set; }
        public int WinY { get; set; }
        public int FavBarWidth { get; set; }
        public int MenuTreeWidth { get; set; }
        public int CurFolderSeq { get; set; }
        public string CurMenuId { get; set; }
        public int WinWidth { get; set; }
        public int WinHeight { get; set; }
        public bool DispTips { get; set; }
        public bool CanChangePassword { get; set; }
        public string LangNameId { get; set; }
        public string LastGraphType { get; set; }
        public bool AllowReq { get; set; }
        public string Jcdept { get; set; }
        public bool UseInternalWebBrowser { get; set; }
        public bool AllowMultipleSessions { get; set; }
        public bool WebUser { get; set; }
        public int ListViewMode { get; set; }
        public bool CanMaintainFavQueries { get; set; }
        public bool CanMaintainFavUrls { get; set; }
        public bool CanMaintainFavPrograms { get; set; }
        public bool CanCustomize { get; set; }
        public int ViewTreeOnly { get; set; }
        public int Timeout { get; set; }
        public bool CanPersonalize { get; set; }
        public bool CanTranslate { get; set; }
        public bool CanSuspend { get; set; }
        public bool CanEditCompAnnotations { get; set; }
        public bool CanEditUserAnnotations { get; set; }
        public string CanEditHelpLinks { get; set; }
        public bool AutoStartMonitor { get; set; }
        public int MonitorPollingInterval { get; set; }
        public string FormOpenMode { get; set; }
        public string EntConType { get; set; }
        public bool DashboardDeveloper { get; set; }
        public bool CanDesignQsearch { get; set; }
        public bool RequireSso { get; set; }
        public bool ViewStatusPanelUserId { get; set; }
        public bool ViewStatusPanelLanguage { get; set; }
        public bool ViewStatusPanelCompany { get; set; }
        public bool ViewStatusPanelPlant { get; set; }
        public bool ViewStatusPanelServer { get; set; }
        public bool ViewStatusPanelWorkstationId { get; set; }
        public int ServerNum { get; set; }
        public string DomainName { get; set; }
        public bool BpmadvancedUser { get; set; }
        public int MaxGroupsFavorites { get; set; }
        public int MaxGroupsSystemMenu { get; set; }
        public string OsuserId { get; set; }
        public bool CanTheme { get; set; }
        public string FormatCulture { get; set; }
        public bool CanOverrideAllocations { get; set; }
        public bool GlbCompSm { get; set; }
        public bool CanUseEntSearch { get; set; }
        public bool CanAccEpiEverywhere { get; set; }
        public bool CanAcessMobile { get; set; }
        public string StartMenuClient { get; set; }
        public string StartMenuEwa { get; set; }
        public string StartMenuMobile { get; set; }
        public bool TeretrieveApproved { get; set; }
        public bool TeretrieveEntered { get; set; }
        public bool TeretrieveRejected { get; set; }
        public bool TeretrieveSubmitted { get; set; }
        public bool TeretrievePartiallyApproved { get; set; }
        public bool TeaprRetrieveApproved { get; set; }
        public bool TeaprRetrieveEntered { get; set; }
        public bool TeaprRetrieveRejected { get; set; }
        public bool TeaprRetrieveSubmitted { get; set; }
        public bool TeaprRetrievePartiallyApproved { get; set; }
        public bool AdvBaqrights { get; set; }
        public bool SecurityAccessOnly { get; set; }
        public bool SolutionMgrCreate { get; set; }
        public bool SolutionMgrInstall { get; set; }
        public string EntSearchUrl { get; set; }
        public bool CanMaintQuickSearch { get; set; }
        public bool UseDefaultEntSearch { get; set; }
        public bool UserAccessOnly { get; set; }
        public string MobilePassword { get; set; }
        public string ShopTrackerReuseLast { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool AdvancedConfiguratorUser { get; set; }
    }
}
