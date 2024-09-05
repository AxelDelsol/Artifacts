using System.CommandLine;
using System.Configuration;

var appSettings = ConfigurationManager.AppSettings;
string token = appSettings["token"] ?? throw new ConfigurationErrorsException("Token is required in configuration");


var rootCommand = new RootCommand("CLI for Artifacts MMORPG");
var moveCommand = new Artifacts.Commands.Move("move", "Move a character at a given position");
var gatherCommand = new Artifacts.Commands.Gather("gather", "Gather the current resource");

rootCommand.AddCommand(moveCommand);
rootCommand.AddCommand(gatherCommand);



return await rootCommand.InvokeAsync(args);

