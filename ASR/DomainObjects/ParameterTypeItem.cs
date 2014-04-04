﻿using Sitecore.Data.Items;

namespace ASR.DomainObjects
{
    
    public class ValueItem:BaseItem
    {
        public ValueItem(Item innerItem) : base(innerItem)
        {
            Value = innerItem["value"];
        }

        public string Value
        {
            get;
            private set;
        }
    }
}
