

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

[TestFixture]
public class RegisterTests
{
    private IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://www.automationexercise.com");
    }

    [Test]
    public void Register_NewUser()
    {
        driver.FindElement(By.LinkText("Signup / Login")).Click();
        Thread.Sleep(2000);

        driver.FindElement(By.Name("name")).SendKeys("Test User");
        driver.FindElement(By.XPath("//input[@data-qa='signup-email']")).SendKeys("testuser@example.com");
        driver.FindElement(By.XPath("//button[@data-qa='signup-button']")).Click();
        Thread.Sleep(2000);

        driver.FindElement(By.Id("id_gender1")).Click();
        driver.FindElement(By.Id("password")).SendKeys("Test@123");
        driver.FindElement(By.Id("first_name")).SendKeys("John");
        driver.FindElement(By.Id("last_name")).SendKeys("Doe");
        driver.FindElement(By.Id("address1")).SendKeys("123 Street, NY");
        driver.FindElement(By.Id("zipcode")).SendKeys("10001");
        driver.FindElement(By.Id("mobile_number")).SendKeys("1234567890");
        driver.FindElement(By.XPath("//button[@data-qa='create-account']")).Click();

        Assert.IsTrue(driver.PageSource.Contains("Account Created"));
    }

    [TearDown]
    public void Cleanup()
    {
        driver.Quit();
    }
}
```

---

```csharp
[Test]
public void Login_Success()
{
    driver.FindElement(By.LinkText("Signup / Login")).Click();
    Thread.Sleep(2000);

    driver.FindElement(By.XPath("//input[@data-qa='login-email']")).SendKeys("testuser@example.com");
    driver.FindElement(By.XPath("//input[@data-qa='login-password']")).SendKeys("Test@123");
    driver.FindElement(By.XPath("//button[@data-qa='login-button']")).Click();
    Thread.Sleep(2000);

    Assert.IsTrue(driver.PageSource.Contains("Logged in as"));
}
```

---

```csharp
[Test]
public void Login_Fail_WrongPassword()
{
    driver.FindElement(By.LinkText("Signup / Login")).Click();
    Thread.Sleep(2000);

    driver.FindElement(By.XPath("//input[@data-qa='login-email']")).SendKeys("testuser@example.com");
    driver.FindElement(By.XPath("//input[@data-qa='login-password']")).SendKeys("WrongPass123");
    driver.FindElement(By.XPath("//button[@data-qa='login-button']")).Click();
    Thread.Sleep(2000);

    Assert.IsTrue(driver.PageSource.Contains("Your email or password is incorrect"));
}
```

---

```csharp
[Test]
public void Logout_Test()
{
    driver.FindElement(By.LinkText("Signup / Login")).Click();
    Thread.Sleep(2000);

    driver.FindElement(By.XPath("//input[@data-qa='login-email']")).SendKeys("testuser@example.com");
    driver.FindElement(By.XPath("//input[@data-qa='login-password']")).SendKeys("Test@123");
    driver.FindElement(By.XPath("//button[@data-qa='login-button']")).Click();
    Thread.Sleep(2000);

    driver.FindElement(By.LinkText("Logout")).Click();
    Thread.Sleep(2000);

    Assert.IsTrue(driver.PageSource.Contains("Signup / Login"));
}