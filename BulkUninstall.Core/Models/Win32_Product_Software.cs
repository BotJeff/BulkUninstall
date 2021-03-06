﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace BulkUninstall.Core.Models
{
    internal class Win32_Product_Software : Software
    {
        internal ManagementObject ManagementObj { get; set; }

        internal override void Uninstall()
        {
            this.ManagementObj?.InvokeMethod("Uninstall", null);
        }
    }
}
