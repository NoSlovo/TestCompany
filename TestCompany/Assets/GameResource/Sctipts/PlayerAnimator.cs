using UnityEngine;

namespace GameResource.Sctipts
{
    [RequireComponent(typeof(Animator))]
    public class PlayerAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        
        private readonly int _idle = Animator.StringToHash("Idle");
        private readonly int _fastRun = Animator.StringToHash("FastRun");
        private readonly int _iRun = Animator.StringToHash("IRin");

        public void Move() => _animator.SetBool(_iRun, true);
        public void StopMove() => _animator.SetBool(_iRun, false);

    }
}
