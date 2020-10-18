﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Xiu2.TileTool.Core
{
    /// <summary>
    /// 包含应用程序的一般信息。
    /// </summary>
    internal class AppInfo
    {
        /// <summary>
        /// 获取当前应用程序的一般信息。
        /// </summary>
        public static AppInfo Main { get; } = new AppInfo(Assembly.GetEntryAssembly()!);

        public AppInfo(Assembly assembly)
        {
            AppName = assembly.GetCustomAttribute<AssemblyProductAttribute>()?.Product
                ?? assembly.GetCustomAttribute<AssemblyTitleAttribute>()!.Title;
            Version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;
            Author = assembly.GetCustomAttribute<AssemblyCompanyAttribute>()!.Company;
        }

        /// <summary>
        /// 获取应用名称。
        /// </summary>
        public string AppName { get; }

        /// <summary>
        /// 获取版本号（可能带预览标签）。
        /// </summary>
        public string Version { get; }

        /// <summary>
        /// 获取作者名。
        /// </summary>
        public string Author { get; }
    }
}
