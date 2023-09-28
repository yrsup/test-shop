using System.Collections;
using System.Collections.Generic;
using TestShop.Core;
using UnityEngine;
using TestShop.Shop.Ui;


namespace TestShop.Shop
{
    public class ShopController : MonoBehaviour
    {
        [SerializeField] private ShopConfig config;
        [SerializeField] ShopWindow shopWindow;
        private List<SpendableListener> spendableHandlers = new List<SpendableListener>();


        private void Start()
        {
            shopWindow.Initialize(config, TryBuyBundle, AddBuyCheat, RemoveBuyCheat);

            foreach (var item in config.Bundles)
            {
                var newHandler = new SpendableListener(item.PriceSpendable, () => OnValueChangedForBundle(item));
                spendableHandlers.Add(newHandler);
                newHandler.StartListen();
            }

            foreach (var avaialbleSpendable in config.AvailableSpendables)
            {
                var newHandler = new SpendableListener(avaialbleSpendable, () => OnSpendableUpdate(avaialbleSpendable));
                spendableHandlers.Add(newHandler);
                newHandler.StartListen();

            }
        }


        private void OnDestroy()
        {
            foreach (var item in spendableHandlers)
            {
                item.StopListen();
            }
        }


        private void TryBuyBundle(ShopBundleConfig targetBundle)
        {
            targetBundle.PriceSpendable.Spend(targetBundle.Price);
            foreach (var item in targetBundle.Rewards)
            {
                item.Consumer.Add(item.Vlaue);
            }
        }



        private void OnValueChangedForBundle(ShopBundleConfig targetBundle)
        {
            shopWindow.UpdateBundle(targetBundle);
        }


        private void AddBuyCheat(ISpendable spendable)
        {
            spendable.Spend(config.CheatStep);
        }


        private void RemoveBuyCheat(ISpendable spendable)
        {
            spendable.Spend(config.CheatStep);
        }


        private void OnSpendableUpdate(ISpendable spendable)
        {
            shopWindow.UpdateSpendableBar(spendable);
        }
    }
}
