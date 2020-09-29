﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinballruleEngine.Evaluator.GardenPointLexer
{
    public abstract class AbstractSyntaxTree
    {
        protected List<AbstractSyntaxTreeNode> rootNodes = new List<AbstractSyntaxTreeNode>();

        public List<AbstractSyntaxTreeNode> RootNodes
        {
            get { return rootNodes; }
            set { rootNodes = value; }
        }        
    }
}
