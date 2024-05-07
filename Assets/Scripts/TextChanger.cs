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

        sequence.Append(_text1.DOText("Я заменил этот текст", _duration));
        sequence.Append(_text1.DOText(". Это дополнение к тексту", _duration).SetRelative());
        sequence.Append(_text1.DOText("Я взломал этот текст", _duration, true, ScrambleMode.All));
    }
}