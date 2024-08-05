// See https://aka.ms/new-console-template for more information
using System.Configuration;
using System.Collections.Specialized;
using System.Xml.Linq;


NameValueCollection config = ConfigurationManager.AppSettings;
string sAttr = config.Get("token") ?? throw new ArgumentNullException("token key is required");

Console.WriteLine($"The environment variable is {sAttr}");
