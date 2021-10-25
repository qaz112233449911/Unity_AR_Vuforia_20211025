using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace LiangWei
{
    /// <summary>
    /// 圖卡目標的虛擬按鈕管理器
    /// </summary>
    public class TargetVirtualButtonManager : MonoBehaviour
    {
        [Header("要監聽的虛擬按鈕")]
        public VirtualButtonBehaviour vbbHit;
        [Header("要控制的動畫元件")]
        public Animator aniTarget;

        private void Start()
        {
            //虛擬按鈕 註冊按下後要執行的方法
            vbbHit.RegisterOnButtonPressed(PlayHitAnimation);
        }
        /// <summary>
        /// 播放動畫方法，虛擬按鈕按下要執行的方法
        /// </summary>
        /// <param name="vbb">虛擬按鈕註冊用的參數</param>
        private void PlayHitAnimation(VirtualButtonBehaviour vbb)
        {
            print(vbb.name);
        }
    }
}
