using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TestShop.Shop.Ui
{
    public class ShopBundleView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI bundleNameLabel;
        [SerializeField] private ShopBundleRewardView shopBundleRewardView;
        [SerializeField] private Transform shopBundleRewarRoot;
        [SerializeField] private Button buyButton;
        private List<ShopBundleRewardView> rewardViewsInstances = new List<ShopBundleRewardView>();


        public ShopBundleConfig ShopBundleConfig {get; private set;}


        public void Initialize(ShopBundleConfig bundleConfig, Action<ShopBundleConfig> tryBuy)
        {
            ShopBundleConfig = bundleConfig;
            bundleNameLabel.text = bundleConfig.name;
            foreach (Core.IReward item in bundleConfig.Rewards)
            {
                CreateReward(item);
            }
            buyButton.onClick.RemoveAllListeners();
            buyButton.onClick.AddListener(() => tryBuy?.Invoke(bundleConfig));
            UpdateView();


            void CreateReward(Core.IReward reward)
            {
                var instance = Instantiate(shopBundleRewardView, shopBundleRewarRoot);
                rewardViewsInstances.Add(instance);
                instance.Initialize(reward);
            }
        }


        public void UpdateView()
        {
            bool canBuy = ShopBundleConfig.Price < ShopBundleConfig.PriceSpendable.Count;
            buyButton.interactable = canBuy;
        }
    }
}
