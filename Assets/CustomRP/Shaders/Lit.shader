// Unity built-in shader source. Copyright (c) 2016 Unity Technologies. MIT license (see license.txt)

// Unlit shader. Simplest possible textured shader.
// - no lighting
// - no lightmap support
// - no per-material color

Shader "Custom RP/Lit" {
Properties {
    _BaseMap("Texture", 2D) = "white" {}
    [MainColor] _BaseColor("Color", Color) = (1.0, 1.0, 1.0, 1.0)
}

SubShader {
    Tags { "LightMode" = "CustomLit"}
    LOD 100

    Pass 
    {
        HLSLPROGRAM

        #pragma vertex LitPassVertex
        #pragma fragment LitPassFragment
        #include "LitPass.hlsl"
        
        ENDHLSL
    }
}

}
