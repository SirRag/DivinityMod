using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Divinity.Items.Trintite
{
    public class TrintiteKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trintite Shortsword");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.damage = 12;
            item.melee = true;
            item.scale = 0.8f;
            item.width = 16;
            item.height = 36;
            item.useTime = 12;
            item.useAnimation = 15;
            item.useStyle = 3;
            item.knockBack = 2;
            item.value = 1000;
            item.rare = 11;
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "TrintiteBar", 18);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}