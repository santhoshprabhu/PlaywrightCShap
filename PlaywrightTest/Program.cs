using Microsoft.Playwright;

class Program
{
    static async Task Main(string[] args)
    {
        // Create a Playwright instance and launch Chromium
        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });

        // Create a new page
        var page = await browser.NewPageAsync();

        // Navigate to the URL
        await page.GotoAsync("https://jupiter.cloud.planittesting.com");

        // Optionally, interact with the page (for example, take a screenshot)
        await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });

        // Wait for a while and then close the browser
        await Task.Delay(5000);  // Adjust the delay as needed
        await browser.CloseAsync();
    }
}
