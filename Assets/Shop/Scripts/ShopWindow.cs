using System;
using System.Collections.Generic;
using UnityEngine;

namespace TestShop.Shop
{
    public class ShopWindow : MonoBehaviour
    {
        [SerializeField] ShopBundleView shopBundleViewPrefab;
        [SerializeField] Transform shopBundleViewRoot;

        private List<ShopBundleView> shopBundleViews = new List<ShopBundleView>();


        public void Initialize(ShopConfig shopConfig, Action<ShopBundleConfig> onTryBuy)
        {
            foreach (ShopBundleConfig item in shopConfig.Bundles)
            {
                CreateBundle(item);
            }


            void CreateBundle(ShopBundleConfig item)
            {
                ShopBundleView instance = Instantiate(shopBundleViewPrefab, shopBundleViewRoot);
                shopBundleViews.Add(instance);
                instance.Initialize(item, onTryBuy);
            }
        }


        public void Show()
        {

        }


        public void UpdateItems()
        {
            foreach (ShopBundleView shopBundleView in shopBundleViews)
            {
                shopBundleView.UpdateView();
            }
        }
    }
}
