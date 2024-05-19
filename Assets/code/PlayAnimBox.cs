using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace code
{
    public class PlayAnimBox : MonoBehaviour
    {
        public Animator animator;
        public string animatorName;

        public void Awake()
        {
            animator.Play(animatorName);
        }

        [Button]
        public void AddData()
        {
            animator = GetComponent<Animator>();
            gameObject.name = animatorName;
        }
    }
}