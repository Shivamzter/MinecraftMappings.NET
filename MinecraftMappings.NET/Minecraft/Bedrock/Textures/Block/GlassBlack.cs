﻿using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GlassBlack : BedrockBlockTexture
    {
        public GlassBlack() : base("Glass Black")
        {
            AddVersion("glass_black")
                .MapsToJavaBlock<BlackStainedGlass>();
        }
    }
}