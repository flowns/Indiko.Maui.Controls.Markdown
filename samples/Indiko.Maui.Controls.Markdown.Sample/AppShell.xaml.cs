using Indiko.Maui.Controls.Markdown.Sample.ViewModels;

namespace Indiko.Maui.Controls.Markdown.Sample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		var tabBar = new TabBar();
		
		tabBar.Items.Add(new ShellContent
		{
			Title = "Example",
			Content = new MainPage(),
			BindingContext = new MainPageViewModel()
			{
				MarkdownText = """
				               This markdown component has been tweaked and styled to be used in the rebranded Flow and Halo apps.
				               
				               # Heading 1
				               ## Heading 2
				               ### Heading 3
				               
				               > ### BLOC QUOTES
				               >
				               > Block quotes can be used for this type of boxes. It can contain any layout element, such as:
				               > - Bullet
				               > - Lists
				               > 
				               > **Bold** and *italic* text, etc...  

				               ```
				               Code blocks can be used to create this type of text. It can only contain text and not layout elements. At least not yet...
				               ```
				               ---
				               You can specify size, alignment and margin for images:
				               
				               ![](https://www.svgrepo.com/show/530402/honor.svg){ alignment=Start top_margin=0 bottom_margin=10 width=40 height=40}
				               
				               ![](https://www.svgrepo.com/show/530402/honor.svg){ alignment=Center top_margin=-30 bottom_margin=10 width=80 height=80}
				               
				               """
			}
		});
		
		tabBar.Items.Add(new ShellContent
		{
			Title = "Assessment",
			Content = new MainPage(),
			BindingContext = new MainPageViewModel()
			{
				MarkdownText = """
				               ## Let’s start with your mood

				               The mood scale* scores from 0 to 25 and contains 3 thresholds:

				               ![](https://directus-926401349027.europe-west2.run.app/assets/fdd275cb-97cc-4299-be9e-d8d6fe5494d0.svg){ alignment=Start top_margin=15 bottom_margin=-5 width=65 height=20}

				               **Steady and resilient**
				               You’re feeling positive and emotionally well. Keep doing what works for you.

				               ![](https://directus-926401349027.europe-west2.run.app/assets/c033d14d-d032-4f6c-8711-dbf33b7105e5.svg){ top_margin=15 bottom_margin=-5 width=65 height=20}

				               **Room to lift**
				               Your mood has room to grow. Small daily changes can help lift it.

				               ![](https://directus-926401349027.europe-west2.run.app/assets/6e0c4653-55f1-4984-a8b8-7f900c8c967d.svg){ top_margin=15 bottom_margin=-5 width=65 height=20}

				               **Running low**
				               You’re not feeling your best right now. It might help to review your routine and add extra support.


				               > ### WHY THIS MATTERS
				               >
				               > Your mood influences motivation, focus, sleep quality, and overall performance. Tracking it helps you see how your sessions may be helping over time.

				               ```
				               *The mood scale is based on WHO who stands for World Health Organisation.
				               ```
				               """
			}
		});
		
		tabBar.Items.Add(new ShellContent
		{
			Title = "NBA",
			Content = new MainPage(),
			BindingContext = new MainPageViewModel()
			{
				MarkdownText = """
				               ![](https://directus-926401349027.europe-west2.run.app/assets/c4726033-9047-444e-a5e1-2ecb15bdccef.png)
				               
				               ## How it affects the brain
				               
				               > Because the brain runs on electricity, neurons react to the current. For neurons to be useful to us, they need to shift their electrical charge. 
				               
				               A neuron receives incoming signals through its dendrites. If the incoming stimulation is strong enough, the neuron is able to pass that signal along. The signal is then transmitted through the entire length of the brain cell in a process called an action potential. Another way to describe it is to say that the neuron “fires”. 

				               ![](https://directus-926401349027.europe-west2.run.app/assets/5cdc514e-216b-4b7d-8a42-cb39e973ff86/image.gig)
				               """
			}
		});
		
		Items.Add(tabBar);
		
		tabBar.Items.Add(new ShellContent
		{
			Title = "More",
			Content = new MainPage(),
			BindingContext = new MainPageViewModel()
			{
				MarkdownText = """

				               # Why .NET MAUI is Awesome
				               MAUI.net (Multi-platform App UI) is a **modern UI toolkit** from **Microsoft** that enables developers to build **beautiful**, **high-performance**, __cross-platform apps__ from a **single codebase**.

				               Move now from ~~xamarin~~ to maui.net !

				               ## Single Codebase, Multiple Platforms
				               With .NET MAUI, you can target for instance

				               - Android 
				               - iOS 
				               - macOS 
				               - Windows

				               with the **same code**.

				               **Why you should learn mobile cross-platform**
				               1. **Broader Market Reach**
				               2. **Cost and Time Efficiency**
				               3. **Consistent User Experience**

				               This significantly reduces development time and effort, allowing developers to focus on building great features rather than dealing with platform-specific code.

				               ![Maui Bot](dev.png)

				               ### Data URL Images (Base64)
				               Testing data URL images with base64 encoding:

				               3x ![♥](data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAEsWlUWHRYTUw6Y29tLmFkb2JlLnhtcAAAAAAAPD94cGFja2V0IGJlZ2luPSLvu78iIGlkPSJXNU0wTXBDZWhpSHpyZVN6TlRjemtjOWQiPz4KPHg6eG1wbWV0YSB4bWxuczp4PSJhZG9iZTpuczptZXRhLyIgeDp4bXB0az0iWE1QIENvcmUgNS41LjAiPgogPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4KICA8cmRmOkRlc2NyaXB0aW9uIHJkZjphYm91dD0iIgogICAgeG1sbnM6ZXhpZj0iaHR0cDovL25zLmFkb2JlLmNvbS9leGlmLzEuMC8iCiAgICB4bWxuczp0aWZmPSJodHRwOi8vbnMuYWRvYmUuY29tL3RpZmYvMS4wLyIKICAgIHhtbG5zOnBob3Rvc2hvcD0iaHR0cDovL25zLmFkb2JlLmNvbS9waG90b3Nob3AvMS4wLyIKICAgIHhtbG5zOnhtcD0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wLyIKICAgIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIgogICAgeG1sbnM6c3RFdnQ9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZUV2ZW50IyIKICAgZXhpZjpQaXhlbFhEaW1lbnNpb249IjE2IgogICBleGlmOlBpeGVsWURpbWVuc2lvbj0iMTYiCiAgIGV4aWY6Q29sb3JTcGFjZT0iMSIKICAgdGlmZjpJbWFnZVdpZHRoPSIxNiIKICAgdGlmZjpJbWFnZUxlbmd0aD0iMTYiCiAgIHRpZmY6UmVzb2x1dGlvblVuaXQ9IjIiCiAgIHRpZmY6WFJlc29sdXRpb249IjcyLzEiCiAgIHRpZmY6WVJlc29sdXRpb249IjcyLzEiCiAgIHBob3Rvc2hvcDpDb2xvck1vZGU9IjMiCiAgIHBob3Rvc2hvcDpJQ0NQcm9maWxlPSJzUkdCIElFQzYxOTY2LTIuMSIKICAgeG1wOk1vZGlmeURhdGU9IjIwMjUtMDgtMDJUMTM6MjY6NDUrMDI6MDAiCiAgIHhtcDpNZXRhZGF0YURhdGU9IjIwMjUtMDgtMDJUMTM6MjY6NDUrMDI6MDAiPgogICA8eG1wTU06SGlzdG9yeT4KICAgIDxyZGY6U2VxPgogICAgIDxyZGY6bGkKICAgICAgc3RFdnQ6YWN0aW9uPSJwcm9kdWNlZCIKICAgICAgc3RFdnQ6c29mdHdhcmVBZ2VudD0iQWZmaW5pdHkgUGhvdG8gMiAyLjYuMyIKICAgICAgc3RFdnQ6d2hlbj0iMjAyNS0wOC0wMlQxMzoyNjo0NSswMjowMCIvPgogICAgPC9yZGY6U2VxPgogICA8L3htcE1NOkhpc3Rvcnk+CiAgPC9yZGY6RGVzY3JpcHRpb24+CiA8L3JkZjpSREY+CjwveDp4bXBtZXRhPgo8P3hwYWNrZXQgZW5kPSJyIj8+r7zYUAAAAYFpQ0NQc1JHQiBJRUM2MTk2Ni0yLjEAACiRdZHPK0RRFMc/ZmgmQ6NYSBaTsDJi1MRGmUlDSRqj/Nq8eeaHmh+v92bSZKtspyix8WvBX8BWWStFpGTNltig5zwzNZPMuZ17Pvd77zndey7YIik1bdQPQDqT08OhgGd+YdHjeMGJDRcd1CuqoY3NzExR0z7uqLPijdeqVfvcv+ZaiRkq1DmFR1VNzwlPCE+t5TSLt4Xb1KSyInwq3KfLBYVvLT1a4meLEyX+sliPhINgaxH2JKo4WsVqUk8Ly8vpTqfyavk+1kuaYpm5WYld4p0YhAkRwMMk4wTxM8iIzH68+OiXFTXyB37zp8lKriqzRgGdVRIkydEnal6qxyTGRY/JSFGw+v+3r0Z8yFeq3hSAhifTfOsBxxZ8F03z89A0v4/A/ggXmUp+9gCG30UvVrTufXBvwNllRYvuwPkmtD9oiq78SnZxWzwOryfQvACt19C4VOpZeZ/je4isy1ddwe4e9Mp59/IP7rdnr0lUWjkAAAAJcEhZcwAACxMAAAsTAQCanBgAAADqSURBVDiNzdK9LkRBGMbx365iO9eg0LgCovBRb6JiKpWL4ApIKLgDleqUm7gFIRsKCiGyUWh0G90WEsWZMxnjBFvxNDPvM+/zn3eS4a/VyYuKZfTxhkHgPvoL2MAszgMXXwAVuzjMeBNsx/0ZetnZXuAoASrm8ISZYsJJXHuF/475wHM3Gkst4SZYhsXeRWgAo5amnzTKAdcYTxEe4yYBQv2mgykA+zGTJoBjXP0ifImTpkiASNzE4zfhB2w1t5cTCLxgBXct4Vusxp6kbtkVeMUahpk9xHo8+6ROaTSq6m+7E8vTUH/vf6gPDdkuW1yOeC0AAAAASUVORK5CYII=){ width=16 height=16 }

				               ## Modern UI Development

				               > .NET MAUI leverages the latest in UI development, including declarative syntax with XAML or C#, hot reload for rapid UI iteration, and a rich set of controls and layouts that adapt to different screen sizes and devices.

				               ## Performance

				               Leveraging the power of .NET 6 and beyond, .NET MAUI apps boast high performance.
				               The framework is optimized for speed and responsiveness, ensuring a smooth user experience across all platforms.

				               ## Extensibility and Ecosystem
				               With access to the extensive .NET ecosystem, developers can easily integrate a wide range of libraries and tools into their MAUI apps, from databases and authentication services to powerful UI components.

				               ## Developer Productivity

				               .NET MAUI comes with powerful development tools, including Visual Studio integration, which provides a rich editing, debugging, and deployment experience, further boosting developer productivity.

				               ---

				               In summary, .NET MAUI offers a unified approach to cross-platform app development, combining ease of use, performance, and extensive ecosystem support, making it an excellent choice for modern app development.

				               ```csharp
				               for(int n= 0; n<10; n++)
				               {
				                   Console.WriteLine(n);
				               }
				               ```

				               ```csharp
				               public class SimpleProgram
				               {
				                   public static void Main(string[] args)
				                   {
				                       string message = "Hello, World!";
				                       Console.WriteLine(message);
				                       Console.WriteLine("This is a simple C# program.");
				                       message = null;
				                       if (message == null)
				                           Console.WriteLine("Message is null!");
				                   }
				               }
				               ```

				               ```int b= 0;```

				               [More about Maui.net](https://learn.microsoft.com/en-us/dotnet/maui/?view=net-maui-8.0)

				               ### Table Support
				               The MarkdownView supports basic tables as well as tables with alignments.

				               Header 1 | Header 2 | Header 3 
				               ----------|----------|----------
				               A1 | B1 | C1 
				               A2 | B2 | C2 
				               A3 | B3 | C3 

				                #### Table with alignments

				               Left  |  Center |  Right 
				               :---------|:--------:|---------:
				               A1 | B1 | C1 
				               A2 | B2 | C2 
				               A3 | B3 | C3 

				               ### Math formula Support

				               $$
				               $E = mc^2
				               $$

				               $$
				               \int_{-\infty}^{\infty} e^{-x^2} dx = \sqrt{\pi}
				               $$

				               $$
				               \pi r^2
				               $$

				               ### Lokal SVG Image
				               ![Lokal SVG ](dotnet_bot)

				               ### Web Source SVG Image
				               ![Web Source SVG](https://www.svgrepo.com/show/530402/honor.svg)

				               ### E-Mail Links
				               Contact us at [support@example.com](support@example.com).
				               [Link1](https://google.com) | [Link2](https://bing.com)

				               ### Nested lists

				               - Item 1
				                 - Subitem 1.1
				                   - Sub-subitem 1.1.1
				                 - Subitem 1.2
				               - Item 2

				               1. First
				                  1.1. Sub-first
				                      1.1.1. Sub-sub-first
				               2. Second

				               - Fruits
				                 1. Apple
				                 2. Banana
				                    - Ripe
				                    - Unripe
				               - Vegetables


				               """
			}
		});
		
		Items.Add(tabBar);
	}
}