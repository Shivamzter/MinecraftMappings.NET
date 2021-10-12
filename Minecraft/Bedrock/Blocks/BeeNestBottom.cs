﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BeeNestBottom : BedrockBlockData
    {
        public const string BlockId = "bee_nest_bottom";
        public const string BlockName = "Bee Nest Bottom";


        public BeeNestBottom() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = Java.Textures.Block.BeeNestBottom.BlockId,
            });
        }
    }
}