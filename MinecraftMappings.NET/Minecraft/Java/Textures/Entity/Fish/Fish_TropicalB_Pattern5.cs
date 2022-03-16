﻿using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalB_Pattern5 : JavaEntityTexture
    {
        public Fish_TropicalB_Pattern5() : base("Fish, Tropical B; Pattern 5")
        {
            AddVersion("tropical_b_pattern_5")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishB>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalB_Pattern5>();
        }
    }
}
