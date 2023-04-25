
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Framework
{
        public class Driver
        {
            private static IWebDriver driver;

            public static void SetupDriver()
            {
                driver = new ChromeDriver();
            }

            public static IWebDriver GetDriver()
            {
                return driver;
            }

            public static void OpenURL(string url)
            {
                //su refresh
                driver.Url = url;
                //be refresh, išlaikom veiksmus, kurie galėjo būti atlikti svetainėje
                // driver.Navigate().GoToUrl(url);
            }

            public static void CloseDriver()
            {
                driver.Quit();
            }
        }
}
