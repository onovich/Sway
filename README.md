# Sway
Sway, a lightweight easing function library. <br/>
**Sway，轻量级的缓动函数库，取名自“摇”。**

![](https://github.com/onovich/Sway/blob/main/Assets/com.mortise.sway/Resource_Sample/spr_scr_shoot.png)

# Unity Support
This library does not depend on the Unity Engine (but relies on [MortiseFrame.Abacus](https://github.com/onovich/MortiseFrame.Abacus)) and can be used for server-side or other projects that prohibit dependency on the Unity Engine.<br/>
**这个库不依赖 Unity Engine（而依赖 [MortiseFrame.Abacus](https://github.com/onovich/MortiseFrame.Abacus)）, 可用于服务端或者其他禁止依赖 Unity Engine 的项目。**

[MortiseFrame.Swing](https://github.com/onovich/MortiseFrame.Swing) is the predecessor of this library, which is also a version dependent on UnityEngine like the current library.<br/>
**[MortiseFrame.Swing](https://github.com/onovich/MortiseFrame.Swing) 是这个库的前身，它也是当前库的依赖 UnityEngine 版。**

You can also choose to use the MortiseFrame.Abacus extension library [MortiseFrame.AbacusExtension](https://github.com/onovich/MortiseFrame.AbacusExtension) as glue to stitch together Sway and the Unity Engine as needed.<br/>
**你也可以视需要选择用 MortiseFrame.Abacus 的扩展库 [MortiseFrame.AbacusExtension](https://github.com/onovich/MortiseFrame.AbacusExtension) 作为胶水，自己缝合 Sway 和 Unity Engine.**

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
