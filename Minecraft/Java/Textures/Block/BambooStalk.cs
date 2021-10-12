﻿using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BambooStalk : JavaBlockData
    {
        public BambooStalk() : base("Bamboo Stalk")
        {
            AddVersion("bamboo_stalk")
                .WithDefaultModel<Java.Models.Block.Bamboo1_Age0>()
                .MapsToBedrockBlock<BedrockBlocks.BambooStem>();
        }
    }
}