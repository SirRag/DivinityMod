using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Divinity.Items.Trintite
{
	[AutoloadEquip(EquipType.Body)]
	public class TrintiteChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Trintite Chestplate");
			Tooltip.SetDefault("");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 32;
			item.value = 10000;
			item.rare = 4;
			item.defense = 6;
		}
		
		public override void UpdateEquip(Player player)
		{
			
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