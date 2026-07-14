using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.CustomField;
using Apps.ClickUp.DataSourceHandlers.List;
using Apps.ClickUp.Models.Request.CustomField;
using Apps.ClickUp.Models.Request.List;
using Apps.ClickUp.Models.Request.Task;
using Tests.ClickUp.Base;

namespace Tests.ClickUp;

[TestClass]
public class DataHandlerTests : TestBase
{
    [TestMethod]
    public async Task FolderDataHandler_works()
    {
        var handler = new FolderDataHandler(InvocationContext);

        var result = await handler.GetDataAsync(new() { }, CancellationToken.None);

        foreach (var item in result)
        {
            Console.WriteLine($"Folder name {item.Key} - {item.Value}");
        }

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task ListCustomFieldDataHandler_works()
    {
        var handler = new ListCustomFieldDataHandler(InvocationContext, new Apps.ClickUp.Models.Request.CustomField.CustomFieldRequest { FolderId = "901513903877" });

        var result = await handler.GetDataAsync(new() { }, CancellationToken.None);

        foreach (var item in result)
        {
            Console.WriteLine($"Folder name {item.Key} - {item.Value}");
        }

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task ListDataHandler_works()
    {
        var handler = new ListDataHandler(InvocationContext, "901410616216");

        var result = await handler.GetDataAsync(new() { }, CancellationToken.None);

        foreach (var item in result)
        {
            Console.WriteLine($"Folder name {item.Key} - {item.Value}");
        }

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task ListTaskDataHandler_works()
    {
        var handler = new ListTaskDataHandler(InvocationContext, new Apps.ClickUp.Models.Request.Task.TaskRequest { FolderId = "901513903877" });

        var result = await handler.GetDataAsync(new() { }, CancellationToken.None);

        foreach (var item in result)
        {
            Console.WriteLine($"Folder name {item.Key} - {item.Value}");
        }

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task PrimaryListDataHandler_works()
    {
        var handler = new PrimaryListDataHandler(InvocationContext, new ListRequest { FolderId = "901410616216" });

        var result = await handler.GetDataAsync(new() { }, CancellationToken.None);

        foreach (var item in result)
        {
            Console.WriteLine($"Folder name {item.Key} - {item.Value}");
        }

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task CustomFieldDataHandler_IsSuccess()
    {
        // Arrange
        var request = new CustomFieldRequest
        {
            ListId = "901417947717"
        };
        var handler = new CustomFieldDataHandler(InvocationContext, request);

        // Act
        var result = await handler.GetDataAsync(new() { SearchString = "" }, CancellationToken.None);

        // Assert
        foreach (var field in result)
            Console.WriteLine($"{field.Key} - {field.Value}");
        
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task DropdownCustomFieldDataHandler_IsSuccess()
    {
        // Arrange
        var taskRequest = new TaskRequest { TaskId = "86baxgdyr" };
        var handler = new DropdownCustomFieldDataHandler(InvocationContext, taskRequest);

        // Act
        var result = await handler.GetDataAsync(new() { SearchString = "status" }, CancellationToken.None);

        // Assert
        foreach (var field in result)
            Console.WriteLine($"{field.Value} - {field.DisplayName}");
        
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task StringCustomFieldDataHandler_IsSuccess()
    {
        // Arrange
        var taskRequest = new TaskRequest { TaskId = "86baxgdyr" };
        var handler = new StringCustomFieldDataHandler(InvocationContext, taskRequest);

        // Act
        var result = await handler.GetDataAsync(new() { SearchString = "" }, CancellationToken.None);

        // Assert
        foreach (var field in result)
            Console.WriteLine($"{field.Value} - {field.DisplayName}");
        
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task NumberCustomFieldDataHandler_IsSuccess()
    {
        // Arrange
        var taskRequest = new TaskRequest { TaskId = "86baxgdyr" };
        var handler = new NumberCustomFieldDataHandler(InvocationContext, taskRequest);

        // Act
        var result = await handler.GetDataAsync(new() { SearchString = "" }, CancellationToken.None);

        // Assert
        foreach (var field in result)
            Console.WriteLine($"{field.Value} - {field.DisplayName}");
        
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task LocationCustomFieldDataHandler_IsSuccess()
    {
        // Arrange
        var taskRequest = new TaskRequest { TaskId = "86baxgdyr" };
        var handler = new LocationCustomFieldDataHandler(InvocationContext, taskRequest);

        // Act
        var result = await handler.GetDataAsync(new() { SearchString = "" }, CancellationToken.None);

        // Assert
        foreach (var field in result)
            Console.WriteLine($"{field.Value} - {field.DisplayName}");
        
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task DateCustomFieldDataHandler_IsSuccess()
    {
        // Arrange
        var taskRequest = new TaskRequest { TaskId = "86baxgdyr" };
        var handler = new DateCustomFieldDataHandler(InvocationContext, taskRequest);

        // Act
        var result = await handler.GetDataAsync(new() { SearchString = "" }, CancellationToken.None);

        // Assert
        foreach (var field in result)
            Console.WriteLine($"{field.Value} - {field.DisplayName}");
        
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task DropdownValueCustomFieldDataHandler_IsSuccess()
    {
        // Arrange
        var taskRequest = new TaskRequest { TaskId = "86bavkjat" };
        var dropdownRequest = new CustomDropdownFieldRequest { FieldId = "0d9f8507-742c-4274-aae3-68293809b2c0" };
        var handler = new DropdownValueCustomFieldDataHandler(InvocationContext, taskRequest, dropdownRequest);

        // Act
        var result = await handler.GetDataAsync(new() { SearchString = "" }, CancellationToken.None);

        // Assert
        foreach (var field in result)
            Console.WriteLine($"{field.Value} - {field.DisplayName}");
        
        Assert.IsNotNull(result);
    }
}
