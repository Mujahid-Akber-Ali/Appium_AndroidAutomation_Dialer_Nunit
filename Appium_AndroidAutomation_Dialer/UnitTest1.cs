using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace Appium_AndroidAutomation_Dialer
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("deviceName", "Pixel 3a");
            capabilities.SetCapability("udid", "93KAY0C8KD");

            var driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.01:4723/wd/hub"), capabilities);

            driver.FindElement(By.Id("com.google.android.dialer:id/dialpad_fab")).Click();

            driver.FindElement(By.Id("com.google.android.dialer:id/zero")).Click();
            driver.FindElement(By.Id("com.google.android.dialer:id/three")).Click();
            driver.FindElement(By.Id("com.google.android.dialer:id/two")).Click();
            driver.FindElement(By.Id("com.google.android.dialer:id/three")).Click();
            driver.FindElement(By.Id("com.google.android.dialer:id/two")).Click();
            driver.FindElement(By.Id("com.google.android.dialer:id/seven")).Click();
            driver.FindElement(By.Id("com.google.android.dialer:id/eight")).Click();
            driver.FindElement(By.Id("com.google.android.dialer:id/three")).Click();
            driver.FindElement(By.Id("com.google.android.dialer:id/three")).Click();
            driver.FindElement(By.Id("com.google.android.dialer:id/seven")).Click();
            driver.FindElement(By.Id("com.google.android.dialer:id/four")).Click();

            driver.FindElement(By.Id("com.google.android.dialer:id/dialpad_voice_call_button")).Click();



        }
    }
}