using UnityEngine;

namespace code.UI
{
    public class ShowGalleryBox : MonoBehaviour
    {
        public PlayAnimBox animBox;
        
        public bool ending1N = false;
        public bool ending1S = false;
        public bool ending1P = false;
        public bool ending2 = false;
        public bool ending3 = false;
        public bool ending4 = false;

        public void Start()
        {
            if (ending1N)
            {
                animBox.gameObject.SetActive(Gallery.ending1N);
            }

            if (ending1S)
            {
                animBox.gameObject.SetActive(Gallery.ending1S);
            }

            if (ending1P)
            {
                animBox.gameObject.SetActive(Gallery.ending1P);
            }

            if (ending2)
            {
                animBox.gameObject.SetActive( Gallery.ending2);
            }

            if (ending3)
            {
                animBox.gameObject.SetActive(Gallery.ending3);
            }

            if (ending4)
            {
                animBox.gameObject.SetActive(Gallery.ending4);
            }
        }

        public void OnValidate()
        {
            animBox = GetComponentInChildren<PlayAnimBox>();
        }
    }
}