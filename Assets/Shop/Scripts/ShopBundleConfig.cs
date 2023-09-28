using System.Collections.Generic;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Shop
{
    [CreateAssetMenu(fileName = "ShopBundleConfig", menuName = "TestShop/Shop/Configs/ShopBundleConfig", order = 100)]
    public class ShopBundleConfig : ScriptableObject
    {
        [SerializeReference, SelectImplementation(typeof(IReward))]
        private List<IReward> rewards = new List<IReward>();

        [SerializeReference, SelectImplementation(typeof(ISpendable))]
        private ISpendable priceSpendable;


        [field: SerializeField] public int Price { get; private set; }


        public List<IReward> Rewards => rewards;


        public ISpendable PriceSpendable => priceSpendable;
    }
}