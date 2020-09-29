using System;
using System.Collections.Generic;
using System.Text;

namespace PinballruleEngine.Parser
{
    public class State
    {
        public List<StatusTransition> StatusTransitions_ { get; set; } = new List<StatusTransition>();

        public bool IsErrorState { get; set; }

        public bool IsPreviewEndeState { get; set; }

        public bool IsFirstPosition { get; set; }

        public int Number { get; set; }

        public string Value { get; set; }

        public State(int number, string value, bool isErrorState = false, bool isFirstPosition = false)
        {
            this.Value = value;
            this.IsFirstPosition = isFirstPosition;
            this.Number = number;
            this.IsErrorState = isErrorState;
        }

        public State Check(char value, StateMachine stateMaschine)
        {
            foreach (StatusTransition statusTransition in StatusTransitions_)
            {
                if (statusTransition.Status_.Value == value.ToString())
                {
                    return statusTransition.Status_;
                }
                else if (statusTransition.Status_.Value == LexerItems.QuestionMark.ToString())
                {
                    return statusTransition.Status_;
                }
                else if (statusTransition.Status_.Value == LexerItems.Percent.ToString())
                {
                    if (statusTransition.Status_.StatusTransitions_[0].Status_.Value != "Ende")
                    {
                        State returnState = statusTransition.Status_.Check(value, stateMaschine);
                        if (!returnState.IsErrorState)
                        {
                            return returnState;
                        }
                    }
                    else
                    {
                        return new State(-1, "End", false);
                    }
                }
            }
            return new State(-1, "Error", true);
        }
    }
}
