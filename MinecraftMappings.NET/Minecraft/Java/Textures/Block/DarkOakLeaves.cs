﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkOakLeaves : JavaBlockTexture
    {
        public DarkOakLeaves() : base("Dark Oak Leaves")
        {
            AddVersion("dark_oak_leaves")
                .WithDefaultModel<Java.Models.Block.DarkOakLeaves>();
                //.MapsToBedrockBlock<BedrockBlocks.LeavesDarkOak>();
        }
    }
}
