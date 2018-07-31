using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Divinity.Items.Sanchezium
{
	public class SancheziumGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gragor Handgun");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 42;
			item.ranged = true;
            item.scale = 0.8f;
			item.width = 80;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 8;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 4; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Bullet;
		}
		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2, 0);
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SancheziumBar", 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
