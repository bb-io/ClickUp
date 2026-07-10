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
        var customFieldRequest = new CustomFieldRequest
        {
            TaskId = "86bavd71m",
            ListId = "901417947717",
            FolderId = "901410616216",
            FieldId = "54ea8863-c02b-49e7-a4a5-81b5764ffdc2"
        };

        // Act
        var result = await actions.GetTaskStringCustomField(customFieldRequest);

        // Assert
        PrintResult(result);
        Assert.IsNotNull(result);
    }
    
    [TestMethod]
    public async Task GetTaskNumberCustomField_ReturnsCustomField()
    {
        // Arrange
        var actions = new TaskActions(InvocationContext);
        var customFieldRequest = new CustomFieldRequest
        {
            TaskId = "86bavd71m",
            ListId = "901417947717",
            FolderId = "901410616216",
            FieldId = "0f74d9b4-1d61-4a71-8ec2-55d7ffa95403"
        };

        // Act
        var result = await actions.GetTaskNumberCustomField(customFieldRequest);

        // Assert
        PrintResult(result);
        Assert.IsNotNull(result);
    }
    
    [TestMethod]
    public async Task GetTaskDateCustomField_ReturnsCustomField()
    {
        // Arrange
        var actions = new TaskActions(InvocationContext);
        var customFieldRequest = new CustomFieldRequest
        {
            TaskId = "86bavd71m",
            ListId = "901417947717",
            FolderId = "901410616216",
            FieldId = "3a3cf71b-ea45-40a5-a0db-5353f03aa1d8"
        };
        
        // Act
        var result = await actions.GetTaskDateCustomField(customFieldRequest);

        // Assert
        PrintResult(result);
        Assert.IsNotNull(result);
    }
    
    [TestMethod]
    public async Task GetTaskLocationCustomField_ReturnsCustomField()
    {
        // Arrange
        var actions = new TaskActions(InvocationContext);
        var customFieldRequest = new CustomFieldRequest
        {
            TaskId = "86bavkjat",
            ListId = "901417947717",
            FolderId = "901410616216",
            FieldId = "20b79f58-b337-43f3-991c-08a64fcea2d3"
        };

        // Act
        var result = await actions.GetTaskLocationCustomField(customFieldRequest);

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
        var fieldRequest = new CustomDropdownFieldRequest { Id = "0d9f8507-742c-4274-aae3-68293809b2c0" };

        // Act
        var result = await actions.GetTaskDropdownCustomField(taskRequest, fieldRequest);

        // Assert
        PrintResult(result);
        Assert.IsNotNull(result);
    }
}