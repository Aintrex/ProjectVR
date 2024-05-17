using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimOnce : MonoBehaviour
{
    private Animator animator;
    private float currentNormalizedTime = 0f; // ���������� ��� �������� �������� ������� ��������

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play("VagonAnim"); // ��������� ��������
    }

    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            // �������� ��������� ���� ���
            currentNormalizedTime = 1; // ��������� �������� ����� ��������
            animator.enabled = false; // ������������� ��������
        }
    }

    // ������� ��� ������������� �������� � ������������ �����
    public void ResumeAnimation()
    {
        animator.enabled = true; // �������� ��������
        animator.Play("VagonAnim", 0, currentNormalizedTime); // ������������� �������� � ������������ �������
    }
}
