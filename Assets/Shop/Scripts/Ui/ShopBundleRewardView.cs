using TestShop.Core;
using UnityEngine;
using TMPro;

namespace TestShop.Shop.Ui
{
    public class ShopBundleRewardView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI rewardNameText;
        [SerializeField] private TextMeshProUGUI rewardCountText;



        public void Initialize(IReward reward)
        {
            rewardNameText.text = reward.GetType().Name;
            rewardCountText.text = reward.Vlaue.ToString();
        }
    }
}
