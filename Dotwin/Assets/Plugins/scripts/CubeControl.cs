using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    public void PlayAnimation()
    {
        var tagertPoscube = transform.up * 3;
        var durat = 1f;
        var eulerangel = new  Vector3(0,180,0);
        var sec = DOTween.Sequence();
        sec.Append(transform.DOMove(tagertPoscube, durat));
        sec.Join(transform.DORotate(eulerangel, durat));
        sec.AppendInterval(0.5f);
        sec.Append(transform.DOScale(Vector3.one * 0.75f, 0.3f));
        sec.Append((transform.DOScale(Vector3.one * 1.5f, 1f)));
        sec.Join(transform.DORotate(eulerangel, 1f, RotateMode.LocalAxisAdd));
        sec.Append(transform.DOScale(Vector3.one, 0.2f));
        
    }

    
    
    
    
}
