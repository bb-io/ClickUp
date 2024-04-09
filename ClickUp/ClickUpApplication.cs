using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Metadata;

namespace Apps.ClickUp;

public class ClickUpApplication : IApplication, ICategoryProvider
{
    private string _name;

    public IEnumerable<ApplicationCategory> Categories
    {
        get => [ApplicationCategory.ProjectManagementAndProductivity, ApplicationCategory.TaskManagement];
        set { }
    }

    public ClickUpApplication()
    {
        _name = "ClickUp";
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public T GetInstance<T>()
    {
        throw new NotImplementedException();
    }
}