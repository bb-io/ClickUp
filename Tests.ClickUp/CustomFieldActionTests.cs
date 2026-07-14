using Apps.ClickUp.Actions;
using Apps.ClickUp.Models.Request;
using Apps.ClickUp.Models.Request.CustomField;
using Apps.ClickUp.Models.Request.List;
using Apps.ClickUp.Models.Request.Task;
using Tests.ClickUp.Base;

namespace Tests.ClickUp;

[TestClass]
public class CustomFieldActionTests : TestBase
{
    [TestMethod]
    public async Task ListCustomFields_ReturnsCustomFields()
    {
        // Arrange
        var actions = new CustomFieldActions(InvocationContext);
        var listRequest = new ListRequest
        {
            FolderId = "901410616216",
            ListId = "901417947717"
        };
        var searchRequest = new SearchCustomFieldsRequest
        {
            FieldType = "drop_down",
            FieldNameContains = "typ"
        };
        
        // Act
        var result = await actions.ListCustomFields(listRequest, searchRequest);

        // Assert
        PrintResult(result);
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task SetStringCustomFieldValue_IsSuccess()
    {
        // Arrange
        var actions = new CustomFieldActions(InvocationContext);
        var taskRequest = new TaskRequest
        {
            TaskId = "86baxgdyr",
            ListId = "901417947717",
            FolderId = "901410616216",
        };
        var query = new CreateRequestQuery { };
        var fieldRequest = new CustomStringFieldRequest { FieldId = "54ea8863-c02b-49e7-a4a5-81b5764ffdc2" };
        var fieldValue = new CustomFieldStringValue { Value = "test from tests!" };

        // Act
        await actions.SetStringCustomFieldValue(taskRequest, query, fieldRequest, fieldValue);
    }

    [TestMethod]
    public async Task SetNumberCustomFieldValue_IsSuccess()
    {
        // Arrange
        var actions = new CustomFieldActions(InvocationContext);
        var taskRequest = new TaskRequest
        {
            TaskId = "86baxgdyr",
            ListId = "901417947717",
            FolderId = "901410616216",
        };
        var query = new CreateRequestQuery { };
        var fieldRequest = new CustomNumberFieldRequest { FieldId = "0f74d9b4-1d61-4a71-8ec2-55d7ffa95403" };
        var fieldValue = new CustomFieldNumberValue { Value = 1234567 };

        // Act
        await actions.SetNumberCustomFieldValue(taskRequest, query, fieldRequest, fieldValue);
    }
    
    [TestMethod]
    public async Task SetDateCustomFieldValue_IsSuccess()
    {
        // Arrange
        var actions = new CustomFieldActions(InvocationContext);
        var taskRequest = new TaskRequest
        {
            TaskId = "86baxgdyr",
            ListId = "901417947717",
            FolderId = "901410616216",
        };
        var query = new CreateRequestQuery { };
        var fieldRequest = new CustomDateFieldRequest { FieldId = "3a3cf71b-ea45-40a5-a0db-5353f03aa1d8" };
        var fieldValue = new CustomFieldDateValue { Value = DateTime.UtcNow };

        // Act
        await actions.SetDateCustomFieldValue(taskRequest, query, fieldRequest, fieldValue);
    }
    
    [TestMethod]
    public async Task SetLocationCustomFieldValue_IsSuccess()
    {
        // Arrange
        var actions = new CustomFieldActions(InvocationContext);
        var taskRequest = new TaskRequest
        {
            TaskId = "86baxgdyr",
            ListId = "901417947717",
            FolderId = "901410616216",
        };
        var query = new CreateRequestQuery { };
        var fieldRequest = new CustomLocationFieldRequest { FieldId = "20b79f58-b337-43f3-991c-08a64fcea2d3" };
        var fieldValue = new CustomFieldLocationValue
        {
            Latitude = -28.016667,
            Longitude = 153.4,
            FormattedAddress = "Gold Coast QLD, Australia"
        };

        // Act
        await actions.SetLocationCustomFieldValue(taskRequest, query, fieldRequest, fieldValue);
    }
}