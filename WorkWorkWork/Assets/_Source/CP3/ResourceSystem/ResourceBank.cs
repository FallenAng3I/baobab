using System;
using System.Collections.Generic;
using CP3.ResourceSystem.Data;

namespace CP3.ResourceSystem
{
    public class ResourceBank
    {
        private const int _startResourceValue = 0;
        
        private Dictionary<ResourceType, Resource> _resources;
        
        public ResourceBank()
        {
            InitResource();
        }
        
        private static ResourceBank source = null;

        public static ResourceBank Source
        {
            get
            {
                if (source == null)
                    source = new();

                return source;
            }
        }

        private void InitResource()
        {
            for (int i = 0; i < Enum.GetValues(typeof(ResourceType)).Length; i++)
            {
                Resource newResource = new((ResourceType)i, _startResourceValue);
                _resources.Add((ResourceType)i, newResource);
            }
        }

        public bool TryGetResourceAmmount
            (ResourceType resourceType, out int resourceAmmount)
        {
            resourceAmmount = 0;
            if (_resources.ContainsKey(resourceType))
            {
                resourceAmmount = _resources[resourceType].ResourceAmmount;
                return true;
            }

            return false;
        }
    }
}
