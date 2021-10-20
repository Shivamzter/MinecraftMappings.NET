﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Cobweb : JavaBlockTexture
    {
        public Cobweb() : base("Cobweb")
        {
            AddVersion("cobweb")
                .WithDefaultModel<Java.Models.Block.Cobweb>();
                //.MapsToBedrockBlock<BedrockBlocks.Cobweb>();
        }
    }
}
