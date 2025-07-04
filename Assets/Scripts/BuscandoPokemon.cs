using UnityEngine;
using UnityEngine.UI;

public class BuscandoPokemon : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private Text _text;
    [SerializeField]
    private string _appearAnimationName = "BuscandoPokemonAppear";
    [SerializeField]
    private string _showAnimationName = "ShowBuscandoPokemon";
    [SerializeField]
    private string _hideAnimationName = "HideBuscandoPokemon";

    public void BuscandoPokemonAppear()
    {
        _animator.Play(_appearAnimationName);
        transform.position = Camera.main.WorldToScreenPoint(transform.position);
    }
    public void ShowBuscandoPokemon()
    {
        _animator.Play(_showAnimationName);
        transform.position = Camera.main.WorldToScreenPoint(transform.position);
    }
    
    public void HideBuscandoPokemon()
    {
        _animator.Play(_hideAnimationName);
        transform.position = Camera.main.WorldToScreenPoint(transform.position);
    }
}
