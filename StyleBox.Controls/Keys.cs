namespace StyleBox.Controls
{
    using System.Runtime.CompilerServices;
    using System.Windows;

    public static class Keys
    {
        public static ResourceKey BrushKey { get; } = CreateResourceKey();

        public static ResourceKey LocalKey { get; } = CreateResourceKey();

        public static ResourceKey DynamicKey { get; } = CreateResourceKey();

        private static ComponentResourceKey CreateResourceKey([CallerMemberName] string caller = null)
        {
            return new ComponentResourceKey(typeof(Keys), caller);
        }
    }
}