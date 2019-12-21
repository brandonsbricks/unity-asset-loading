using BRM.UnityAssets.Interfaces;
using UnityEngine;

namespace BRM.UnityAssets
{
    public class FileBundleLoader<TAsset> : SimpleAssetLoader<TAsset> where TAsset : Object
    {
        //todo: decide how to handle bundle loading separately from the asset loading
        //todo: ... in initialization, on load, on load lazily, bundle injection in constructor, ..?
        //todo:
        public override void Load(AssetData<TAsset> assetData)
        {
            var bundlePath = assetData.CombinedPath;
            var bundle = AssetBundle.LoadFromFile(assetData.ContainerName);
            var asset = bundle.LoadAsset<TAsset>(assetData.Name);
            assetData.OnAssetLoaded?.Invoke(asset);
        }
    }
}