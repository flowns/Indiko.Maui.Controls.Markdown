using Markdig;
using Markdig.Renderers;

namespace Indiko.Maui.Controls.Markdown.Extensions;

public class SpacerExtension : IMarkdownExtension
{
    public void Setup(MarkdownPipelineBuilder pipeline)
    {
        pipeline.BlockParsers.Insert(0, new SpacerBlockParser());
    }

    public void Setup(MarkdownPipeline pipeline, IMarkdownRenderer renderer)
    {
        // Intentionally left empty. We don't need a custom renderer.
    }
}
