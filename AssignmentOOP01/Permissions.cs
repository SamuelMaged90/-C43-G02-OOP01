
namespace AssignmentOOP01
{
    [Flags]
    internal enum Permissions : byte
    {
        Read = 1, 
        write = 2, 
        Delete = 4, 
        Execute = 8
    }
}
