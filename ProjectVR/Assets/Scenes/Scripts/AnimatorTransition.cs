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
        // Подписываемся на событие окончания анимации первого аниматора
        AnimationClip[] animationClips = firstAnimator.runtimeAnimatorController.animationClips;

        foreach (AnimationClip clip in animationClips)
        {
            AnimationEvent animationEvent = new AnimationEvent();
            animationEvent.time = clip.length; // Вызываем событие в конце анимации

            animationEvent.functionName = "OnAnimationEnd"; // Вызываемый метод при окончании анимации
            clip.AddEvent(animationEvent);
        }
    }

    void OnAnimationEnd()
    {
        firstAnimator.SetTrigger("RotateFinish"); // Активируем триггер в первом аниматоре
    }

    public void OnTransitionComplete() // Метод, вызываемый по завершении перехода
    {
        Debug.Log("Transition to the second animator complete!");
        // Дополнительные действия после завершения перехода
    }
}
