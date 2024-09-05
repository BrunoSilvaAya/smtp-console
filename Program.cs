using System.Net;
using System.Net.Mail;
using RazorLight;

var splitLogo = false;

if (args.Length > 0)
{
    if (bool.TryParse(args[0], out bool result))
    {
        splitLogo = result;
    }
    else
    {
        Console.WriteLine("Invalid argument. Please pass 'true' or 'false'.");
        return;
    }
}

string smtpServer = "localhost";
int smtpPort = 25;
string smtpUser = ""; 
string smtpPass = ""; 

string fromEmail = "bruno@aya.com"; 
string toEmail = "test@lotusone.com";
string subject = "Template Test";

string logoPath = @"C:\git\smtp\lotus3.png";

string logoPath2 = @"C:\git\smtp\shifts.png";

var engine = new RazorLightEngineBuilder()
    .UseEmbeddedResourcesProject(typeof(Program)) 
    .UseMemoryCachingProvider() 
    .Build();

var model = new Model
{
    Header = new Header
    {
        IncludeShiftsLogo = splitLogo
    },
    Body = new Body
    {
        Title = "Body Title",
        Description = "Body Description",
        Tables =
        [
            new() {
                Title = "Table 1 Title",
                Data = new List<Data>
                {
                    new Data { Key = "Table 1 First Key", Value = "Table 1 Value A" },
                    new Data { Key = "Table 1 Second Key", Value = "Table 2 Value B" }
                }
            },
            new Table
            {
                Title = "Table 2 Title",
                Data = new List<Data>
                {
                    new Data { Key = "Table 2 First Key", Value = "Table 2 Value" },
                    new Data { Key = "Table 2 Second Key", Value = "Table 2 Another Value" }
                }
            }
        ],
        Buttons =
        [
            new Button { Url = "https://example.com", Text = "Click Me", BorderColor = "#47D0E6", BackgroundColor = "#47D0E6" },
            new Button { Url = "https://anotherexample.com", Text = "Learn More", BorderColor = "#47D0E6", BackgroundColor = "#FFF" }
        ]
    },
    Footer = new Footer
    {
        FooterText = @"

                    <div class=""footer-questions"">
                      <div class=""footer-questions-text"">Questions?</div>
                      <div class=""footer-questions-contacts"">Contact <a class=""link"" href=""mailto:BillingDisputes@ayahealthcare.com"">BillingDisputes@ayahealthcare.com</a> or <b>(866) 687-7390</b></div>
                    </div>

                    <div class=""footer-automated-notification"">
                      This is an automated notification. Please do not reply to this message.
                    </div>

                    <div class=""footer-copyright"">
                      ©2024 Aya Healthcare, Inc<br/>
                      <a href=""https://www.lotusone.com"">www.LotusOne.com</a>
                    </div>"
    }
};


string templatePath = "smtp-console.emailTemplate";
string body = await engine.CompileRenderAsync(templatePath, model);

try
{
    MailMessage mail = new()
    {
        From = new MailAddress(fromEmail),
        Subject = subject,
        Body = body,
        IsBodyHtml = true
    };
    mail.To.Add(toEmail);    
    
    LinkedResource inlineLogo1 = new(logoPath, "image/png")
    {
        ContentId = "logo1"
    };
    LinkedResource inlineLogo2 = new(logoPath2, "image/png")
    {
        ContentId = "logo2"
    };

    AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");
    htmlView.LinkedResources.Add(inlineLogo1);
    htmlView.LinkedResources.Add(inlineLogo2);
    mail.AlternateViews.Add(htmlView);

    SmtpClient smtpClient = new(smtpServer, smtpPort)
    {
        Credentials = new NetworkCredential(smtpUser, smtpPass),
        EnableSsl = false
    };

    smtpClient.Send(mail);

    Console.WriteLine("Email sent successfully!");
}
catch (Exception ex)
{
    Console.WriteLine("Error sending email: " + ex.Message);
}