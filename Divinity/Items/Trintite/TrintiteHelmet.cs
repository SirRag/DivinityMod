using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Divinity.Items.Trintite
{
	[AutoloadEquip(EquipType.Head)]
	public class TrintiteHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 24;
			item.value = 10000;
			item.rare = 4;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("TrintiteChestplate") && legs.type == mod.ItemType("TrintiteLeggings");
		}
		
		public override void UpdateEquip(Player player)
		{
			
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TrintiteBar", 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}