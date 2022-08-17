using IO.Unity3D.Source.Async;

namespace IO.Unity3D.Source.AssetBundleX
{
    //******************************************
    // 
    //
    // @Author: Kakashi
    // @Email: john.cha@qq.com
    // @Date: 2022-08-17 23:00
    //******************************************
    public interface IAssetBundleManager
    {
        ITaskWithResult<IAssetBundle> LoadAssetAsync(string path);
        
        void UnRef(IAssetBundle assetBundle);
    }
}