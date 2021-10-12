﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AzureBluet : JavaBlockData
    {
        public AzureBluet() : base("Azure Bluet")
        {
            AddVersion("azure_bluet")
                .WithMinVersion(new GameVersion(1, 14))
                .WithDefaultModel<Java.Models.Block.AzureBluet>()
                .MapsToBedrockBlock<BedrockBlocks.FlowerHoustonia>();
        }
    }
}