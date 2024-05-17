using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTransition : MonoBehaviour
{
    public Animator firstAnimator;
    public string triggerParameterName;
    public Animator secondAnimator;

    void Start()
    {
        // ������������� �� ������� ��������� �������� ������� ���������
        AnimationClip[] animationClips = firstAnimator.runtimeAnimatorController.animationClips;

        foreach (AnimationClip clip in animationClips)
        {
            AnimationEvent animationEvent = new AnimationEvent();
            animationEvent.time = clip.length; // �������� ������� � ����� ��������

            animationEvent.functionName = "OnAnimationEnd"; // ���������� ����� ��� ��������� ��������
            clip.AddEvent(animationEvent);
        }
    }

    void OnAnimationEnd()
    {
        firstAnimator.SetTrigger("RotateFinish"); // ���������� ������� � ������ ���������
    }

    public void OnTransitionComplete() // �����, ���������� �� ���������� ��������
    {
        Debug.Log("Transition to the second animator complete!");
        // �������������� �������� ����� ���������� ��������
    }
}
