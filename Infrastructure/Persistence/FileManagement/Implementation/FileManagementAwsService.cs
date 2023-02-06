using System.Net;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Domain.Entity;
using Infrastructure.Core.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Persistence.FileManagement.Implementation;

public class FileManagementAwsService : IFileManagementService
{
    private readonly AppSettings _config;
    private readonly ILogger<FileManagementAwsService> _logger;
    private readonly IAmazonS3 _amazonS3Client;

    public FileManagementAwsService(IOptions<AppSettings> config,
        ILogger<FileManagementAwsService> logger)
    {
        _config = config.Value;
        _logger = logger;
        _amazonS3Client = new AmazonS3Client(RegionEndpoint.GetBySystemName(_config.Aws.Region));
    }

    public async Task<string> SaveAsync(IFormFile file, Dictionary<string, string>? metadata, string bucketName = "")
    {
        try
        {
            // Rename file to random string to prevent injection and similar security threats
            var trustedFileName = WebUtility.HtmlEncode(file.FileName);
            var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
            var randomFileName = Path.GetRandomFileName();
            var trustedStorageName = $"{_config.AttachmentsFolderName}/{randomFileName}{ext}";

            var objectRequest = new PutObjectRequest
            {
                InputStream = file.OpenReadStream(),
                Key = trustedStorageName,
                BucketName = bucketName,
            };

            // Add meta tags which can include the original file name and other descriptions

            if (metadata != null && metadata.Any())
            {
                foreach (var tag in metadata)
                {
                    objectRequest.Metadata.Add(tag.Key, tag.Value);
                }
            }

            objectRequest.Metadata.Add("originalFileName", trustedFileName);


            await _amazonS3Client.PutObjectAsync(objectRequest);


            var fileUrl = GenerateAwsFileUrl(bucketName, trustedStorageName, false);

            _logger.LogInformation("File uploaded to Amazon S3 bucket successfully");
            return fileUrl;
        }
        catch (Exception ex) when (ex is NullReferenceException)
        {
            _logger.LogError("File data not contained in form {ExceptionMessage}", ex.Message);
            throw;
        }
        catch (Exception ex) when (ex is AmazonS3Exception)
        {
            _logger.LogError("Something went wrong during file upload {ExceptionMessage}", ex.Message);
            throw;
        }
    }

    private string GenerateAwsFileUrl(string bucketName, string key, bool useRegion = true)
    {
        var publicUrl = useRegion
            ? $"https://{bucketName}.{_config.Aws.Region}.{_config.Aws.ServiceUrl}/{key}"
            : $"https://{bucketName}.{_config.Aws.ServiceUrl}/{key}";

        return publicUrl;
    }


    public Task<IEnumerable<string>> GetObjectsUrlByKey(object key)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetObjectUrlByKey(object key)
    {
        throw new NotImplementedException();
    }

    public Task Update(object key, Attachment file)
    {
        throw new NotImplementedException();
    }

    public Task Delete(object key)
    {
        throw new NotImplementedException();
    }
}