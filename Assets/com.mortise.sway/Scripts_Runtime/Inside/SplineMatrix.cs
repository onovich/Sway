using System;
using System.Collections.Generic;
using MortiseFrame.Abacus;

namespace MortiseFrame.Sway {

    public static class SplineMatrix {

        static readonly FMatrix4x4 BezierMatrix = new FMatrix4x4(
           new FVector4(1, 0, 0, 0),
           new FVector4(-3, 3, 0, 0),
           new FVector4(3, -6, 3, 0),
           new FVector4(-1, 3, -3, 1)
       );

        static readonly FMatrix4x4 HermiteMatrix = new FMatrix4x4(
            new FVector4(1, 0, 0, 0),
            new FVector4(0, 1, 0, 0),
            new FVector4(-3, -2, 3, -1),
            new FVector4(2, 1, -2, 1)
        );

        static readonly FMatrix4x4 CatmullRomMatrix = new FMatrix4x4(
            new FVector4(0, 2, 0, 0) * (1f / 2f),
            new FVector4(-1, 0, 1, 0) * (1f / 2f),
            new FVector4(2, -5, 4, -1) * (1f / 2f),
            new FVector4(-1, 3, -3, 1) * (1f / 2f)
       );


        static readonly FMatrix4x4 BSplineMatrix = new FMatrix4x4(
           new FVector4(1, 4, 1, 0) * (1f / 6f),
           new FVector4(-3, 0, 3, 0) * (1f / 6f),
           new FVector4(3, -6, 3, 0) * (1f / 6f),
           new FVector4(-1, 3, -3, 1) * (1f / 6f)
       );

        internal static FMatrix4x4 GetSplineMatrix(SplineType splineType) {
            switch (splineType) {
                case SplineType.Bezier:
                    return BezierMatrix;
                case SplineType.CatmullRom:
                    return CatmullRomMatrix;
                case SplineType.Hermite:
                    return HermiteMatrix;
                case SplineType.BSpline:
                    return BSplineMatrix;
                default:
                    throw new ArgumentException("Invalid spline type.", nameof(splineType));
            }
        }

    }

}