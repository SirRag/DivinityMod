using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Divinity.Items.Trintite
{
    public class TrintiteOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trintite Ore");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.autoReuse = true;
            item.rare = 5;
            item.consumable = true;
            item.createTile = mod.TileType("TrintiteOreTile");
            item.rare = 5;
        }
    }
}