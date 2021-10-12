﻿using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Internal.Entities;
using MinecraftMappings.Internal.Items;
using MinecraftMappings.Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinecraftMappings.Internal
{
    public abstract class MinecraftGameEdition<TBlockTexture, TItem, TEntity, TModel>
        where TBlockTexture : IBlockData
        where TItem : IItemData
        where TEntity : IEntityData
        where TModel : IModelData
    {
        private static readonly Lazy<IEnumerable<TBlockTexture>> allBlocksLazy = new Lazy<IEnumerable<TBlockTexture>>(BlockData.FromAssembly<TBlockTexture>);
        private static readonly Lazy<IEnumerable<TItem>> allItemsLazy = new Lazy<IEnumerable<TItem>>(ItemData.FromAssembly<TItem>);
        private static readonly Lazy<IEnumerable<TEntity>> allEntitiesLazy = new Lazy<IEnumerable<TEntity>>(EntityData.FromAssembly<TEntity>);
        private static readonly Lazy<IEnumerable<TModel>> allModelsLazy = new Lazy<IEnumerable<TModel>>(ModelData.FromAssembly<TModel>);

        public IEnumerable<TBlockTexture> AllBlocks => allBlocksLazy.Value;
        public IEnumerable<TItem> AllItems => allItemsLazy.Value;
        public IEnumerable<TEntity> AllEntities => allEntitiesLazy.Value;
        public IEnumerable<TModel> AllModels => allModelsLazy.Value;


        public IEnumerable<TBlockVersion> FindLatestBlockTextureVersionById<TBlockVersion>(string id)
            where TBlockVersion : BlockDataVersion, new()
        {
            return allBlocksLazy.Value.OfType<IBlockData<TBlockVersion>>()
                .Select(block => block.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IEnumerable<TItemVersion> FindItemVersionById<TItemVersion>(string id)
            where TItemVersion : ItemDataVersion, new()
        {
            return allItemsLazy.Value.OfType<IItemData<TItemVersion>>()
                .Select(item => item.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IEnumerable<TEntityVersion> FindEntityVersionById<TEntityVersion>(string id)
            where TEntityVersion : EntityDataVersion, new()
        {
            return allEntitiesLazy.Value.OfType<IEntityData<TEntityVersion>>()
                .Select(entity => entity.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IEnumerable<TEntityVersion> GetEntitiesByVersion<TEntityVersion>(Version version)
            where TEntityVersion : EntityDataVersion, new()
        {
            return allEntitiesLazy.Value.OfType<IEntityData<TEntityVersion>>()
                .Select(entity => entity.GetVersion(version));
        }

        public IEnumerable<ModelVersion> FindModelVersionById(string id)
        {
            return allModelsLazy.Value
                .Select(model => model.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IModelData GetModelForTexture<TBlockVersion>(string textureId)
            where TBlockVersion : BlockDataVersion, new()
        {
            if (textureId == null) return null;

            var blockTextures = FindLatestBlockTextureVersionById<TBlockVersion>(textureId);
            var modelType = blockTextures.FirstOrDefault()?.DefaultModel;
            if (modelType == null) return null;

            return (IModelData)Activator.CreateInstance(modelType);
        }
    }
}