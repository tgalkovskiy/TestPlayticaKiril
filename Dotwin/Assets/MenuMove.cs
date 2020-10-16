using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MenuMove : MonoBehaviour
{
    [SerializeField] private Transform centerpoint;
    [SerializeField] private Transform pausepoint;
    [SerializeField] private Transform PlayButtom;
    private bool ispause;
    private float pauseTartposY;
    void Start()
    {
        pauseTartposY = pausepoint.position.y;
    }

    public void ShowPausePanel()
    {
        var posY = ispause ? pauseTartposY : centerpoint.position.y;
        pausepoint.DOMoveY(posY, 1f);

        var scale = ispause ? Vector3.zero : Vector3.one;
        pausepoint.DOScale(scale, 1f);
        if (ispause)
        {
            var sequinz = DOTween.Sequence();
            sequinz.Append(PlayButtom.DOScale(Vector3.one, 0.5f));
            sequinz.Append(PlayButtom.DOShakeRotation(
                0.3f, new Vector3(0f, 0f, 30f), 20, 40));
        }
        else
        {
            PlayButtom.DOScale(Vector3.zero, 0.5f);
        }
            
    }
}
