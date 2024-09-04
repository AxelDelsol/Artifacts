using System.CommandLine;
using System.Configuration;

var appSettings = ConfigurationManager.AppSettings;
string token = appSettings["token"] ?? throw new ConfigurationErrorsException("Token is required in configuration");


var rootCommand = new RootCommand("CLI for Artifacts MMORPG");
var moveCommand = new Artifacts.Commands.Move("move", "Move a character at a given position");

rootCommand.AddCommand(moveCommand);


return await rootCommand.InvokeAsync(args);

