using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence().SetLoops(_repeats, _loopType);

        sequence.Append(_text1.DOText("� ������� ���� �����", _duration));
        sequence.Append(_text1.DOText(". ��� ���������� � ������", _duration).SetRelative());
        sequence.Append(_text1.DOText("� ������� ���� �����", _duration, true, ScrambleMode.All));
    }
}