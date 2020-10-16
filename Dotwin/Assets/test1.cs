using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class test1 : MonoBehaviour
{
    [SerializeField] private Transform ButtomUp;

    [SerializeField] private Transform ButtomDown;

    [SerializeField] private Button _Up;
    [SerializeField] private Button _Down;

    private float tagertposY = 6f;
    // Start is called before the first frame update
    void Start()
    {
        _Up.onClick.AddListener(Up);
        _Down.onClick.AddListener(Dow);
    }

    private void Up()
    {
        ButtomUp.DOMoveY(tagertposY, 1f);
    }

    private void Dow()
    {
        ButtomDown.DOMoveX(tagertposY, 1f);
    }
    
}
