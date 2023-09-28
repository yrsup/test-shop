using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestShop.Shop
{
    public class ShopController : MonoBehaviour
    {
        [SerializeField] ShopConfig config;
        [SerializeField] ShopWindow shopWindow;


        private void TryBuyBundle(ShopBundleConfig targetBundle)
        {
            targetBundle.PriceSpendable.Spend(targetBundle.Price);
        }



        private void Start()
        {
            shopWindow.Initialize(config, TryBuyBundle);
        }
    }
}
