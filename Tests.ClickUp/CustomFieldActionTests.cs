using Apps.ClickUp.Actions;
using Apps.ClickUp.Models.Request.CustomField;
using Apps.ClickUp.Models.Request.List;
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
}