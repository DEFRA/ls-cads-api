using Microsoft.AspNetCore.Builder;

namespace LsCadsApi.Test.Config;

public class EnvironmentTest
{

   [Fact]
   public void IsNotDevModeByDefault()
   { 
       var builder = WebApplication.CreateEmptyBuilder(new WebApplicationOptions());
       var isDev = LsCadsApi.Config.Environment.IsDevMode(builder);
       Assert.False(isDev);
   }
}
