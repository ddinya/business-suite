using Spectre.Console;

namespace BusinessSuite.Helpers;
public class Welcome
{
  public static string AskForMode()
  {
    Console.WriteLine("Welcome to the BusinessSuite!");
        Console.WriteLine("");
    var option = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("[green]Select mode:[/]")
        .PageSize(10)
        .AddChoices([
            "Create Invoice", "Edit income table"
        ]));
    return option;
  }
}