namespace Admin.Core.Service.Admin.Permission.Input
{
    public class PermissionUpdateDotInput : PermissionAddDotInput
    {
        /// <summary>
        /// Ȩ��Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// �汾
        /// </summary>
        public long Version { get; set; }
    }
}
