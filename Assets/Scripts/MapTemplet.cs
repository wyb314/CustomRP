/*************************************************************************/
//  MapTemplet.cs                                                   	
/*************************************************************************/
/*                          The file is part of:                         */
/*                              Dev Center                               */
/*************************************************************************/
/*                        Author：Chico(wuyuanbing)                      */
/*                 	Creation Time：2024/8/15 14:16:21                    */
/*************************************************************************/
/*                    			Descriptions:   			             */
/*                    				TODO:		   			          	 */
/*************************************************************************/
/*  						   Copyright （C）:   		                 */
/*                    		   CenturyGames		   			             */
/*************************************************************************/
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "MapTemplet", menuName = "ScriptableObjects/MapTemplet", order = 1)]
public class MapTemplet : SerializedScriptableObject
{
    [BoxGroup("程序化生成设置")][HorizontalGroup("程序化生成设置/1")][LabelText("岛屿高度")][ProgressBar(0, 10, Segmented = true)][DisableIf("mapAsset")] public int islandHeight = 3;
    [BoxGroup("程序化生成设置")][HorizontalGroup("程序化生成设置/1",width:80)][ShowInInspector][HideLabel]public int IslandHeight => islandHeight;

    [BoxGroup("程序化生成设置")][HorizontalGroup("程序化生成设置/2")][LabelText("岛屿范围")][ProgressBar(10, 500)][DisableIf("mapAsset")] public float islandRange = 50;
    [BoxGroup("程序化生成设置")][HorizontalGroup("程序化生成设置/2", width: 80)][ShowInInspector][HideLabel] public float IslandRange => islandRange;

    [BoxGroup("程序化生成设置")][HorizontalGroup("程序化生成设置/3")][LabelText("海平面高度")][ProgressBar(0, 10, Segmented = true)][DisableIf("mapAsset")] public int waterHeight;
    [BoxGroup("程序化生成设置")][HorizontalGroup("程序化生成设置/3", width: 80)][ShowInInspector][HideLabel] public int WaterHeight=>waterHeight;

    [BoxGroup("资源模板")][AssetsOnly][LabelText("地图")] public TextAsset mapAsset;
}
