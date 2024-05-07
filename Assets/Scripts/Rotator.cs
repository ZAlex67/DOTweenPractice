using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration;
    [SerializeField] private RotateMode _rotateMode;

    private void Start()
    {
        transform.DORotate(_rotation, _duration, _rotateMode);
    }
}