using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class test2Rot : MonoBehaviour
{
    
    void Start()
    {
        var Tween = transform.DORotate(new Vector3(0, 0, 360), 1, RotateMode.LocalAxisAdd);
        var _ScaLe = transform.DOScale(Vector3.one * 0.5f, 1f);
        var Sen = DOTween.Sequence();
        Sen.Append(_ScaLe);
        Tween.SetLoops(-1);
        Tween.SetEase(Ease.Linear);

    }

    
}
