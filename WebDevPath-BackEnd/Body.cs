using System;
namespace WebDevPath_BackEnd
{
    public class Body
    {
        public Head Head { get; set; } = new Head();
        public List<Arm> Arms { get; set; } = new List<Arm>();
        public List<Leg> Legs { get; set; } = new List<Leg>();
    }
}

