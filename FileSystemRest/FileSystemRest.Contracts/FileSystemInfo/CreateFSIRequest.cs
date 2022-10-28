
namespace FileSystemRest.Contracts.FileSystemInfo
{
    public record CreateFSIRequest(
        string Name,
        string Id,
        string MimeType,
        string DataB64,
        long CreatedDateUnixTime,
        string ParentId
    );

}