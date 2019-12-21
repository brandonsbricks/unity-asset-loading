using BRM.UnityAssets.Interfaces;
using UnityEngine;

namespace BRM.UnityAssets
{
    public class ResourcesLoader<TAsset> : SimpleAssetLoader<TAsset> where TAsset : Object
    {
        public override void Load(AssetData<TAsset> assetData)
        {
            string resourcesPath = $"{assetData.ContainerName}/{assetData.Name}.{assetData.FileExtension}";
            var asset = Resources.Load<TAsset>(resourcesPath);
            assetData.OnAssetLoaded?.Invoke(asset);
        }
    }
}