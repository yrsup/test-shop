using System.Collections.Generic;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Shop
{
    [CreateAssetMenu(fileName = "ShopBundleConfig", menuName = "TestShop/Shop/Configs/ShopBundleConfig", order = 100)]
    public class ShopBundleConfig : ScriptableObject
    {
        [SerializeReference, SelectImplementation(typeof(IReward))]
        List<IReward> rewards = new List<IReward>();

        [SerializeReference, SelectImplementation(typeof(ISpendable))]
        ISpendable priceSpendable;


        [field: SerializeField] public int Price { get; private set; }


        public List<IReward> Rewards => rewards;


        public ISpendable PriceSpendable => priceSpendable;
    }
}