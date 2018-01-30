using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimitiveCalculator
{
    private IStrategy strategy;
    private Dictionary<char, IStrategy> operators = new Dictionary<char, IStrategy>()
    {
        { '+', new AdditionStrategy() },
        { '-', new SubtractionStrategy() },
        { '*', new MultiplyStrategy() },
        { '/', new DivideStrategy() },
    };

    public PrimitiveCalculator(IStrategy strategy)
    {
        this.strategy = strategy; // DI default strategy 
    }

    public PrimitiveCalculator()
    {
        this.strategy = this.operators['+']; // default strategy 
    }

    public void changeStrategy(char @operator)
    {
        this.strategy = this.operators[@operator];
    }

    public int performCalculation(int firstOperand, int secondOperand)
    {
        return this.strategy.Calculate(firstOperand, secondOperand);
    }
}

