using System;
using IO.Unity3D.Source.Async;

namespace IO.Unity3D.Source.AssetBundleX
{
    //******************************************
    // 
    //
    // @Author: Kakashi
    // @Email: john.cha@qq.com
    // @Date: 2022-08-17 22:49
    //******************************************
    public interface IAssetBundle
    {
        void AddOnLoaded(Action<IAssetBundle> onLoaded);
        
        ITaskWithResult<T> LoadAssetAsync<T>(string assetPath) where T : UnityEngine.Object;
        
        ITaskWithResult<Object> LoadAssetAsync(string assetPath, Type type);
        
        string GetPath();
    }
}