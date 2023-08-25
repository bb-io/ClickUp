using Blackbird.Applications.Sdk.Common;

namespace ClickUp;

public class ClickUpApplication : IApplication
{
    private string _name;

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