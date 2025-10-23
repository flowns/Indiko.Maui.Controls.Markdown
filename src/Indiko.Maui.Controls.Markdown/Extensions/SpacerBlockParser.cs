using Markdig.Parsers;

namespace Indiko.Maui.Controls.Markdown.Extensions;

public class SpacerBlockParser : BlockParser
{
    private const string Keyword = "::spacer";
    private const int DefaultHeight = 8;
    
    public override BlockState TryOpen(BlockProcessor processor)
    {
        var line = processor.Line;
        line.TrimStart();
        
        if (!line.MatchLowercase(Keyword)) return BlockState.None;
        
        int height = DefaultHeight;
            
        line.Start += Keyword.Length;
        line.TrimStart();
        string remainingText = line.ToString();
        
        if (int.TryParse(remainingText.Split(' ', '\t')[0], out int number))
        {
            height = number;
        }

        var block = new SpacerBlock(this) { Height = height };
        processor.NewBlocks.Push(block);
        return BlockState.Break;

    }
}