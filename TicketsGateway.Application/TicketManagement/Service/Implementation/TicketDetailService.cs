using System.Net;
using System.Net.Mail;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using TicketsGateway.Application.TicketManagement.Http.Dto;
using TicketsGateway.Application.TicketManagement.Http.Request;
using TicketsGateway.Application.TicketManagement.RestEaseClients;
using TicketsGateway.Application.Base;
using TicketsGateway.Application.Core.Helpers;

namespace TicketsGateway.Application.TicketManagement.Service.Implementation;

public class TicketDetailService : BaseService, ITicketDetailService
{
    private readonly ILogger<TicketDetailService> _logger;
    private readonly ITicketDetailRestEaseClient _ticketDetailRestEaseClient;
    private readonly IMapper _mapper;
    private readonly ITicketRestEaseClient _ticketRestEaseClient;
    private readonly AppSettings _appSettings;
    private readonly IAttachmentRestEaseClient _attachmentRestEaseClient;

    public TicketDetailService(ILogger<TicketDetailService> logger, IMapper mapper, AppSettings appSettings,
        IHttpContextAccessor accessor) :
        base(accessor)
    {
        _logger = logger;
        _mapper = mapper;
        _appSettings = appSettings;
        _attachmentRestEaseClient =
            RestEase.RestClient.For<IAttachmentRestEaseClient>(appSettings.MicroservicesUrls.TicketsManagementUrl);
        _ticketRestEaseClient =
            RestEase.RestClient.For<ITicketRestEaseClient>(appSettings.MicroservicesUrls.TicketsManagementUrl);
        _ticketDetailRestEaseClient =
            RestEase.RestClient.For<ITicketDetailRestEaseClient>(appSettings.MicroservicesUrls.TicketsManagementUrl);
    }

    public async Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketCode(int ticketCode, string token)
    {
        try
        {
            var ticketDetailList = await _ticketDetailRestEaseClient.GetAllByTicketCode(ticketCode, token);
            foreach (var ticketDetail in ticketDetailList)
            {
                var query = await _attachmentRestEaseClient.GetAsync(a => a.TicketDetailId == ticketDetail.Id);
                ticketDetail.Attachments = query;
            }

            var ticketDetailDtoList = _mapper.Map<IEnumerable<TicketDetailDto>>(ticketDetailList);
            return new Response<IEnumerable<TicketDetailDto>>(HttpStatusCode.OK, "Found details", true,
                ticketDetailDtoList);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<IEnumerable<TicketDetailDto>>(HttpStatusCode.InternalServerError,
                AnErrorHappenedMessage,
                false, new List<TicketDetailDto>(), e);
        }
    }

    public async Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketId(Guid ticketId)
    {
        try
        {
            var queryResult = await _ticketDetailRestEaseClient.GetAsync(t => ticketId.CompareTo(t.TicketId) == 0);
            var ticketDetails = queryResult.Include("Attachments").AsEnumerable();
            var ticketDetailDtoList = _mapper.Map<IEnumerable<TicketDetailDto>>(ticketDetails);
            return new Response<IEnumerable<TicketDetailDto>>(HttpStatusCode.OK, "Found details", true,
                ticketDetailDtoList);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<IEnumerable<TicketDetailDto>>(HttpStatusCode.InternalServerError,
                AnErrorHappenedMessage,
                false, new List<TicketDetailDto>(), e);
        }
    }

