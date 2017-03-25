using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace StardewTestTwo
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
{
    /*********
    ** Public methods
    *********/
    /// <summary>Initialise the mod.</summary>
    /// <param name="helper">Provides methods for interacting with the mod directory, such as read/writing a config file or custom JSON files.</param>
    public override void Entry(IModHelper helper)
    {
        ControlEvents.KeyPressed += this.ReceiveKeyPress;
    }


    /*********
    ** Private methods
    *********/
    /// <summary>The method invoked when the player presses a keyboard button.</summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="e">The event data.</param>
    private void ReceiveKeyPress(object sender, EventArgsKeyPressed e)
    {
        this.Monitor.Log($"Player pressed {e.KeyPressed}.");
    }
}
}

