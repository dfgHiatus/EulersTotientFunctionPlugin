using FrooxEngine;
using FrooxEngine.LogiX;
using BaseX;

namespace TotientMod
{
    [NodeName("Euler's Totient Function")]
    [Category(new string[] { "LogiX/Operators" })]

    public sealed class EulersTotientFunction : LogixNode
    {
        public readonly Input<int> input;
        public readonly Output<int> output;

        protected override void OnEvaluate()
        {
            int result = 1;
            for (int i = 2; i < input.EvaluateRaw(); i++)
                if (MathX.GreatestCommonDivisor(i, input.EvaluateRaw()) == 1)
                    result++;
            output.Value = result;
        }
    }
}

