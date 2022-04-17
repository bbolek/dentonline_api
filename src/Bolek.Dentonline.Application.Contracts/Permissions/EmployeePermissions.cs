namespace Bolek.Dentonline.Permissions;

public class EmployeePermissions
{
    public const string GroupName = "Dentonline";

    public static class Employees
    {
        public const string Default = GroupName + ".Employees";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}