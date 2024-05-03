using UnityEngine;
using TMPro;

public class CountBaskets : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Add the GameObject which has TextMeshPro component of the score here")]
    private GameObject score;
    
    private int _initialScore;

    private TextMeshProUGUI _textMeshPro;
    private void Start()
    {
        var found = score.TryGetComponent(out _textMeshPro);
        Debug.Log(found ? "Found text in count basket" : "Did not find textMeshPro in count basket");
    }
    public void IncreaseScore()
    {
        _initialScore++;
        if (_textMeshPro != null)
        {
            _textMeshPro.text = _initialScore.ToString();
        }
    }
}
