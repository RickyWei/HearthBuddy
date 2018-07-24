﻿namespace Triton.Bot.Profiles
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public abstract class ConditionalProfileGroupElement : ProfileGroupElement
    {
        private string _condition;
        private Func<bool> _conditionExpression;

        protected ConditionalProfileGroupElement()
        {
        }

        [XmlIgnore]
        public bool Condition
        {
            get
            {
                return this._conditionExpression();
            }
        }

        [XmlAttribute("Condition")]
        public string ConditionString
        {
            get
            {
                return this._condition;
            }
            set
            {
                if (value != this._condition)
                {
                    this._condition = value;
                    this._conditionExpression = ProfileScripting.GetCondition(value);
                }
            }
        }
    }
}

