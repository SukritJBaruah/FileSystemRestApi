
namespace FileSystemRest.Models;

public class Fsi{
    public string Name { get; }
    public string Id{ get; }
    public string MimeType { get; }
    public string DataB64 { get; }
    public long CreatedDateUnixTime { get; }
    public long UpdatedDateUnixTime { get; }
    public string ParentId { get; }
    
    public Fsi(string name,
            string id,
            string mimeType,
            string dataB64,
            long createdDateUnixTime,
            long updatedDateUnixTime,
            string parentId)
    {
        Name = name;
        Id = id;
        MimeType = mimeType;
        DataB64 = dataB64;
        CreatedDateUnixTime = createdDateUnixTime;
        UpdatedDateUnixTime = updatedDateUnixTime;
        ParentId = parentId;

    }
}