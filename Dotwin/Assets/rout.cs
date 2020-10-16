using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class rout : MonoBehaviour
{
    [SerializeField] private Transform tagert;
    [SerializeField] private Transform[] points;
    [SerializeField] private Button PlayBat;
    [SerializeField] private Button StopPlay;

    private Tweener _tweener;

    private void Start()
    {
        PlayBat.onClick.AddListener(Play);
        StopPlay.onClick.AddListener(Stop);
    }

    // Start is called before the first frame update
    public void Play()
    {
        var path = new Vector3[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            path[i] = points[i].position;
        }

        tagert.DOPath(path, 5f);
    }

    private void Stop()
    {
        Debug.Log("!");
        _tweener.Pause();
       
    }
}
