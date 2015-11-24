namespace VersionAttribute
{
    using System;
    [AttributeUsage(AttributeTargets.Struct | 
        AttributeTargets.Class | 
        AttributeTargets.Interface | 
        AttributeTargets.Enum |
        AttributeTargets.Method)]

    class VersionAttribute : Attribute
    {
        public string Version { get; private set; } 

        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public override string ToString()
        {
            return this.Version;
        }

    }
}
