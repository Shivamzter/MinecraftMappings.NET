﻿using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cake : JavaBlockModel
    {
        public Cake() : base("Cake")
        {
            AddVersion("cake", "1.0.0")
                .WithPath("models/block")
                .AddTexture("bottom", "block/cake_bottom")
                .AddTexture("top", "block/cake_top")
                .AddTexture("side", "block/cake_side")
                .AddElement(element => {
                    element.From = new Vector3(1f, 0f, 1f);
                    element.To = new Vector3(15f, 8f, 15f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceDown = new ModelFace("#bottom");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                });
        }
    }
}
