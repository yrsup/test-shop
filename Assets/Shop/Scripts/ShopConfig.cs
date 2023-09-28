using System.Collections.Generic;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Shop
{
    [CreateAssetMenu(fileName = "ShopConfig", menuName = "TestShop/Shop/Configs/ShopConfig", order = 100)]
    public class ShopConfig : ScriptableObject
    {
        [SerializeField] List<ShopBundleConfig> configs = new List<ShopBundleConfig>();


        public List<ShopBundleConfig> Bundles => configs;
    }
}