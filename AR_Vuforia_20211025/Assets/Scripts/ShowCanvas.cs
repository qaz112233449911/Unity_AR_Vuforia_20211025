using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiangWei
{
    /// <summary>
    /// 顯示畫布
    /// </summary>
    public class ShowCanvas : MonoBehaviour
    {
        [Header("畫布群組元件")]
        public CanvasGroup group;

       /// <summary>
       /// 開始淡入
       /// </summary>
        public void StartFade(float increase)
        {
            StartCoroutine(FadeCanvas(increase));
        }

        /// <summary>
        /// 畫布淡入 : 每隔0.1秒 添加0.1透明度執行十次
        /// </summary>
        /// <param name="increase">要增加得值，0.1淡入，-0.1淡出</param>
        /// <returns></returns>
        private IEnumerator FadeCanvas(float increase)
        {
            for(int i = 0; i < 10; i++)
            {
                group.alpha += increase;
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
