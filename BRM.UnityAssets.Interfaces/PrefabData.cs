using System;
using System.IO;
using Object = UnityEngine.Object;

namespace BRM.UnityAssets.Interfaces
{
    public abstract class AssetData<T> where T : Object
    {
        public Action<T> OnAssetLoaded;
        public string Name;
        public string ContainerName;
        
        public string FileExtension
        {
            get => _fileExtension;
            set => _fileExtension = value.TrimStart('.');
        }
        public string CombinedPath => $"{Path.Combine(ContainerName, Name)}.{FileExtension}";
        
        private string _fileExtension;
    }
}