using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace HaNoiDevDays.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp("com.vuductuyen.hanoidevdays.crossclock")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .PreferIdeSettings()
                .StartApp();
        }
    }
}

