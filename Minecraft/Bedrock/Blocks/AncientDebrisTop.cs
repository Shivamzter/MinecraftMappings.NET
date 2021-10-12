﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class AncientDebrisTop : BedrockBlockData
    {
        public const string BlockId = "ancient_debris_top";
        public const string BlockName = "Ancient Debris Top";


        public AncientDebrisTop() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = Java.Textures.Block.AncientDebrisTop.BlockId,
                MinVersion = new GameVersion(1, 16),
            });
        }
    }
}