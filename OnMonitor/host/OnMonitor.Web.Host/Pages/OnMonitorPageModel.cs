﻿using OnMonitor.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace OnMonitor.Pages
{
    public abstract class OnMonitorPageModel : AbpPageModel
    {
        protected OnMonitorPageModel()
        {
            LocalizationResourceType = typeof(OnMonitorResource);
        }
    }
}