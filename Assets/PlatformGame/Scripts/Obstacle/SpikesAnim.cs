using UnityEngine;
using DG.Tweening;

public class SpikesAnim : MonoBehaviour
{
    [SerializeField] private float endValue;
    [SerializeField] private float duration;
    [SerializeField] private Ease ease;
    

    
    private void Start()
    {    
        transform.DOLocalMoveY(endValue, duration).SetEase(ease).SetLoops(-1, LoopType.Yoyo);  
     
    }
}
