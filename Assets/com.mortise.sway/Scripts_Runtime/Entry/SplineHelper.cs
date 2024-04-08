using System;
using MortiseFrame.Abacus;

namespace MortiseFrame.Sway {

    public static class SplineHelper {

        public static FVector3 Easing(FVector3 p0, FVector3 p1, FVector3 p2, FVector3 p3, float current, float duration, SplineType splineType) {
            if (duration <= 0f) {
                throw new ArgumentException("Duration Must Be Greater Than Zero.", nameof(duration));
            }

            var t = current / duration;
            t = FMath.Clamp01(t);

            FMatrix4x4 splineMatrix = SplineMatrix.GetSplineMatrix(splineType);

            FVector4 T = new FVector4(1, t, t * t, t * t * t);
            FVector4 Px = new FVector4(p0.x, p1.x, p2.x, p3.x);
            FVector4 Py = new FVector4(p0.y, p1.y, p2.y, p3.y);
            FVector4 Pz = new FVector4(p0.z, p1.z, p2.z, p3.z);

            float x = FVector4.Dot(splineMatrix * T, Px);
            float y = FVector4.Dot(splineMatrix * T, Py);
            float z = FVector4.Dot(splineMatrix * T, Pz);

            return new FVector3(x, y, z);
        }

        public static float CalculateSplineLength(FVector3 p0, FVector3 p1, FVector3 p2, FVector3 p3, SplineType splineType, int segments = 100) {
            float length = 0f;
            FVector3 prevPoint = Easing(p0, p1, p2, p3, 0, 1, splineType);
            FVector3 nextPoint;

            for (int i = 1; i <= segments; i++) {
                nextPoint = Easing(p0, p1, p2, p3, i, segments, splineType);
                length += FVector3.Distance(prevPoint, nextPoint);
                prevPoint = nextPoint;
            }

            return length;
        }

    }

}