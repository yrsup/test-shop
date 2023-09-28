using System;
using System.Collections.Generic;
using TestShop.Core;
using UnityEngine;

namespace TestShop.Shop.Ui
{
    public class ShopWindow : MonoBehaviour
    {
        [SerializeField] private SpendableBar spendableBar;
        [SerializeField] private Transform spendableBarRoot;
        [SerializeField] private ShopBundleView shopBundleViewPrefab;
        [SerializeField] private Transform shopBundleViewRoot;

        private Dictionary<ShopBundleConfig, ShopBundleView> shopBundleViews = new Dictionary<ShopBundleConfig, ShopBundleView>();
        private Dictionary<ISpendable, SpendableBar> spendableBars = new Dictionary<ISpendable, SpendableBar>();


        public void Initialize(
            ShopConfig shopConfig, 
            Action<ShopBundleConfig> onTryBuy,
            Action<ISpendable> onAdd,
            Action<ISpendable> onRemove)
        {
            foreach (ShopBundleConfig item in shopConfig.Bundles)
            {
                CreateBundle(item);
            }

            foreach (ISpendable item in shopConfig.AvailableSpendables)
            {
                CreateSpendableBar(item);
            }


            void CreateBundle(ShopBundleConfig item)
            {
                ShopBundleView instance = Instantiate(shopBundleViewPrefab, shopBundleViewRoot);
                shopBundleViews.Add(item, instance);
                instance.Initialize(item, onTryBuy);
            }


            void CreateSpendableBar(ISpendable spendable)
            {
                SpendableBar instance = Instantiate(spendableBar, spendableBarRoot);
                instance.Initialize(spendable, onAdd, onRemove);
                spendableBars.Add(spendable, instance);
            }
        }


        public void UpdateBundle(ShopBundleConfig targetBundle)
        {
            shopBundleViews[targetBundle].UpdateView();
        }


        public void UpdateSpendableBar(ISpendable spendable)
        {
            spendableBars[spendable].UpdateCount();
        }
    }
}
