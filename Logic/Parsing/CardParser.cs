namespace Logic.Parsing;

using Logic.Models;
using System.IO;
using System.Text.Json;
using System;

public static class CardParser
{
    public static Card[] ParseAll(string path)
    {
        List<Card> output = [];

        string[] files = Directory.GetFiles(path);

        foreach (string fileName in files)
        {
            string json = File.ReadAllText(path + $"/{fileName}");
            var result = ParseCard(json);

            if (result is CardResult success)
                output.Add(success.Result);
            else if (result is ParseError failure)
                Console.WriteLine(failure.Error);
        }

        return [.. output];
    }

    private static ParseResult ParseCard(string json)
    {
        try
        {
            if (JsonSerializer.Deserialize<Card>(json) is Card result)
                return new CardResult(result);
        }
        catch (JsonException jse)
        {
            return new ParseError($"{jse.Message} @{jse.Path}");
        }
        return new ParseError("Unknown error");
    }

    private abstract record class ParseResult;

    private record class CardResult(Card Result) : ParseResult;
    private record class ParseError(string Error) : ParseResult;
}
