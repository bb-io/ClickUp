using Apps.ClickUp.Actions.Base;
using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Models.Entities;
using Apps.ClickUp.Models.Request;
using Apps.ClickUp.Models.Request.Attachment;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.SDK.Extensions.FileManagement.Interfaces;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using RestSharp;
using Method = RestSharp.Method;

namespace Apps.ClickUp.Actions;

[ActionList]
public class AttachmentActions : ClickUpActions
{
    private readonly IFileManagementClient _fileManagementClient;

    public AttachmentActions(InvocationContext invocationContext, IFileManagementClient fileManagementClient) : base(
        invocationContext)
    {
        _fileManagementClient = fileManagementClient;
    }

    [Action("Create task attachment", Description = "Adds files as an attachment to a task")]
    public async Task<AttachmentEntity> CreateAttachment(
        [ActionParameter] CreateAttachmentRequest input,
        [ActionParameter] CreateRequestQuery query)
    {
        var file = await _fileManagementClient.DownloadAsync(input.File);
        
        var endpoint = $"{ApiEndpoints.Tasks}/{input.TaskId}{ApiEndpoints.Attachments}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Post, Creds)
            .AddFile("attachment", () => file, input.FileName ?? input.File.Name);
            
        return await Client.ExecuteWithErrorHandling<AttachmentEntity>(request);
    }
}