using UnityEngine;

namespace CP3.ResourceSystem
{
    public sealed class ResourceBankSingleton : MonoBehaviour
    {
        private ResourceBankSingleton()
        {
        }

        private static ResourceBankSingleton source = null;

        public static ResourceBankSingleton Source
        {
            get
            {
                if (source == null)
                    source = new();

                return source;
            }
        }
    }
}
