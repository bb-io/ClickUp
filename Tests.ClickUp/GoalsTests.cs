using Apps.ClickUp.Models.Request.Goal;
using Tests.ClickUp.Base;

namespace Tests.ClickUp
{
    [TestClass]
    public class GoalsTests : TestBase
    {
        [TestMethod]
        public async Task GetGoals_works()
        {
            var action = new Apps.ClickUp.Actions.GoalActions(InvocationContext);

            var result = await action.GetGoals(new ListGoalsQuery { });

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(result));

            Assert.IsNotNull(result);
        }
    }
}
