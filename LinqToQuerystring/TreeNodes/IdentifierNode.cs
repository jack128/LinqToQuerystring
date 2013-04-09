﻿namespace LinqToQuerystring.TreeNodes
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using Antlr.Runtime;

    using LinqToQuerystring.TreeNodes.Base;

    public class IdentifierNode : TreeNode
    {
        public IdentifierNode(Type inputType, IToken payload)
            : base(inputType, payload)
        {
        }

        public override Expression BuildLinqExpression(IQueryable query, Expression expression, Expression item)
        {
            return Expression.Property(item, this.Text);
        }
    }
}