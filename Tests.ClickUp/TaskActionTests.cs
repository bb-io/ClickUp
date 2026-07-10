using Apps.ClickUp.Actions;
using Apps.ClickUp.Models.Request.CustomField;
using Apps.ClickUp.Models.Request.Task;
using Tests.ClickUp.Base;

namespace Tests.ClickUp;

[TestClass]
public class TaskActionTests : TestBase
{
    [TestMethod]
    public async Task GetTaskStringCustomField_ReturnsCustomField()
    {
        // Arrange
        var actions = new TaskActions(InvocationContext);
        var taskRequest = new TaskRequest
        {
            TaskId = "86bavd71m",
            ListId = "901417947717",
            FolderId = "901410616216"
        };
        var customFieldRequest = new CustomFieldNameRequest
        {
            Name = "Shopify Item"
        };

        // Act
        var result = await actions.GetTaskStringCustomField(taskRequest, customFieldRequest);

        // Assert
        PrintResult(result);
        Assert.IsNotNull(result);
    }
    
    [TestMethod]
    public async Task GetTaskNumberCustomField_ReturnsCustomField()
    {
        // Arrange
        var actions = new TaskActions(InvocationContext);
        var taskRequest = new TaskRequest
        {
            TaskId = "86bavkjat",
            ListId = "901417947717",
            FolderId = "901410616216"
        };
        var customFieldRequest = new CustomFieldNameRequest
        {
            Name = "Test number"
        };

        // Act
        var result = await actions.GetTaskNumberCustomField(taskRequest, customFieldRequest);

        // Assert
        PrintResult(result);
        Assert.IsNotNull(result);
    }
    
    [TestMethod]
    public async Task GetTaskDateCustomField_ReturnsCustomField()
    {
        // Arrange
        var actions = new TaskActions(InvocationContext);
        var taskRequest = new TaskRequest
        {
            TaskId = "86bavkjat",
            ListId = "901417947717",
            FolderId = "901410616216"
        };
        var customFieldRequest = new CustomFieldNameRequest
        {
            Name = "Deadline"
        };

        // Act
        var result = await actions.GetTaskDateCustomField(taskRequest, customFieldRequest);

        // Assert
        PrintResult(result);
        Assert.IsNotNull(result);
    }
    
    [TestMethod]
    public async Task GetTaskLocationCustomField_ReturnsCustomField()
    {
        // Arrange
        var actions = new TaskActions(InvocationContext);
        var taskRequest = new TaskRequest
        {
            TaskId = "86bavkjat",
            ListId = "901417947717",
            FolderId = "901410616216"
        };
        var customFieldRequest = new CustomFieldNameRequest
        {
            Name = "Test location"
        };

        // Act
        var result = await actions.GetTaskLocationCustomField(taskRequest, customFieldRequest);

        // Assert
        PrintResult(result);
        Assert.IsNotNull(result);
    }
    
    [TestMethod]
    public async Task GetTaskDropdownCustomField_ReturnsCustomField()
    {
        // Arrange
        var actions = new TaskActions(InvocationContext);
        var taskRequest = new TaskRequest
        {
            TaskId = "86bavkjat",
            ListId = "901417947717",
            FolderId = "901410616216"
        };
        var customFieldRequest = new CustomFieldNameRequest
        {
            Name = "Content Type"
        };

        // Act
        var result = await actions.GetTaskDropdownCustomField(taskRequest, customFieldRequest);

        // Assert
        PrintResult(result);
        Assert.IsNotNull(result);
    }
}