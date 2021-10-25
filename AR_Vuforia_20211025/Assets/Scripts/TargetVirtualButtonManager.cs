using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace LiangWei
{
    /// <summary>
    /// �ϥd�ؼЪ��������s�޲z��
    /// </summary>
    public class TargetVirtualButtonManager : MonoBehaviour
    {
        [Header("�n��ť���������s")]
        public VirtualButtonBehaviour vbbHit;
        [Header("�n����ʵe����")]
        public Animator aniTarget;

        private void Start()
        {
            //�������s ���U���U��n���檺��k
            vbbHit.RegisterOnButtonPressed(PlayHitAnimation);
        }
        /// <summary>
        /// ����ʵe��k�A�������s���U�n���檺��k
        /// </summary>
        /// <param name="vbb">�������s���U�Ϊ��Ѽ�</param>
        private void PlayHitAnimation(VirtualButtonBehaviour vbb)
        {
            print(vbb.name);
        }
    }
}
