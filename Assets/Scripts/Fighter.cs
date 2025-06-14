using UnityEngine;

public class Fighter : MonoBehaviour
{
    [SerializeField]
    private Health _health;
    [SerializeField]
    private Animator _characterAnimator;
    [SerializeField]
    private Attacks _attacks;
    [SerializeField]
    private bool _isActive = false;
    private bool IsActive => _isActive;
    public Health Health=> _health;
    public Attacks Attacks => _attacks;
    
}
