using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOScale(_scale, _duration);
    }
}