using TestShop.Core;
using UnityEngine;
using TMPro;

namespace TestShop.Shop
{
    public class ShopBundleRewardView : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI rewardNameText;
        [SerializeField] TextMeshProUGUI rewardCountText;



        public void Initialize(IReward reward)
        {
            rewardNameText.text = reward.GetType().Name;
            rewardCountText.text = reward.Vlaue.ToString();
        }
    }
}
