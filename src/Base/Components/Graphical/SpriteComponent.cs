﻿namespace PongBrain.Base.Components.Graphical {

/*-------------------------------------
 * USINGS
 *-----------------------------------*/

using Graphics.Shaders;
using Graphics.Textures;

/*-------------------------------------
 * CLASSES
 *-----------------------------------*/

public sealed class SpriteComponent {
    /*-------------------------------------
     * PUBLIC PROPERTIES
     *-----------------------------------*/

    public float LayerDepth { get; set; }

    public float ScaleX { get; set; } = 1.0f;

    public float ScaleY { get; set; } = 1.0f;

    public ITexture Texture { get; set; }
}

}
