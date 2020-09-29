using System;
using System.Collections.Generic;
using System.Text;

namespace PinballruleEngine.RuleEngine
{
    public class StatusTransition
    {
        public State Status_ { get; set; }

        public bool Marked
        {
            get;
            set;
        }

        public StatusTransition(State transitionStatus)
        {
            this.Status_ = transitionStatus;
        }
    }
}
