using System;

using MudBlazor;
using Colors = MudBlazor.Colors;

namespace Wordspect;
public static class WordSpectTheme
{
    public static MudTheme GetCustomTheme()
    {
        return new MudTheme()
        {
            Palette = new Palette()
            {
                Primary = Colors.Blue.Default,
                Secondary = Colors.Green.Accent4,
                AppbarBackground = Colors.Grey.Darken4,
                Background = Colors.DeepPurple.Default,
            },
            PaletteDark = new Palette()
            {
                Primary = Colors.Blue.Lighten1
            },
            LayoutProperties = new LayoutProperties()
            {
                DrawerWidthLeft = "260px",
                DrawerWidthRight = "300px"  
            }
        };
    }
}
