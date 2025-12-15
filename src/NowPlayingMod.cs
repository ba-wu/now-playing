using Vintagestory.API.Client;
using Vintagestory.API.Common;

namespace NowPlaying
{
    public class NowPlayingMod : ModSystem
    {
        private ICoreClientAPI capi;

        /// <summary>
        /// Only load this mod on the client side
        /// </summary>
        public override bool ShouldLoad(EnumAppSide side)
        {
            return side == EnumAppSide.Client;
        }

        /// <summary>
        /// Initialize client-side functionality
        /// Called when the client starts
        /// </summary>
        public override void StartClientSide(ICoreClientAPI api)
        {
            capi = api;

            // Register the .song command using the modern ChatCommands API
            api.ChatCommands
                .Create("song")
                .WithDescription("Display the currently playing music track")
                .HandleWith(OnSongCommand);

            // Log successful initialization
            api.Logger.Notification("[Now Playing] Mod initialized successfully");
        }

        /// <summary>
        /// Command handler - called when user types .song
        /// </summary>
        private TextCommandResult OnSongCommand(TextCommandCallingArgs args)
        {
            // Get the current music track from the client API
            IMusicTrack track = capi.CurrentMusicTrack;

            // Check if a track is currently playing
            if (track != null && track.IsActive)
            {
                // Build the message with track information
                string message = $"♪ Now playing: {track.Name}";

                // Display in chat
                capi.ShowChatMessage(message);

                // Log for debugging
                capi.Logger.Debug($"[Now Playing] Displayed track: {track.Name}");
            }
            else
            {
                // No music playing
                capi.ShowChatMessage("No music track is currently playing.");

                capi.Logger.Debug("[Now Playing] No active music track");
            }

            return TextCommandResult.Success();
        }
    }
}
