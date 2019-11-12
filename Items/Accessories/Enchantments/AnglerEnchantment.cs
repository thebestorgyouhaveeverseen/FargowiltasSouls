using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace FargowiltasSouls.Items.Accessories.Enchantments
{
    public class AnglerEnchantment : EnchantmentItem
    {
        public const string TOOLTIP =
            @"'As long as they aren't all shoes, you can go home happily'
Increases fishing skill
All fishing rods will have 4 extra lures";


        public AnglerEnchantment() : base("Angler Enchantment", TOOLTIP, 20, 20, 
            TileID.DemonAltar, Item.sellPrice(gold: 2), ItemRarityID.Pink, new Color(113, 125, 109))
        {
        }


        public override void SetStaticDefaults()
        {
            DisplayName.AddTranslation(GameCulture.Chinese, "渔夫魔石");
            Tooltip.AddTranslation(GameCulture.Chinese, 
@"'只要不全是鞋子, 你可以高高兴兴地回家'
增加钓鱼技能
所有鱼竿将会增加4个额外的鱼饵");

            base.SetStaticDefaults();
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<FargoPlayer>().FishSoul1 = true;
            player.fishingSkill += 10;
        }


        protected override void AddRecipeBase(ModRecipe recipe)
        {
            recipe.AddIngredient(ItemID.AnglerHat);
            recipe.AddIngredient(ItemID.AnglerVest);
            recipe.AddIngredient(ItemID.AnglerPants);
            recipe.AddIngredient(ItemID.WoodFishingPole);
            recipe.AddIngredient(ItemID.ReinforcedFishingPole);
            recipe.AddIngredient(ItemID.FiberglassFishingPole);
            recipe.AddIngredient(ItemID.Rockfish);
            recipe.AddIngredient(ItemID.SawtoothShark);

            recipe.AddIngredient(ItemID.FrostDaggerfish, 200);
            recipe.AddIngredient(ItemID.OldShoe, 5);
        }
    }
}