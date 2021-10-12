﻿using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueOrchid : JavaBlockData
    {
        public BlueOrchid() : base("Blue Orchid")
        {
            AddVersion("blue_orchid")
                .WithDefaultModel<Java.Models.Block.BlueOrchid>()
                .MapsToBedrockBlock<BedrockBlocks.FlowerBlueOrchid>();
        }
    }
}