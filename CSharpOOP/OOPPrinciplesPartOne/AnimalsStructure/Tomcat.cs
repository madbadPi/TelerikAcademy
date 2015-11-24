namespace AnimalsStructure
{
    using System;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(string tomcattName, int tomcattAge)
            : base(tomcattName, tomcattAge, Sex.male)
        {
        }
    }
}
