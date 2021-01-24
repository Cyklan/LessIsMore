﻿namespace LessRoomyMoreShooty.Component.Sprites.Item.PickUpItems
{
    public class LargeHealItem : Item
    {
        public LargeHealItem() : base("Large Heal", "Just like a hospital visit.")
        {
            Texture = ContentManager.ButtonTexture;
        }

        public override void OnPickup(Player player)
        {
            if (player.CurrentHealth < player.MaxHealth - 3)
                player.CurrentHealth += 3;
        }
    }
}
