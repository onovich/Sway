# Sway
Sway, a lightweight easing function library. <br/>
**Sway，轻量级的缓动函数库，取名自“摇”。**

![](https://github.com/onovich/Sway/blob/main/Assets/com.mortise.sway/Resource_Sample/spr_scr_shoot.png)

Sway provides easing functions, waveform functions, spline functions, which can be used for applications such as animations, trajectories, cameras, etc.<br/>
**Sway 提供缓动函数、波形函数、样条函数，可用于动画 / 轨迹 / 相机等应用。**

The project also provides a wealth of runtime examples.<br/>
**项目内也提供了丰富的运行时示例。**

# Unity Support
This library does not depend on the Unity Engine (but relies on [MortiseFrame.Abacus](https://github.com/onovich/MortiseFrame.Abacus)) and can be used for server-side or other projects that prohibit dependency on the Unity Engine.<br/>
**这个库不依赖 Unity Engine（而依赖 [MortiseFrame.Abacus](https://github.com/onovich/MortiseFrame.Abacus)）, 可用于服务端或者其他禁止依赖 Unity Engine 的项目。**

[MortiseFrame.Swing](https://github.com/onovich/MortiseFrame.Swing) is the predecessor of this library, which is also a version dependent on UnityEngine like the current library.<br/>
**[MortiseFrame.Swing](https://github.com/onovich/MortiseFrame.Swing) 是这个库的前身，它也是当前库的依赖 UnityEngine 版。**

You can also choose to use the MortiseFrame.Abacus extension library [MortiseFrame.AbacusExtension](https://github.com/onovich/MortiseFrame.AbacusExtension) as glue to stitch together Sway and the Unity Engine as needed.<br/>
**你也可以视需要选择用 MortiseFrame.Abacus 的扩展库 [MortiseFrame.AbacusExtension](https://github.com/onovich/MortiseFrame.AbacusExtension) 作为胶水，自己缝合 Sway 和 Unity Engine.**

# Enum
| Enum        | Members                                           |
|-------------|---------------------------------------------------|
| EasingMode  | None, EaseIn, EaseOut, EaseInOut                  |
| EasingType  | Linear, Sine, Quad, Cubic, Quart, Quint, Expo, Circ, Back, Elastic, Bounce |
| SplineType  | Bezier, CatmullRom, Hermite, BSpline              |

# Functions
| Static Class      | Static Function      | Args                                                                                   |
|-------------|----------------------|---------------------------------------------------------------------------------------------------|
| EasingHelper | EasingFColor         | FColor start, FColor end, float current, float duration, EasingType type, EasingMode mode = EasingMode.None |
| EasingHelper | EasingFColor32       | FColor32 start, FColor32 end, float current, float duration, EasingType type, EasingMode mode = EasingMode.None |
| EasingHelper | Easing2D             | FVector2 start, FVector2 end, float current, float duration, EasingType type, EasingMode mode = EasingMode.None |
| EasingHelper | Easing3D             | FVector3 start, FVector3 end, float current, float duration, EasingType type, EasingMode mode = EasingMode.None |
| EasingHelper | Easing               | float start, float end, float current, float duration, EasingType type, EasingMode mode = EasingMode.None |
| EasingHelper | EasingByte           | byte start, byte end, float current, float duration, EasingType type, EasingMode mode = EasingMode.None |
| SplineHelper | Easing               | FVector3 p0, FVector3 p1, FVector3 p2, FVector3 p3, float current, float duration, SplineType splineType |
| SplineHelper | CalculateSplineLength | FVector3 p0, FVector3 p1, FVector3 p2, FVector3 p3, SplineType splineType, int segments = 100         |
| WaveHelper   | EasingInWave         | float frequency, float amplitude, float current, float duration, float phase, WaveType waveType, EasingType type, EasingMode mode = EasingMode.None |
| WaveHelper   | EasingOutWave        | float frequency, float amplitude, float current, float duration, float phase, WaveType waveType, EasingType type, EasingMode mode = EasingMode.None |
| WaveHelper   | Wave                 | float frequency, float amplitude, float current, float phase, WaveType waveType                        |

# Sample
```
var timer = 10f;
Color color;
Vector2 pos;
float x;
float dt = 20f

while (timer > 0) {
    timer -= dt;
    color = EasingHelper.EasingColor(Color.black, Color.red, timer, 10f, EasingType.Sine, EasingMode.EaseInOut); 
    pos = EasingHelper.Easing2D(Vector2.zero, Vector2.one, timer, 10f, EasingType.Linear, EasingMode.None);
    x = EasingHelper.Easing(-1f, 1f, timer, 10f, EasingType.Back, EasingMode.EaseIn);
    Thread.Sleep(sleepTime);
}
```

# UPM URL
ssh://git@github.com/onovich/Sway.git?path=/Assets/com.mortise.sway#main

# UPM URL
ssh://git@github.com/onovich/Abacus.git?path=/Assets/com.mortise.abacus#main
