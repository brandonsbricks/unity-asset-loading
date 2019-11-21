using System.IO;
using BRM.UnityAssets.Interfaces;
using UnityEngine;
using UnityEditor;

namespace BRM.UnityAssets.Editor
{
    public class AssetDatabaseLoader<TAsset> : SimpleAssetLoader<TAsset> where TAsset : Object
    {
        public override void Load(AssetData<TAsset> assetData)
        {
            string assetDatabasePath = Path.Combine("Assets", assetData.CombinedPath);
            var asset = AssetDatabase.LoadAssetAtPath<TAsset>(assetDatabasePath);
            assetData.OnAssetLoaded?.Invoke(asset);
        }
    }
}