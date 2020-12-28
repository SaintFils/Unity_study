using UnityEngine;

public class doorAnimation : MonoBehaviour
{
    private Animator _doorAnimator;

    private void Start()
    {
        _doorAnimator = GetComponent<Animator>();
    }

    public void openDoor()
    {
        _doorAnimator.SetTrigger("Open");
    }
}
