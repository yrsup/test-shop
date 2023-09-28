using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TestShop.Shop
{
    public class ShopBundleView : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI bundleName;
        [SerializeField] ShopBundleRewardView shopBundleRewardView;
        [SerializeField] Transform shopBundleRewarRoot;
        [SerializeField] Button buyButton;
        List<ShopBundleRewardView> rewardViewsInstances = new List<ShopBundleRewardView>();


        public void Initialize(ShopBundleConfig bundleConfig, Action<ShopBundleConfig> tryBuy)
        {
            bundleName.text = bundleConfig.name;
            foreach (Core.IReward item in bundleConfig.Rewards)
            {
                CreateReward(item);
            }
            buyButton.onClick.RemoveAllListeners();
            buyButton.onClick.AddListener(() => tryBuy?.Invoke(bundleConfig));

            //bundleConfig.Price


            void CreateReward(Core.IReward reward)
            {
                var instance = Instantiate(shopBundleRewardView, shopBundleRewarRoot);
                rewardViewsInstances.Add(instance);
                instance.Initialize(reward);
            }
        }


        public void UpdateView()
        {

        }
    }
}
