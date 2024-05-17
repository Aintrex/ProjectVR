using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimOnce : MonoBehaviour
{
    private Animator animator;
    private float currentNormalizedTime = 0f; // Переменная для хранения текущего времени анимации

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play("VagonAnim"); // Запускаем анимацию
    }

    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            // Анимация проиграна один раз
            currentNormalizedTime = 1; // Сохраняем конечное время анимации
            animator.enabled = false; // Останавливаем анимацию
        }
    }

    // Функция для возобновления анимации с сохраненного места
    public void ResumeAnimation()
    {
        animator.enabled = true; // Включаем анимацию
        animator.Play("VagonAnim", 0, currentNormalizedTime); // Воспроизводим анимацию с сохраненного времени
    }
}
