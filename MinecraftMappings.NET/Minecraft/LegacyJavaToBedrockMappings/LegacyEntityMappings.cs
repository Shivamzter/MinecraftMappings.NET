using System;
using System.Collections.Generic;

namespace MinecraftMappings.Minecraft.LegacyJavaToBedrockMappings
{
    public class LegacyEntityMappings : Dictionary<string, string>
    {
        public static LegacyEntityMappings Instance {get;} = new();

        private LegacyEntityMappings() : base(new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) {
            // TODO: Banner
            ["assets/minecraft/textures/entity/armorstand/wood"] = "textures/entity/armor_stand",
            ["assets/minecraft/textures/entity/bear/polarbear"] = "textures/entity/polarbear",
            ["assets/minecraft/textures/entity/bed/black"] = "textures/entity/bed/black",
            ["assets/minecraft/textures/entity/bed/blue"] = "textures/entity/bed/blue",
            ["assets/minecraft/textures/entity/bed/brown"] = "textures/entity/bed/brown",
            ["assets/minecraft/textures/entity/bed/cyan"] = "textures/entity/bed/cyan",
            ["assets/minecraft/textures/entity/bed/gray"] = "textures/entity/bed/gray",
            ["assets/minecraft/textures/entity/bed/green"] = "textures/entity/bed/green",
            ["assets/minecraft/textures/entity/bed/light_blue"] = "textures/entity/bed/light_blue",
            ["assets/minecraft/textures/entity/bed/lime"] = "textures/entity/bed/lime",
            ["assets/minecraft/textures/entity/bed/magenta"] = "textures/entity/bed/magenta",
            ["assets/minecraft/textures/entity/bed/orange"] = "textures/entity/bed/orange",
            ["assets/minecraft/textures/entity/bed/pink"] = "textures/entity/bed/pink",
            ["assets/minecraft/textures/entity/bed/purple"] = "textures/entity/bed/purple",
            ["assets/minecraft/textures/entity/bed/red"] = "textures/entity/bed/red",
            ["assets/minecraft/textures/entity/bed/light_gray"] = "textures/entity/bed/silver",
            ["assets/minecraft/textures/entity/bed/white"] = "textures/entity/bed/white",
            ["assets/minecraft/textures/entity/bed/yellow"] = "textures/entity/bed/yellow",
            ["assets/minecraft/textures/entity/bee/bee"] = "textures/entity/bee/bee",
            ["assets/minecraft/textures/entity/bee/bee_angry"] = "textures/entity/bee/bee_angry",
            ["assets/minecraft/textures/entity/bee/bee_angry_nectar"] = "textures/entity/bee/bee_angry_nectar",
            ["assets/minecraft/textures/entity/bee/bee_nectar"] = "textures/entity/bee/bee_nectar",
            ["assets/minecraft/textures/entity/bell/bell_body"] = "textures/entity/bell/bell",
            ["assets/minecraft/textures/entity/boat/acacia"] = "textures/entity/boat/boat_acacia",
            ["assets/minecraft/textures/entity/boat/birch"] = "textures/entity/boat/boat_birch",
            ["assets/minecraft/textures/entity/boat/darkoak"] = "textures/entity/boat/boat_darkoak",
            ["assets/minecraft/textures/entity/boat/jungle"] = "textures/entity/boat/boat_jungle",
            ["assets/minecraft/textures/entity/boat/oak"] = "textures/entity/boat/boat_oak",
            ["assets/minecraft/textures/entity/boat/spruce"] = "textures/entity/boat/boat_spruce",
            ["assets/minecraft/textures/entity/cat/all_black"] = "textures/entity/cat/allblackcat",
            ["assets/minecraft/textures/entity/cat/black"] = "textures/entity/cat/blackcat",
            ["assets/minecraft/textures/entity/cat/british_shorthair"] = "textures/entity/cat/britishshorthair",
            ["assets/minecraft/textures/entity/cat/calico"] = "textures/entity/cat/calico",
            ["assets/minecraft/textures/entity/cat/jellie"] = "textures/entity/cat/jellie",
            ["assets/minecraft/textures/entity/cat/ocelot"] = "textures/entity/cat/ocelot",
            ["assets/minecraft/textures/entity/cat/persian"] = "textures/entity/cat/persian",
            ["assets/minecraft/textures/entity/cat/ragdoll"] = "textures/entity/cat/ragdoll",
            ["assets/minecraft/textures/entity/cat/red"] = "textures/entity/cat/red",
            ["assets/minecraft/textures/entity/cat/siamese"] = "textures/entity/cat/siamese",
            ["assets/minecraft/textures/entity/cat/tabby"] = "textures/entity/cat/tabby",
            ["assets/minecraft/textures/entity/cat/white"] = "textures/entity/cat/white",
            ["assets/minecraft/textures/entity/chest/christmas"] = "textures/entity/chest/christmas",
            ["assets/minecraft/textures/entity/chest/christmas_left"] = "textures/entity/chest/christmas_left",
            ["assets/minecraft/textures/entity/chest/christmas_right"] = "textures/entity/chest/christmas_right",
            ["assets/minecraft/textures/entity/chest/ender"] = "textures/entity/chest/ender",
            ["assets/minecraft/textures/entity/chest/normal"] = "textures/entity/chest/normal",
            ["assets/minecraft/textures/entity/chest/normal_left"] = "textures/entity/chest/normal_left",
            ["assets/minecraft/textures/entity/chest/normal_right"] = "textures/entity/chest/normal_right",
            ["assets/minecraft/textures/entity/chest/trapped"] = "textures/entity/chest/trapped",
            ["assets/minecraft/textures/entity/chest/trapped_left"] = "textures/entity/chest/trapped_left",
            ["assets/minecraft/textures/entity/chest/trapped_right"] = "textures/entity/chest/trapped_right",
            ["assets/minecraft/textures/entity/cow/brown_mooshroom"] = "textures/entity/cow/brown_mooshroom",
            ["assets/minecraft/textures/entity/cow/cow"] = "textures/entity/cow/cow",
            ["assets/minecraft/textures/entity/cow/red_mooshroom"] = "textures/entity/cow/mooshroom",
            ["assets/minecraft/textures/entity/creeper/creeper"] = "textures/entity/creeper/creeper",
            ["assets/minecraft/textures/entity/creeper/creeper_armor"] = "textures/entity/creeper/creeper_armor",
            ["assets/minecraft/textures/entity/end_crystal/end_crystal"] = "textures/entity/endercrystal/endercrystal",
            ["assets/minecraft/textures/entity/end_crystal/end_crystal_beam"] = "textures/entity/endercrystal/endercrystal_beam",
            ["assets/minecraft/textures/entity/enderdragon/dragon"] = "textures/entity/dragon/dragon",
            ["assets/minecraft/textures/entity/enderdragon/dragon_exploding"] = "textures/entity/dragon/dragon_exploding",
            ["assets/minecraft/textures/entity/enderdragon/dragon_eyes"] = "textures/entity/dragon/dragon_eyes",
            ["assets/minecraft/textures/entity/enderman/enderman"] = "textures/entity/enderman/enderman",
            ["assets/minecraft/textures/entity/fish/cod"] = "textures/entity/fish/cod",
            ["assets/minecraft/textures/entity/fish/pufferfish"] = "textures/entity/fish/pufferfish",
            ["assets/minecraft/textures/entity/fish/salmon"] = "textures/entity/fish/salmon",
            ["assets/minecraft/textures/entity/fish/tropical_a"] = "textures/entity/fish/tropical_a",
            ["assets/minecraft/textures/entity/fish/tropical_a_pattern_1"] = "textures/entity/fish/tropical_a_pattern_1",
            ["assets/minecraft/textures/entity/fish/tropical_a_pattern_2"] = "textures/entity/fish/tropical_a_pattern_2",
            ["assets/minecraft/textures/entity/fish/tropical_a_pattern_3"] = "textures/entity/fish/tropical_a_pattern_3",
            ["assets/minecraft/textures/entity/fish/tropical_a_pattern_4"] = "textures/entity/fish/tropical_a_pattern_4",
            ["assets/minecraft/textures/entity/fish/tropical_a_pattern_5"] = "textures/entity/fish/tropical_a_pattern_5",
            ["assets/minecraft/textures/entity/fish/tropical_a_pattern_6"] = "textures/entity/fish/tropical_a_pattern_6",
            ["assets/minecraft/textures/entity/fish/tropical_b"] = "textures/entity/fish/tropical_b",
            ["assets/minecraft/textures/entity/fish/tropical_b_pattern_1"] = "textures/entity/fish/tropical_b_pattern_1",
            ["assets/minecraft/textures/entity/fish/tropical_b_pattern_2"] = "textures/entity/fish/tropical_b_pattern_2",
            ["assets/minecraft/textures/entity/fish/tropical_b_pattern_3"] = "textures/entity/fish/tropical_b_pattern_3",
            ["assets/minecraft/textures/entity/fish/tropical_b_pattern_4"] = "textures/entity/fish/tropical_b_pattern_4",
            ["assets/minecraft/textures/entity/fish/tropical_b_pattern_5"] = "textures/entity/fish/tropical_b_pattern_5",
            ["assets/minecraft/textures/entity/fish/tropical_b_pattern_6"] = "textures/entity/fish/tropical_b_pattern_6",
            ["assets/minecraft/textures/entity/fox/fox"] = "textures/entity/fox/fox",
            ["assets/minecraft/textures/entity/fox/snow_fox"] = "textures/entity/fox/arctic_fox",
            ["assets/minecraft/textures/entity/ghast/ghast"] = "textures/entity/ghast/ghast",
            ["assets/minecraft/textures/entity/ghast/ghast_shooting"] = "textures/entity/ghast/ghast_shooting",
            ["assets/minecraft/textures/entity/hoglin/hoglin"] = "textures/entity/hoglin/hoglin",
            ["assets/minecraft/textures/entity/hoglin/zoglin"] = "textures/entity/zoglin/zoglin",
            ["assets/minecraft/textures/entity/horse/armor/horse_armor_diamond"] = "textures/entity/horse/armor/horse_armor_diamond",
            ["assets/minecraft/textures/entity/horse/armor/horse_armor_gold"] = "textures/entity/horse/armor/horse_armor_gold",
            ["assets/minecraft/textures/entity/horse/armor/horse_armor_iron"] = "textures/entity/horse/armor/horse_armor_iron",
            ["assets/minecraft/textures/entity/horse/armor/horse_armor_leather"] = "textures/entity/horse/armor/horse_armor_leather",
            ["assets/minecraft/textures/entity/horse/horse_black"] = "textures/entity/horse/horse_black",
            ["assets/minecraft/textures/entity/horse/horse_brown"] = "textures/entity/horse/horse_brown",
            ["assets/minecraft/textures/entity/horse/horse_chestnut"] = "textures/entity/horse/horse_chestnut",
            ["assets/minecraft/textures/entity/horse/horse_creamy"] = "textures/entity/horse/horse_creamy",
            ["assets/minecraft/textures/entity/horse/horse_darkbrown"] = "textures/entity/horse/horse_darkbrown",
            ["assets/minecraft/textures/entity/horse/horse_gray"] = "textures/entity/horse/horse_gray",
            ["assets/minecraft/textures/entity/horse/horse_markings_blackdots"] = "textures/entity/horse/horse_markings_blackdots",
            ["assets/minecraft/textures/entity/horse/horse_markings_white"] = "textures/entity/horse/horse_markings_white",
            ["assets/minecraft/textures/entity/horse/horse_markings_whitedots"] = "textures/entity/horse/horse_markings_whitedots",
            ["assets/minecraft/textures/entity/horse/horse_markings_whitefield"] = "textures/entity/horse/horse_markings_whitefield",
            ["assets/minecraft/textures/entity/horse/horse_skeleton"] = "textures/entity/horse/horse_skeleton",
            ["assets/minecraft/textures/entity/horse/horse_white"] = "textures/entity/horse/horse_white",
            ["assets/minecraft/textures/entity/horse/horse_zombie"] = "textures/entity/horse/horse_zombie",
            ["assets/minecraft/textures/entity/horse/mule"] = "textures/entity/horse/mule",
            ["assets/minecraft/textures/entity/illager/evoker"] = "textures/entity/illager/evoker",
            ["assets/minecraft/textures/entity/illager/evoker_fangs"] = "textures/entity/illager/fangs",
            ["assets/minecraft/textures/entity/illager/pillager"] = "textures/entity/pillager",
            ["assets/minecraft/textures/entity/illager/ravager"] = "textures/entity/illager/ravager",
            ["assets/minecraft/textures/entity/illager/vex"] = "textures/entity/vex/vex",
            ["assets/minecraft/textures/entity/illager/vex_charging"] = "textures/entity/vex/vex_charging",
            ["assets/minecraft/textures/entity/illager/vindicator"] = "textures/entity/vindicator",
            ["assets/minecraft/textures/entity/iron_golem/iron_golem"] = "textures/entity/iron_golem",
            ["assets/minecraft/textures/entity/llama/decor/black"] = "textures/entity/llama/decor/decor_black",
            ["assets/minecraft/textures/entity/llama/decor/blue"] = "textures/entity/llama/decor/decor_blue",
            ["assets/minecraft/textures/entity/llama/decor/brown"] = "textures/entity/llama/decor/decor_brown",
            ["assets/minecraft/textures/entity/llama/decor/cyan"] = "textures/entity/llama/decor/decor_cyan",
            ["assets/minecraft/textures/entity/llama/decor/gray"] = "textures/entity/llama/decor/decor_gray",
            ["assets/minecraft/textures/entity/llama/decor/green"] = "textures/entity/llama/decor/decor_green",
            ["assets/minecraft/textures/entity/llama/decor/light_blue"] = "textures/entity/llama/decor/decor_light_blue",
            ["assets/minecraft/textures/entity/llama/decor/light_gray"] = "textures/entity/llama/decor/decor_silver",
            ["assets/minecraft/textures/entity/llama/decor/lime"] = "textures/entity/llama/decor/decor_lime",
            ["assets/minecraft/textures/entity/llama/decor/magenta"] = "textures/entity/llama/decor/decor_magenta",
            ["assets/minecraft/textures/entity/llama/decor/orange"] = "textures/entity/llama/decor/decor_orange",
            ["assets/minecraft/textures/entity/llama/decor/pink"] = "textures/entity/llama/decor/decor_pink",
            ["assets/minecraft/textures/entity/llama/decor/purple"] = "textures/entity/llama/decor/decor_purple",
            ["assets/minecraft/textures/entity/llama/decor/red"] = "textures/entity/llama/decor/decor_red",
            ["assets/minecraft/textures/entity/llama/decor/trader_llama"] = "textures/entity/llama/decor/trader_llama_decor",
            ["assets/minecraft/textures/entity/llama/decor/white"] = "textures/entity/llama/decor/decor_white",
            ["assets/minecraft/textures/entity/llama/decor/yellow"] = "textures/entity/llama/decor/decor_yellow",
            ["assets/minecraft/textures/entity/llama/brown"] = "textures/entity/llama/llama_brown",
            ["assets/minecraft/textures/entity/llama/creamy"] = "textures/entity/llama/llama_creamy",
            ["assets/minecraft/textures/entity/llama/gray"] = "textures/entity/llama/llama_gray",
            ["assets/minecraft/textures/entity/llama/spit"] = "textures/entity/llama/spit",
            ["assets/minecraft/textures/entity/llama/white"] = "textures/entity/llama/llama_white",
            ["assets/minecraft/textures/entity/panda/aggressive_panda"] = "textures/entity/panda/panda_aggressive",
            ["assets/minecraft/textures/entity/panda/brown_panda"] = "textures/entity/panda/panda_brown",
            ["assets/minecraft/textures/entity/panda/lazy_panda"] = "textures/entity/panda/panda_lazy",
            ["assets/minecraft/textures/entity/panda/panda"] = "textures/entity/panda/panda",
            ["assets/minecraft/textures/entity/panda/playful_panda"] = "textures/entity/panda/panda_playful",
            ["assets/minecraft/textures/entity/panda/weak_panda"] = "textures/entity/panda/panda_sneezy",
            ["assets/minecraft/textures/entity/panda/worried_panda"] = "textures/entity/panda/panda_worried",
            ["assets/minecraft/textures/entity/parrot/parrot_blue"] = "textures/entity/parrot/parrot_blue",
            ["assets/minecraft/textures/entity/parrot/parrot_green"] = "textures/entity/parrot/parrot_green",
            ["assets/minecraft/textures/entity/parrot/parrot_grey"] = "textures/entity/parrot/parrot_grey",
            ["assets/minecraft/textures/entity/parrot/parrot_red_blue"] = "textures/entity/parrot/parrot_red_blue",
            ["assets/minecraft/textures/entity/parrot/parrot_yellow_blue"] = "textures/entity/parrot/parrot_yellow_blue",
            ["assets/minecraft/textures/entity/pig/pig"] = "textures/entity/pig/pig",
            ["assets/minecraft/textures/entity/pig/pig_saddle"] = "textures/entity/pig/pig_saddle",
            ["assets/minecraft/textures/entity/piglin/piglin"] = "textures/entity/piglin/piglin",
            ["assets/minecraft/textures/entity/piglin/piglin_brute"] = "textures/entity/piglin/piglin_brute",
            ["assets/minecraft/textures/entity/piglin/zombified_piglin"] = "textures/entity/piglin/zombie_piglin",
            ["assets/minecraft/textures/entity/rabbit/black"] = "textures/entity/rabbit/blackrabbit",
            ["assets/minecraft/textures/entity/rabbit/brown"] = "textures/entity/rabbit/brown",
            ["assets/minecraft/textures/entity/rabbit/gold"] = "textures/entity/rabbit/gold",
            ["assets/minecraft/textures/entity/rabbit/salt"] = "textures/entity/rabbit/salt",
            ["assets/minecraft/textures/entity/rabbit/toast"] = "textures/entity/rabbit/toast",
            ["assets/minecraft/textures/entity/rabbit/white"] = "textures/entity/rabbit/white",
            ["assets/minecraft/textures/entity/rabbit/white_splotched"] = "textures/entity/rabbit/white_splotched",
            ["assets/minecraft/textures/entity/sheep/sheep"] = "textures/entity/sheep/sheep",
            ["assets/minecraft/textures/entity/shulker/shulker"] = "textures/entity/shulker/shulker_undyed",
            ["assets/minecraft/textures/entity/shulker/shulker_black"] = "textures/entity/shulker/shulker_black",
            ["assets/minecraft/textures/entity/shulker/shulker_blue"] = "textures/entity/shulker/shulker_blue",
            ["assets/minecraft/textures/entity/shulker/shulker_brown"] = "textures/entity/shulker/shulker_brown",
            ["assets/minecraft/textures/entity/shulker/shulker_cyan"] = "textures/entity/shulker/shulker_cyan",
            ["assets/minecraft/textures/entity/shulker/shulker_gray"] = "textures/entity/shulker/shulker_gray",
            ["assets/minecraft/textures/entity/shulker/shulker_green"] = "textures/entity/shulker/shulker_green",
            ["assets/minecraft/textures/entity/shulker/shulker_light_blue"] = "textures/entity/shulker/shulker_light_blue",
            ["assets/minecraft/textures/entity/shulker/shulker_light_gray"] = "textures/entity/shulker/shulker_silver",
            ["assets/minecraft/textures/entity/shulker/shulker_lime"] = "textures/entity/shulker/shulker_lime",
            ["assets/minecraft/textures/entity/shulker/shulker_magenta"] = "textures/entity/shulker/shulker_magenta",
            ["assets/minecraft/textures/entity/shulker/shulker_orange"] = "textures/entity/shulker/shulker_orange",
            ["assets/minecraft/textures/entity/shulker/shulker_pink"] = "textures/entity/shulker/shulker_pink",
            ["assets/minecraft/textures/entity/shulker/shulker_purple"] = "textures/entity/shulker/shulker_purple",
            ["assets/minecraft/textures/entity/shulker/shulker_red"] = "textures/entity/shulker/shulker_red",
            ["assets/minecraft/textures/entity/shulker/shulker_white"] = "textures/entity/shulker/shulker_white",
            ["assets/minecraft/textures/entity/shulker/shulker_yellow"] = "textures/entity/shulker/shulker_yellow",
            ["assets/minecraft/textures/entity/shulker/spark"] = "textures/entity/shulker/spark",
            ["assets/minecraft/textures/entity/signs/acacia"] = "textures/entity/sign_acacia",
            ["assets/minecraft/textures/entity/signs/birch"] = "textures/entity/sign_birch",
            ["assets/minecraft/textures/entity/signs/crimson"] = "textures/entity/sign_crimson",
            ["assets/minecraft/textures/entity/signs/dark_oak"] = "textures/entity/sign_dark_oak",
            ["assets/minecraft/textures/entity/signs/jungle"] = "textures/entity/sign_jungle",
            ["assets/minecraft/textures/entity/signs/oak"] = "textures/entity/sign_oak",
            ["assets/minecraft/textures/entity/signs/spruce"] = "textures/entity/sign_spruce",
            ["assets/minecraft/textures/entity/signs/warped"] = "textures/entity/sign_warped",
            ["assets/minecraft/textures/entity/skeleton/skeleton"] = "textures/entity/skeleton/skeleton",
            ["assets/minecraft/textures/entity/skeleton/stray"] = "textures/entity/skeleton/stray",
            ["assets/minecraft/textures/entity/skeleton/stray_overlay"] = "textures/entity/skeleton/stray_overlay",
            ["assets/minecraft/textures/entity/skeleton/wither_skeleton"] = "textures/entity/skeleton/wither_skeleton",
            ["assets/minecraft/textures/entity/slime/magmacube"] = "textures/entity/slime/magmacube",
            ["assets/minecraft/textures/entity/slime/slime"] = "textures/entity/slime/slime",
            ["assets/minecraft/textures/entity/spider/cave_spider"] = "textures/entity/spider/cave_spider",
            ["assets/minecraft/textures/entity/spider/spider"] = "textures/entity/spider/spider",
            ["assets/minecraft/textures/entity/squid/squid"] = "textures/entity/squid",
            ["assets/minecraft/textures/entity/strider/strider"] = "textures/entity/strider/strider",
            ["assets/minecraft/textures/entity/strider/strider_cold"] = "textures/entity/strider/strider_suffocated",
            ["assets/minecraft/textures/entity/turtle/big_sea_turtle"] = "textures/entity/sea_turtle",
            ["assets/minecraft/textures/entity/villager/villager"] = "textures/entity/villager/villager",
            ["assets/minecraft/textures/entity/wither/wither"] = "textures/entity/wither_boss/wither",
            ["assets/minecraft/textures/entity/wither/wither_armor"] = "textures/entity/wither_boss/wither_armor_white",
            ["assets/minecraft/textures/entity/wither/wither_invulnerable"] = "textures/entity/wither_boss/wither_invulnerable",
            ["assets/minecraft/textures/entity/wolf/wolf"] = "textures/entity/wolf/wolf",
            ["assets/minecraft/textures/entity/wolf/wolf_angry"] = "textures/entity/wolf/wolf_angry",
            ["assets/minecraft/textures/entity/wolf/wolf_tame"] = "textures/entity/wolf/wolf_tame",
            ["assets/minecraft/textures/entity/zombie/drowned"] = "textures/entity/zombie/drowned",
            ["assets/minecraft/textures/entity/zombie/husk"] = "textures/entity/zombie/husk",
            ["assets/minecraft/textures/entity/zombie/zombie"] = "textures/entity/zombie/zombie",
            ["assets/minecraft/textures/entity/zombie_villager/zombie_villager"] = "textures/entity/zombie_villager/zombie_villager",
            ["assets/minecraft/textures/entity/alex"] = "textures/entity/alex",
            ["assets/minecraft/textures/entity/bat"] = "textures/entity/bat",
            ["assets/minecraft/textures/entity/beacon_beam"] = "textures/entity/beacon_beam",
            ["assets/minecraft/textures/entity/blaze"] = "textures/entity/blaze",
            ["assets/minecraft/textures/entity/chicken"] = "textures/entity/chicken",
            ["assets/minecraft/textures/entity/dolphin"] = "textures/entity/dolphin",
            ["assets/minecraft/textures/entity/enchanting_table_book"] = "textures/entity/enchanting_table_book",
            ["assets/minecraft/textures/entity/end_portal"] = "textures/entity/end_portal",
            ["assets/minecraft/textures/entity/endermite"] = "textures/entity/endermite",
            ["assets/minecraft/textures/entity/experience_orb"] = "textures/entity/experience_orb",
            ["assets/minecraft/textures/entity/fishing_hook"] = "textures/entity/fishhook",
            ["assets/minecraft/textures/entity/guardian"] = "textures/entity/guardian",
            ["assets/minecraft/textures/entity/guardian_beam"] = "textures/entity/guardian_beam",
            ["assets/minecraft/textures/entity/guardian_elder"] = "textures/entity/guardian_elder",
            ["assets/minecraft/textures/entity/lead_knot"] = "textures/entity/lead_knot",
            ["assets/minecraft/textures/entity/minecart"] = "textures/entity/minecart",
            ["assets/minecraft/textures/entity/phantom"] = "textures/entity/phantom",
            ["assets/minecraft/textures/entity/shield_base_nopattern"] = "textures/entity/shield",
            ["assets/minecraft/textures/entity/silverfish"] = "textures/entity/silverfish",
            ["assets/minecraft/textures/entity/snow_golem"] = "textures/entity/snow_golem",
            ["assets/minecraft/textures/entity/steve"] = "textures/entity/steve",
            ["assets/minecraft/textures/entity/trident"] = "textures/entity/trident",
            ["assets/minecraft/textures/entity/trident"] = "textures/entity/trident",
            ["assets/minecraft/textures/entity/trident_riptide"] = "textures/entity/trident_riptide",
            ["assets/minecraft/textures/entity/wandering_trader"] = "textures/entity/wandering_trader",
            ["assets/minecraft/textures/entity/witch"] = "textures/entity/witch",
        }) {}
    }
}