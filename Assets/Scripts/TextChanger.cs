using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        _text1.DOText("� ������� ���� �����", _duration).SetLoops(_repeats, _loopType);
        _text2.DOText(". ��� ���������� � ������", _duration).SetLoops(_repeats, _loopType);
        _text3.DOText("� ������� ���� �����", _duration, true, ScrambleMode.All).SetLoops(_repeats, _loopType);
    }
}