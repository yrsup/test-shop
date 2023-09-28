using System.Collections.Generic;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Shop
{
    [CreateAssetMenu(fileName = "ShopConfig", menuName = "TestShop/Shop/Configs/ShopConfig", order = 100)]
    public class ShopConfig : ScriptableObject
    {
        [SerializeField] private List<ShopBundleConfig> configs = new List<ShopBundleConfig>();
        [SerializeReference, SelectImplementation(typeof(ISpendable))]
        private List<ISpendable> availableSpendables;

        [field: SerializeField] public int CheatStep { get; private set; } = 5;

        public List<ShopBundleConfig> Bundles => configs;
        public List<ISpendable> AvailableSpendables => availableSpendables;
    }
}