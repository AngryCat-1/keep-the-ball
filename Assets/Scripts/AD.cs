using UnityEngine;
using YG;
using System.Collections;

public class AD : MonoBehaviour
{
    [SerializeField]  YandexGame sdk;
    private void Start()
    {
        StartCoroutine(ShowAd());
    }

    IEnumerator ShowAd()
    {
        for (; ; )
        {
            sdk._FullscreenShow();
            yield return new WaitForSeconds(60);
        }
    }
}