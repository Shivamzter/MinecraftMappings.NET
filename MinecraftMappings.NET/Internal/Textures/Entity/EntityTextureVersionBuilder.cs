﻿using MinecraftMappings.Internal.Models.Entity;

namespace MinecraftMappings.Internal.Textures.Entity
{
    public abstract class EntityTextureVersionBuilder<TVersion>
        where TVersion : EntityTextureVersion
    {
        protected readonly TVersion EntityVersion;


        protected EntityTextureVersionBuilder(TVersion blockVersion)
        {
            EntityVersion = blockVersion;
        }

        protected EntityTextureVersionBuilder<TVersion> WithPath(string path)
        {
            EntityVersion.Path = path; 
            return this;
        }

        protected EntityTextureVersionBuilder<TVersion> WithDefaultModel<TModel>()
            where TModel : IEntityModel
        {
            EntityVersion.DefaultModel = typeof(TModel);
            return this;
        }

        protected EntityTextureVersionBuilder<TVersion> WithMinVersion(string version)
        {
            EntityVersion.MinVersion = GameVersion.Parse(version);
            return this;
        }

        protected EntityTextureVersionBuilder<TVersion> WithMinVersion(GameVersion version)
        {
            EntityVersion.MinVersion = version;
            return this;
        }
    }
}
