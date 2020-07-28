﻿namespace Admin.Core.Service.Admin.Permission.Input
{
    public class PermissionUpdateApiInput : PermissionAddApiInput
    {
        /// <summary>
        /// 权限Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public long Version { get; set; }
    }
}
