namespace StyleBox.Controls
{
    using System.Runtime.CompilerServices;
    using System.Windows;

    public static class Keys
    {
        public static ResourceKey ColorKey { get; } = CreateResourceKey();

        public static ResourceKey BlueBrushKey { get; } = CreateResourceKey();

        public static ResourceKey ColorBrushKey { get; } = CreateResourceKey();

        public static ResourceKey LocalColorStyleKey { get; } = CreateResourceKey();

        public static ResourceKey DynamicBlueBrushStyleKey { get; } = CreateResourceKey();

        public static ResourceKey DynamicColorBrushStyleKey { get; } = CreateResourceKey();

        private static ComponentResourceKey CreateResourceKey([CallerMemberName] string caller = null)
        {
            return new ComponentResourceKey(typeof(Keys), caller);
        }
    }
}