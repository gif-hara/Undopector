﻿using UnityEditor;
using UnityEngine;

public sealed class ExampleClass : EditorWindow
{
    private static readonly string[] mList =
    {
        "AboutWIndowLicenseLabel"                       ,
        "AC LeftArrow"                                  ,
        "AC RightArrow"                                 ,
        "AnimationEventBackground"                      ,
        "AnimationEventTooltip"                         ,
        "AnimationEventTooltipArrow"                    ,
        "AnimationKeyframeBackground"                   ,
        "AnimationRowEven"                              ,
        "AnimationRowOdd"                               ,
        "AnimationSelectionTextField"                   ,
        "AnimationTimelineTick"                         ,
        "AnimPropDropdown"                              ,
        "AppToolbar"                                    ,
        "BoldLabel"                                     ,
        "BoldToggle"                                    ,
        "ButtonLeft"                                    ,
        "ButtonMid"                                     ,
        "ButtonRight"                                   ,
        "CN Box"                                        ,
        "CN CountBadge"                                 ,
        "CN EntryBackEven"                              ,
        "CN EntryBackOdd"                               ,
        "CN EntryError"                                 ,
        "CN EntryInfo"                                  ,
        "CN EntryWarn"                                  ,
        "CN Message"                                    ,
        "CN StatusError"                                ,
        "CN StatusInfo"                                 ,
        "CN StatusWarn"                                 ,
        "ColorField"                                    ,
        "ColorPicker2DThumb"                            ,
        "ColorPickerBackground"                         ,
        "ColorPickerBox"                                ,
        "ColorPickerHorizThumb"                         ,
        "Command"                                       ,
        "CommandLeft"                                   ,
        "CommandMid"                                    ,
        "CommandRight"                                  ,
        "ControlLabel"                                  ,
        "CurveEditorLabelTickmarks"                     ,
        "dockarea"                                      ,
        "dockareaOverlay"                               ,
        "dockareaStandalone"                            ,
        "dragtab"                                       ,
        "dragtabdropwindow"                             ,
        "DropDown"                                      ,
        "DropDownButton"                                ,
        "ErrorLabel"                                    ,
        "ExposablePopupItem"                            ,
        "ExposablePopupMenu"                            ,
        "EyeDropperHorizontalLine"                      ,
        "EyeDropperPickedPixel"                         ,
        "EyeDropperVerticalLine"                        ,
        "flow background"                               ,
        "flow node 0"                                   ,
        "flow node 0 on"                                ,
        "flow node 1"                                   ,
        "flow node 1 on"                                ,
        "flow node 2"                                   ,
        "flow node 2 on"                                ,
        "flow node 3"                                   ,
        "flow node 3 on"                                ,
        "flow node 4"                                   ,
        "flow node 4 on"                                ,
        "flow node 5"                                   ,
        "flow node 5 on"                                ,
        "flow node 6"                                   ,
        "flow node 6 on"                                ,
        "flow node hex 0"                               ,
        "flow node hex 0 on"                            ,
        "flow node hex 1"                               ,
        "flow node hex 1 on"                            ,
        "flow node hex 2"                               ,
        "flow node hex 2 on"                            ,
        "flow node hex 3"                               ,
        "flow node hex 3 on"                            ,
        "flow node hex 4"                               ,
        "flow node hex 4 on"                            ,
        "flow node hex 5"                               ,
        "flow node hex 5 on"                            ,
        "flow node hex 6"                               ,
        "flow node hex 6 on"                            ,
        "flow node titlebar"                            ,
        "flow target in"                                ,
        "flow triggerPin in"                            ,
        "flow triggerPin out"                           ,
        "flow varPin in"                                ,
        "flow varPin out"                               ,
        "flow varPin tooltip"                           ,
        "Foldout"                                       ,
        "FoldOutPreDrop"                                ,
        "GameViewBackground"                            ,
        "Grad Down Swatch"                              ,
        "Grad Down Swatch Overlay"                      ,
        "Grad Up Swatch"                                ,
        "Grad Up Swatch Overlay"                        ,
        "grey_border"                                   ,
        "GridList"                                      ,
        "GridListText"                                  ,
        "GroupBox"                                      ,
        "GUIEditor.BreadcrumbLeft"                      ,
        "GUIEditor.BreadcrumbMid"                       ,
        "GV Gizmo DropDown"                             ,
        "HeaderLabel"                                   ,
        "HelpBox"                                       ,
        "Hi Label"                                      ,
        "HorizontalMinMaxScrollbarThumb"                ,
        "hostview"                                      ,
        "IN BigTitle"                                   ,
        "IN BigTitle Inner"                             ,
        "IN DropDown"                                   ,
        "IN Foldout"                                    ,
        "IN Label"                                      ,
        "IN LockButton"                                 ,
        "IN ObjectField"                                ,
        "IN TextField"                                  ,
        "IN ThumbnailSelection"                         ,
        "IN ThumbnailShadow"                            ,
        "IN Title"                                      ,
        "IN TitleText"                                  ,
        "InnerShadowBg"                                 ,
        "InvisibleButton"                               ,
        "LargeButton"                                   ,
        "LargeButtonLeft"                               ,
        "LargeButtonMid"                                ,
        "LargeButtonRight"                              ,
        "LargeLabel"                                    ,
        "LightmapEditorSelectedHighlight"               ,
        "LODBlackBox"                                   ,
        "LODCameraLine"                                 ,
        "LODLevelNotifyText"                            ,
        "LODRendererAddButton"                          ,
        "LODRendererButton"                             ,
        "LODRendererRemove"                             ,
        "LODRenderersText"                              ,
        "LODSceneText"                                  ,
        "LODSliderBG"                                   ,
        "LODSliderRange"                                ,
        "LODSliderRangeSelected"                        ,
        "LODSliderText"                                 ,
        "LODSliderTextSelected"                         ,
        "MeBlendBackground"                             ,
        "MeBlendPosition"                               ,
        "MeBlendTriangleLeft"                           ,
        "MeBlendTriangleRight"                          ,
        "MeLivePlayBackground"                          ,
        "MeLivePlayBar"                                 ,
        "MeTimeLabel"                                   ,
        "MeTransitionBack"                              ,
        "MeTransitionBlock"                             ,
        "MeTransitionHandleLeft"                        ,
        "MeTransitionHandleLeftPrev"                    ,
        "MeTransitionHandleRight"                       ,
        "MeTransitionHead"                              ,
        "MeTransitionSelect"                            ,
        "MeTransitionSelectHead"                        ,
        "MeTransOff2On"                                 ,
        "MeTransOffLeft"                                ,
        "MeTransOffRight"                               ,
        "MeTransOn2Off"                                 ,
        "MeTransOnLeft"                                 ,
        "MeTransOnRight"                                ,
        "MeTransPlayhead"                               ,
        "MiniBoldLabel"                                 ,
        "minibutton"                                    ,
        "minibuttonleft"                                ,
        "minibuttonmid"                                 ,
        "minibuttonright"                               ,
        "MiniLabel"                                     ,
        "MiniMinMaxSliderHorizontal"                    ,
        "MiniMinMaxSliderVertical"                      ,
        "MiniPopup"                                     ,
        "MiniPullDown"                                  ,
        "MiniTextField"                                 ,
        "MiniToolbarButton"                             ,
        "MiniToolbarButtonLeft"                         ,
        "MinMaxHorizontalSliderThumb"                   ,
        "NotificationBackground"                        ,
        "NotificationText"                              ,
        "ObjectField"                                   ,
        "ObjectFieldThumb"                              ,
        "ObjectFieldThumbOverlay"                       ,
        "ObjectFieldThumbOverlay2"                      ,
        "ObjectPickerBackground"                        ,
        "ObjectPickerLargeStatus"                       ,
        "ObjectPickerPreviewBackground"                 ,
        "ObjectPickerResultsEven"                       ,
        "ObjectPickerResultsGrid"                       ,
        "ObjectPickerResultsOdd"                        ,
        "ObjectPickerSmallStatus"                       ,
        "ObjectPickerTab"                               ,
        "ObjectPickerToolbar"                           ,
        "OL box"                                        ,
        "OL box NoExpand"                               ,
        "OL EntryBackEven"                              ,
        "OL EntryBackOdd"                               ,
        "OL Label"                                      ,
        "OL Minus"                                      ,
        "OL Plus"                                       ,
        "OL Title"                                      ,
        "OL Title TextRight"                            ,
        "OL Toggle"                                     ,
        "OL ToggleWhite"                                ,
        "PaneOptions"                                   ,
        "PlayerSettingsLevel"                           ,
        "PlayerSettingsPlatform"                        ,
        "Popup"                                         ,
        "PopupCurveDropdown"                            ,
        "PopupCurveEditorBackground"                    ,
        "PopupCurveEditorSwatch"                        ,
        "PopupCurveSwatchBackground"                    ,
        "PR Insertion"                                  ,
        "PR Label"                                      ,
        "PR Ping"                                       ,
        "PR TextField"                                  ,
        "PreBackground"                                 ,
        "PreButton"                                     ,
        "PreferencesKeysElement"                        ,
        "PreferencesSection"                            ,
        "PreferencesSectionBox"                         ,
        "PreHorizontalScrollbar"                        ,
        "PreHorizontalScrollbarThumb"                   ,
        "PreLabel"                                      ,
        "PreOverlayLabel"                               ,
        "PreSlider"                                     ,
        "PreSliderThumb"                                ,
        "PreToolbar"                                    ,
        "PreToolbar2"                                   ,
        "PreVerticalScrollbar"                          ,
        "PreVerticalScrollbarThumb"                     ,
        "ProfilerBadge"                                 ,
        "ProfilerLeftPane"                              ,
        "ProfilerPaneSubLabel"                          ,
        "ProfilerRightPane"                             ,
        "ProfilerScrollviewBackground"                  ,
        "ProfilerSelectedLabel"                         ,
        "ProgressBarBack"                               ,
        "ProgressBarBar"                                ,
        "ProgressBarText"                               ,
        "ProjectBrowserBottomBarBg"                     ,
        "ProjectBrowserGridLabel"                       ,
        "ProjectBrowserHeaderBgMiddle"                  ,
        "ProjectBrowserHeaderBgTop"                     ,
        "ProjectBrowserIconAreaBg"                      ,
        "ProjectBrowserIconDropShadow"                  ,
        "ProjectBrowserPreviewBg"                       ,
        "ProjectBrowserSubAssetBg"                      ,
        "ProjectBrowserSubAssetBgCloseEnded"            ,
        "ProjectBrowserSubAssetBgDivider"               ,
        "ProjectBrowserSubAssetBgMiddle"                ,
        "ProjectBrowserSubAssetBgOpenEnded"             ,
        "ProjectBrowserSubAssetExpandBtn"               ,
        "ProjectBrowserTopBarBg"                        ,
        "QualitySettingsDefault"                        ,
        "Radio"                                         ,
        "RightLabel"                                    ,
        "RL Background"                                 ,
        "RL DragHandle"                                 ,
        "RL Element"                                    ,
        "RL Footer"                                     ,
        "RL FooterButton"                               ,
        "RL Header"                                     ,
        "SC ViewAxisLabel"                              ,
        "SC ViewLabel"                                  ,
        "SceneViewOverlayTransparentBackground"         ,
        "ScriptText"                                    ,
        "SearchCancelButton"                            ,
        "SearchCancelButtonEmpty"                       ,
        "SearchModeFilter"                              ,
        "SearchTextField"                               ,
        "SelectionRect"                                 ,
        "ShurikenCheckMark"                             ,
        "ShurikenEffectBg"                              ,
        "ShurikenEmitterTitle"                          ,
        "ShurikenLabel"                                 ,
        "ShurikenMinus"                                 ,
        "ShurikenModuleBg"                              ,
        "ShurikenModuleTitle"                           ,
        "ShurikenObjectField"                           ,
        "ShurikenPlus"                                  ,
        "ShurikenPopUp"                                 ,
        "ShurikenToggle"                                ,
        "ShurikenValue"                                 ,
        "SliderMixed"                                   ,
        "StaticDropdown"                                ,
        "sv_iconselector_back"                          ,
        "sv_iconselector_button"                        ,
        "sv_iconselector_labelselection"                ,
        "sv_iconselector_selection"                     ,
        "sv_iconselector_sep"                           ,
        "sv_label_0"                                    ,
        "sv_label_1"                                    ,
        "sv_label_2"                                    ,
        "sv_label_3"                                    ,
        "sv_label_4"                                    ,
        "sv_label_5"                                    ,
        "sv_label_6"                                    ,
        "sv_label_7"                                    ,
        "TabWindowBackground"                           ,
        "Tag MenuItem"                                  ,
        "TE NodeBackground"                             ,
        "TE NodeBox"                                    ,
        "TE NodeBoxSelected"                            ,
        "TE NodeLabelBot"                               ,
        "TE NodeLabelTop"                               ,
        "TE PinLabel"                                   ,
        "TE Toolbar"                                    ,
        "TE toolbarbutton"                              ,
        "TE ToolbarDropDown"                            ,
        "TimeScrubber"                                  ,
        "TimeScrubberButton"                            ,
        "TL InPoint"                                    ,
        "TL OutPoint"                                   ,
        "TL Playhead"                                   ,
        "ToggleMixed"                                   ,
        "Toolbar"                                       ,
        "toolbarbutton"                                 ,
        "ToolbarDropDown"                               ,
        "ToolbarPopup"                                  ,
        "ToolbarSeachCancelButton"                      ,
        "ToolbarSeachCancelButtonEmpty"                 ,
        "ToolbarSeachTextField"                         ,
        "ToolbarSeachTextFieldPopup"                    ,
        "ToolbarSearchField"                            ,
        "ToolbarTextField"                              ,
        "Tooltip"                                       ,
        "U2D.createRect"                                ,
        "U2D.dragDot"                                   ,
        "U2D.dragDotDimmed"                             ,
        "VCS_StickyNote"                                ,
        "VCS_StickyNoteArrow"                           ,
        "VCS_StickyNoteLabel"                           ,
        "VCS_StickyNoteP4"                              ,
        "VerticalMinMaxScrollbarThumb"                  ,
        "WhiteBoldLabel"                                ,
        "WhiteLabel"                                    ,
        "WhiteLargeLabel"                               ,
        "WhiteMiniLabel"                                ,
        "WinBtnCloseMac"                                ,
        "WinBtnInactiveMac"                             ,
        "WinBtnMaxMac"                                  ,
        "WinBtnMinMac"                                  ,
        "WindowBottomResize"                            ,
        "Wizard Box"                                    ,
        "Wizard Error"                                  ,
        "WordWrapLabel"                                 ,
        "WordWrappedLabel"                              ,
        "WordWrappedMiniLabel"                          ,
    };

    private Vector2 mScrollPos;

    [MenuItem("Tools/Example")]
    private static void Example()
    {
        GetWindow<ExampleClass>(true);
    }

    private void OnGUI()
    {
        mScrollPos = EditorGUILayout.BeginScrollView(mScrollPos);
        foreach (var n in mList)
        {
            EditorGUILayout.BeginHorizontal(GUILayout.Height(48));
            EditorGUILayout.SelectableLabel(n);
            EditorGUILayout.Toggle(false, n);
            EditorGUILayout.EndHorizontal();
            GUILayout.Box(
                string.Empty,
                GUILayout.Width(position.width - 24),
                GUILayout.Height(1)
            );
        }
        EditorGUILayout.EndScrollView();
    }
}