
namespace FileSystemRest.Contracts.FileSystemInfo
{
    public record UpdateFSIRequest(
        string Name,
        string DataB64,
        long UpdatedDateUnixTime,
        string ParentId
    );
}