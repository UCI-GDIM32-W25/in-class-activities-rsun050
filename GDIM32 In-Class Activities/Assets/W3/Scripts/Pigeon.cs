using UnityEngine;

public enum MovementState {
    Idle, Flying
}

public class Pigeon : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    // (1) add a member variable to represent the Pigeon's state
    [SerializeField] private MovementState _state = MovementState.Idle; // SFing it so i can see it in inspector :P

    void Update()
    {
        UpdateState();
        UpdateAppearance();
    }

    // (2) fill in this method to update the pigeon's state based on input
    // if the player is pressing the 'A' key, the state should be set to Flying
    // - otherwise, it should be Idle
    private void UpdateState ()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _state = MovementState.Flying;
        } else {
            _state = MovementState.Idle;
        }
    }

    // (3) fill in this method to update the pigeon's animation based on its state
    // based on whether the player is Flying or Idling, use the given methods PlayFlyAnimation and PlayIdleAnimation
    // to play the correct animation
    // use a Switch statement!
    private void UpdateAppearance()
    {
        switch(_state)
        {
            case MovementState.Idle:
                PlayIdleAnimation();
                break;
            case MovementState.Flying:
                PlayFlyAnimation();
                break;
        }
    }

    private void PlayFlyAnimation () {
        _animator.SetBool("isFlying", true);
    }

    private void PlayIdleAnimation () {
        _animator.SetBool("isFlying", false);
    }
}
