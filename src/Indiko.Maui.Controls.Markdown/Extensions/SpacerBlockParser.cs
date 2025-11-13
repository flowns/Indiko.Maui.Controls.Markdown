using System.Text.RegularExpressions;
using Markdig.Parsers;

namespace Indiko.Maui.Controls.Markdown.Extensions;

public class SpacerBlockParser : BlockParser
{
    private static readonly Regex SpacerRegex = 
        new(@"::spacer\s+(-?\d+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
    
    private const int DefaultHeight = 8;
    
    public override BlockState TryOpen(BlockProcessor processor)
    {
        Match match = SpacerRegex.Match(processor.Line.ToString());

        // Check if the pattern was found AND if the capturing group (the number) exists
        if (!match.Success) return BlockState.None;
        
        // Group 1 contains the captured digits string
        string numberString = match.Groups[1].Value;
        int height = int.TryParse(numberString, out int number) ? number : DefaultHeight;
        
        var block = new SpacerBlock(this) { Height = height };
        processor.NewBlocks.Push(block);
        return BlockState.Break;
    }
}