
namespace FileSystemRest.Contracts.FileSystemInfo
{
    public record FSIResponse(
        string Name,
        string Id,
        string MimeType,
        string DataB64,
        long CreatedDateUnixTime,
        long UpdatedDateUnixTime,
        string ParentId
    );
}