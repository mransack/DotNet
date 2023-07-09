using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class ExpressionTree
    {
        public void DemoExpression() {
            Expression<Func<int, int, int>> addExpression = (a, b) => a + b;
            BinaryExpression body = (BinaryExpression)addExpression.Body;
            ParameterExpression left = (ParameterExpression)body.Left;
            ParameterExpression right = (ParameterExpression)body.Right;

            Console.WriteLine("Expression: {0} + {1}", left.Name, right.Name);
            Func<int, int, int> addFunc = addExpression.Compile();
            int result = addFunc(5, 6);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
