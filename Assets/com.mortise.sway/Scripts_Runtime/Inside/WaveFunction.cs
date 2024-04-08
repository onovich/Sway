using System;
using MortiseFrame.Abacus;

namespace MortiseFrame.Sway {

    internal static class WaveFunction {

        // 正弦波
        internal static float SineWave(float frequency, float amplitude, float current, float phase) {
            return amplitude * (float)FMath.Sin(2 * FMath.PI * (frequency * current) + phase);
        }

        // 方波
        internal static float SquareWave(float frequency, float amplitude, float current, float phase) {
            return amplitude * FMath.Sign(FMath.Sin(2 * FMath.PI * (frequency * current) + phase));
        }

        // 锯齿波
        internal static float SawtoothWave(float frequency, float amplitude, float current, float phase) {
            float t = (frequency * current + phase / (2 * FMath.PI)) % 1;
            return amplitude * (2 * t - 1);
        }

        // 三角波
        internal static float TriangleWave(float frequency, float amplitude, float current, float phase) {
            float t = (frequency * current + phase / (2 * FMath.PI)) % 1;
            return amplitude * (4 * FMath.Abs(t - 0.5f) - 1);
        }


    }

}

