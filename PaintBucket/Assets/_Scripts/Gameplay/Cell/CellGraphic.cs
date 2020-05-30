using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CellGraphic :  SerializedMonoBehaviour
{
    [SerializeField]
    public Button button;

    [SerializeField]
    private Image _cellImage;
    [SerializeField]
    private Cell _cell;

    public int currentColor { get; private set; }


    private Coroutine _coloringCoroutine;

    private void SetColor (Color32 _color)
    {
        _cellImage.color = _color;
    }

    public void SetColorFromPalette(int colorId, CellAnimationType _animationType = CellAnimationType.None)
    {
        if (_coloringCoroutine != null)
        {
            StopCoroutine(_coloringCoroutine);
        }
        _coloringCoroutine = StartCoroutine(ColoringCoroutine(colorId, _animationType));
    }

    private IEnumerator ColoringCoroutine(int colorId, CellAnimationType _animationType)
    {
        if (_animationType == CellAnimationType.None)
        {
            currentColor = colorId;
            SetColor(Gameplay.ColorPalette[currentColor]);
            yield break;
        }
        else if (_animationType == CellAnimationType.ToColor)
        {
            currentColor = colorId;
            _cellImage.DOColor(Gameplay.ColorPalette[currentColor], Gameplay.ANIMATION_TIME);
        }
        else if (_animationType == CellAnimationType.ToColorAndBack)
        {
            _cellImage.DOColor(Gameplay.ColorPalette[colorId], Gameplay.ANIMATION_TIME);
            yield return new WaitForSeconds(Gameplay.ANIMATION_TIME);
            _cellImage.DOColor(Gameplay.ColorPalette[currentColor], Gameplay.ANIMATION_TIME);

        }


        yield return null;
    }
    
}

public enum CellAnimationType
{
    None,
    ToColor,
    ToColorAndBack,
}
