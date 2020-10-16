using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class test1 : MonoBehaviour
{
    [SerializeField] private Transform ButtomUp;
    [SerializeField] private Transform[] Pos;
    [SerializeField] private Transform ButtomDown;

    [SerializeField] private Button _Up;
    [SerializeField] private Button _Down;
    
    // Start is called before the first frame update
    void Start()
    {
        _Up.onClick.AddListener(Up);
        _Down.onClick.AddListener(Dow);
    }

    private void Up()
    {
        ButtomUp.DOMove(Pos[0].position, 1f);
        var Sen = DOTween.Sequence();
        Sen.Append(ButtomUp.DOScale(Vector3.one * 0.5f, 1));
    }

    private void Dow()
    {
        ButtomDown.DOMove(Pos[1].position, 1f);
        var Sen = DOTween.Sequence();
        Sen.Append(ButtomDown.DOScale(Vector3.one * 0.5f, 1));
    }
    
}
