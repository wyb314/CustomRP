#ifndef CUSTOM_UNITY_INPUT_INCLUDED
#define CUSTOM_UNITY_INPUT_INCLUDED

///////////////////////////////////////////////////////////////////////////////
// Transformations                                                            /
///////////////////////////////////////////////////////////////////////////////
float4x4 unity_MatrixV;
float4x4 unity_MatrixP;
float4x4 unity_MatrixVP;

float4x4 unity_MatrixInvV;
float4x4 unity_MatrixInvP;
float4x4 unity_MatrixInvVP;

float4x4 unity_prev_MatrixM;
float4x4 unity_prev_MatrixIM;
float4x4 glstate_matrix_projection;


///////////////////////////////////////////////////////////////////////////////
// Per-object variable                                                        /
///////////////////////////////////////////////////////////////////////////////
// Block Layout should be respected due to SRP Batcher
CBUFFER_START(UnityPerDraw)
// Space block Feature
float4x4 unity_ObjectToWorld;
float4x4 unity_WorldToObject;
float4 unity_LODFade; // x is the fade value ranging within [0,1]. y is x quantized into 16 levels
half4 unity_WorldTransformParams; // w is usually 1.0, or -1.0 for odd-negative scale transforms

CBUFFER_END

#endif