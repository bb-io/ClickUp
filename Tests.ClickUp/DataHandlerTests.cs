using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.List;
using Apps.ClickUp.Models.Request.List;
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
        var handler = new ListDataHandler(InvocationContext, "901513903877");

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
        var handler = new PrimaryListDataHandler(InvocationContext, new ListRequest { FolderId = "901513903877" });

        var result = await handler.GetDataAsync(new() { }, CancellationToken.None);

        foreach (var item in result)
        {
            Console.WriteLine($"Folder name {item.Key} - {item.Value}");
        }

        Assert.IsNotNull(result);
    }

}
