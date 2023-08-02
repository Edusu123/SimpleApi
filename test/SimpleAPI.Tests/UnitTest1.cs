namespace SimpleAPI.Tests;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void Test1()
    {
        var testValue = controller.Get().First();
        Assert.Equal(testValue.Date.ToString("yyyy"), DateTime.Now.AddDays(1).ToString("yyyy"));
    }
}