using BRM.UnityAssets.Interfaces;
using Object = UnityEngine.Object;

namespace BRM.UnityAssets
{
    public abstract class SimpleAssetLoader<TAsset> : ILoadAssets where TAsset : Object
    {
        public abstract void Load(AssetData<TAsset> assetData);
    }
}