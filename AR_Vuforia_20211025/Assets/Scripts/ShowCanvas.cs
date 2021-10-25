using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiangWei
{
    /// <summary>
    /// ��ܵe��
    /// </summary>
    public class ShowCanvas : MonoBehaviour
    {
        [Header("�e���s�դ���")]
        public CanvasGroup group;

       /// <summary>
       /// �}�l�H�J
       /// </summary>
        public void StartFade(float increase)
        {
            StartCoroutine(FadeCanvas(increase));
        }

        /// <summary>
        /// �e���H�J : �C�j0.1�� �K�[0.1�z���װ���Q��
        /// </summary>
        /// <param name="increase">�n�W�[�o�ȡA0.1�H�J�A-0.1�H�X</param>
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
