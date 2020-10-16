using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class test3 : MonoBehaviour
{
    [SerializeField] private Transform Cart1;
    [SerializeField] private Transform Cart2;
    [SerializeField] private Button GetCard;
    [SerializeField] private Button ReversCard;
    [SerializeField] private Transform[] Tagert; 

    private void Start()
    {
        GetCard.onClick.AddListener(_Cart1);
        ReversCard.onClick.AddListener(_Cart2);
    }

    public void _Cart1()
    {
        var tagertPoscube = transform.up * 3;
        var durat = 1f;
        var Sec = DOTween.Sequence();
        Sec.Append(Cart1.DOMove(Tagert[0].position, durat));
        Sec.Join(Cart1.DOScale(Vector3.one * 2f, 0.3f));
        Sec.AppendInterval(1f);
        Sec.Append(Cart1.DOScale(Vector3.one, 0.3f));
        Sec.Join(Cart1.DOMove(Tagert[1].position, durat));
    }

    public void _Cart2()
    {
        var sec = DOTween.Sequence();
        Cart2.DORotate(new Vector3(0, 180, 0),2f, RotateMode.LocalAxisAdd);
        sec.Join(Cart2.DOScale(Vector3.one * 1.5f, 1f));
        sec.Append(Cart2.DOScale(Vector3.one, 1f));
    }
}
