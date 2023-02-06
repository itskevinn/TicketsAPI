using Domain.Entity;
using Infrastructure.Core.Interface;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Persistence.FileManagement;

public interface IFileManagementService : ITransientService
{
    /// <summary>
    /// Method used for saving a file to a server
    /// </summary>
    /// <param name="file"> File to save</param>
    /// <param name="metadata"> Metadata if needed to put in the file</param>
    /// <param name="bucketName"> Name of the bucket to be used for storing the file</param>
    /// <returns>File url</returns>
    public Task<string> SaveAsync(IFormFile file, Dictionary<string, string> metadata, string bucketName = "");

    /// <summary>
    /// Method used to get multiple files url by a given key
    /// </summary>
    /// <param name="key">Key used to search</param>
    /// <returns>A list of urls of the objects</returns>
    public Task<IEnumerable<string>> GetObjectsUrlByKey(object key);

    /// <summary>
    /// Method used to get file url by a given key
    /// </summary>
    /// <param name="key">Key used to search</param>
    /// <returns>The url of the file</returns>
    public Task<string> GetObjectUrlByKey(object key);

    /// <summary>
    /// Method used to update file by a given key
    /// </summary>
    /// <param name="key">Key of the file to update</param>
    /// <param name="file">The file object to upload</param>
    public Task Update(object key, Attachment file);

    /// <summary>
    /// Method used to delete file by a given key
    /// </summary>
    /// <param name="key">Key of the file to delete</param>
    public Task Delete(object key);
}