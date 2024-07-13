using FarmerPortraits;
using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using StardewValley.Menus;

namespace DialogueDisplayFrameworkApi
{
    internal class DialogueDisplayIntegrations
    {
        public static bool IsApplied { get; private set; } = false;

        private static IModHelper Helper => ModEntry.SHelper;
        private static ModConfig Config => ModEntry.Config;

        private static IDialogueDisplayApi DialogueDisplayApi;

        public static void Apply(IDialogueDisplayApi api)
        {
            DialogueDisplayApi = api;

            DialogueDisplayApi.OnRenderingDialogueBox = TestEvent;

            IsApplied = true;
        }

        public static void TestEvent(SpriteBatch b, DialogueBox box, IDialogueDisplayData data)
        {
            ModEntry.SMonitor.Log($"test ! {data.XOffset}", LogLevel.Warn);
            throw new System.Exception("...");
        }

        public static void OnRenderingDialogueBox(SpriteBatch b, DialogueBox dialogueBox, dynamic data)
        {
        }

        public static void OnRenderingPortrait(SpriteBatch b, DialogueBox dialogueBox, dynamic rawData)
        {
            //var data = rawData as IPortraitData; 

            //ModEntry.SMonitor.Log($"It's working!! {rawData.XOffset}", LogLevel.Warn);
        }

        public static void OnRenderingText(SpriteBatch b, DialogueBox dialogueBox, dynamic data)
        {

        }

        public static void OnRenderingDivider(SpriteBatch b, DialogueBox dialogueBox, dynamic data)
        {

        }
    }
}
