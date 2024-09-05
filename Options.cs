using System.CommandLine;

namespace Artifacts
{
    internal static class Options
    {
        public static Option<string> Character = new(
            aliases: ["--character", "-c"],
            description: "Which character will perform the action")
        {
            IsRequired = true,
        };

        public static Option<Position?> Position = new(
            aliases: ["--position", "-p"],
            isDefault: true,
            description: "x,y coordinates of the action.",
            parseArgument: result =>
            {
                if (result.Tokens.Count != 2)
                {
                    result.ErrorMessage = "--coordinates requires two arguments x,y";
                    return null;
                }

                int x;
                if (!int.TryParse(result.Tokens[0].Value, out x))
                {
                    result.ErrorMessage = $"x argument must be an int. Got {result.Tokens[0].Value}";
                }
                int y;
                if (!int.TryParse(result.Tokens[1].Value, out y))
                {
                    result.ErrorMessage = $"y argument must be an int. Got {result.Tokens[1].Value}";
                }

                return new Position
                {
                    X = x,
                    Y = y,
                };

            })
        {
            Arity = ArgumentArity.OneOrMore,
            AllowMultipleArgumentsPerToken = true,
        };

        public static Option<int> Quantity = new(
            aliases: ["--quantity", "-q"],
            description: "How many items should we collect",
            getDefaultValue: () => 1);

        public static Option<string> Item = new(
            aliases: ["--item", "-i"],
            description: "Code item");
    }
}
