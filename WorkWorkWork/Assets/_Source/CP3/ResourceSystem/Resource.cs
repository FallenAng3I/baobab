using CP3.ResourceSystem.Data;

namespace CP3.ResourceSystem
{
    public class Resource
    {
        public int ResourceAmmount { get; private set; }
        public ResourceType ResourceType { get; private set; }

        public Resource(ResourceType resourceType, int startValue)
        {
            ResourceAmmount = startValue;
            ResourceType = resourceType;
        }
    }
}
