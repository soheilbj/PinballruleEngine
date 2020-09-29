


using PinballruleEngine.Enum;
using System.Collections.Generic;

namespace PinballruleEngine.Evaluator
{
    public class DynamicBaseClass : System.Dynamic.DynamicObject
    {
        public string Name { get; set; }

        public string ReferenceName { get; set; }

        public ObjectType Type { get; set; }

        public List<dynamic> Fields = new List<dynamic>();
        public override bool TryGetMember(System.Dynamic.GetMemberBinder binder, out object result)
        {
            return base.TryGetMember(binder, out result);
        }
    }
}
