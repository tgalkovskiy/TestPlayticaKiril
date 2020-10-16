using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    [SerializeField] private Transform ButtomUp;
    [SerializeField] private Transform ButtomDonw;
    
    
    private void Up()
    {
        var tagertPosition= transform.up * 4;
        var durat = 2f;
        var sec = DOTween.Sequence();
        sec.Append(transform.DOMove(tagertPosition, durat));
    }

    private void Down()
    { 
        var tagertPosition= -transform.up * 4;
        var durat = 2f; 
        var sec = DOTween.Sequence();
       sec.Append(transform.DOMove(tagertPosition, durat));
    }
}