    public async Task<Response<TicketDetailDto>> CreateAsync(TicketDetailRequest request)
    {
        try
        {
            if (!await _ticketRestEaseClient.ExistsAsync(request.TicketId))
                throw new TicketNotFoundException($"ticket not found: {request.TicketId}");

            var ticketDetail = _mapper.Map<TicketDetail>(request);
            SetCurrentUserToEntity(ticketDetail);
            var metadata = new Dictionary<string, string> { { "ticketId", request.TicketId.ToString() } };
            if (request.Attachments != null)
            {
                var attachmentsUrls = await SaveAttachments(request.Attachments, metadata);
                ticketDetail.Attachments = attachmentsUrls
                    .Select(a => new Attachment
                        { Url = a, CreatedBy = GetCurrentUser().Username, CreatedOn = DateTime.Now, Status = true })
                    .ToList();
            }

            ticketDetail.TicketCode = (await _ticketRestEaseClient.FindByAsync(t => t.Id == request.TicketId))!.Code;
            ticketDetail = await _ticketDetailRestEaseClient.CreateAsync(ticketDetail);
            var ticketDetailDto = _mapper.Map<TicketDetailDto>(ticketDetail);
            return new Response<TicketDetailDto>(HttpStatusCode.OK, "Ticket registered successfully",
                true, ticketDetailDto);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDetailDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new TicketDetailDto(), e);
        }
    }

    public async Task<Response<TicketDetailDto>> UpdateAsync(UpdateTicketDetailRequest request)
    {
        try
        {
            var oldTicket = await _ticketDetailRestEaseClient.FindAsync(request.Id);
            if (oldTicket == null)
                throw new TicketDetailNotFoundException("Detail not found");
            var ticketDetail = _mapper.Map<TicketDetail>(request);
            ticketDetail.Id = oldTicket.Id;
            ticketDetail.CreatedBy = oldTicket.CreatedBy;
            ticketDetail.CreatedOn = oldTicket.CreatedOn;
            _ticketDetailRestEaseClient.Update(ticketDetail);
            var ticketDto = _mapper.Map<TicketDetailDto>(ticketDetail);
            return new Response<TicketDetailDto>(HttpStatusCode.OK, "Detail updated successfully", true, ticketDto);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDetailDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new TicketDetailDto(), e);
        }
    }

    public async Task<Response<bool>> Delete(Guid ticketDetailId)
    {
        try
        {
            var ticket = await _ticketDetailRestEaseClient.FindAsync(ticketDetailId);
            if (ticket == null)
                throw new TicketDetailNotFoundException("Detail not found");
            await _ticketDetailRestEaseClient.DeleteAsync(ticketDetailId);
            //TODO: Delete files from server
            await DeleteAttachmentsByTicketDetailIdAsync(ticketDetailId);
            return new Response<bool>(HttpStatusCode.OK, "Detail updated successfully", true, true);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<bool>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, false, e);
        }
    }

    private static Task DeleteAttachmentsByTicketDetailIdAsync(Guid ticketDetailId)
    {
        throw new NotImplementedException(
            "Method TicketDetailService/DeleteAttachmentsByTicketDetailIdAsync is not implemented.");
    }

    private async Task<IEnumerable<string>> SaveAttachments(IEnumerable<IFormFile> attachments,
        Dictionary<string, string> metadata)
    {
        try
        {
            return await ValidateFiles(attachments, metadata);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            throw;
        }
    }

    private async Task<IEnumerable<string>> ValidateFiles(IEnumerable<IFormFile> files,
        Dictionary<string, string> metadata)
    {
        const string bucketName = "tickets-bucket";
        var attachmentsUrl = new List<string>();
        foreach (var file in files.Where(IsValidFile))
        {
            attachmentsUrl.Add(await UploadFile(file, metadata, bucketName));
        }

        return attachmentsUrl;
    }

    private async Task<string> UploadFile(IFormFile file, Dictionary<string, string> metadata,
        string bucketName)
    {
        return await _fileManagementService.SaveAsync(file, metadata, bucketName);
    }

    private static bool IsValidFile(IFormFile file)
    {
        if (file.Length < 0)
            return false;

        // Check file extension to prevent security threats associated with unknown file types
        var permittedExtensions = new[] { ".jpg", ".jpeg", ".png", ".pdf" };
        var ext = Path.GetExtension(file.FileName).ToLowerInvariant();

        // Check if the file has the valid size to be uploaded
        if (permittedExtensions.Contains(ext))
            return true;
        throw new InvalidDataException($"File {file.FileName} is not a valid file extension");
    }
}