using System.Diagnostics;
using Markdig.Parsers;
using Markdig.Syntax;

namespace Indiko.Maui.Controls.Markdown.Extensions;

[DebuggerDisplay("{GetType().Name} Line: {Line}, {Lines} Level: {Level}")]
public class SpacerBlock : LeafBlock
{
    public SpacerBlock(BlockParser? parser = null) : base(parser)
    {
        ProcessInlines = true;
    }

    public int Height { get; set; }
}
