using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;
    [SerializeField] private float _duration;

    private void Start()
    {
        _text1.DOText("� ������� ���� �����", _duration);
        _text2.DOText(". ��� ���������� � ������", _duration).SetRelative();
        _text3.DOText("� ������� ���� �����", _duration, true, ScrambleMode.All);
    }
}