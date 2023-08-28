using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using ClickUp.Actions.Base;
using ClickUp.Api;
using ClickUp.Constants;
using ClickUp.Models.Entities;
using ClickUp.Models.Request;
using ClickUp.Models.Request.Attachment;
using Method = RestSharp.Method;

namespace ClickUp.Actions;

[ActionList]
public class AttachmentActions : ClickUpActions
{
    public AttachmentActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Create task attachment", Description = "Adds files as an attachment to a task")]
    public Task<AttachmentEntity> CreateAttachment(
        [ActionParameter] CreateAttachmentRequest input,
        [ActionParameter] CreateRequestQuery query)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{input.TaskId}{ApiEndpoints.Attachments}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Post, Creds)
            .WithFile(input.File.Bytes, input.FileName ?? input.File.Name, "attachment");
        
        return Client.ExecuteWithErrorHandling<AttachmentEntity>(request);
    }
}