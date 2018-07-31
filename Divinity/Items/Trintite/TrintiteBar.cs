using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Divinity.Items.Trintite
{
    public class TrintiteBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trintite Bar");
        }
        public override void SetDefaults()
        {
            item.maxStack = 99;
            item.rare = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "TrintiteOre", 5);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}